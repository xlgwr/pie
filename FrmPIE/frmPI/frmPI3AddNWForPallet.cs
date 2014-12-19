using FrmIDR._0API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using PIE.Model;
using PIE.DBUtility;
using PIE.DAL;
using PIE.BLL;
using PIE.Common;
using PI.Model;
using PI.DAL;
using PI.BLL;
using System.Threading;

namespace FrmPIE.frmPI
{
    public partial class frmPI3AddNWForPallet : Form
    {
        frmIDR _idr_show;
        Commfunction cf;
        frmEnterTxt _frmET;
        DataSet _reobjdet;


        frmEnterForReference _FrmForRefe;
        public string _strCellColName;
        public string _sameColumnName;
        public string _deffCellName;
        public string _deffCellValue;
        public bool _selectFlag;


        public string _clickCellname = "pi_pallet_no";

        public frmPI3AddNWForPallet(frmIDR idr)
        {
            _idr_show = idr;
            _idr_show.tabCtlRight1.SelectedTab.Layout += SelectedTab_Layout;

            cf = new Commfunction(idr);
            InitializeComponent();

            initWidth();
            data1GV1_PIPalletList.ReadOnly = true;
            data1GV1_PIPalletList.BorderStyle = BorderStyle.None;
            btn00More.Click += btn00More0_Click;



        }

        void btn00More0_Click(object sender, EventArgs e)
        {
            _FrmForRefe = new frmEnterForReference(_idr_show, this);

            _FrmForRefe.textBox1.Text = txt4PIID_search.Text;
            _FrmForRefe.textBox1.Focus();
            _FrmForRefe.lbl1SelectNotice.Text = "";
            _FrmForRefe.lbl2SelectValue.Text = "";
            //
            _FrmForRefe.data0GVForReference.RowEnter += data0GVForReference_RowEnter;
            _FrmForRefe.data0GVForReference.CellClick += data0GVForReference_Click;
            //
            _FrmForRefe.button1.Click += enquireByForReferenct;
            _FrmForRefe.data0GVForReference.CellDoubleClick += button1_DoubleClick;
            _FrmForRefe.btn2OK.Click += button1_DoubleClick;
            //
            _FrmForRefe.chkTop50.CheckedChanged += chkTop50_CheckedChanged;
            //
            _FrmForRefe.gb0ForReference.Text = "Enquire Result";
            //
            initSelectCondition();
            //
            init_FrmForRefeDGV("");

            _FrmForRefe.ShowDialog();
        }
        void chkTop50_CheckedChanged(object sender, EventArgs e)
        {

            _FrmForRefe.lbl1SelectNotice.Text = "";
            _FrmForRefe.lbl2SelectValue.Text = "";
            if (_FrmForRefe.chkTop50.Checked)
            {
                //
                initSelectCondition();
                //
                init_FrmForRefeDGV("");
            }
            else
            {
                enquireByForReferenct(sender, e);
            }
        }
        private void initSelectCondition()
        {
            _FrmForRefe.lblTitle.Text = "PI ID# OR IP:";
            _FrmForRefe.Text = "Enquire by PI ID";
            //
            _strCellColName = "PI_ID";
            _sameColumnName = "pi_user_ip";
            _clickCellname = "CartonID";
            _deffCellName = "pi_status";
            _deffCellValue = "Yes";

        }
        private void init_FrmForRefeDGV(string strwhere)
        {
            strwhere = _strCellColName + @" like '%" + strwhere + @"%' or " + _sameColumnName + @" like '%" + strwhere + @"%'";
            if (_strCellColName.Equals("batch_id"))
            {
                var batch_ds = new PIE.DAL.plr_batch_mstr_ext().GetList(50, strwhere, "batch_id desc", true);
                _FrmForRefe.data0GVForReference.DataSource = batch_ds.Tables[0].DefaultView;
                cf.initHeaderTextPlrBatchMstr1(_FrmForRefe.data0GVForReference);
            }
            else if (_strCellColName.Equals("PI_ID"))
            {
                var batch_ds = new PI.DAL.pi_mstr_ext().GetList(50, strwhere, "PI_ID desc", true);
                _FrmForRefe.data0GVForReference.DataSource = batch_ds.Tables[0].DefaultView;
                cf.initHeaderTextPIMstrForEquire(_FrmForRefe.data0GVForReference);
            }
            else
            {
                _FrmForRefe.data0GVForReference.DataSource = null;
            }
            _FrmForRefe.data0GVForReference.Refresh();

        }
        void button1_DoubleClick(object sender, EventArgs e)
        {
            _FrmForRefe.Close();
            _currentIndex = 0;
            btn1Search_Click(sender, e);
        }

