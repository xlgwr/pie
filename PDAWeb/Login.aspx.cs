using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using PIE.Model;
using PIE.DAL;
using PI.BLL;
using PIE.DBUtility;

public partial class Login : System.Web.UI.Page
{
    PIE.Model.sys_user _sys_user_model;

    protected void Page_Load(object sender, EventArgs e)
    {

        Session.Clear();

        if (!IsPostBack)
        {
            txtUserName.Focus();
            lblMessage.Text = "";
        }
        Session["addflag"] = "false";
    }

    protected void BtnLogin_Click(object sender, EventArgs e)
    {
        lblMessage.Text = "";
        string comp = this.ddlcmp0.Text.Trim();
        string username = this.txtUserName.Text.Trim();
        string pwd = this.txtPassword.Text.Trim();
        string pwd2 = this.txtpwd2.Text.Trim();

        if (comp == "")
        {
            lblMessage.Text = "公司為空!";
            txtUserName.Focus();
            return;
        }
        if (username == "")
        {
            lblMessage.Text = "工号為空!";
            txtUserName.Focus();
            return;
        }
        if (pwd == "")
        {
            lblMessage.Text = "密碼為空!";
            txtPassword.Focus();
            return;
        }
        if (pwd2 == "")
        {
            lblMessage.Text = "密碼為空!";
            txtPassword.Focus();
            return;
        }
        _sys_user_model = new PIE.BLL.sys_user().GetModel(username, comp);

        if (_sys_user_model==null)
        {
            lblMessage.Text = "不存在对应的工号!";
            ddlcmp0.Text = comp;
            txtUserName.Text = username;
            txtPassword.Text = pwd;
            txtUserName.Focus();
            return;
        }
        if (_sys_user_model.user_password.Equals(PIE.DBUtility.DESEncrypt.Encrypt(pwd + pwd2)))
        {

            Session["user_id"] = username;
            Session["piid"] = "";
            Session["pallet"] = "";
            Session["type"] = "";
            Session["palletNum"] = "";
            Response.Redirect("ScanSet.aspx");
            
        }
        else
        {
            lblMessage.Text = "密码错误!";
            ddlcmp0.Text = comp;
            txtUserName.Text = username;
            txtPassword.Text = pwd;
            txtPassword.Focus();
            return;
        }

    }

    protected void BtnClear_Click(object sender, EventArgs e)
    {
        lblMessage.Text = "";
        txtPassword.Text = "";
        txtUserName.Text = "";
        txtUserName.Focus();
    }
}