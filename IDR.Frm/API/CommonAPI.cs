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

using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Collections;
using System.Reflection;
using System.Linq.Expressions;
using System.Drawing;

namespace IDR.Frm.API
{
    class CommonAPI
    {
        //attr
        public bool _isSortAscending { get; set; }
        public DataGridViewColumn _sortColumn { get; set; }


        public int _intnext { get; set; }

        Default _frmDefault;

        public CommonAPI() { initPara(); }

        public CommonAPI(Default frmDefault)
        {
            _frmDefault = frmDefault;
            initPara();
        }

        private void initPara()
        {
            _isSortAscending = false;
            _intnext = 0;
        }
        #region base function

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
        #endregion
        #region gen carton id

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

            parameters[10].Value = plr_mstr_model.plr_cre_userid;

            //parameters[11].Value = plr_mstr_model.plr_partno;

            parameters[11].Value = _frmDefault._clientIP;
            parameters[12].Direction = ParameterDirection.Output;

            var strsql = "[dbo].[sp_GenCtn_Tran] @Batch_ID,@LineID,@plr_doc_type,@CartonID,@CartonType,@plr_po,@plr_qty,@ctnPre,@ctnFr,@ctnTo,@plr_cre_userid,@plr_user_ip,@result OUTPUT";
            _frmDefault._dbpie.Database.SqlQuery<object>(strsql, parameters).SingleOrDefault();

            result = Convert.ToInt16(parameters[12].Value);
            return result;
        }
        #endregion
        #region select data function
        /// <summary>
        /// 获取对应的字段名
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="keySelector"></param>
        /// <returns></returns>
        public static string GetMemberName<TSource, TKey>(Expression<Func<TSource, TKey>> keySelector)
        {
            string fieldName = null;
            var exp = keySelector.Body as UnaryExpression;
            if (exp == null)
            {
                var body = keySelector.Body as MemberExpression;
                fieldName = body.Member.Name;
            }
            else
            {
                fieldName = (exp.Operand as MemberExpression).Member.Name;
            }
            return fieldName;
        }

        public void genexprexsswhere(string getProperty, string rightConstant, string methodName)
        {
            IQueryable<plr_batch_mstr> plr_batch_mstr = _frmDefault._dbpie.plr_batch_mstr;
            //创建一个参数c
            ParameterExpression param =
                Expression.Parameter(typeof(plr_batch_mstr), "c");
            //c.City=="London"
            Expression left = Expression.Property(param,
            typeof(plr_batch_mstr).GetProperty(getProperty));//"City"
            Expression right = Expression.Constant(rightConstant);//"London"
            Expression filter = Expression.Equal(left, right);

            Expression pred = Expression.Lambda(filter, param);
            //Where(c=>c.City=="London")
            Expression expr = Expression.Call(typeof(Queryable), methodName,//"Where"
            new Type[] { typeof(plr_batch_mstr) },
                Expression.Constant(plr_batch_mstr), pred);
            //生成动态查询
            IQueryable<plr_batch_mstr> query = _frmDefault._dbpie.plr_batch_mstr.AsQueryable()
                .Provider.CreateQuery<plr_batch_mstr>(expr);
        }

