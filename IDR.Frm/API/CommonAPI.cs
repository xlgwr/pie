using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using MessageBox = System.Windows.Forms.MessageBox;

using System.Data.Entity;
using IDR.Common;
using IDR.Common.DEncrypt;
using IDR.Frm.API;

using IDR.EF.PIE;
using IDR.EF.PIRemote;

using IDR.Frm.Logon;
using IDR.Frm.Properties;

using System.IO;
using System.Data.SqlClient;
using System.Threading;
using System.Data;

namespace IDR.Frm.API
{
    class CommonAPI
    {
        Default _frmDefault;

        public CommonAPI() { }

        public CommonAPI(Default frmDefault)
        {
            _frmDefault = frmDefault;
        }
        /// <summary>
        ///  ControlIsNullOrEmpty
        /// </summary>
        /// <param name="msg">messageBox msg</param>
        /// <param name="cl">control name</param>
        /// <returns>true,false</returns>
        public bool ControlIsNullOrEmpty(string msg, Control cl)
        {
            if (string.IsNullOrEmpty(cl.Text))
            {
                MessageBox.Show(msg);
                cl.Focus();
                return true;
            }
            return false;
        }

        /// <summary>
        ///  ControlIsNullOrEmpty
        /// </summary>
        /// <param name="msg">label msg</param>
        /// <param name="cl">control name</param>
        /// <returns>true,false</returns>
        public bool ControlIsNullOrEmpty(string msg, Control cl, Control clnotice)
        {
            if (string.IsNullOrEmpty(cl.Text))
            {
                cl.Focus();
                clnotice.Text = msg;
                return true;
            }
            return false;
        }
        /// <summary>
        /// set control text
        /// </summary>
        /// <param name="ctl"></param>
        /// <param name="strMsg"></param>
        /// <param name="enable"></param>
        /// <param name="visible"></param>
        public void setControlText(System.Windows.Forms.Control ctl, string strMsg, bool enable, bool visible)
        {
            _frmDefault.Invoke(new Action(delegate
            {
                ctl.Text = strMsg;
                ctl.Enabled = enable;
                ctl.Visible = visible;
            }));

        }
        /// <summary>
        /// button enable
        /// </summary>
        /// <param name="ctl"></param>
        /// <param name="strMsg"></param>
        /// <param name="enable"></param>
        /// <param name="visible"></param>
        public void setControlText(System.Windows.Forms.Control ctl, bool enable, bool visible)
        {
            _frmDefault.Invoke(new Action(delegate
            {
                ctl.Enabled = enable;
                ctl.Visible = visible;
            }));

        }
        /// <summary>
        /// set toolstriptitem state bar
        /// </summary>
        /// <param name="ctl"></param>
        /// <param name="strMsg"></param>
        /// <param name="enable"></param>
        /// <param name="visible"></param>
        public void setControlText(System.Windows.Forms.ToolStripItem ctl, string strMsg, bool enable, bool visible)
        {
            _frmDefault.Invoke(new Action(delegate
            {
                ctl.Text = strMsg;
                ctl.Enabled = enable;
                ctl.Visible = visible;
            }));

        }
        /// <summary>
        /// get prefix for cartonid
        /// </summary>
        /// <param name="CartonId"></param>
        /// <param name="CartonType"></param>
        /// <param name="carprefix"></param>
        /// <returns></returns>
        public string[] initCartonFromTo(string CartonId, string CartonType, out string carprefix)
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
        /// <summary>
        /// Generate Carton id
        /// </summary>
        /// <param name="plr_mstr_model"></param>
        /// <returns></returns>
        public int GenCartonNo(plr_mstr plr_mstr_model)
        {
            int result;
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

            parameters[11].Value = _frmDefault._clientIP;
            parameters[12].Direction = ParameterDirection.Output;

            var strsql = "[dbo].[sp_GenCtn_Tran] @Batch_ID,@LineID,@plr_doc_type,@CartonID,@CartonType,@plr_po,@plr_qty,@ctnPre,@ctnFr,@ctnTo,@plr_cre_userid,@plr_user_ip,@result OUTPUT";
            _frmDefault._dbpie.Database.SqlQuery<object>(strsql, parameters).SingleOrDefault();

            result = Convert.ToInt16(parameters[12].Value);
            return result;
        }
        internal void OpenFolderAndSelectFile(string pathname)
        {
            throw new NotImplementedException();
        }
        //////////////////////////////////add new
    }
}
