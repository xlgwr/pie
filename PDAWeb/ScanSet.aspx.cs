using System;
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

public partial class ScanSet : System.Web.UI.Page
{
    PI.Model.pi_mstr _pi_mstr_model;
    string strPallet = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["user_id"] == null)
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
                existPIID(txtPIID.Text);
                txtPalletNum.Focus();
            }
        }
        txtPIID.Focus(); 
       // txtNW.Text = txtPalletNum.SelectedItem.Value;

    }
    protected void BtnSure_Click(object sender, EventArgs e)
    {
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
            if (string.IsNullOrEmpty(strPIID))
            {
                lblMessage.Text = "生成PIID,出错，无法新增。";
                return;
            }
            _pi_mstr_model.PI_ID = strPIID;
            _pi_mstr_model.LineID = 1;
            _pi_mstr_model.pi_deci1 = 1;
            ListItem li = new ListItem("001", "0");
            txtPalletNum.Items.Add(li);
            txtPalletNum.SelectedIndex=txtPalletNum.Items.Count-1;
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
            existPIID(strPIID);

            if (string.IsNullOrWhiteSpace(txtPalletNum.SelectedItem.Text))
            {

                txtPalletNum.Focus();
                lblMessage.Text = "Notice: Please select Pallet Num.";
                return;
            }

        }

        initSession(strPIID);

        Response.Redirect("Default.aspx");


        //Response.Write("<script language='javascript'>window.open('Default.aspx', '_blank', 'fullscreen=yes,toolbar=no,titlebar=no');</script>");


    }

    private void existPIID(string strPIID)
    {
        _pi_mstr_model = new PI.DAL.pi_mstr().GetModel(strPIID, 1);
        ddlPlant.Text = _pi_mstr_model.Plant;
        ddlType.Text = _pi_mstr_model.pi_type;
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
        if (string.IsNullOrEmpty(strPIID))
        {
            lblMessage.Text = "PI ID is null";
            return;
        }
        if (string.IsNullOrWhiteSpace(txtPalletNum.SelectedItem.Text))
        {
            txtPalletNum.Focus();
            lblMessage.Text = "Pallet Num is Null.";
            return;

        }
        Session["piid"] = strPIID;
        Session["palletNum"] = txtPalletNum.SelectedItem.Text;
        Session["plant"] = ddlPlant.Text;
        Session["nw"] = txtNW.Text;
        Session["type"] = ddlType.Text;
    }
    protected void BtnClear_Click(object sender, EventArgs e)
    {
        txtPIID.Text = "";
        ddlPlant.SelectedIndex = 0;
        ddlType.SelectedIndex = 0;
    }

    protected void BtnExist_Click(object sender, EventArgs e)
    {
        Session["user_id"] = null;
        Session["piid"] = null;
        Session["plant"] = null;
        Session["type"] = null;
        Session["nw"] = null;
        Session["palletNum"] = null;

        Response.Write("<script language='javascript'>top.location.href='Login.aspx';</script>");

    }
    protected void txtPalletAdd_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtPIID.Text))
        {
            lblMessage.Text = "PI ID is null";
            return;

        }
        var maxpallernum = new PI.DAL.pi_det().GetMaxId(txtPIID.Text).ToString("000");
        ListItem li = new ListItem(maxpallernum, " ");
        txtPalletNum.Items.Add(maxpallernum);
        txtPalletNum.SelectedIndex = txtPalletNum.Items.Count - 1;
        txtNW.Text = "";
        //txtNW.Focus();
        lblMessage.Text = "";
    }
    protected void btnnw_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtNW.Text) || string.IsNullOrWhiteSpace(txtPIID.Text) || string.IsNullOrWhiteSpace(txtPalletNum.SelectedItem.Text))
        {
            lblMessage.Text="PI ID or Pallet# or NW is null.";
            return;
        }
        var strupdatenw = "update pi_det set pi_pallet_no='" + txtNW.Text + "' where PI_ID='" + txtPIID.Text.Trim() + "' and pi_deci1='" + txtPalletNum.SelectedItem.Text + "'";
        var intresult = DbHelperSQL.ExecuteSql(strupdatenw);
        if (intresult>0)
        {
            lblMessage.Text = "Update NW of Pallet#: " + txtPalletNum.SelectedItem.Text + " success.";
        }
    }
    protected void txtPalletNum_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtNW.Text = txtPalletNum.SelectedItem.Value;
        if (string.IsNullOrWhiteSpace(txtNW.Text))
        {
            txtNW.Focus();
        }
    }
}