        public static Expression<Func<plr_batch_mstr, plr_batch_mstr_ext>> select_plr_batch_mstr_ext()
        {
            return p => new plr_batch_mstr_ext
            {
                batch_id = p.batch_id,
                batch_doc = p.batch_doc,
                batch_status = p.batch_status,
                batch_dec01 = p.batch_dec01,
                batch_chr01 = p.batch_chr01,
                batch_cre_date = p.batch_cre_date,
                batch_cre_user = p.batch_cre_user,
                batch_user_ip = p.batch_user_ip

            };
        }
        public static Expression<Func<plr_mstr, plr_mstr_ext>> select_plr_mstr_ext()
        {
            return p => new plr_mstr_ext
            {
                Batch_ID = p.Batch_ID,
                LineID = p.LineID,
                plr_status = p.plr_status,
                packingListID = p.packingListID,
                InvoiceID = p.InvoiceID,

                plr_pallet_no = p.plr_pallet_no,
                CartonType = p.CartonType,
                CartonID = p.CartonID,
                carton_id_prifix = p.carton_id_prifix,
                plr_po = p.plr_po,

                plr_co = p.plr_co,
                plr_partno = p.plr_partno,
                plr_date_code = p.plr_date_code,
                plr_vend_mfgr = p.plr_vend_mfgr,
                Plr_vm_partno = p.Plr_vm_partno,

                plr_carton_qty = p.plr_carton_qty,
                plr_qty = p.plr_qty,
                plr_suppliers_id = p.plr_suppliers_id,
                plr_rcp_date = p.plr_rcp_date,
                plr_deli_date = p.plr_deli_date,
                re_mark = p.re_mark,

                plr_doc_type = p.plr_doc_type,
                plr_cre_date = p.plr_cre_date,
                plr_update_date = p.plr_update_date,
                plr_cre_userid = p.plr_cre_userid,
                plr_user_ip = p.plr_user_ip

            };
        }
        public static Expression<Func<plr_mstr_tran, plr_mstr_tran_ext>> select_plr_mstr_tran_ext()
        {
            return p => new plr_mstr_tran_ext
            {
                Batch_ID = p.Batch_ID,
                LineID = p.LineID,
                plr_status = p.plr_status,

                plr_status_msg = p.plr_status_msg,
                plr_wec_ctn = p.plr_wec_ctn,

                plr_pallet_no = p.plr_pallet_no,
                CartonType = p.CartonType,
                CartonNo = p.CartonNo,
                CartonID = p.CartonID,
                carton_id_prifix = p.carton_id_prifix,
                plr_po = p.plr_po,

                plr_partno = p.plr_partno,
                plr_carton_qty = p.plr_carton_qty,
                plr_qty = p.plr_qty,

                plr_rcp_date = p.plr_rcp_date,
                plr_deli_date = p.plr_deli_date,
                re_mark = p.re_mark,

                plr_cre_date = p.plr_cre_date,
                plr_update_date = p.plr_update_date,
                plr_cre_userid = p.plr_cre_userid,
                plr_user_ip = p.plr_user_ip

            };
        }
        /// <summary>
        /// plr_batch_mstr
        /// </summary>
        /// <param name="_strBatchID"></param>
        /// <returns>List<object></returns>
        public IQueryable<plr_batch_mstr_ext> getSelectList_plr_batch_mstr(string _strBatchID)
        {
            return _frmDefault._dbpie.plr_batch_mstr.Where(m => m.batch_id.Equals(_strBatchID))
                    .Select(select_plr_batch_mstr_ext());
        }

        public IQueryable<plr_batch_mstr_ext> getSelectList_plr_batch_mstr(Expression<Func<plr_batch_mstr, bool>> lambdex)
        {
            return _frmDefault._dbpie.plr_batch_mstr.Where(lambdex)
                    .Select(select_plr_batch_mstr_ext());
        }
        /// <summary>
        /// plr_batch_mstr_ext top num
        /// </summary>
        /// <param name="_strBatchID"></param>
        /// <param name="topnum"></param>
        /// <returns></returns>
        public IQueryable<plr_batch_mstr_ext> getSelectList_plr_batch_mstr(Expression<Func<plr_batch_mstr, bool>> lambdex, int topnum)
        {
            return getSelectList_plr_batch_mstr(lambdex).Take(topnum);
        }

        /// <summary>
        /// plr_mstr
        /// </summary>
        /// <param name="_strBatchID"></param>
        /// <returns>List<object></returns>
        public IQueryable<plr_mstr_ext> getSelectList_plr_mstr(string _strBatchID)
        {
            return _frmDefault._dbpie.plr_mstr.Where(m => m.Batch_ID.Equals(_strBatchID))
                    .Select(select_plr_mstr_ext());
        }
        /// <summary>
        /// plr_mstr
        /// </summary>
        /// <param name="plr_mstr_list"></param>
        /// <returns>List<object></returns>
        public IQueryable<plr_mstr_ext> getSelectList_plr_mstr(IQueryable<plr_mstr> plr_mstr_list)
        {
            return plr_mstr_list
                    .Select(select_plr_mstr_ext());
        }

        /// <summary>
        /// getSelectList_plr_mstr_tran
        /// </summary>
        /// <param name="_strBatchID"></param>
        /// <returns></returns>
        public IQueryable<plr_mstr_tran_ext> getSelectList_plr_mstr_tran(string _strBatchID)
        {
            return _frmDefault._dbpie.plr_mstr_tran.Where(m => m.Batch_ID.Equals(_strBatchID))
                    .Select(select_plr_mstr_tran_ext());
        }