        void data0GVForReference_Click(object sender, DataGridViewCellEventArgs e)
        {
            DoWrokObject dwo = new DoWrokObject(_FrmForRefe.data0GVForReference, e.RowIndex, e.ColumnIndex, _strCellColName);
            string strBatchID = cf.selectCellMethod(dwo);
            txt4PIID_search.Text = strBatchID;
        }

        void data0GVForReference_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DoWrokObject dwo = new DoWrokObject(_FrmForRefe, _FrmForRefe.data0GVForReference, 3, e.RowIndex, Color.LightGreen, _strCellColName, "Current " + _strCellColName + "#:", _sameColumnName, _deffCellName, _deffCellValue, Color.LightGray);
            cf.initThreadDowrokColor(dwo);

        }
        void enquireByForReferenct(object sender, EventArgs e)
        {
            _FrmForRefe.chkTop50.Checked = false;
            if (string.IsNullOrEmpty(_FrmForRefe.textBox1.Text))
            {
                _FrmForRefe.textBox1.Focus();
                return;
            }
            init_FrmForRefeDGV(_FrmForRefe.textBox1.Text.Trim());
            //txt0SearchID.Text = _FrmForRefe.textBox1.Text.Trim();
            //cf.EnquireByPart(data0GVPiReport, "pisr_part", _FrmForRefe.textBox1.Text.Trim());
        }

