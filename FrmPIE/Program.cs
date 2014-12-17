using System;
using System.Collections.Generic;
using System.Web.Services.Description;
using System.Windows.Forms;

using PIE.DBUtility;
using System.Data.SqlClient;
using System.Data;

using System.Net;
using System.Net.Sockets;

using System.DirectoryServices;
using System.Text.RegularExpressions;
using System.Drawing;

namespace FrmPIE
{
    static class Program
    {
        #region def paraider

        public static string _frm0Version;
        public static string _frm1VersionLast;
        public static string _frm6Versionprefix;

        public static int _frm3VersionDotNet;
        public static int _frm4VersionMain;
        public static int _frm5VersionSecond;

        public static bool _frm7VersionUpdateFlag = false;
        public static string _frm8VersionMsg;
        public static string _frm9VersionURL;
        public static string _frm10VersionFixMsg;

        public static string _uploaderpmsg = "";
        public static string _uploaderrows = "";
        public static string _strURL = "";

        static LogonDomain LogonOn = null;
        #endregion

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            //frmVersion = "@2V20141010H10-dev";
            _frm3VersionDotNet = 2;
            _frm4VersionMain = 20141217;

            _frm5VersionSecond = 11;
            _frm6Versionprefix = "RTM";//RTM
            //fix msg
            _frm10VersionFixMsg = "1.fix upload xls for kyca,add po number to 10.";
            //dev  main
            _frm0Version = "@" + _frm3VersionDotNet + "V" + _frm4VersionMain + "H" + _frm5VersionSecond + "-" + _frm6Versionprefix;

            _strURL = "http://142.2.47.149/pisoft/net" + _frm3VersionDotNet + ".0/0" + _frm6Versionprefix;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            //
            string t_name_m = "version";
            string t_value_m = "last" + _frm3VersionDotNet;

