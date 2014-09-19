using PIE.DBUtility;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
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

    List<PIE.Model.plr_mstr_tran> _plr_mstr_tran_model_list;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Session["addflag"] = "true";
            if (Session["user_id"] == null || Session["user_id"].ToString() == "")
            {
                Response.Write("<script language='javascript'>alert('您没有登录或登录超时，请重新登录！');top.location.href='Login.aspx';</script>");
                return;
            }
            if (Session["piid"].ToString().Trim() != "" && Session["plant"].ToString().Trim() != "" && Session["type"].ToString().Trim() != "" && Session["palletNum"].ToString().Trim() != "")
            {
                txtpiid.Text = Session["piid"].ToString();
                txtPlant.Text = "Plant:" + Session["plant"].ToString();
                txtType.Text = "Type:" + Session["type"].ToString();
                txtPalletNum.Text = Session["palletNum"].ToString();
                strpiid = txtpiid.Text.Trim();
            }
            else
            {
                Response.Write("<script language='javascript'>alert('您没有PIID,plant,type,palletNum，请重新输入！');top.location.href='ScanSet.aspx';</script>");
                return;
            }
            txtboxid.Focus();
            if (Session["msg"] != null)
            {
                lblMessage.Text = Session["msg"].ToString();
            }
        }
    }
    protected void BtnClear_Click(object sender, EventArgs e)
    {
        initfalse("", "");
    }
    protected void BtnOK_Click(object sender, EventArgs e)
    {

        bool result_pi_det = false;

        if (string.IsNullOrWhiteSpace(txtboxid.Text))
        {
            txtboxid.Focus();
            ShowMsg(" WecCtnSN is null.", "Error");
            return;
        }
        if (string.IsNullOrWhiteSpace(txtPalletNum.Text))
        {
            txtPalletNum.Focus();
            ShowMsg(" Pallet# is null.", "Error");
            return;
        }
        if (!getCoValiteWecCtnID())
        {
            return;
        }

        //if (string.IsNullOrWhiteSpace(txtCo.Text))
        //{
        //    txtCo.Focus();
        //    ShowMsg("Error: CO is null.", "Error");
        //    return;
        //}

        if (_plr_mstr_tran_model_list.Count > 0)
        {
            foreach (var tran in _plr_mstr_tran_model_list)
            {
                if (tran.plr_wec_ctn.Equals(txtboxid.Text))
                {
                    if (string.IsNullOrWhiteSpace(tran.plr_co))
                    {
                        _coisnull = true;
                        _strconext = "";
                        Session["pi_wec_ctn"] = tran.plr_wec_ctn;
                    }
                    _pi_det_model.PI_ID = txtpiid.Text;
                    _pi_det_model.pi_type = Session["plant"].ToString();
                    _pi_det_model.pi_LineID = _nextlineid;
                    _pi_det_model.pi_wec_ctn = tran.plr_wec_ctn;

                    _pi_det_model.plr_LineID_tran = tran.LineID;
                    _pi_det_model.pi_deci1 = Convert.ToInt32(txtPalletNum.Text);
                    _pi_det_model.pi_pallet_no = Session["nw"].ToString();

                    _pi_det_model.CartonNo = tran.CartonNo;
                    _pi_det_model.CartonID = tran.CartonID;


                    _pi_det_model.pi_chr01 = tran.plr_co;
                    _pi_det_model.pi_remark = "New";
                    _pi_det_model.pi_cre_date = DbHelperSQL.getServerGetDate();
                    _pi_det_model.pi_update_date = _pi_det_model.pi_cre_date;
                    _pi_det_model.pi_cre_userid = Session["user_id"].ToString();
                    _pi_det_model.pi_user_ip = HttpContext.Current.Request.UserHostAddress;
                    _pi_det_model.pi_status = "No";

                    var existBatchidLine = true;
                    while (existBatchidLine)
                    {
                        existBatchidLine = new PI.DAL.pi_det_ext().Exists(_pi_det_model.PI_ID, _pi_det_model.pi_LineID);
                        if (existBatchidLine)
                        {
                            //ShowMsg("系统中已存在PIID：" + _pi_det_model.PI_ID + ",LineID:" + _pi_det_model.pi_LineID.ToString() + "，将修改LineID+1.", "Notice");
                            //lblMessage.Text = "Notice:系统中已存在PIID：" + _pi_det_model.PI_ID + ",LineID:" + _pi_det_model.pi_LineID.ToString() + "，将修改LineID+1.";

                            _pi_det_model.pi_LineID += 1;
                            //lbl3COScanWECCtnLable.Text = "下个为：PI ID:" + _pi_det_model.PI_ID + ",LineID:" + _pi_det_model.pi_LineID.ToString();
                        }


                    }
                    result_pi_det = new PI.DAL.pi_det().Add(_pi_det_model);
                    if (result_pi_det)
                    {
                        tran.plr_chr01 = "S";
                        tran.plr_update_date = DateTime.Now;
                        var updatescan = new PIE.BLL.plr_mstr_tran().Update(tran);
                    }
                    _nextlineid = _pi_det_model.pi_LineID;
                }
            }
        }


        if (result_pi_det)
        {


            lblMessage.Text = "";
            txtboxid.Focus();
            _addNextNewFalg = true;

            if (string.IsNullOrEmpty(txtpiid.ToString()))
            {

                ShowMsg("新增新的PI ID", "Notice", true);
            }
            else
            {
                PI.Model.pi_det pi_det_new = new PI.Model.pi_det();
                pi_det_new.PI_ID = _pi_det_model.PI_ID;
                pi_det_new.pi_LineID = _pi_det_model.pi_LineID + 1;
                _nextlineid = pi_det_new.pi_LineID;

                txtpiid.Text = Session["piid"].ToString();
                Session["addflag"] = "false";
                //initModelForTextBox(pi_det_new);
                _addNextNewFalg = true;
                Session["msg"] = "继续扫描,上次为:" + _pi_det_model.PI_ID + ",LID:" + _pi_det_model.pi_LineID.ToString() + ",Pt#:" + txtPalletNum.Text + "<br/>" + _strco + "," + txtboxid.Text;

                ShowMsg(Session["msg"].ToString(), "->", true);


            }
            txtboxid.Text = "";
            //txtCo.Text = "";
            lbl3co.Text = "";
            if (_coisnull)
            {
                Session["msg"] = "";
                Response.Write("<script language='javascript'>top.location.href='Comaint.aspx';</script>");
            }

        }
        else
        {
            Session["addflag"] = "true";
            ShowMsg("Scan Add fail", "Error");
        }

        //Response.Write("<script language='javascript'>alert('" + _strmsg + "');</script>");
    }
    private void ShowMsg(string msg, string title)
    {

        lblMessage.ForeColor = Color.Red;
        lblMessage.Visible = true;
        lblMessage.Text = title + ":" + msg;
        _strmsg = title + ":" + msg;
        //Response.Write("<script language='javascript'>alert('" + _strmsg + "');</script>");
    }
    private void ShowMsg(string msg, string title, bool lblred)
    {
        lblMessage.ForeColor = Color.Black;
        lblMessage.Visible = true;
        lblMessage.Text = title + ":" + msg;
        _strmsg = title + ":" + msg;
        //Response.Write("<script language='javascript'>alert('" + _strmsg + "');</script>");
    }
    private bool getCoValiteWecCtnID()
    {

        lblMessage.Text = "";
        if (txtboxid.Text.Length >= 12)
        {
            var exist = new PIE.DAL.plr_mstr_tran_ext().Exists(txtboxid.Text);
            if (!exist)
            {
                initfalse(txtboxid.Text + " is not exist.", "Error");
                return false;
            }
            _plr_mstr_tran_model_list = new PIE.BLL.plr_mstr_tran().GetModelList("plr_wec_ctn='" + txtboxid.Text + "'");
            if (_plr_mstr_tran_model_list != null)
            {

                if (_plr_mstr_tran_model_list.Count > 0)
                {
                    if (!_plr_mstr_tran_model_list[0].plr_deci1.ToString().Equals("1"))
                    {
                        initfalse(txtboxid.Text + " has not Print Label, Can't Scan.", "Error");
                        return false;

                    }
                    if (!string.IsNullOrEmpty(_plr_mstr_tran_model_list[0].plr_chr01) && _plr_mstr_tran_model_list[0].plr_chr01.Equals("S"))
                    {
                        initfalse(txtboxid.Text + " has being Scaning.", "Error");
                        return false;

                    }
                    var strco = _plr_mstr_tran_model_list[0].plr_co;
                    if (string.IsNullOrEmpty(strco))
                    {
                        //if (string.IsNullOrWhiteSpace(txtCo.Text))
                        //{
                        //    ShowMsg(txtboxid.Text + " has no Co.", "Error");
                        //    txtCo.Focus();
                        //    return false;
                        //}
                        //else
                        //{
                        //    PIE.Model.pkey_ctl existco = new PIE.BLL.pkey_ctl().GetModel("co", txtCo.Text);
                        //    if (existco != null)
                        //    {
                        //        lbl3co.Text = existco.t_value + ":" + existco.t_desc;
                        //        _strco = existco.t_value + ":" + existco.t_desc;
                        //    }
                        //    else
                        //    {
                        //        ShowMsg(txtCo.Text + " has no Desc.", "Error: ");
                        //        _strco = "";
                        //        txtCo.Text = "";
                        //        txtCo.Focus();
                        //        return false;
                        //    }
                        //}
                    }
                    else
                    {
                        // txtCo.Text = strco;

                        if (strco.Length > 0)
                        {
                            PIE.Model.pkey_ctl existco = new PIE.BLL.pkey_ctl().GetModel("co", strco);
                            if (existco != null)
                            {
                                lbl3co.Text = existco.t_value + ":" + existco.t_desc;
                                _strco = existco.t_value + ":" + existco.t_desc;
                            }
                            //else
                            //{
                            //    ShowMsg(txtCo.Text + " has no Desc.", "Error: ");
                            //    txtCo.Text = "";
                            //    _strco = "";
                            //    txtCo.Focus();
                            //    return false;
                            //}
                        }
                    }


                    return true;
                }
                else
                {
                    initfalse(txtboxid.Text + " has be Scaning over.", "Notice");
                    return false;
                }

            }
            else
            {

                initfalse(txtboxid.Text + " is not exist.", "Error");
                return false;
            }

        }
        else
        {
            ShowMsg(txtboxid.Text + " is not exist.", "Error");
        }


        initfalse(txtboxid.Text + " is not exist.", "Error");
        return false;
    }

    private void initfalse(string strmsg, string title)
    {
        ShowMsg(strmsg, title);
        txtboxid.Text = "";
        //txtCo.Text = "";
        txtboxid.Focus();
    }

    protected void BtnReturn_Click(object sender, EventArgs e)
    {
        // Session["piid"] = null;
        //  Session["plant"] = null;
        //  Session["type"] = null;

        Response.Write("<script language='javascript'>top.location.href='ScanSet.aspx';</script>");
    }
    //protected void txtCo_TextChanged(object sender, EventArgs e)
    //{
    //}
    public void initScanTXT(int secMorelen, int substringlen)
    {

        if (txtboxid.Text.Length >= substringlen)
        {
            char ckey = '\'';
            string str12 = txtboxid.Text.Replace(ckey, ' ');

            txtboxid.Text = str12.Substring(str12.Length - substringlen, substringlen);

            txtboxid.Focus();
        }
    }
    protected void txtboxid_TextChanged(object sender, EventArgs e)
    {

    }
    protected void BtnExit_Click(object sender, EventArgs e)
    {
        Session["user_id"] = "";
        Session["piid"] = "";
        Session["plant"] = "";
        Session["type"] = "";
        Session["palletNum"] = "";
        Session["nw"] = "";
        Response.Write("<script language='javascript'>top.location.href='Login.aspx';</script>");
    }
    protected void btnco_Click(object sender, EventArgs e)
    {
        getCoValiteWecCtnID();
    }
}