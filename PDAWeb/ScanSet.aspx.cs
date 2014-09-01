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
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["user_id"] == null)
            {
                Response.Write("<script language='javascript'>alert('您没有登录或登录超时，请重新登录！');top.location.href='Login.aspx';</script>");
                return;
            }
        }
        txtPIID.Focus();

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
            _pi_mstr_model = new PI.DAL.pi_mstr().GetModel(strPIID, 1);
            ddlPlant.Text = _pi_mstr_model.Plant;
            ddlType.Text = _pi_mstr_model.pi_type;
        }
        if (string.IsNullOrEmpty(strPIID))
        {
            lblMessage.Text = "PI ID is null";
            return;
        }
        Session["piid"] = strPIID;
        Session["plant"] = ddlPlant.Text;
        Session["type"] = ddlType.Text;

        Response.Redirect("Default.aspx");

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
        Response.Write("<script language='javascript'>top.location.href='Login.aspx';</script>");
    }
}