        void SelectedTab_Layout(object sender, LayoutEventArgs e)
        {
            initWidth();
        }
        private void initWidth()
        {
            gb2det_PIdet.Width = gb0PIAddNWForPallet.Width - gb2det_PIdet.Left;
            gb1mstr_PIMstr.Width = gb2det_PIdet.Width;
            //groupBox1PIMstr.Width = gb2det_PIdet.Width;

            gb2det_PIdet.Height = gb0PIAddNWForPallet.Height - gb2det_PIdet.Top;


            data1GV1_PIPalletList.RowEnter += data1GV1ePackingDet1_BatchInfo_RowEnter;
            data1GV1_PIPalletList.CellClick += data1GV1ePackingDet1_BatchInfo_CellClick;
        }
        void data1GV1ePackingDet1_BatchInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DoWrokObject dwo = new DoWrokObject(data1GV1_PIPalletList, e.RowIndex, e.ColumnIndex);
            cf.selectCellMethod(dwo, _idr_show._pi_mstr_model.PI_ID);
            _currentIndex = e.RowIndex;
            txt1PI_id_PIMstr.Text = data1GV1_PIPalletList.CurrentRow.Cells["PI_ID"].Value.ToString();
            txt2_Plant_PIMstr.Text = data1GV1_PIPalletList.CurrentRow.Cells["Pallet"].Value.ToString();
            txt3NW.Text = data1GV1_PIPalletList.CurrentRow.Cells["GW"].Value.ToString();
            txt3NW.SelectAll();
        }

        void data1GV1ePackingDet1_BatchInfo_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DoWrokObject dwo = new DoWrokObject(data1GV1_PIPalletList, 3, e.RowIndex, Color.LightGreen, "Pallet", "GW", "0", Color.LightGray);
            cf.initThreadDowrokColor(dwo);
        }
        private void frmPI3AddNWForPallet_Load(object sender, EventArgs e)
        {

        }

        public void btn1Search_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txt4PIID_search.Text))
            {
                //initGV(txt4PIID_search.Text.Trim());
                _selectFlag = true;
                ThreadPool.QueueUserWorkItem(new WaitCallback(initGV), txt4PIID_search.Text);

            }
        }

        public void initGV(object o)
        {
            _idr_show.Invoke(new FrmIDR._0API.Commfunction.Action(delegate()
            {
                var strPIID = o.ToString().Replace("'", ""); ;
                string sql_pallet = "select [PI_NO] as PI_ID,[pi_pallet_no] as Pallet,[PI_GW] as GW FROM [dbo].[vpi_report_palletCount] where PI_NO='" + strPIID + "' order by PI_NO,plr_LineID";

                var ds_piid = DbHelperSQL.Query(sql_pallet);
                if (ds_piid != null && ds_piid.Tables[0].Rows.Count > 0)
                {
                    data1GV1_PIPalletList.DataSource = ds_piid.Tables[0].DefaultView;
                    var intcurr = _currentIndex + 1;
                    if (intcurr < data1GV1_PIPalletList.Rows.Count && _selectFlag == false)
                    {
                        data1GV1_PIPalletList.Rows[intcurr].Cells[0].Selected = true;
                        _currentIndex++;
                        if (_currentIndex == data1GV1_PIPalletList.Rows.Count - 1)
                        {
                            _currentIndex = 0;
                            data1GV1_PIPalletList.Rows[_currentIndex].Cells[0].Selected = true;
                        }
                    }
                    txt1PI_id_PIMstr.Text = data1GV1_PIPalletList.CurrentRow.Cells["PI_ID"].Value.ToString();
                    txt2_Plant_PIMstr.Text = data1GV1_PIPalletList.CurrentRow.Cells["Pallet"].Value.ToString();
                    txt3NW.Text = data1GV1_PIPalletList.CurrentRow.Cells["GW"].Value.ToString();
                    txt3NW.SelectAll();
                    data1GV1_PIPalletList.Refresh();
                    lbl0Msg.Text = "PI NO: " + strPIID + " load success.";
                }
                else
                {
                    txt4PIID_search.Focus();
                    _idr_show.AcceptButton = btn1Search;
                    lbl0Msg.Text = "PI NO: " + strPIID + " is not exists.";
                }

            }));

        }

        private void txt4PIID_search_TextChanged(object sender, EventArgs e)
        {
            _idr_show.AcceptButton = btn1Search;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _idr_show.AcceptButton = btn0Add;
        }

        private void btn0Add_Click(object sender, EventArgs e)
        {
            lbl0Msg.Text = "";
            if (!string.IsNullOrEmpty(txt3NW.Text))
            {
                if (PageValidate.IsDecimal(txt3NW.Text))
                {
                    if (string.IsNullOrEmpty(txt1PI_id_PIMstr.Text) || string.IsNullOrEmpty(txt2_Plant_PIMstr.Text))
                    {
                        //txt3NW.Focus();
                        txt3NW.SelectAll();
                        _idr_show.AcceptButton = btn0Add;
                        lbl0Msg.Text = "please select a right data, please try again. ";
                        return;
                    }
                    string sql_update = "update pi_det set pi_pallet_no='" + txt3NW.Text.Trim() + "' where pi_id='" + txt1PI_id_PIMstr.Text.Trim() + "' and pi_chr03='" + txt2_Plant_PIMstr.Text.Trim() + "'";
                    if (chk0AllSame.Checked)
                    {
                        sql_update = "update pi_det set pi_pallet_no='" + txt3NW.Text.Trim() + "' where pi_id='" + txt1PI_id_PIMstr.Text.Trim() + "'";

                    }
                    var updateflag = DbHelperSQL.ExecuteSql(sql_update);
                    if (updateflag > 0)
                    {
                        lbl0Msg.Text = "Success: Update pi_id='" + txt1PI_id_PIMstr.Text.Trim() + "' and pi_chr03='" + txt2_Plant_PIMstr.Text + "' to " + txt3NW.Text + " Success";
                        _selectFlag = false;
                        ThreadPool.QueueUserWorkItem(new WaitCallback(initGV), txt1PI_id_PIMstr.Text);
                    }
                    else
                    {
                        //txt3NW.Focus();
                        txt3NW.SelectAll();
                        _idr_show.AcceptButton = btn0Add;
                        lbl0Msg.Text = "Error: Update pi_id='" + txt1PI_id_PIMstr.Text.Trim() + "' and pi_chr03='" + txt2_Plant_PIMstr.Text + "' to " + txt3NW.Text + " Fail, please try again. ";

                    }
                }
                else
                {
                    //txt3NW.Focus();
                    txt3NW.SelectAll();
                    _idr_show.AcceptButton = btn0Add;
                    lbl0Msg.Text = "Please enter a right number.";
                }
            }
            else
            {
                //txt3NW.Focus();
                txt3NW.SelectAll();
                _idr_show.AcceptButton = btn0Add;
                lbl0Msg.Text = "Please enter a right number.";
            }
        }


        public int _currentIndex { get; set; }
    }
}
