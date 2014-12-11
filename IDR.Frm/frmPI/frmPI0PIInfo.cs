using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MessageBox = System.Windows.Forms.MessageBox;

using System.Data.Entity;
using IDR.Common;
using IDR.Common.DEncrypt;
using IDR.Frm.API;

using IDR.EF.PIE;
using IDR.EF.PIRemote;
using IDR.Frm.Temple;
using System.Threading;

namespace IDR.Frm.frmPI
{
    public partial class frmPI0PIInfo : Form
    {
        //attribute
        public IQueryable<vpi_detApisr_grr> _list_pi_det_join_grr { get; set; }

        public DataGridView _dgv_ToolScriptMenu { get; set; }

        //commonfunction
        CommonAPI cf;
        PIE _dbpie;

        ////frm win
        Default _frmDefault;
        frmEnterTxt _frmET;

        public frmPI0PIInfo()
        {
            InitializeComponent();
        }
        public frmPI0PIInfo(Default frmDefault)
        {
            InitializeComponent();
            //////////////
            initForDefault(frmDefault);
            //initfrm
            initFrm(frmDefault._dbpie);
            //initDGV
            initDGV();
        }
        #region init
        void initPara()
        {
            //function,db
            _dbpie = new PIE();
            cf = new CommonAPI(_frmDefault);
            //attribute
            //datagridview sort
            data1GV1_PIdet.ColumnHeaderMouseClick += data1GV_plr_mstr_BatchInfo_ColumnHeaderMouseClick;

            //datagridview row enter,cell click
            data1GV1_PIdet.RowEnter += data1GV_plr_mstr_BatchInfo_RowEnter;
            data1GV1_PIdet.CellClick += data1GV_plr_mstr_BatchInfo_CellClick;

            //equire by part
            data1GV1_PIdet.ContextMenuStrip = tsm0menu_EnquireByPart;

            tsm0menu_EnquireByPart.Click += tsm0menu_EnquireByPart_Click;
            tsmi00enquireByPartToolStripMenuItem.Click += ctmenu0EnquireByPart_Click;

        }
        void initFrm()
        {
            this.FormClosing += Default_FormClosing;
            //init width
            this.gb00PIScanPIDataitemInquire.Resize += gb0frmUploadExcel_Resize;
            //initpara
            initPara();
        }
        void initFrm(PIE dbpie)
        {
            initFrm();
            _dbpie = dbpie;
        }
        void initForDefault(Default frmDefault)
        {
            _frmDefault = frmDefault;
            _frmDefault.tabCtlRight1.SelectedTab.Layout += SelectedTab_Layout;
        }
        private void initwidth()
        {
            gb1mstr_PIMstr.Width = gb00PIScanPIDataitemInquire.Width - gb1mstr_PIMstr.Left - 5;
            gb2det_PIdet.Width = gb1mstr_PIMstr.Width;

            gb2det_PIdet.Height = gb00PIScanPIDataitemInquire.Height - gb2det_PIdet.Top - 10;

        }

