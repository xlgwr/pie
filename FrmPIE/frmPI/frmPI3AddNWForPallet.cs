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

        public frmPI3AddNWForPallet(frmIDR idr)
        {
            _idr_show = idr;
            _idr_show.tabCtlRight1.SelectedTab.Layout += SelectedTab_Layout;

            cf = new Commfunction(idr);
            InitializeComponent();

            initWidth();
            data1GV1_PIPalletList.ReadOnly = true;
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
            txt1PI_id_PIMstr.Text = data1GV1_PIPalletList.CurrentRow.Cells["PI_ID"].Value.ToString();
            txt2_Plant_PIMstr.Text = data1GV1_PIPalletList.CurrentRow.Cells["Pallet"].Value.ToString();
            txt3NW.Text = data1GV1_PIPalletList.CurrentRow.Cells["NW"].Value.ToString();
        }

        void data1GV1ePackingDet1_BatchInfo_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DoWrokObject dwo = new DoWrokObject(data1GV1_PIPalletList, 3, e.RowIndex, Color.LightGreen, "Pallet", "NW", "0", Color.LightGray);
            cf.initThreadDowrokColor(dwo);
        }
        private void frmPI3AddNWForPallet_Load(object sender, EventArgs e)
        {

        }

        public void btn1Search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt4PIID_search.Text))
            {
                initGV(txt4PIID_search.Text.Trim());

                // ThreadPool.QueueUserWorkItem(new WaitCallback(doGenCarton), o);
                ThreadPool.QueueUserWorkItem(new WaitCallback(initGV), txt4PIID_search.Text);
            }
        }

        public void initGV(object o)
        {
            _idr_show.Invoke(new FrmIDR._0API.Commfunction.Action(delegate()
            {
                var strPIID = o.ToString();
                string sql_pallet = "select distinct pi_id as PI_ID,pi_chr03 as Pallet,pi_pallet_no as NW FROM pi_det where PI_ID='" + strPIID + "' order by pi_chr03,pi_pallet_no";
                var ds_piid = DbHelperSQL.Query(sql_pallet);
                if (ds_piid != null && ds_piid.Tables[0].Rows.Count > 0)
                {
                    data1GV1_PIPalletList.DataSource = ds_piid.Tables[0].DefaultView;
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
                if (PageValidate.IsNumber(txt3NW.Text))
                {
                    string sql_update = "update pi_det set pi_pallet_no='" + txt3NW.Text.Trim() + "' where pi_id='" + txt1PI_id_PIMstr.Text.Trim() + "' and pi_chr03='" + txt2_Plant_PIMstr.Text.Trim() + "'";
                    var updateflag = DbHelperSQL.ExecuteSql(sql_update);
                    if (updateflag > 0)
                    {
                        lbl0Msg.Text = "Success: Update pi_id='" + txt1PI_id_PIMstr.Text.Trim() + "' and pi_chr03='" + txt2_Plant_PIMstr.Text + "' to " + txt3NW.Text + " Success";

                        ThreadPool.QueueUserWorkItem(new WaitCallback(initGV), txt1PI_id_PIMstr.Text);
                    }
                    else
                    {
                        txt3NW.Focus();
                        _idr_show.AcceptButton = btn0Add;
                        lbl0Msg.Text = "Error: Update pi_id='" + txt1PI_id_PIMstr.Text.Trim() + "' and pi_chr03='" + txt2_Plant_PIMstr.Text + "' to " + txt3NW.Text + " Fail, please try again. ";

                    }
                }
                else
                {
                    txt3NW.Focus();
                    _idr_show.AcceptButton = btn0Add;
                    lbl0Msg.Text = "Please enter a right number.";
                }
            }
            else
            {
                txt3NW.Focus();
                _idr_show.AcceptButton = btn0Add;
                lbl0Msg.Text = "Please enter a right number.";
            }
        }

    }
}