        //PI
        public IQueryable<pi_mstr> getSelectList_pi_mstr(Expression<Func<pi_mstr, bool>> lambdex)
        {
            return _frmDefault._dbpie.pi_mstr.Where(lambdex);
            //.Select(p => new pi_mstr
            //{


            //});
        }
        /// <summary>
        /// top num
        /// </summary>
        /// <param name="_strBatchID"></param>
        /// <param name="topnum"></param>
        /// <returns></returns>
        public IQueryable<pi_mstr> getSelectList_pi_mstr(Expression<Func<pi_mstr, bool>> lambdex, int topnum)
        {
            return getSelectList_pi_mstr(lambdex).Take(topnum);
        }
        public IQueryable<pi_det> getSelectList_pi_det(Expression<Func<pi_det, bool>> lambdex)
        {
            return _frmDefault._dbpie.pi_det.Where(lambdex);
            //.Select(p => new pi_mstr
            //{


            //});
        }


        #endregion
        #region init data gric view head text
        /// <summary>
        /// dgvAttritubeInit(dgv, 1, true);
        /// </summary>
        /// <param name="dgv">DataGridView</param>
        /// <param name="intFrozen">0--n</param>
        /// <param name="readOnly">readOnly</param>
        private static void dgvAttritubeInit(DataGridView dgv, int intFrozen, bool readOnly)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.AllowUserToOrderColumns = true;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv.MultiSelect = false;
            dgv.ReadOnly = readOnly;
            for (int i = 0; i <= intFrozen; i++)
            {
                dgv.Columns[i].Frozen = true;
            }


        }
        public void initHeaderText_plr_batch_mstr(DataGridView dgv)
        {
            if (dgv.Rows.Count < 0)
            {
                return;
            }
            dgvAttritubeInit(dgv, 1, true);

            dgv.Columns["Batch_ID"].HeaderText = "Batch ID";
            //dgv.Columns["plr_suppliers_id"].HeaderText = "Suppliers";
            dgv.Columns["batch_doc"].HeaderText = "Batch Type";
            dgv.Columns["batch_status"].HeaderText = "Void";//"Status";
            //dgv.Columns["batch_void"].HeaderText = "Void";

            dgv.Columns["batch_cre_date"].HeaderText = "Create Date";
            //dgv.Columns["batch_update_date"].HeaderText = "Update Date";
            dgv.Columns["batch_cre_user"].HeaderText = "User Id";
            //dgv.Columns["batch_chr01"].HeaderText = "other";
            dgv.Columns["batch_dec01"].HeaderText = "Items Count";
            dgv.Columns["batch_chr01"].HeaderText = "PI Status";
            dgv.Columns["batch_user_ip"].HeaderText = "Create IP";

        }
        public void initHeaderText_plr_mstr(DataGridView dgv)
        {
            if (dgv.Rows.Count < 0)
            {
                return;
            }
            dgvAttritubeInit(dgv, 1, true);

            dgv.Columns["Batch_ID"].HeaderText = "Batch ID";
            dgv.Columns["LineID"].HeaderText = "LineID";
            dgv.Columns["plr_status"].HeaderText = "Void";
            dgv.Columns["packingListID"].HeaderText = "PackingListID";
            dgv.Columns["InvoiceID"].HeaderText = "Invoice ID";

            dgv.Columns["plr_pallet_no"].HeaderText = "Pallet No";
            dgv.Columns["CartonType"].HeaderText = "Remainder";
            dgv.Columns["CartonID"].HeaderText = "Carton ID";
            dgv.Columns["carton_id_prifix"].HeaderText = "Carton Prefix";
            dgv.Columns["plr_po"].HeaderText = "PO#";

            dgv.Columns["plr_co"].HeaderText = "CO";
            dgv.Columns["plr_partno"].HeaderText = "Part";
            dgv.Columns["plr_date_code"].HeaderText = "Date Code";
            dgv.Columns["plr_vend_mfgr"].HeaderText = "MFGR";
            dgv.Columns["Plr_vm_partno"].HeaderText = "MFGR-Part";



            dgv.Columns["plr_carton_qty"].HeaderText = "Qty/Carton";
            dgv.Columns["plr_qty"].HeaderText = "Total/Qty";
            dgv.Columns["plr_suppliers_id"].HeaderText = "Suppliers";
            dgv.Columns["plr_rcp_date"].HeaderText = "Rcp Date";
            dgv.Columns["plr_deli_date"].HeaderText = "Deli Date";

            dgv.Columns["re_mark"].HeaderText = "Remark";

            dgv.Columns["plr_doc_type"].HeaderText = "Batch Type";
            dgv.Columns["plr_cre_date"].HeaderText = "Create Date";
            dgv.Columns["plr_update_date"].HeaderText = "Update Date";
            dgv.Columns["plr_cre_userid"].HeaderText = "User Id";
            dgv.Columns["plr_user_ip"].HeaderText = "Client IP";

            ///no use
            //dgv.Columns["carton_id_from"].HeaderText = "Carton No From";
            //dgv.Columns["carton_id_to"].HeaderText = "To";

            //dgv.Columns["plr_site"].HeaderText = "MG";
            //dgv.Columns["plr_ttl"].HeaderText = "Total";

            //dgv.Columns["plr_um"].HeaderText = "UM";
            //dgv.Columns["plr_nw"].HeaderText = "Net-Wt (KG)";
            //dgv.Columns["plr_gw"].HeaderText = "Gross-Wt (KG)";
            //dgv.Columns["plr_msm"].HeaderText = "Measurement";
            //dgv.Columns["re_mark"].HeaderText = "Remark";

            //other set
            dgv.Columns["Batch_ID"].ReadOnly = true;
            dgv.Columns["LineID"].ReadOnly = true;
            dgv.Columns["plr_status"].ReadOnly = true;

            //dgv.Columns["LineID"].Width = 25;
            //dgv.Columns["plr_status"].Width = 50;
            //dgv.Columns["plr_pallet_no"].Width = 50;

            dgv.Columns["plr_rcp_date"].ValueType = Type.GetType("System.DateTime");
            dgv.Columns["plr_deli_date"].ValueType = Type.GetType("System.DateTime");
        }
        public void initHeaderText_plr_mstr_tran(DataGridView dgv)
        {
            if (dgv.Rows.Count < 0)
            {
                return;
            }
            dgvAttritubeInit(dgv, 1, true);

            dgv.Columns["Batch_ID"].HeaderText = "Batch ID";
            dgv.Columns["LineID"].HeaderText = "Line";
            dgv.Columns["plr_status"].HeaderText = "Status";
            dgv.Columns["plr_status_msg"].HeaderText = "Msg";
            dgv.Columns["plr_wec_ctn"].HeaderText = "WEC CTN";

            dgv.Columns["plr_pallet_no"].HeaderText = "Pallet No";
            dgv.Columns["CartonType"].HeaderText = "Remainder";
            dgv.Columns["CartonID"].HeaderText = "Carton ID";
            dgv.Columns["carton_id_prifix"].HeaderText = "Carton Prefix";
            dgv.Columns["plr_po"].HeaderText = "PO#";

            dgv.Columns["plr_partno"].HeaderText = "Part";
            dgv.Columns["plr_qty"].HeaderText = "Total/QTY";
            dgv.Columns["plr_carton_qty"].HeaderText = "Qty/Carton";


            dgv.Columns["plr_rcp_date"].HeaderText = "Rcp Date";
            dgv.Columns["plr_deli_date"].HeaderText = "Deli Date";
            dgv.Columns["re_mark"].HeaderText = "Remark";

            dgv.Columns["plr_cre_date"].HeaderText = "Create Date";
            dgv.Columns["plr_update_date"].HeaderText = "Update Date";
            dgv.Columns["plr_cre_userid"].HeaderText = "User Id";
            dgv.Columns["plr_user_ip"].HeaderText = "Client IP";

            //dgv.Columns["Wec_Ctn"].HeaderText = "WEC Ctn ID";
            //dgv.Columns["plr_suppliers_id"].HeaderText = "Suppliers ID";
            //dgv.Columns["Plr_vm_partno"].HeaderText = "MFGR-Part";
            //dgv.Columns["InvoiceID"].HeaderText = "Invoice ID";
            //dgv.Columns["packingListID"].HeaderText = "PackingListID";

            //dgv.Columns["LineID"].Width = 25;
            //dgv.Columns["plr_status"].Width = 50;
            //dgv.Columns["plr_pallet_no"].Width = 50;
        }


        public void initHeaderTextPIMstr(DataGridView dgv)
        {
            if (dgv.Rows.Count < 0)
            {
                return;
            }
            dgv.BorderStyle = BorderStyle.None;
            dgv.ReadOnly = true;
            dgv.Columns[0].Frozen = true;
            dgv.Columns[1].Frozen = true;

            dgv.Columns["PI_ID"].HeaderText = "PI ID";
            dgv.Columns["Plant"].HeaderText = "Plant";

            dgv.Columns["pi_type"].HeaderText = "Type";

            dgv.Columns["pi_remark"].HeaderText = "Remark";

            dgv.Columns["pi_cre_date"].HeaderText = "Create Date";
            dgv.Columns["pi_update_date"].HeaderText = "Update Date";
            //dgv.Columns["pi_cre_userid"].HeaderText = "User Id";
            //dgv.Columns["pi_user_ip"].HeaderText = "Client IP";
        }
        public void initHeaderTextPIMstrForEquire(DataGridView dgv)
        {
            if (dgv.Rows.Count < 0)
            {
                return;
            }

            dgv.BorderStyle = BorderStyle.None;
            //PI_ID,pi_status,Plant,pi_type,pi_user_ip,pi_remark,pi_cre_date,pi_chr01
            dgv.ReadOnly = true;
            dgv.Columns[0].Frozen = true;
            dgv.Columns[1].Frozen = true;

            dgv.Columns["PI_ID"].HeaderText = "PI ID";
            dgv.Columns["pi_status"].HeaderText = "Upload Status";

            dgv.Columns["Plant"].HeaderText = "Plant";

            dgv.Columns["pi_type"].HeaderText = "Type";
            dgv.Columns["pi_user_ip"].HeaderText = "Client IP";

            dgv.Columns["pi_remark"].HeaderText = "Remark";

            dgv.Columns["pi_cre_date"].HeaderText = "Create Date";
            //dgv.Columns["pi_update_date"].HeaderText = "Update Date";
            //dgv.Columns["pi_cre_userid"].HeaderText = "User Id";
            dgv.Columns["pi_chr01"].HeaderText = "from BatchID";
        }
        public void initHeaderTextPIDet(DataGridView dgv)
        {
            if (dgv.Rows.Count < 0)
            {
                return;
            }
            dgv.ReadOnly = true;
            dgv.BorderStyle = BorderStyle.None;
            dgv.Columns[0].Frozen = true;
            dgv.Columns[1].Frozen = true;
            dgv.Columns["PI_ID"].HeaderText = "PI ID";
            dgv.Columns["pi_LineID"].HeaderText = "Line";

            dgv.Columns["pi_wec_ctn"].HeaderText = "Scan SN";

            dgv.Columns["pi_pallet_no"].HeaderText = "Pallet";
            dgv.Columns["CartonNo"].HeaderText = "CartonNo";

            dgv.Columns["CartonID"].HeaderText = "CartonID";


        }
        public void initHeaderTextPIDetGrr(DataGridView dgv)
        {
            if (dgv.Rows.Count < 0)
            {
                return;
            }
            dgv.BorderStyle = BorderStyle.None;
            dgv.ReadOnly = true;
            dgv.Columns[0].Frozen = true;
            dgv.Columns[1].Frozen = true;
            dgv.Columns[2].Frozen = true;
            dgv.Columns["PI_ID"].HeaderText = "PI ID";
            dgv.Columns["pi_LineID"].HeaderText = "Line";

            dgv.Columns["pi_wec_ctn"].HeaderText = "Scan SN";

            dgv.Columns["pi_pallet_no"].HeaderText = "Pallet";
            dgv.Columns["plr_LineID_tran"].HeaderText = "Scan Line";

            dgv.Columns["CartonNo"].HeaderText = "CartonNo";

            dgv.Columns["CartonID"].HeaderText = "CartonID";

            dgv.Columns["pi_chr01"].HeaderText = "CO";

            dgv.Columns["pisr_rir"].HeaderText = "RIR #";
            dgv.Columns["pisr_invoice"].HeaderText = "Invoice";
            dgv.Columns["pisr_part"].HeaderText = "WEC-Part";
            dgv.Columns["Pisr_receiver"].HeaderText = "Receiver";
            dgv.Columns["pisr_site"].HeaderText = "MG";
            dgv.Columns["pisr_po_nbr"].HeaderText = "PO-Number";
            dgv.Columns["pisr_qty"].HeaderText = "Qty";
            dgv.Columns["pisr_curr"].HeaderText = "Curr";
            dgv.Columns["pisr_cost"].HeaderText = "U/P";
            dgv.Columns["pisr_base_cost"].HeaderText = "U/P(Base)";
            dgv.Columns["pisr_us_cost"].HeaderText = "U/P(USD)";
            dgv.Columns["pisr_seq"].HeaderText = "Seq";

            dgv.Columns["pisr_con_code"].HeaderText = "Custom Conn";

            //dgv.Columns["pisr_ch_desc"].HeaderText = "Description";
            dgv.Columns["pi_status"].HeaderText = "Upload Status";
            dgv.Columns["sq_name"].HeaderText = "Description";

            dgv.Columns["pisr_net_wt"].HeaderText = "Net Weight";
            dgv.Columns["pisr_rec_type"].HeaderText = "STS/IQC/SI";
            dgv.Columns["pisr_abc"].HeaderText = "ABC";
            dgv.Columns["pisr_code"].HeaderText = "商检";
            //
            dgv.Columns["pisr_lic_req"].HeaderText = "Lic. Req";

            dgv.Columns["pisr_sbu"].HeaderText = "SBU";
            dgv.Columns["pisr_vend"].HeaderText = "Vend";
            //dgv.Columns["mfgr_name"].HeaderText = "MFGR Name";

            //dgv.Columns["pisr_char01"].HeaderText = "MFGR";
            //dgv.Columns["pisr_char02"].HeaderText = "Vend Name";

            dgv.Columns["pi_cre_date"].HeaderText = "Create Date";
            dgv.Columns["pisr_dec01"].HeaderText = "k200 NW";
            dgv.Columns["pisr_dec02"].HeaderText = "NW";


        }
        #endregion
        #region gen LambdaExpression
        public LambdaExpression orderby_LambdaExpression<T>(string propertyName) where T : class
        {
            Type type = typeof(T);

            PropertyInfo property = type.GetProperty(propertyName);
            if (property == null)
                throw new ArgumentException("propertyName", "Not Exist");

            ParameterExpression param = Expression.Parameter(type, "p");
            Expression propertyAccessExpression = Expression.MakeMemberAccess(param, property);
            LambdaExpression orderByExpression = Expression.Lambda(propertyAccessExpression, param);

            return orderByExpression;

        }

        public IQueryable<T> Sort<T>(IQueryable<T> q, string SortField, string SortDirection)
            where T : class
        {
            return SortBy(q, SortField + " " + SortDirection);
        }
        #endregion
        internal void OpenFolderAndSelectFile(string pathname)
        {
            throw new NotImplementedException();
        }
        ///////
        #region datagridview sort

        public IQueryable<T> SortBy<T>(IQueryable<T> source, string sortExpression)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            string sortDirection = String.Empty;
            string propertyName = String.Empty;

            sortExpression = sortExpression.Trim();
            int spaceIndex = sortExpression.Trim().IndexOf(" ");
            if (spaceIndex < 0)
            {
                propertyName = sortExpression;
                sortDirection = "ASC";
            }
            else
            {
                propertyName = sortExpression.Substring(0, spaceIndex);
                sortDirection = sortExpression.Substring(spaceIndex + 1).Trim();
            }

            if (String.IsNullOrEmpty(propertyName))
            {
                return source;
            }

            ParameterExpression parameter = Expression.Parameter(source.ElementType, String.Empty);
            MemberExpression property = Expression.Property(parameter, propertyName);
            LambdaExpression lambda = Expression.Lambda(property, parameter);

            string methodName = (sortDirection == "ASC") ? "OrderBy" : "OrderByDescending";

            Expression methodCallExpression = Expression.Call(typeof(Queryable), methodName,
                                                new Type[] { source.ElementType, property.Type },
                                                source.Expression, Expression.Quote(lambda));

            return source.Provider.CreateQuery<T>(methodCallExpression);
        }

        public void DGV_ColumnHeaderMouseClick<T>(object sender, DataGridViewCellMouseEventArgs e, DataGridView dgv, IQueryable<T> iQuery)
            where T : class
        {
            if (iQuery.Count() < 0)
            {
                return;
            }
            DataGridViewColumn column = dgv.Columns[e.ColumnIndex];

            _isSortAscending = (_sortColumn == null || _isSortAscending == false);

            string direction = _isSortAscending ? "ASC" : "DESC";

            dgv.DataSource = Sort<T>(iQuery, column.DataPropertyName, direction).ToList();

            dgv.Refresh();

            if (_sortColumn != null) dgv.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = System.Windows.Forms.SortOrder.None;
            dgv.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = _isSortAscending ? System.Windows.Forms.SortOrder.Ascending : System.Windows.Forms.SortOrder.Descending;

            _sortColumn = column;
        }

        #endregion


        #region datagridview cell click
        /// <summary>
        /// cell click
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="colName"></param>
        /// <param name="colValue"></param>
        public void selectNextDGVRow(DataGridView dgv, string colName, string colValue)
        {
            for (int i = 0; i < dgv.RowCount; i++)// - 1
            {
                if (dgv.Rows[i].Cells[colName].Value.ToString().Equals(colValue))
                {
                    dgv.Rows[i].Cells[0].Selected = true;
                    break;
                }
            }
        }
        /// <summary>
        /// cell click normal
        /// </summary>
        /// <param name="dwo"></param>
        /// <returns></returns>
        public string dgv_cellClick(DoWorkObject dwo)
        {
            //- 1
            _frmDefault.status14toolLabelCellRowColXY.Text = "总计:" + (dwo._dgv.Rows.Count) + ",当前行:" + (dwo._eX + 1) + ",列:" + (dwo._eY + 1);
            //_idr_show.status13toolSStatusLblMsg.Text = "";
            _frmDefault.status15toolLabelstrResult.Text = "";
            try
            {
                if (dwo._eX >= 0 && dwo._eX < dwo._dgv.RowCount)// - 1
                {
                    string str_ID = dwo._dgv.Rows[dwo._eX].Cells[dwo._strCellColName].Value.ToString().Trim();
                    _frmDefault.status14toolLabelCellRowColXY.Text += "," + str_ID;
                    if (dwo._strCellColName.Equals("Batch_ID"))
                    {
                        _frmDefault.Batch_ID = str_ID;
                    }
                    else if (dwo._strCellColName.Equals("PI_ID"))
                    {
                        _frmDefault.PI_ID = str_ID;
                    }

                    return str_ID;
                }
                return "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }

        }
        /// <summary>
        /// cell click main-item
        /// </summary>
        /// <param name="dwo"></param>
        /// <param name="mainDataGV"></param>
        public void dgv_cellClick(DoWorkObject dwo, bool mainDataGV)
        {


            _frmDefault.status14toolLabelCellRowColXY.Text = "总计:" + (dwo._dgv.Rows.Count) + ",当前行:" + (dwo._eX + 1) + ",列:" + (dwo._eY + 1);
            try
            {
                if (dwo._eX >= 0 && dwo._eX < dwo._dgv.RowCount) //- 1
                {
                    _frmDefault._plr_mstr_model.Batch_ID = dwo._dgv.Rows[dwo._eX].Cells["Batch_ID"].Value.ToString().Trim();

                    _frmDefault._plr_mstr_model.LineID = Convert.ToInt32(dwo._dgv.Rows[dwo._eX].Cells["LineID"].Value);
                    _frmDefault._plr_mstr_model.CartonID = dwo._dgv.Rows[dwo._eX].Cells["CartonID"].Value.ToString().Trim();

                    selectNextDGVRow(dwo._dgv1, "LineID", _frmDefault._plr_mstr_model.LineID.ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// row enter
        /// </summary>
        /// <param name="dwko"></param>
        public void dgv_rowEnter(object dwko)
        {
            _frmDefault.Invoke(new Action(delegate()
            {
                _frmDefault._sameColumnCount = 0;
                _frmDefault._sameColumnNameCount = 0;

                _frmDefault.status16toolLabelstrSameColumnCount.Text = "";
                DoWorkObject dwo = (DoWorkObject)dwko;
                int mcount = 0;
                int minValue = 0;
                int maxValue = 0;
                int minresult = 0;
                int maxreuslt = 0;

                if (dwo._eX >= 0 && dwo._eX < dwo._dgv.RowCount)// - 1
                {
                    var cartonidenter = dwo._dgv.Rows[dwo._eX].Cells[dwo._sameColumnName].Value;

                    if (!string.IsNullOrEmpty(dwo._selectColumnNameValue))
                    {
                        _frmDefault._selectColumnNameValue = dwo._dgv.Rows[dwo._eX].Cells[dwo._selectColumnNameValue].Value.ToString();
                        if (dwo._FrmForRefeHas)
                        {

                            dwo._FrmForRefe.lbl2SelectValue.Text = dwo._dgv.Rows[dwo._eX].Cells[dwo._selectColumnNameValue].Value.ToString();
                            dwo._FrmForRefe.lbl1SelectNotice.Text = dwo._FrmForRefeLblMsg + dwo._FrmForRefe.lbl2SelectValue.Text;


                        }
                    }
                    //dgv.Rows[dgv.CurrentRow.Index].Cells[selectedindex].Selected = true;

                    //m
                    for (int i = 0; i < dwo._dgv.RowCount; i++)// - 1
                    {
                        if (!string.IsNullOrEmpty(dwo._sameColumnNameCount))
                        {
                            if (dwo._dgv.Rows[i].Cells[dwo._sameColumnNameCount].Value.ToString().Equals(dwo._sameColumnNameCountValut))
                            {
                                _frmDefault._sameColumnCount++;
                            }
                        }


                        if (dwo._dgv.Rows[i].DefaultCellStyle.BackColor != Color.White)
                        {
                            dwo._dgv.Rows[i].DefaultCellStyle.BackColor = Color.White;
                            if (dwo._dgv.Rows[i].Cells[dwo._deffCellName].Value.ToString().Equals(dwo._deffCellValue))
                            {
                                dwo._dgv.Rows[i].Cells[dwo._deffCellName].Style.BackColor = dwo._deffcolors;
                            }

                        }
                        var cartonid = dwo._dgv.Rows[i].Cells[dwo._sameColumnName].Value;
                        if (cartonid != DBNull.Value)
                        {
                            if (cartonid.ToString() == cartonidenter.ToString())
                            {
                                _frmDefault._sameColumnNameCount++;
                                mcount++;
                                dwo._dgv.Rows[i].DefaultCellStyle.BackColor = dwo._colors;

                                if (dwo._dgv.Rows[i].Cells[dwo._deffCellName].Value.ToString().Equals(dwo._deffCellValue))
                                {
                                    dwo._dgv.Rows[i].Cells[dwo._deffCellName].Style.BackColor = dwo._deffcolors;
                                }
                                if (!string.IsNullOrEmpty(dwo._compMaxMin))
                                {
                                    if (mcount == 1)
                                    {
                                        minValue = (int)dwo._dgv.Rows[i].Cells[dwo._compMaxMin].Value;
                                        maxValue = minValue;
                                    }
                                    else
                                    {
                                        minresult = (int)dwo._dgv.Rows[i].Cells[dwo._compMaxMin].Value;
                                        maxreuslt = minresult;
                                        if (minresult < minValue)
                                        {
                                            minValue = minresult;
                                        }
                                        if (maxreuslt > maxValue)
                                        {
                                            maxValue = maxreuslt;
                                        }
                                    }
                                }

                            }
                        }
                    }
                    _frmDefault._intFrom = minValue;
                    _frmDefault._intTo = maxValue;

                    if (!string.IsNullOrEmpty(dwo._sameColumnNameCount))
                    {
                        _frmDefault.status16toolLabelstrSameColumnCount.Text = dwo._sameColumnNameCountHeaderText + " : " + dwo._sameColumnNameCountValut + " has " + _frmDefault._sameColumnCount.ToString() + " items";
                    }
                    if (string.IsNullOrEmpty(_frmDefault.status16toolLabelstrSameColumnCount.Text))
                    {
                        _frmDefault.status16toolLabelstrSameColumnCount.Text = " Same Rows:" + _frmDefault._sameColumnNameCount;
                    }
                    else
                    {
                        _frmDefault.status16toolLabelstrSameColumnCount.Text += ", Same Rows:" + _frmDefault._sameColumnNameCount;
                    }

                }
            }));
        }
        public void dgv_rowEnter_ThreadPool(object dwko)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(dgv_rowEnter), dwko);
        }
        #endregion

        /// <summary>
        /// EnquireByPart
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="cellsHeader"></param>
        /// <param name="strcontains"></param>
        public void EnquireByPart(DataGridView dgv, string cellsHeader, string strcontains)
        {
            _frmDefault.Invoke(new Action(delegate()
            {
                int rowcount = dgv.Rows.Count;

                if (rowcount > 0)
                {
                    for (int i = _intnext; i < rowcount - 1; i++)
                    {
                        if (dgv.Rows[i].Cells[cellsHeader].Value.ToString().ToLower().Contains(strcontains.ToLower()))
                        {

                            dgv.Rows[i].Cells[cellsHeader].Selected = true;

                            _intnext = i + 1;
                            if (_intnext >= rowcount - 1)
                            {
                                _intnext = 0;
                            }
                            break;
                        }
                        if (i >= rowcount - 2)
                        {
                            _intnext = 0;
                            dgv.ClearSelection();
                        }
                    }
                }
            }));


        }

        public string EnquireByHeadText(DataGridView dgv, string headerText, string strcontains)
        {
            var tmpStartnext = _intnext;
            var _columnIndex = 2;
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                if (dgv.Columns[i].HeaderText.Equals(headerText))
                {
                    _columnIndex = i;
                    break;
                }
            }
            int rowcount = dgv.Rows.Count;
            if (rowcount > 0)
            {
                for (int i = _intnext; i < rowcount - 1; i++)
                {
                    if (dgv.Rows[i].Cells[_columnIndex].Value.ToString().ToLower().Contains(strcontains.ToLower()))
                    {

                        dgv.Rows[i].Cells[_columnIndex].Selected = true;

                        _intnext = i + 1;
                        if (_intnext >= rowcount - 1)
                        {
                            _intnext = 0;
                        }

                        return "success: find in [" + headerText + "] with " + strcontains + " at " + _intnext + " Row," + " start " + tmpStartnext;
                        break;
                    }
                    if (i >= rowcount - 2)
                    {
                        _intnext = 0;
                        dgv.ClearSelection();
                    }
                }
                return "Error: No find in [" + headerText + "] with " + strcontains + " start " + tmpStartnext;
            }
            return "No Data";


        }
        //////////////////////////////////add new
    }

}
