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
    public partial class frmPI4AddCoForPallet : Form
    {
        frmIDR _idr_show;
        Commfunction cf;

        public frmPI4AddCoForPallet()
        {
            InitializeComponent();
        }
        public frmPI4AddCoForPallet(frmIDR idr)
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
            txt1Co_Name_PIMstr.Text = data1GV1_PIPalletList.CurrentRow.Cells["Name"].Value.ToString();
            txt3CO_Value.Text = data1GV1_PIPalletList.CurrentRow.Cells["Value"].Value.ToString();
            txt3CO_Value.SelectAll();
        }

        void data1GV1ePackingDet1_BatchInfo_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DoWrokObject dwo = new DoWrokObject(data1GV1_PIPalletList, 3, e.RowIndex, Color.LightGreen, "Name", "Value", "", Color.LightGray);
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
                var strPIID = o.ToString().Replace("'","");
                string sql_pallet = "select top 100 t_value as Name,t_desc as Value from pkey_ctl where t_name='co' and t_value like '%" + strPIID + "%'  order by t_value";

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
                    txt1Co_Name_PIMstr.Text = data1GV1_PIPalletList.CurrentRow.Cells["Name"].Value.ToString();
                    txt3CO_Value.Text = data1GV1_PIPalletList.CurrentRow.Cells["Value"].Value.ToString();
                    txt3CO_Value.SelectAll();
                    data1GV1_PIPalletList.Refresh();
                    lbl0Msg.Text = "Co Name: " + strPIID + " load success.";
                }
                else
                {
                    txt4PIID_search.Focus();
                    _idr_show.AcceptButton = btn1Search;
                    lbl0Msg.Text = "Co Name: " + strPIID + " is not exists.";
                }

            }));

        }


        public bool _selectFlag { get; set; }

        public int _currentIndex { get; set; }


        private void btn0Add_Click(object sender, EventArgs e)
        {
            lbl0Msg.Text = "";
            if (string.IsNullOrEmpty(txt1Co_Name_PIMstr.Text))
            {
                //txt3NW.Focus();
                txt1Co_Name_PIMstr.Focus();
                _idr_show.AcceptButton = btn0Add;
                lbl0Msg.Text = "please enter a right data1, please try again. ";
                return;
            }
            if (string.IsNullOrEmpty(txt3CO_Value.Text))
            {
                txt3CO_Value.Focus();
                _idr_show.AcceptButton = btn0Add;
                lbl0Msg.Text = "please enter a right data2, please try again. ";
                return;
            }
            var str_tmp_coName = txt1Co_Name_PIMstr.Text.Trim().ToUpper();
            var str_tmp_coValue = txt3CO_Value.Text.Trim().ToUpper();

            var addexit = new PIE.BLL.pkey_ctl().Exists("co", str_tmp_coName);

            if (addexit)
            {
                var tmpexit = new PIE.BLL.pkey_ctl().GetModel("co", str_tmp_coName);
                if (tmpexit.t_desc.Equals(str_tmp_coValue))
                {
                    return;
                }
                if (System.Windows.Forms.MessageBox.Show("\tCo Name: " + str_tmp_coName + "  is Exist." +
                    "\n Are you sure,update the " + tmpexit.t_desc + " to " + str_tmp_coValue, "Notice", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    lbl0Msg.Text = "Error: Update Co Name='" + str_tmp_coName + " to Co Value " + str_tmp_coValue + " Success";
                    return;
                }
                tmpexit.t_desc = str_tmp_coValue;
                var updateflag = new PIE.BLL.pkey_ctl().Update(tmpexit);

                if (updateflag)
                {
                    lbl0Msg.Text = "Success: Update Co Name='" + str_tmp_coName + " to Co Value " + str_tmp_coValue + " Success";
                    _selectFlag = false;
                    ThreadPool.QueueUserWorkItem(new WaitCallback(initGV), str_tmp_coName);
                }
                else
                {
                    //txt3NW.Focus();
                    txt3CO_Value.SelectAll();
                    _idr_show.AcceptButton = btn0Add;
                    lbl0Msg.Text = "Error: Update Co Name='" + str_tmp_coName + " to Co Value " + str_tmp_coValue + " faile";

                }
            }
            else
            {
                var tmpexit = new PIE.Model.pkey_ctl();
                tmpexit.t_name = "co";
                tmpexit.t_value = str_tmp_coName;
                tmpexit.t_desc = str_tmp_coValue;
                tmpexit.ctl_fro = 1;
                var addflag = new PIE.BLL.pkey_ctl().Add(tmpexit);

                if (addflag)
                {
                    lbl0Msg.Text = "Success: add Co Name='" + str_tmp_coName + " to Co Value " + str_tmp_coValue + " Success";
                    _selectFlag = false;
                    ThreadPool.QueueUserWorkItem(new WaitCallback(initGV), str_tmp_coName);
                }
                else
                {
                    //txt3NW.Focus();
                    txt3CO_Value.SelectAll();
                    _idr_show.AcceptButton = btn0Add;
                    lbl0Msg.Text = "Error: add Co Name='" + str_tmp_coName + " to Co Value " + str_tmp_coValue + " faile";

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
            txt1Co_Name_PIMstr.Text = "";
            txt3CO_Value.Text = "";
            txt1Co_Name_PIMstr.Focus();
            _idr_show.AcceptButton = btn0Add;
        }
    }
}