            PIE.Model.pkey_ctl _lastversion_model;
            PIE.Model.pkey_ctl _lastversion_model_fixmsg = new PIE.Model.pkey_ctl();
            try
            {
                _lastversion_model = new PIE.DAL.pkey_ctl().GetModel(t_name_m, t_value_m);

                if (_lastversion_model == null)
                {
                    PIE.Model.pkey_ctl pkey_ctl_mode = new PIE.Model.pkey_ctl();
                    pkey_ctl_mode.t_name = t_name_m;
                    pkey_ctl_mode.t_value = t_value_m;
                    pkey_ctl_mode.t_desc = _frm0Version;
                    pkey_ctl_mode.t_yyww = _strURL;
                    pkey_ctl_mode.prefix = _frm6Versionprefix;
                    pkey_ctl_mode.ctl_fro = _frm4VersionMain;
                    pkey_ctl_mode.ctl_to = _frm5VersionSecond;
                    pkey_ctl_mode.ctl_curr = _frm3VersionDotNet;
                    var addresultflg = new PIE.BLL.pkey_ctl().Add(pkey_ctl_mode);
                }
                else
                {
                    if (!_lastversion_model.t_desc.Equals(_frm0Version))
                    {
                        if (_frm4VersionMain > _lastversion_model.ctl_fro)
                        {
                            _frm7VersionUpdateFlag = false;
                            //version
                            _lastversion_model.t_desc = _frm0Version;
                            _lastversion_model.ctl_fro = _frm4VersionMain;
                            _lastversion_model.ctl_to = _frm5VersionSecond;
                            _lastversion_model.prefix = _frm6Versionprefix;

                            var updateLast = new PIE.BLL.pkey_ctl().Update(_lastversion_model);
                            //version msg
                            _lastversion_model_fixmsg.t_name = t_name_m;
                            _lastversion_model_fixmsg.t_value = _frm0Version;
                            _lastversion_model_fixmsg.t_desc = _frm10VersionFixMsg;
                            var updatelastMsg = new PIE.BLL.pkey_ctl().Add(_lastversion_model_fixmsg);


                        }
                        else if (_frm4VersionMain == _lastversion_model.ctl_fro)
                        {
                            if (_frm5VersionSecond > _lastversion_model.ctl_to)
                            {
                                _frm7VersionUpdateFlag = false;

                                _lastversion_model.t_desc = _frm0Version;
                                _lastversion_model.ctl_fro = _frm4VersionMain;
                                _lastversion_model.ctl_to = _frm5VersionSecond;
                                _lastversion_model.prefix = _frm6Versionprefix;

                                var updateLast = new PIE.BLL.pkey_ctl().Update(_lastversion_model);

                                //version msg
                                _lastversion_model_fixmsg.t_name = t_name_m;
                                _lastversion_model_fixmsg.t_value = _frm0Version;
                                _lastversion_model_fixmsg.t_desc = _frm10VersionFixMsg;
                                var updatelastMsg = new PIE.BLL.pkey_ctl().Add(_lastversion_model_fixmsg);

                            }
                            else
                            {
                                _frm1VersionLast = _lastversion_model.t_desc;
                                _frm7VersionUpdateFlag = true;
                                _frm8VersionMsg = "down new Version ";
                                _frm9VersionURL = _lastversion_model.t_yyww;
                                _lastversion_model_fixmsg = new PIE.BLL.pkey_ctl().GetModel(t_name_m, _frm1VersionLast);
                                if (_lastversion_model_fixmsg != null)
                                {
                                    _frm10VersionFixMsg = _lastversion_model_fixmsg.t_desc;

                                }
                            }

                        }
                        else
                        {
                            _frm1VersionLast = _lastversion_model.t_desc;
                            _frm7VersionUpdateFlag = true;
                            _frm8VersionMsg = "down new Version ";
                            _frm9VersionURL = _lastversion_model.t_yyww;
                            _lastversion_model_fixmsg = new PIE.BLL.pkey_ctl().GetModel(t_name_m, _frm1VersionLast);
                            if (_lastversion_model_fixmsg != null)
                            {
                                _frm10VersionFixMsg = _lastversion_model_fixmsg.t_desc;

                            }
                        }

                    }
                    else
                    {
                        _frm7VersionUpdateFlag = false;
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            // Application.Run(new frmplMain());

            //var FrmPIE = new FrmPIE();
            //FrmPIE.Text += frmVersion;
            //Application.Run(FrmPIE);

            //logon on
            LogonOn = new LogonDomain();
            LogonOn.Text += _frm0Version;
            Application.Run(LogonOn);

            //var index = new IndexTemple();
            //Application.Run(index);

            //var frmIDR = new frmIDR();
            //frmIDR.Text += frmVersion;
            //Application.Run(frmIDR);

        }

        public static void checkNewVersion()
        {
            string t_name_m = "version";
            string t_value_m = "last" + _frm3VersionDotNet;

            PIE.Model.pkey_ctl _lastversion_model;
            PIE.Model.pkey_ctl _lastversion_model_fixmsg;
            try
            {
                _lastversion_model = new PIE.DAL.pkey_ctl().GetModel(t_name_m, t_value_m);
                if (!_frm0Version.Equals(_lastversion_model.t_desc))
                {
                    _frm1VersionLast = _lastversion_model.t_desc;
                    _lastversion_model_fixmsg = new PIE.DAL.pkey_ctl().GetModel(t_name_m, _frm1VersionLast);
                    _frm8VersionMsg = _lastversion_model_fixmsg.t_desc;
                    _frm7VersionUpdateFlag = true;
                }
                else
                {
                    _frm7VersionUpdateFlag = false;
                }
            }
            catch
            {
                _frm7VersionUpdateFlag = false;
            }
        }
        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            //throw new NotImplementedException("error thread:"+e.Exception.Message);
            MessageBox.Show(e.Exception.Message);
        }
        public static string ADValidate(string ADPath, string Uname, string Password)
        {

            DirectoryEntry de = new DirectoryEntry(ADPath, Uname, Password);
            try
            {
                DirectorySearcher search = new DirectorySearcher(de);
                search.Filter = "(sAMAccountName=" + Uname + ")";
                SearchResult result = search.FindOne();
                return "OK";
            }
            catch (Exception ex)
            {
                throw new Exception("ErrorAdValidate:Invalid UserName Or Password, Please try again.Thank your.");
            }
            finally
            {
                de.Close();
            }

        }

        public static string getSecondPasswrdflag(string strdomain, string username, string secondpassword)
        {
            string flag = "";
            WebReference208.UserLoginCheck service = new WebReference208.UserLoginCheck();
            flag = service.WFUserSecondPwdChk(strdomain, username, secondpassword);
            return flag;
        }
        public static string getClientIP()
        {
            IPAddress[] arrIPAddresses = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress ip in arrIPAddresses)
            {
                if (ip.AddressFamily.Equals(AddressFamily.InterNetwork))
                {
                    return ip.ToString();
                }
            }
            return "Nothing";
        }
        public static string POchecking(string POnbr, string Partno, string Qty)
        {
            try
            {
                DataSet ds;

                WebReferenceRTM99.Service server100 = new WebReferenceRTM99.Service();
                server100.Timeout = 9000000;

                var strPO = POnbr + " @ " + Partno + " @ " + Qty;

                int returnValueNumber;
                string wec_ctn_pre;
                getInitServer(POnbr, out returnValueNumber, out wec_ctn_pre);

                ds = server100.GetTable_n(wec_ctn_pre, "wsas014", strPO);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    return ds.Tables[0].Rows[0][3].ToString();
                }
                else
                {
                    return "ERP has no this record";
                }

            }
            catch (Exception ex)
            {
                return "Error";
            }




        }

