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
        public static string frmVersion;
        public static string _uploaderpmsg = "";
        public static string _uploaderrows = "";

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            frmVersion = "@4V2014-09-26-12-dev";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);

            // Application.Run(new frmplMain());

            //var FrmPIE = new FrmPIE();
            //FrmPIE.Text += frmVersion;
            //Application.Run(FrmPIE);

            //logon on

            var LogonOn = new LogonDomain();
            LogonOn.Text += frmVersion;
            Application.Run(LogonOn);

            //var index = new IndexTemple();
            //Application.Run(index);

            //var frmIDR = new frmIDR();
            //frmIDR.Text += frmVersion;
            //Application.Run(frmIDR);

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
                int returnValueNumber;
                string wec_ctn_pre;
                string strServer;
                DataSet ds;

                WebReference100.Service server100 = new WebReference100.Service();
                server100.Timeout = 9000000;

                var strPO = POnbr + " @ " + Partno + " @ " + Qty;

                SqlParameter[] parameters ={
                new SqlParameter("@po_nbr",SqlDbType.VarChar,30),
                new SqlParameter("@wec_ctn_pre",SqlDbType.VarChar,30)
                };
                parameters[0].Value = POnbr;

                parameters[1].Direction = ParameterDirection.Output;

                DbHelperSQL.RunProcedure("sp_Get_WecCtnPre", parameters, out returnValueNumber);

                wec_ctn_pre = parameters[1].Value.ToString().Trim();


                if (wec_ctn_pre == "WWTS")
                {
                    strServer = "TESTOLDWEC";
                }
                else if (wec_ctn_pre == "WEC")
                {
                    strServer = "P1";
                }
                else if (wec_ctn_pre == "WTSZ")
                {
                    strServer = "TESTOLDWEC";
                }
                else if (wec_ctn_pre == "Wellop")
                {
                    strServer = "TESTOLDWEC";
                }
                else
                {
                    strServer = "other";
                }

                ds = server100.GetTable_n(strServer, "wsas014", strPO);

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

        public static string POchecking(PIE.Model.plr_mstr plr_mstr_model)
        {
            try
            {

                string wec_ctn_pre;
                string strServer;
                DataSet ds;

                string strpocheck = "";

                PIE.Model.plr_mstr_err plr_mstr_err_model = new PIE.Model.plr_mstr_err();

                WebReference100.Service server100 = new WebReference100.Service();
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
        private static bool initWebServer(string plr_po, WebReference100.Service server100, string intable, string strPO, out DataSet ds)
        {
            int returnValueNumber;
            string wec_ctn_pre;
            string strServer;


            SqlParameter[] parameters ={
                new SqlParameter("@po_nbr",SqlDbType.VarChar,30),
                new SqlParameter("@wec_ctn_pre",SqlDbType.VarChar,30)
                };

            parameters[0].Value = plr_po;

            parameters[1].Direction = ParameterDirection.Output;

            DbHelperSQL.RunProcedure("sp_Get_WecCtnPre", parameters, out returnValueNumber);

            wec_ctn_pre = parameters[1].Value.ToString().Trim();



            if (wec_ctn_pre == "WWTS")
            {
                strServer = "TESTOLDWEC";
            }
            else if (wec_ctn_pre == "WEC")
            {
                strServer = "P1";
            }
            else if (wec_ctn_pre == "WTSZ")
            {
                strServer = "TESTOLDWEC";
            }
            else if (wec_ctn_pre == "Wellop")
            {
                strServer = "TESTOLDWEC";
            }
            else
            {
                strServer = "P1";
            }
            try
            {

                ds = server100.GetTable_n(strServer, intable, strPO);
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

                WebReference100.Service server100 = new WebReference100.Service();
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
                carprefix = m.Value;

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
        public static void OpenFolderAndSelectFile(String fileFullName)
        {
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("Explorer.exe");
            psi.Arguments = "/e,/select," + fileFullName;
            System.Diagnostics.Process.Start(psi);
        }

    }

}