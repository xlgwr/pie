﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using PI.DAL;
using PI.BLL;
using PI.Model;

using System.Data.SqlClient;
using System.Data;
using PIE.DBUtility;
using PIE.Common;

public partial class ScanSet : System.Web.UI.Page
{
    PI.Model.pi_mstr _pi_mstr_model;
    string strPallet = "";
    public static bool _PalletAdd = false;
    public static string _newPall = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["user_id"] == null || Session["user_id"].ToString()=="")
            {
                Response.Write("<script language='javascript'>alert('您没有登录或登录超时，请重新登录！');top.location.href='Login.aspx';</script>");
                return;
            }
            txtPalletNum.Items.Clear();
            txtPalletNum.Items.Add(" ");
            //Session["user_id"] = null;
            //Session["piid"] = null;
            //Session["plant"] = null;
            //Session["type"] = null;
            //Session["palletNum"] = null;
            if (Session["piid"] != null && !string.IsNullOrWhiteSpace(Session["piid"].ToString()))
            {
                txtPIID.Text = Session["piid"].ToString();
                if (!exist_PIID(txtPIID.Text))
                {
                    return;
                };
                txtPalletNum.Focus();
            }
            if ((!string.IsNullOrWhiteSpace(Session["palletNum"].ToString())) && !string.IsNullOrWhiteSpace(txtPIID.Text))
            {
                txtPIID.Text = Session["piid"].ToString();
                if (!exist_PIID(txtPIID.Text))
                {
                    return;
                };
                var item = txtPalletNum.Items.FindByText(Session["palletNum"].ToString());
                var index = txtPalletNum.Items.IndexOf(item);
                txtPalletNum.SelectedIndex = index;
                txtNW.Text = txtPalletNum.SelectedItem.Value;
                txtNW.Focus();
            }
            else
            {

                txtPIID.Focus();
            }
            _PalletAdd = false;
            _newPall = "";
        }
        else
        {

            txtPIID.Focus();
        }
        
        // txtNW.Text = txtPalletNum.SelectedItem.Value;

    }
    protected void BtnSure_Click(object sender, EventArgs e)
    {
        Session["nw"] = "";
        int intOutAffected;
        string strPIID = txtPIID.Text.Trim();
        if (string.IsNullOrEmpty(strPIID))
        {
            lblMessage.Text = "PI ID is null,if you sure,this will be generate a New one.";

        }

        var existpiid = new PI.DAL.pi_mstr().Exists(strPIID, 1);



        if (!existpiid)
        {
            _pi_mstr_model = new PI.Model.pi_mstr();

            #region add New PIID



            SqlParameter[] parameters = {
                                            new SqlParameter("@PIID",SqlDbType.NVarChar,11)
                                        };
            parameters[0].Direction = ParameterDirection.Output;

            DbHelperSQL.RunProcedure("sp_GetPIID", parameters, out intOutAffected);
            strPIID = parameters[0].Value != null ? parameters[0].Value.ToString() : "";
            txtPIID.Text = strPIID;
            if (string.IsNullOrEmpty(strPIID))
            {
                lblMessage.Text = "生成PIID,出错，无法新增。";
                return;
            }
            _pi_mstr_model.PI_ID = strPIID;
            _pi_mstr_model.LineID = 1;
            _pi_mstr_model.pi_deci1 = 1;

            Session["palletNum"] = "001";
            txtPalletNum.Items.Add("001");
            txtPalletNum.SelectedItem.Text = "001";

            _pi_mstr_model.Plant = ddlPlant.Text;
            _pi_mstr_model.pi_type = ddlType.Text;


            _pi_mstr_model.pi_cre_userid = Session["user_id"].ToString();
            _pi_mstr_model.pi_cre_date = DbHelperSQL.getServerGetDate();
            _pi_mstr_model.pi_update_date = _pi_mstr_model.pi_cre_date;
            _pi_mstr_model.pi_user_ip = HttpContext.Current.Request.UserHostAddress;
            _pi_mstr_model.pi_status = "No";

            var result_plr_batch = new PI.DAL.pi_mstr().Add(_pi_mstr_model);
            if (!result_plr_batch)
            {
                lblMessage.Text = "Add PI Mstr info fail";
                return;
            }
            else
            {
                lblMessage.Text = "PIID is not exist,New one OK";

            }
            #endregion

        }
        else
        {
            goDefault(txtPIID.Text);
        }
        if (string.IsNullOrWhiteSpace(txtPalletNum.SelectedItem.Text))
        {
            txtPalletNum.Focus();
            lblMessage.Text = "Pallet Num is Null.";
            return;

        }
        initSession(strPIID);
        Response.Redirect("Default.aspx");


        //Response.Write("<script language='javascript'>window.open('Default.aspx', '_blank', 'fullscreen=yes,toolbar=no,titlebar=no');</script>");


    }
    public void goDefault(string strpiid)
    {
        exist_PIID(strpiid);
        if (!_PalletAdd)
        {
            if (string.IsNullOrWhiteSpace(txtPalletNum.SelectedItem.Text))
            {

                txtPalletNum.Focus();
                lblMessage.Text = "Notice: Please select Pallet Num.";
                return;
            }
        }
        else
        {
            if (string.IsNullOrWhiteSpace(txtPalletNum.SelectedItem.Text))
            {
                txtPalletNum.Focus();
                lblMessage.Text = "Pallet Num is Null.";
                return;

            }
            initSession(strpiid);
            Response.Redirect("Default.aspx");

        }
    }
    private bool exist_PIID(string strPIID)
    {
        if (string.IsNullOrWhiteSpace(strPIID))
        {
            lblMessage.Text = "PINum is null";
            txtPIID.Focus();
            return false;
        }


        _pi_mstr_model = new PI.DAL.pi_mstr().GetModel(strPIID, 1);
        ddlPlant.Text = _pi_mstr_model.Plant;
        ddlType.Text = _pi_mstr_model.pi_type;
        ddlitemAdd(strPIID);
        if (_PalletAdd)
        {
            Session["palletNum"] = _newPall;
            ListItem linew = new ListItem(_newPall, "");
            if (!txtPalletNum.Items.Contains(linew))
            {

                txtPalletNum.Items.Add(linew);
                var index = txtPalletNum.Items.IndexOf(linew);
                txtPalletNum.SelectedIndex = index;
                txtNW.Text = Session["nw"].ToString();
            }

        }
        else
        {
            if (!string.IsNullOrWhiteSpace(Session["palletNum"].ToString()))
            {
                ListItem linew = txtPalletNum.Items.FindByText(Session["palletNum"].ToString());
                var index = txtPalletNum.Items.IndexOf(linew);
                if (index > -1)
                {

                    txtPalletNum.SelectedIndex = index;
                }

            }
            else
            {
                txtPalletNum.SelectedIndex = txtPalletNum.Items.Count - 1;
            }
        }
        return true;
    }

    private void ddlitemAdd(string strPIID)
    {
        if (!_PalletAdd)
        {
            txtPalletNum.Items.Clear();
            txtPalletNum.Items.Add(" ");
        }
        var ds = new PI.BLL.pi_det().GetList("PI_ID='" + strPIID + "'");

        if (ds.Tables[0].Rows.Count > 0)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i]["pi_deci1"] == DBNull.Value)
                {
                    continue;
                }
                var pallet = Convert.ToInt32(ds.Tables[0].Rows[i]["pi_deci1"]).ToString("000");
                var strnw = ds.Tables[0].Rows[i]["pi_pallet_no"].ToString();
                ListItem li = new ListItem(pallet, strnw);
                if (!txtPalletNum.Items.Contains(li))
                {
                    txtPalletNum.Items.Add(li);
                    //var index = txtPalletNum.Items.IndexOf(li);
                    //txtPalletNum.SelectedIndex = index;
                }

            }

        }
    }

    private void initSession(string strPIID)
    {

        Session["piid"] = strPIID;
        Session["plant"] = ddlPlant.SelectedItem.Text;
        Session["type"] = ddlType.SelectedItem.Text;

        if (_PalletAdd)
        {
            Session["palletNum"] = _newPall;

        }
        else
        {
            Session["palletNum"] = txtPalletNum.SelectedItem.Text;

        }
        Session["nw"] = txtNW.Text;
    }
    protected void BtnClear_Click(object sender, EventArgs e)
    {
        txtPIID.Text = "";
        txtNW.Text = "";
        Session["palletNum"] = "";        
        txtPIID.Focus();
        txtPalletNum.Items.Clear();
        ddlPlant.SelectedIndex = 0;
        ddlType.SelectedIndex = 0;
    }

    protected void BtnExist_Click(object sender, EventArgs e)
    {
        Session["user_id"] = "";
        Session["piid"] = "";
        Session["plant"] = "";
        Session["type"] = "";
        Session["nw"] = "";
        Session["palletNum"] = "";

        Response.Write("<script language='javascript'>top.location.href='Login.aspx';</script>");

    }
    protected void txtPalletAdd_Click(object sender, EventArgs e)
    {
        lblMessage.Text = "";
        if (string.IsNullOrWhiteSpace(txtPIID.Text))
        {
            lblMessage.Text = "PI ID is null";
            return;

        }
        var maxpallernum = new PI.DAL.pi_det_ext().GetMaxId(txtPIID.Text).ToString("000");
        ListItem li = new ListItem(maxpallernum, "0");
        txtPalletNum.Items.Add(maxpallernum);
        txtPalletNum.SelectedIndex = txtPalletNum.Items.Count - 1;
        txtNW.Text = "";
        _PalletAdd = true;
        _newPall = maxpallernum;
        //txtNW.Focus();
        txtPalletNum.Focus();
    }
    protected void btnnw_Click(object sender, EventArgs e)
    {
        var addflag=Session["addflag"].ToString();
       
        if (addflag.Equals("true"))
        {
            lblMessage.Text = txtPalletNum.SelectedItem.Text + "Pallet# is New,not set nw, please add by Scan later.";
            //txtNW.Text = "";
            Session["nw"] = txtNW.Text;
            Response.Write("<script language='javascript'>alert('" + lblMessage.Text + "！');</script>");
            initSession(txtPIID.Text);
            //Response.Redirect("Default.aspx");
            Response.Write("<script language='javascript'>top.location.href='Default.aspx';</script>");
        }
        if (_PalletAdd)
        {
            if (txtPalletNum.SelectedItem.Text == _newPall)
            {
                lblMessage.Text = txtPalletNum.SelectedItem.Text + "Pallet# is New,not set nw, please add by Scan later.";
                txtNW.Text = "";
                Response.Write("<script language='javascript'>alert('" + lblMessage.Text + "！');</script>");
                txtPalletNum.Focus();
                return;
            }

        }
        if (string.IsNullOrWhiteSpace(txtPIID.Text) || string.IsNullOrWhiteSpace(txtPalletNum.SelectedItem.Text))
        {
            lblMessage.Text = "PI ID or Pallet# is null.";           
            return;
        }
        if (!PageValidate.IsDecimal(txtNW.Text.Trim()))
        {
            Session["palletNum"] = txtPalletNum.SelectedItem.Text;
            lblMessage.Text = txtNW.Text + " is error.Please enter the right NW like (0.001).";
            txtNW.Text = "";
            txtNW.Focus();
            return;
        }
        var strupdatenw = "update pi_det set pi_pallet_no='" + txtNW.Text + "' where PI_ID='" + txtPIID.Text.Trim() + "' and pi_deci1='" + txtPalletNum.SelectedItem.Text + "'";
        var intresult = DbHelperSQL.ExecuteSql(strupdatenw);
        if (intresult > 0)
        {
            Session["palletNum"] = txtPalletNum.SelectedItem.Text;
            lblMessage.Text = "Update NW of Pallet#: " + txtPalletNum.SelectedItem.Text + " success.";
            txtPalletNum.SelectedItem.Value = txtNW.Text;
            txtPalletNum.Focus();
        }
    }
    protected void txtPalletNum_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblMessage.Text = "";
        txtNW.Text = txtPalletNum.SelectedItem.Value;
        Session["palletNum"] = txtPalletNum.SelectedItem.Text;
        if (_PalletAdd)
        {
            if (txtPalletNum.SelectedItem.Text == _newPall)
            {
                lblMessage.Text = "Pallet# is New,please add by Scan later.";
                txtPalletNum.Focus();
                return;
            }
        }
        if (string.IsNullOrWhiteSpace(txtNW.Text))
        {
            txtNW.Focus();
        }
        else
        {
            txtPalletNum.Focus();
        }
    }
    protected void txtPIID_TextChanged(object sender, EventArgs e)
    {
        if (txtPIID.Text.Length >= 11)
        {

            _newPall = "";
            _PalletAdd = false;
            ddlitemAdd(txtPIID.Text);
            txtNW.Text = "";

        }
    }
}