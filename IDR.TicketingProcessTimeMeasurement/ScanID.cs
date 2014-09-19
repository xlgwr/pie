using PIE.DBUtility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IDR.TicketingProcessTimeMeasurement
{
    public partial class ScanID : Form
    {
        frmticketingPTMR _frmticketingPTMR;
        int _intDoType = 0;
        string _strScanSN = "";
        public ScanID(frmticketingPTMR frm_ticketingPTMR, int intDoType)
        {
            _frmticketingPTMR = frm_ticketingPTMR;
            _intDoType = intDoType;
            InitializeComponent();
            textBox1.Focus();
            this.AcceptButton = button1;
        }

        private void ScanID_Load(object sender, EventArgs e)
        {
            switch (_intDoType)
            {
                case 1:
                    lblHead.Text = "入单时间扫描(新记录)";
                    this.Text = "入单时间扫描(新记录)";
                    break;
                case 2:
                    lblHead.Text = "返回时间扫描";
                    this.Text = "返回时间扫描";
                    break;
                case 3:
                    lblHead.Text = "收货时间扫描";
                    this.Text = "收货时间扫描";
                    break;
                case 4:
                    lblHead.Text = "离开时间扫描";
                    this.Text = "离开时间扫描";
                    break;
                default:
                    lblHead.Text = "供应商出入交货时间登记";
                    this.Text = "供应商出入交货时间登记";
                    break;
            }
        }

        private void ScanID_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            _frmticketingPTMR.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text.Trim()))
            {
                lblMsg.Text = "Scan SN is Null.";
                textBox1.Focus();
                return;
            }
            _strScanSN = textBox1.Text.Trim().ToUpper();

            var isUseSupperID = new PIE.DAL.ticketingPTMR_ext().GetModel(_strScanSN);
            switch (_intDoType)
            {
                case 1:
                    #region in
                    if (isUseSupperID == null)
                    {
                        PIE.Model.ticketingPTMR tickptmr = new PIE.Model.ticketingPTMR();
                        tickptmr.t_id = newTid();
                        if (tickptmr.t_id == null)
                        {
                            return;
                        }
                        tickptmr.t_suppliers_id = _strScanSN;
                        tickptmr.t_inDocTime = DbHelperSQL.getServerGetDate();
                        tickptmr.t_cre_date = tickptmr.t_inDocTime;
                        tickptmr.t_update_date = tickptmr.t_inDocTime;
                        tickptmr.t_int01 = 1;
                        tickptmr.t_user_ip = _frmticketingPTMR._clientIP;

                        var savetick = new PIE.BLL.ticketingPTMR().Add(tickptmr);
                        if (savetick)
                        {
                            initDataGV();
                            MessageBox.Show("登记成功。");

                        }
                    }
                    else
                    {
                        MessageBox.Show(textBox1.Text + " 已经登记，时间为：" + isUseSupperID.t_inDocTime.ToString());
                        initDataGV();
                    }
                    break;
                    #endregion

                case 2:
                    #region back2
                    if (isUseSupperID != null)
                    {
                        if (!string.IsNullOrWhiteSpace(isUseSupperID.t_backTime.ToString()))
                        {

                            MessageBox.Show("早已登记。时间为：" + isUseSupperID.t_backTime.ToString());
                            initDataGV();
                            break;
                        }
                        isUseSupperID.t_backTime = DbHelperSQL.getServerGetDate();
                        var updatetid = new PIE.BLL.ticketingPTMR().Update(isUseSupperID);
                        if (updatetid)
                        {
                            MessageBox.Show("登记时间成功。");
                            initDataGV();
                        }
                    }
                    else
                    {
                        MessageBox.Show(textBox1.Text + " 未登记,请进入功能【入单】进行登记，谢谢。");
                    }
                    break;

                    #endregion
                case 3:
                    #region Rece3
                    if (isUseSupperID != null)
                    {
                        if (!string.IsNullOrWhiteSpace(isUseSupperID.t_receTime.ToString()))
                        {

                            MessageBox.Show("早已登记。时间为：" + isUseSupperID.t_receTime.ToString());
                            initDataGV();
                            break;
                        }
                        isUseSupperID.t_receTime = DbHelperSQL.getServerGetDate();
                        var updatetid = new PIE.BLL.ticketingPTMR().Update(isUseSupperID);
                        if (updatetid)
                        {
                            MessageBox.Show("登记时间成功。");
                            initDataGV();
                        }
                    }
                    else
                    {
                        MessageBox.Show(textBox1.Text + " 未登记,请进入功能【入单】进行登记，谢谢。");
                    }
                    #endregion
                    break;
                case 4:
                    #region leave4
                    if (isUseSupperID != null)
                    {
                        if (!string.IsNullOrWhiteSpace(isUseSupperID.t_outAwayTime.ToString()))
                        {

                            MessageBox.Show("早已登记。时间为：" + isUseSupperID.t_outAwayTime.ToString());
                            initDataGV(isUseSupperID);
                            break;
                        }
                        isUseSupperID.t_outAwayTime = DbHelperSQL.getServerGetDate();
                        isUseSupperID.t_int01 = 4;
                        isUseSupperID.t_cre_user = _frmticketingPTMR._clientIP;

                        var updatetid = new PIE.BLL.ticketingPTMR().Update(isUseSupperID);
                        if (updatetid)
                        {
                            MessageBox.Show("登记时间成功。");
                            initDataGV(isUseSupperID);
                        }
                    }
                    else
                    {
                        MessageBox.Show(textBox1.Text + " 未登记,请进入功能【入单】进行登记，谢谢。");
                    }
                    #endregion
                    break;
                default:
                    break;
            }

        }

        private void initDataGV()
        {
            string strwhere = "t_suppliers_id='" + _strScanSN + "' and t_int01 = 1";
            DataSet ds = new PIE.DAL.ticketingPTMR_ext().GetList(strwhere);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

            dataGridView1.Refresh();
        }
        private void initDataGV(PIE.Model.ticketingPTMR tick)
        {
            string strwhere = "t_suppliers_id='" + tick.t_suppliers_id + "' and t_id = '" + tick.t_id + "' ";
            DataSet ds = new PIE.DAL.ticketingPTMR_ext().GetList(strwhere);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

            dataGridView1.Refresh();
        }
        public string newTid()
        {
            string strTID = "";
            int intOutAffected;
            SqlParameter[] parameters = {
                                            new SqlParameter("@TID",SqlDbType.NVarChar,11)
                                        };
            parameters[0].Direction = ParameterDirection.Output;

            DbHelperSQL.RunProcedure("sp_GetTID", parameters, out intOutAffected);
            strTID = parameters[0].Value != null ? parameters[0].Value.ToString() : "";

            if (string.IsNullOrEmpty(strTID))
            {
                MessageBox.Show("生成新记录,出错，请重新尝试。", "Error");
                return null;
            }
            return strTID;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            _frmticketingPTMR.Show();
        }
    }
}