        public static void getInitServer(string POnbr, out int returnValueNumber, out string wec_ctn_pre)
        {
            SqlParameter[] parameters ={
                new SqlParameter("@po_nbr",SqlDbType.VarChar,30),
                new SqlParameter("@wec_ctn_pre",SqlDbType.VarChar,30)
                };
            parameters[0].Value = POnbr;

            parameters[1].Direction = ParameterDirection.Output;

            DbHelperSQL.RunProcedure("sp_Get_WecCtnPre", parameters, out returnValueNumber);

            wec_ctn_pre = parameters[1].Value.ToString().Trim();
        }

        public static string POchecking(PIE.Model.plr_mstr plr_mstr_model)
        {
            try
            {

                string wec_ctn_pre;
                string strServer;
                DataSet ds;

                string strpocheck = "";

                PIE.Model.plr_mstr_err plr_mstr_err_model = new PIE.Model.plr_mstr_err();

                WebReferenceRTM99.Service server100 = new WebReferenceRTM99.Service();
                server100.Timeout = 9000000;

                var strPO = plr_mstr_model.plr_po + " @ " + plr_mstr_model.plr_partno + " @ " + plr_mstr_model.plr_qty.ToString();

                initWebServer(plr_mstr_model.plr_po, server100, "wsas014", strPO, out ds);


                if (ds.Tables[0].Rows.Count > 0)
                {

                    strpocheck = ds.Tables[0].Rows[0][3].ToString();

                    plr_mstr_model.plr_chr01 = strpocheck;
                    plr_mstr_model.plr_update_date = DbHelperSQL.getServerGetDate();

                    var updatePO = new PIE.BLL.plr_mstr().Update(plr_mstr_model);
                    var existMstrErr = new PIE.BLL.plr_mstr_err().Delete(plr_mstr_model.Batch_ID, plr_mstr_model.LineID);

                    if (updatePO && strpocheck != "OK")
                    {
                        plr_mstr_err_model.Batch_ID = plr_mstr_model.Batch_ID;
                        plr_mstr_err_model.LineID = plr_mstr_model.LineID;
                        plr_mstr_err_model.plr_doc_type = plr_mstr_model.plr_doc_type;
                        plr_mstr_err_model.plr_po = plr_mstr_model.plr_po;
                        plr_mstr_err_model.plr_partno = plr_mstr_model.plr_partno;
                        plr_mstr_err_model.plr_qty = plr_mstr_model.plr_qty;
                        plr_mstr_err_model.plr_cre_date = plr_mstr_model.plr_cre_date;
                        plr_mstr_err_model.plr_update_date = DbHelperSQL.getServerGetDate();

                        plr_mstr_err_model.plr_user_ip = getClientIP();

                        plr_mstr_err_model.plr_err_msg = strpocheck;



                        var addPlrMstrErr = new PIE.BLL.plr_mstr_err().Add(plr_mstr_err_model);
                        if (addPlrMstrErr)
                        {
                            return "msg@" + strpocheck;
                        }

                    }
                    else if (updatePO && strpocheck.Equals("OK"))
                    {
                        return "OK";
                    }
                    else
                    {

                        return "Error1";
                    }
                }
                return "Error2";

            }
            catch (Exception ex)
            {
                return "Error3:" + ex.Message;
            }




        }
        private static bool initWebServer(string plr_po, WebReferenceRTM99.Service server100, string intable, string strPO, out DataSet ds)
        {
            int returnValueNumber;
            string wec_ctn_pre;

            getInitServer(plr_po, out returnValueNumber, out wec_ctn_pre);

            try
            {

                ds = server100.GetTable_n(wec_ctn_pre, intable, strPO);
                return true;
            }
            catch (Exception ex)
            {

                ds = null;
                return false;
                //MessageBox.Show(ex.Message);

            }

        }