        #region dgv cell click and row enter
        void data1GV_plr_mstr_BatchInfo_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cf.DGV_ColumnHeaderMouseClick<vpi_detApisr_grr>(sender, e, data1GV1_PIdet, _list_pi_det_join_grr);
        }
        void data1GV_plr_mstr_BatchInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DoWorkObject dwo = new DoWorkObject(data1GV1_PIdet, e.RowIndex, e.ColumnIndex);
            cf.dgv_cellClick(dwo,_frmDefault._pi_mstr_model.PI_ID);
        }

        void data1GV_plr_mstr_BatchInfo_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DoWorkObject dwo = new DoWorkObject(data1GV1_PIdet, 3, e.RowIndex, Color.LightGreen, "CartonID", "pi_status", "Yes", Color.LightGray);
            cf.dgv_rowEnter_ThreadPool(dwo);
        }

        #endregion
        #region equire by part
        void tsm0menu_EnquireByPart_Click(object sender, EventArgs e)
        {
            var tmpDGV = (DataGridView)tsm0menu_EnquireByPart.SourceControl;
            if (_dgv_ToolScriptMenu == null)
            {
                _dgv_ToolScriptMenu = tmpDGV;
                return;
            }
            if (_dgv_ToolScriptMenu != tmpDGV)
            {
                cf._intnext = 0;
                _dgv_ToolScriptMenu = tmpDGV;
            }
        }

        void ctmenu0EnquireByPart_Click(object sender, EventArgs e)
        {
            _frmET = new frmEnterTxt(_frmDefault);
            //_frmET._frm0BatchInfo = this;
            _frmET._title = "Enquire by ";
            //_frmET.lblTitle.Text = "Part#:";
            for (int i = 0; i < _dgv_ToolScriptMenu.ColumnCount; i++)
            {
                var tmpHeaderText = _dgv_ToolScriptMenu.Columns[i].HeaderText;
                _frmET.comb0TextValue.Items.Add(tmpHeaderText);
                if (tmpHeaderText.StartsWith("rir",true,null))
                {
                    _frmET.comb0TextValue.SelectedIndex = i;
                }
            }
            if (_frmET.comb0TextValue.Items.Count <= 0)
            {
                MessageBox.Show("No data");
                return;
            }
            _frmET.button1.Click += enquireByPart;
            _frmET.ShowDialog();
            //throw new NotImplementedException();
        }
        void enquireByPart(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_frmET.textBox1.Text))
            {
                _frmET.textBox1.Focus();
                return;
            }
            _frmET.lblMsg.Text = cf.EnquireByHeadText(_dgv_ToolScriptMenu, _frmET.comb0TextValue.Text, _frmET.textBox1.Text.Trim());
        }
        #endregion
        void SelectedTab_Layout(object sender, LayoutEventArgs e)
        {
            //btnSelectfileUploadExcel.Focus();
        }
        void gb0frmUploadExcel_Resize(object sender, EventArgs e)
        {
            initwidth();
        }
        void Default_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_dbpie != null)
            {
                _dbpie.Dispose();
            }
        }
        #endregion

        private void initDGV()
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(initGVpi_mstr), _frmDefault._pi_mstr_model.PI_ID);
            ThreadPool.QueueUserWorkItem(new WaitCallback(initGVpi_det_join_grr), _frmDefault._pi_mstr_model.PI_ID);
        }

        private void initGVpi_mstr(object o)
        {
            var tmp_model = _dbpie.pi_mstr.Find(o.ToString(),1);
            init_ModelToTxt(tmp_model, true);
        }
        private void initGVpi_det_join_grr(object o)
        {
            _frmDefault.Invoke(new Action(delegate()
            {
                _list_pi_det_join_grr = cf.getSelectList_vpi_detApisr_grr(o.ToString());
                data1GV1_PIdet.DataSource = _list_pi_det_join_grr.ToList();
                cf.initHeaderText_pi_det_join_grr(data1GV1_PIdet);
                data1GV1_PIdet.Refresh();
            }));
        }

        private void init_ModelToTxt(pi_mstr model, bool breadonly)
        {
            if (string.IsNullOrEmpty(model.PI_ID))
            {
                return;
            }
            _frmDefault.Invoke(new Action(delegate()
            {
                txt1PI_id_PIMstr.Text = model.PI_ID;
                txt2_Plant_PIMstr.Text = model.Plant;
                txt3Type_PIMstr.Text = model.pi_type;
                txt5_cre_date_PIMstr.Text = model.pi_cre_date.ToString();

                txt1PI_id_PIMstr.ReadOnly = breadonly;
                txt2_Plant_PIMstr.ReadOnly = breadonly;
                txt3Type_PIMstr.ReadOnly = breadonly;
                txt5_cre_date_PIMstr.ReadOnly = breadonly;
                //throw new NotImplementedException();
            }));
        }
    }
}
