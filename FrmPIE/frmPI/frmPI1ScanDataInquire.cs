using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using FrmIDR._0API;
using FrmPIE;

namespace frmPI
{
    public partial class frmPI1ScanDataInquire : Form
    {
        frmIDR _idr_show;
        Commfunction cf;
        frmEnterTxt _frmET;
        DataSet _reobjdet;

        public frmPI1ScanDataInquire(frmIDR idr)
        {
            _idr_show = idr;
            cf = new Commfunction(idr);
            InitializeComponent();

            initWidth();
            data1GV1_PIdet.ReadOnly = true;

            DoWorkObject obj = new DoWorkObject(data0GVPIMstr,data1GV1_PIdet, _idr_show._pi_mstr_model.PI_ID);

            _idr_show._tInitGDV = new Thread(new ParameterizedThreadStart(initDGVDelegate));

            if (_idr_show._tInitGDV.ThreadState == ThreadState.Running)
            {
                _idr_show._tInitGDV.Abort();
            }

            if (_idr_show._tInitGDV.ThreadState == ThreadState.Unstarted)
            {
                _idr_show._tInitGDV.Start(obj);
            }
            if (_idr_show._tInitGDV.ThreadState == ThreadState.Stopped)
            {
                _idr_show._tInitGDV = new Thread(new ParameterizedThreadStart(initDGVDelegate));
                _idr_show._tInitGDV.Start(obj);
            }

            _idr_show.tabCtlRight1.SelectedTab.Layout += SelectedTab_Layout;

            data0GVPIMstr.RowEnter += data0GVPIMstr_RowEnter;
            data0GVPIMstr.CellClick += data0GVPIMstr_CellClick;

            data1GV1_PIdet.RowEnter += data1GV1ePackingDet1_BatchInfo_RowEnter;
            data1GV1_PIdet.CellClick += data1GV1ePackingDet1_BatchInfo_CellClick;


            data1GV1_PIdet.ContextMenuStrip = ctmenu0EnquireByPart;
            enquireByPartToolStripMenuItem.Click += enquireByPartToolStripMenuItem_Click;
        }

        private void enquireByPartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmET = new frmEnterTxt(_idr_show, this);
            _frmET.button1.Click += enquireByPart;
            _frmET.lblTitle.Text = "Part#:";
            _frmET.Text = "Enquire by Part:";
            _frmET.ShowDialog();
        }
        void enquireByPart(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_frmET.textBox1.Text))
            {
                _frmET.textBox1.Focus();
                return;
            }
            cf.EnquireByPart(data1GV1_PIdet, "pisr_part", _frmET.textBox1.Text.Trim());
        }
        void SelectedTab_Layout(object sender, LayoutEventArgs e)
        {
            initWidth();
        }
        private void initWidth()
        {
            gb2det_PIdet.Width = gb00PIScanPIDataitemInquire.Width - gb2det_PIdet.Left;
            gb1mstr_PIMstr.Width = gb2det_PIdet.Width;
            //groupBox1PIMstr.Width = gb2det_PIdet.Width;

            gb2det_PIdet.Height = gb00PIScanPIDataitemInquire.Height - gb2det_PIdet.Top;
        }
        void data0GVPIMstr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DoWorkObject dwo = new DoWorkObject(data0GVPIMstr,data1GV1_PIdet, e.RowIndex, e.ColumnIndex);
            cf.selectCellMethod(dwo, _idr_show._pi_mstr_model.PI_ID,true,this);
        }
        void data0GVPIMstr_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DoWorkObject dwo = new DoWorkObject(data0GVPIMstr, 3, e.RowIndex, Color.Yellow, "pi_user_ip", "pi_status", "Yes", Color.LightGray);
            cf.initThreadDowrokColor(dwo);
        }
        void data1GV1ePackingDet1_BatchInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DoWorkObject dwo = new DoWorkObject(data1GV1_PIdet, e.RowIndex, e.ColumnIndex);
            cf.selectCellMethod(dwo, _idr_show._pi_mstr_model.PI_ID);
        }

        void data1GV1ePackingDet1_BatchInfo_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DoWorkObject dwo = new DoWorkObject(data1GV1_PIdet, 3, e.RowIndex, Color.LightGreen, "CartonID", "pi_status", "Yes", Color.LightGray);
            cf.initThreadDowrokColor(dwo);
        }
        private void initDGV(object doWorkobj)
        {
            DoWorkObject obj = (DoWorkObject)doWorkobj;

            CartonFromTo ctftPlrMstr = new CartonFromTo(obj._dgv, obj._strBatchId, 1, "upload", _idr_show._custip, _idr_show._custip);
            CartonFromTo ctftPlrMstrall = new CartonFromTo(obj._dgv, obj._strBatchId, 0, "upload", _idr_show._custip, _idr_show._custip,100);

            CartonFromTo ctftPlrMstrTran = new CartonFromTo(obj._dgv1, obj._strBatchId, 0, "upload", _idr_show._custip, _idr_show._custip);

            var reobjmstr = cf.initDataGVpi_mstr(ctftPlrMstr, false, "model");

            var reobjmstrDGVreflash = cf.initDataGVpi_mstr(ctftPlrMstrall, true, "all");
            _reobjdet = (DataSet)cf.initDataGVpi_det_join_grr(ctftPlrMstrTran, true, "ds");

            if (reobjmstr != null)
            {
                _idr_show._pi_mstr_model = (PI.Model.pi_mstr)reobjmstr;

                initModelToTxtPlrBatchMast(_idr_show._pi_mstr_model, true);
            }

        }
        public void initModelToTxtPlrBatchMast(PI.Model.pi_mstr model, bool breadonly)
        {
            txt1PI_id_PIMstr.Text = model.PI_ID;
            txt2_Plant_PIMstr.Text = model.Plant;
            txt3Type_PIMstr.Text = model.pi_type;
            txt5_cre_date_PIMstr.Text = model.pi_cre_date.ToString();

            txt1PI_id_PIMstr.ReadOnly = breadonly;
            txt2_Plant_PIMstr.ReadOnly = breadonly;
            txt3Type_PIMstr.ReadOnly = breadonly;
            txt5_cre_date_PIMstr.ReadOnly = breadonly;
        }
        private void initDGVDelegate(object doWorkobj)
        {
            Commfunction.dinitDataGVSource me = new Commfunction.dinitDataGVSource(initDGV);
            _idr_show.Invoke(me, doWorkobj);
        }
        private void frmPI1ScanDataInquire_Load(object sender, EventArgs e)
        {

        }

        private void downLoad1ToExceltoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            cf.downLoadExcel(_reobjdet, _idr_show.status15toolLabelstrResult, cf.nameList0vpi_report_ds(), "21PIScan" + _idr_show._pi_mstr_model.PI_ID);
        }
    }
}
