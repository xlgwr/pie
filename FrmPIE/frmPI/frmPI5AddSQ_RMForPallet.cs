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
using FrmIDR._0API;

namespace FrmPIE.frmPI
{
    public partial class frmPI5AddSQ_RMForPallet : Form
    {
        frmIDR _idr_show;
        Commfunction cf;

        public frmPI5AddSQ_RMForPallet()
        {
            InitializeComponent();
        }
        public frmPI5AddSQ_RMForPallet(frmIDR idr)
        {
            _idr_show = idr;
            _idr_show.tabCtlRight1.SelectedTab.Layout += SelectedTab_Layout;

            cf = new Commfunction(idr);
            InitializeComponent();

            initWidth();
            data1GV1_PIPalletList.ReadOnly = true;
            data1GV1_PIPalletList.BorderStyle = BorderStyle.None;
            _currentIndex = 0;
            _selectFlag = false;
        }
        void SelectedTab_Layout(object sender, LayoutEventArgs e)
        {
            initWidth();
        }
        private void initWidth()
        {
            gb2det_PIdet.Width = gb0PIAddCoForPallet.Width - gb2det_PIdet.Left;
            gb1mstr_PIMstr.Width = gb2det_PIdet.Width;
            //groupBox1PIMstr.Width = gb2det_PIdet.Width;

            gb2det_PIdet.Height = gb0PIAddCoForPallet.Height - gb2det_PIdet.Top;


            data1GV1_PIPalletList.RowEnter += data1GV1ePackingDet1_BatchInfo_RowEnter;
            data1GV1_PIPalletList.CellClick += data1GV1ePackingDet1_BatchInfo_CellClick;
        }
        void data1GV1ePackingDet1_BatchInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DoWrokObject dwo = new DoWrokObject(data1GV1_PIPalletList, e.RowIndex, e.ColumnIndex);
            cf.selectCellMethod(dwo, 0);
            _currentIndex = e.RowIndex;

            txt1SQID_PIMstr.Text = data1GV1_PIPalletList.CurrentRow.Cells["sq_id"].Value.ToString();
            txtSQ2Name.Text = data1GV1_PIPalletList.CurrentRow.Cells["sq_name"].Value.ToString();
            txtSQ3Desc.Text = data1GV1_PIPalletList.CurrentRow.Cells["sq_desc"].Value.ToString();

            txtSQ2Name.SelectAll();
        }

        void data1GV1ePackingDet1_BatchInfo_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DoWrokObject dwo = new DoWrokObject(data1GV1_PIPalletList, 3, e.RowIndex, Color.LightGreen, "sq_name", "sq_desc", "", Color.LightGray);
            cf.initThreadDowrokColor(dwo);
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
                //,[co_id],[co_desc]
                string sql_pallet = "SELECT TOP 100 [sq_id],[sq_name],[sq_desc] FROM [dbo].[pi_sq] where [sq_type]='RM' and ([sq_id] = '" + strPIID + "' or [sq_name] like '%" + strPIID + "%')  order by [sq_id]";

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
                    txt1SQID_PIMstr.Text = data1GV1_PIPalletList.CurrentRow.Cells["sq_id"].Value.ToString();
                    txtSQ2Name.Text = data1GV1_PIPalletList.CurrentRow.Cells["sq_name"].Value.ToString();
                    txtSQ3Desc.Text = data1GV1_PIPalletList.CurrentRow.Cells["sq_desc"].Value.ToString();

