using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using PI.Model;
using PI.DAL;
using PI.BLL;
using PIE.Model;
using PIE.DAL;
using PIE.Model;
using PIE.DBUtility;
using PIE.Common;
using System.Data;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }
    [WebMethod]
    public DataSet[] get_PI_Mstr(string ctnSN)
    {
        DataSet pi_mstr_ds;
        DataSet pi_det_ds;

        string strwhere = "pi_wec_ctn='" + ctnSN + "'";
        pi_det_ds = new PI.BLL.pi_det().GetList(strwhere);
        if (pi_det_ds.Tables[0].Rows.Count > 0)
        {
            string piid = pi_det_ds.Tables[0].Rows[0]["PI_ID"].ToString();
            pi_mstr_ds = new PI.BLL.pi_mstr().GetList("PI_ID='" + piid + "'");
            pi_det_ds = new PI.BLL.pi_det().GetList("PI_ID='" + piid + "'");

            return new DataSet[] { pi_mstr_ds, pi_det_ds };
        }
        return new DataSet[] { null, null };

    }
    [WebMethod]
    public int scan_PI_det(PI.Model.pi_mstr pi_mstr_model, string ctn_SN, string strco, string user_id)
    {
        var _plr_mstr_tran_model_list = new PIE.BLL.plr_mstr_tran().GetModelList("plr_wec_ctn='" + ctn_SN + "'");

        var _pi_det_model = new PI.Model.pi_det();
        _pi_det_model.PI_ID = pi_mstr_model.PI_ID;
        _pi_det_model.pi_type = pi_mstr_model.pi_type;

        if (_plr_mstr_tran_model_list != null)
        {
            foreach (var tran in _plr_mstr_tran_model_list)
            {
                if (tran.plr_wec_ctn.Equals(ctn_SN))
                {
                    _pi_det_model.pi_wec_ctn = tran.plr_wec_ctn;
                    _pi_det_model.plr_LineID_tran = tran.LineID;
                    _pi_det_model.pi_pallet_no = tran.plr_pallet_no;
                    _pi_det_model.CartonNo = tran.CartonNo;
                    _pi_det_model.CartonID = tran.CartonID;

                    _pi_det_model.pi_chr01 = strco;
                    _pi_det_model.pi_remark = "New";
                    _pi_det_model.pi_cre_date = DbHelperSQL.getServerGetDate();
                    _pi_det_model.pi_update_date = _pi_det_model.pi_cre_date;
                    _pi_det_model.pi_cre_userid = user_id;
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
                    var result_pi_det = new PI.DAL.pi_det().Add(_pi_det_model);
                    if (result_pi_det)
                    {
                        tran.plr_chr01 = "S";
                        tran.plr_update_date = DateTime.Now;
                        var updatescan = new PIE.BLL.plr_mstr_tran().Update(tran);
                    }
                }
                else
                {
                    break;
                }
            }
            return _pi_det_model.pi_LineID;
        }
        else
        {
            return 0;
        }

    }
}
