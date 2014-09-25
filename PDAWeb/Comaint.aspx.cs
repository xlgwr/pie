using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

using PI.Model;
using PI.DAL;
using PI.BLL;
using PIE.DBUtility;

public partial class Comaint : System.Web.UI.Page
{
    bool _addNextNewFalg = false;
    bool _coisnull = false;
    string _strconext = "";

    int _nextlineid = 1;
    string strpiid = "";
    string strSN = "";
    string _strco = "";
    string _strmsg = "";
    PI.Model.pi_mstr _pi_mstr_model = new PI.Model.pi_mstr();
    PI.Model.pi_det _pi_det_model = new PI.Model.pi_det();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {


            if (Session["user_id"] == null || Session["user_id"].ToString() == "")
            {
                Response.Write("<script language='javascript'>alert('您没有登录或登录超时，请重新登录！');top.location.href='Login.aspx';</script>");
                return;
            }
            if (Session["piid"].ToString().Trim() != "" && Session["plant"].ToString().Trim() != "" && Session["type"].ToString().Trim() != "" && Session["pi_wec_ctn"].ToString().Trim() != "")
            {
                txtpiid.Text = Session["piid"].ToString();
                //txtPlant.Text = "Plant:" + Session["plant"].ToString();
                //txtType.Text = "Type:" + Session["type"].ToString();
                txtPalletNum.Text = Session["palletNum"].ToString();//"pallet#:" + "CtnSN:" +
                txtboxid.Text =  Session["pi_wec_ctn"].ToString();
                strpiid = txtpiid.Text.Trim();

                _pi_det_model = new PI.DAL.pi_det_ext().GetModel(Session["piid"].ToString(), Session["pi_wec_ctn"].ToString());
                if (_pi_det_model != null)
                {
                    var plr_mstr_tran = new PIE.DAL.plr_mstr_tran_ext().GetModel(_pi_det_model.plr_LineID_tran, _pi_det_model.pi_wec_ctn);
                    lblMessage.Text = "更新CO, Part#:" + plr_mstr_tran.plr_partno;
                    txtPart.Text = plr_mstr_tran.plr_partno;
                    txtCo.Focus();
                }
                else
                {
                    Response.Write("<script language='javascript'>alert('更新OK，继续扫描！');top.location.href='Default.aspx';</script>");
                    return;
                }
            }
            else
            {
                Response.Write("<script language='javascript'>alert('您没有PIID,plant,type,CtnSN，请重新输入！');top.location.href='ScanSet.aspx';</script>");
                return;
            }
            txtCo.Focus();

        }

    }
    protected void BtnOK_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtCo.Text))
        {
            lblMessage.Text = "CO is Null";
            return;
        }
        PIE.Model.pkey_ctl existco = new PIE.BLL.pkey_ctl().GetModel("co", txtCo.Text);
        if (existco != null)
        {
            string coDesc = existco.t_value + ":" + existco.t_desc;
            lbl3co.Text = coDesc;
            _pi_det_model = new PI.DAL.pi_det_ext().GetModel(Session["piid"].ToString(), Session["pi_wec_ctn"].ToString());
            if (_pi_det_model == null)
            {
                Response.Write("<script language='javascript'>alert('没有CO需要更新，继续扫描！');top.location.href='Default.aspx';</script>");
                return;
            }
            else
            {
                _pi_det_model.pi_chr01 = existco.t_value;
                var pi_det_model_pudate = new PI.BLL.pi_det().Update(_pi_det_model);
                
                if (pi_det_model_pudate)
                {
                    _pi_det_model = new PI.DAL.pi_det_ext().GetModel(Session["piid"].ToString(), Session["pi_wec_ctn"].ToString());
                    if (_pi_det_model != null)
                    {
                        var plr_mstr_tran = new PIE.DAL.plr_mstr_tran_ext().GetModel(_pi_det_model.plr_LineID_tran, _pi_det_model.pi_wec_ctn);
                        lblMessage.Text = "更新下一个CO, Part#:" + plr_mstr_tran.plr_partno;
                        txtPart.Text = plr_mstr_tran.plr_partno;
                        txtCo.Focus();
                    }
                    else
                    {
                        Session["msg"] = "->继续扫描,上次为:" + Session["piid"].ToString() + "," + Session["pi_wec_ctn"].ToString() + "<br />Pt#" + Session["palletNum"].ToString() + ",CO:" + coDesc;
                        Response.Write("<script language='javascript'>alert('Update CO Success，继续扫描！');top.location.href='Default.aspx';</script>");
                        return;
                    }
                }
                else
                {
                    lblMessage.Text = "Update fail.";
                }
            }
        }
        else
        {
            lblMessage.Text = "CO " + txtCo.Text + " is not exist";            
            txtCo.Text = "";
            txtCo.Focus();
           
            return;
        }
    }
}