                    txtSQ2Name.SelectAll();
                    data1GV1_PIPalletList.Refresh();
                    lbl0Msg.Text = "SQ ID: " + strPIID + " load success.";
                }
                else
                {
                    txt4PIID_search.Focus();
                    _idr_show.AcceptButton = btn1Search;
                    lbl0Msg.Text = "SQ ID: " + strPIID + " is not exists.";
                }

            }));

        }


        public bool _selectFlag { get; set; }

        public int _currentIndex { get; set; }


        private void btn0Add_Click(object sender, EventArgs e)
        {
            lbl0Msg.Text = "";

            if (string.IsNullOrEmpty(txt1SQID_PIMstr.Text))
            {
                //txt3NW.Focus();
                txt1SQID_PIMstr.Focus();
                _idr_show.AcceptButton = btn0Add;
                lbl0Msg.Text = "please enter a right data 1, please try again. ";
                return;
            }

            if (!PageValidate.IsNumber(txt1SQID_PIMstr.Text))
            {
                txt1SQID_PIMstr.SelectAll();
                lbl0Msg.Text = "SQ id is error. please enter a right Number, please try again. ";
                return;
            }
            if (string.IsNullOrEmpty(txtSQ2Name.Text))
            {
                //txt3NW.Focus();
                txtSQ2Name.Focus();
                _idr_show.AcceptButton = btn0Add;
                lbl0Msg.Text = "please select a right data 2, please try again. ";
                return;
            }
            if (string.IsNullOrEmpty(txtSQ3Desc.Text))
            {
                //txt3NW.Focus();
                txtSQ3Desc.Focus();
                _idr_show.AcceptButton = btn0Add;
                lbl0Msg.Text = "please select a right data 3, please try again. ";
                return;
            }
            var str_tmp_sq_id = Convert.ToInt32(txt1SQID_PIMstr.Text.Trim());
            var str_tmp_sq_name = txtSQ2Name.Text.Trim();
            var str_tmp_sq_desc = txtSQ3Desc.Text.Trim();

            var addexit = new PI.BLL.pi_sq().Exists("RM", str_tmp_sq_id);

            if (addexit)
            {
                var tmpexit = new PI.BLL.pi_sq().GetModel("RM", str_tmp_sq_id);
                if (System.Windows.Forms.MessageBox.Show("\tSQ ID: " + str_tmp_sq_id + "  is Exist.\n" +
                    "\n Are you sure,update the \n Name: " + tmpexit.sq_name + " to " + str_tmp_sq_name +
                    "\n Desc: " + tmpexit.sq_desc + " to " + str_tmp_sq_desc, "Notice", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    lbl0Msg.Text = "Error: Update SQ ID='" + str_tmp_sq_id + " to SQ Name " + str_tmp_sq_name + " Success";
                    return;
                }

                tmpexit.sq_name = str_tmp_sq_name;
                tmpexit.sq_desc = str_tmp_sq_desc;

                var updateflag = new PI.BLL.pi_sq().Update(tmpexit);

                if (updateflag)
                {
                    lbl0Msg.Text = "Success: Update SQ ID=" + str_tmp_sq_id + " to SQ Name " + str_tmp_sq_name + " Success";
                    _selectFlag = false;
                    ThreadPool.QueueUserWorkItem(new WaitCallback(initGV), str_tmp_sq_id);
                }
                else
                {
                    //txt3NW.Focus();
                    txtSQ2Name.SelectAll();
                    _idr_show.AcceptButton = btn0Add;
                    lbl0Msg.Text = "Error: Update SQ ID=" + str_tmp_sq_id + " to SQ Name " + str_tmp_sq_name + " faile";

                }
            }
            else
            {
                var tmpexit = new PI.Model.pi_sq();
                tmpexit.sq_type = "RM";
                tmpexit.sq_id = str_tmp_sq_id;
                tmpexit.sq_name = str_tmp_sq_name;
                tmpexit.sq_desc = str_tmp_sq_desc;
                tmpexit.co_id = "9999";

                var addflag = new PI.BLL.pi_sq().Add(tmpexit);

                if (addflag)
                {
                    lbl0Msg.Text = "Success: add SQ ID=" + str_tmp_sq_id + " to SQ Name " + str_tmp_sq_name + " Success";
                    _selectFlag = false;
                    ThreadPool.QueueUserWorkItem(new WaitCallback(initGV), str_tmp_sq_id);
                }
                else
                {
                    //txt3NW.Focus();
                    txtSQ2Name.SelectAll();
                    _idr_show.AcceptButton = btn0Add;
                    lbl0Msg.Text = "Error: add SQ ID=" + str_tmp_sq_id + " to SQ Name " + str_tmp_sq_name + " faile";

                }

            }


        }

        private void txt1Co_Name_PIMstr_Enter(object sender, EventArgs e)
        {
            _idr_show.AcceptButton = btn0Add;
        }

        private void txt3CO_Value_Enter(object sender, EventArgs e)
        {
            _idr_show.AcceptButton = btn0Add;
        }

        private void txt4PIID_search_TextChanged(object sender, EventArgs e)
        {
            _idr_show.AcceptButton = btn1Search;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt1SQID_PIMstr.Text = "";
            txtSQ2Name.Text = "";
            txtSQ3Desc.Text = "";

            txt1SQID_PIMstr.Focus();
            _idr_show.AcceptButton = btn0Add;
        }

        private void txtSQ3Desc_TextChanged(object sender, EventArgs e)
        {
            _idr_show.AcceptButton = btn0Add;
        }

        private void txt4PIID_search_TextChanged_1(object sender, EventArgs e)
        {
            _idr_show.AcceptButton = btn1Search;
        }
    }
}