        public static void UploadtoERP(FrmPIE frmpie)
        {
            try
            {
                string strWheretran = "plr_status = 'C'";
                string strWhereMast = "";
                string strPO = "";
                string strPO_mstr = "";

                int intUploadSum = 0;
                int intUploadCount = 0;
                int intUploadDup = 0;
                int intUploadErrCount = 0;


                string strResult = "";

                WebReferenceRTM99.Service server100 = new WebReferenceRTM99.Service();
                server100.Timeout = 9000000;

                DataSet ds = null;

                List<PIE.Model.plr_mstr> plr_mstr_ls = null;

                List<PIE.Model.plr_mstr_tran> plr_mstr_tran_ls = new PIE.BLL.plr_mstr_tran().GetModelList(strWheretran);



                if (plr_mstr_tran_ls != null && plr_mstr_tran_ls.Count > 0)
                {

                    intUploadSum = plr_mstr_tran_ls.Count;
                    var currint = 0;
                    foreach (PIE.Model.plr_mstr_tran item in plr_mstr_tran_ls)
                    {
                        char ckey = '@';
                        strPO = item.Batch_ID + "@" + "" + "@" + "" + "@" +
                                                     item.InvoiceID + "@" + item.plr_po + "@" + "" + "@" +
                                                     item.plr_partno + "@" + item.plr_site + "@" + item.Plr_vm_partno + "@" + item.plr_vend_mfgr + "@" + "" + "@" +
                                                     item.plr_co + "@" + item.plr_date_code + "@" + "" + "@" + "" + "@" +
                                                     item.plr_qty + "@" + "" + "@" +
                                                     item.Wec_Ctn + "@" + item.CartonNo + "@" + item.plr_carton_qty + "@" +
                                                     "" + "@" + "" + "@" + "" + "@" + "" + "@" + "" + "@" + "" + "@" + "" + "@" + "" + "@" + "" + "@" +
                                                     item.CartonID + "@" + item.plr_pallet_no;
                        strPO = @strPO.ToString();

                        currint++;

                        frmpie.SetToolTextdelegate(frmpie.toolLabel2ThreadMsg, "$UploadToERP: Notice: 第 " + currint + " 条开始上传", true, true);

                        var returnWeb = initWebServer(item.plr_po, server100, "wsas013", strPO, out ds);
                        if (returnWeb)
                        {
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                string strResultWebser = ds.Tables[0].Rows[0][4].ToString();
                                string strErrMessage = ds.Tables[0].Rows[0][5].ToString();
                                string strABC = ds.Tables[0].Rows[0][6].ToString();
                                string strcheck = ds.Tables[0].Rows[0][7].ToString();

                                item.plr_chr01 = strABC;
                                item.plr_chr02 = strcheck;

                                if (strResultWebser.Equals("2"))
                                {
                                    item.plr_status = "U";
                                    item.plr_status_msg = strErrMessage;
                                    item.plr_update_date = DateTime.Now;
                                    item.plr_user_ip = getClientIP();

                                    var intupdate = new PIE.BLL.plr_mstr_tran().Update(item);

                                    intUploadCount++;

                                    frmpie.SetToolTextdelegate(frmpie.toolLabel2ThreadMsg, "$UploadToERP: Notice: 第 " + intUploadCount + " 条上传Success。", true, true);

                                }
                                else if (strResultWebser.Equals("1"))
                                {

                                    item.plr_status = "U";
                                    item.plr_status_msg = strErrMessage;
                                    item.plr_update_date = DateTime.Now;
                                    item.plr_user_ip = getClientIP();

                                    var intupdate = new PIE.BLL.plr_mstr_tran().Update(item);

                                    intUploadDup++;
                                }
                                else
                                {
                                    item.plr_status = "E";
                                    item.plr_status_msg = strErrMessage;

                                    item.plr_update_date = DateTime.Now;
                                    item.plr_user_ip = getClientIP();

                                    var intupdate = new PIE.BLL.plr_mstr_tran().Update(item);
                                    strResult = strResult + "未上传：" + item.Batch_ID + "," + item.LineID + ",Error:" + strErrMessage + "\n";
                                    intUploadErrCount++;
                                }

                            }
                            else
                            {

                                item.plr_status = "N";
                                item.plr_status_msg = "WebServer Error 没有返回值";

                                item.plr_update_date = DateTime.Now;
                                item.plr_user_ip = getClientIP();

                                var intupdate = new PIE.BLL.plr_mstr_tran().Update(item);
                                strResult = strResult + "未上传：" + item.Batch_ID + "," + item.LineID + ",Error:" + "WebServer 没有返回值" + "\n";
                                intUploadErrCount++;
                            }

                        }
                        else
                        {
                            strResult = "$UploadToERP: Error: Webservice 连接超时.";
                            break;
                        }

                    }
                    strResult = strResult == "" ? "\t1. 需要上传：" + intUploadSum + "条,\n\t2. 上传：" + intUploadCount + "条记录OK.\n\t3. 有" + intUploadDup + "条重复。\n\t4. 有" + intUploadErrCount + "条上传失败。\n" : "\t1. 需要上传：" + intUploadSum + "条,\n\t2. 上传：" + intUploadCount + "条记录OK.\n\t3. 有" + intUploadDup + "条重复。\n\t4. 有" + intUploadErrCount + "条上传失败。\n" + "\t5.失败的记录:\n" + strResult;


                }
                else
                {
                    strResult = "$UploadToERP: Error: 系统数据库中没有可上传的（C状态）记录。";
                }
                MessageBox.Show(strResult);
                _uploaderpmsg = "$UploadToERP: 上传ERP完成。";

            }
            catch (Exception ex)
            {

                _uploaderpmsg = "$UploadToERP: Error:" + ex.Message;
            }


        }
        public static string[] initCartonFromTo(string CartonId, string CartonType, out string carprefix)
        {
            Regex RegPrefix = new Regex(@"[a-zA-Z\.,@?^=%&amp;:/~\+#]+");
            var iPos = CartonId.IndexOf('-');
            var strCtnId = CartonId;

            string[] strCtnIdArr = new string[2];

            Match m = RegPrefix.Match(strCtnId);
            if (m.Success)
            {
                carprefix = m.Value.Trim();

            }
            else
            {
                carprefix = "";
            }
            if (!string.IsNullOrEmpty(carprefix))
            {

                strCtnId = strCtnId.Replace(carprefix, " ");
            }
            if (iPos > 0)
            {
                strCtnIdArr = strCtnId.Split('-');
                //if (Convert.ToInt32(strCtnIdArr[0]) > Convert.ToInt32(strCtnIdArr[1]))
                //{
                //    strCtnIdArr[1] = strCtnIdArr[0];
                //}

            }
            else
            {


                strCtnIdArr[0] = strCtnId;
                strCtnIdArr[1] = strCtnId;
            }

            return strCtnIdArr;
        }

        public static int GenCartonNo(PIE.Model.plr_mstr plr_mstr_model)
        {
            int result;
            int intEffected;
            string strprefix;
            //if (plr_mstr_model.CartonType.Equals("0"))
            //{
            //    return 0;
            //}
            string[] cartonFrTo = initCartonFromTo(plr_mstr_model.CartonID, plr_mstr_model.CartonType, out strprefix);

            if (Convert.ToInt32(cartonFrTo[0]) > Convert.ToInt32(cartonFrTo[1]))
            {
                MessageBox.Show("CartonFrom :" + cartonFrTo[0] + " > " + cartonFrTo[1] + ",Batch ID:" + plr_mstr_model.Batch_ID + ",LineID: " + plr_mstr_model.LineID + ",无法生成 Wec Carton");
                return 1;
            }
            SqlParameter[] parameters = {
                                                new SqlParameter("@Batch_ID",SqlDbType.NVarChar,20),
                                                new SqlParameter("@LineID",SqlDbType.Int),
                                                new SqlParameter("@plr_doc_type",SqlDbType.NVarChar,50),
                                                new SqlParameter("@CartonID",SqlDbType.NVarChar,30),
                                                new SqlParameter("@CartonType",SqlDbType.NVarChar,30),

                                                new SqlParameter("@plr_po",SqlDbType.NVarChar,50),
                                                new SqlParameter("@plr_qty",SqlDbType.Decimal,18),
                                                new SqlParameter("@ctnPre",SqlDbType.NVarChar,10),
                                                new SqlParameter("@ctnFr",SqlDbType.Int),
                                                new SqlParameter("@ctnTo",SqlDbType.Int),

                                                new SqlParameter("@plr_cre_userid",SqlDbType.NVarChar,50),
                                               // new SqlParameter("@plr_partno",SqlDbType.NVarChar,30),   
                                             
                                                new SqlParameter("@plr_user_ip",SqlDbType.NVarChar,50),

                                                new SqlParameter("@result",SqlDbType.SmallInt)                    
                                            }
                                        ;
            parameters[0].Value = plr_mstr_model.Batch_ID;
            parameters[1].Value = plr_mstr_model.LineID;
            parameters[2].Value = plr_mstr_model.plr_doc_type;
            parameters[3].Value = plr_mstr_model.CartonID;
            parameters[4].Value = plr_mstr_model.CartonType;

            parameters[5].Value = plr_mstr_model.plr_po;
            parameters[6].Value = plr_mstr_model.plr_qty;


            parameters[7].Value = strprefix;
            parameters[8].Value = cartonFrTo[0];
            parameters[9].Value = cartonFrTo[1];

            parameters[10].Value = "";

            //parameters[11].Value = plr_mstr_model.plr_partno;

            parameters[11].Value = Program.getClientIP();
            parameters[12].Direction = ParameterDirection.Output;

            DbHelperSQL.RunProcedure("sp_GenCtn_Tran", parameters, out intEffected);
            result = Convert.ToInt16(parameters[12].Value);
            return result;
        }
        public static int GenCartonNo(DataSet ds)
        {
            int intresutl = 1;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                PIE.Model.plr_mstr plr_mstr_model = new PIE.DAL.plr_mstr_ext().DataRowToModel(dr, true);
                intresutl = Program.GenCartonNo(plr_mstr_model);
            }
            return intresutl;
        }
        public static void OpenFolderAndSelectFile(String fileFullName)
        {
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("Explorer.exe");
            psi.Arguments = "/e,/select," + fileFullName;
            //psi.UseShellExecute = true;
            //psi.Verb = "open";
            System.Diagnostics.Process.Start(psi);
        }
        public static bool showNewVersion(LinkLabel lk)
        {
            checkNewVersion();
            if (Program._frm7VersionUpdateFlag)
            {
                lk.Visible = true;
                lk.Text = "New Version!" + Program._frm1VersionLast + ", Click to DownLoad.";
                lk.LinkClicked += link0NewVersion_LinkClicked;
                return true;
            }
            lk.Visible = false;
            return false;
        }
        static void link0NewVersion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(_frm10VersionFixMsg))
                {
                    MessageBox.Show("New Version: \n" + _frm1VersionLast + "\n\n" + _frm10VersionFixMsg, "Update Notice");
                }
                LinkLabel lk = (LinkLabel)sender;
                lk.Links[0].LinkData = Program._frm9VersionURL;
                if (lk.Visible == true)
                {
                    System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
                    lk.Visible = false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (LogonOn != null)
                {

                    LogonOn.Close();
                }
                else
                {
                    Application.Exit();
                }
                GC.Collect();
            }
        }
        ///////////////////////////////////new
    }

}