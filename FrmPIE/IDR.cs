using FrmPIE._0API;
using FrmPIE.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using models = PIE.Model;

using FrmPIE.frmPIE;
using FrmPIE.frmPI;

//xls
using System.IO;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
//xlsx
using NPOI.XSSF.UserModel;

namespace FrmPIE
{


    public partial class frmIDR : Form
    {
        LogonDomain _logonDomain = new LogonDomain();
        public PIE.Model.sys_user _sys_user_model = new PIE.Model.sys_user();

        public Thread _tuploadExcel;
        public Thread _tInitGDV;
        public Thread _tuploadERP;
        public Thread _tprintCtn;
        public Thread _tDoWorkBackClorThread;
        public Thread _tRefresh;
        public Thread _tSetCtlText;

        public HSSFWorkbook _hssfworkbook;           //xls
        public XSSFWorkbook _xssfworkbook;    //xlsx;
        public DataSet _batchMstr;


        public DataGridView _voidDGV;
        public int _voideX;
        public int _voideY;
        public Boolean _voidhasLineID;
        public Boolean _voidRefresh;

        public models.plr_batch_mstr _plr_batch_mstr_model = new models.plr_batch_mstr();
        public PI.Model.pi_mstr _pi_mstr_model = new PI.Model.pi_mstr();
        Commfunction cf;
        public string _custip = Program.getClientIP();

        int _icurrTabMouseUpIndex = 1;
        int _icurrAddGBtop = 0;
        int _icurrMouseX = 0;
        int _icurrMouseY = 0;

        public int _intFrom = 0;
        public int _intTo = 0;

        public string _strSaveLabelFile = "";
        public string _strDownLoadExcel = "";
        public frmIDR(LogonDomain logonDomain, PIE.Model.sys_user sys_user_model)
        {
            _logonDomain = logonDomain;
            _sys_user_model = sys_user_model;

            InitializeComponent();
            foreach (var item in tabCtlRight1.TabPages)
            {
                TabPage tp = (TabPage)item;
                tp.MouseDown += tp_MouseDown;
            }
            cf = new Commfunction(this);

        }
        public frmIDR()
        {

            InitializeComponent();
            foreach (var item in tabCtlRight1.TabPages)
            {
                TabPage tp = (TabPage)item;
                tp.MouseDown += tp_MouseDown;
            }
            cf = new Commfunction(this);

        }
        private void frmIDR_Load(object sender, EventArgs e)
        {

            initHideImage(new object[] { hideLeftBarToolStripMenuItem2, hideLeftToolStripMenuItem3, status11toolBtnleft }, 1);
            initHideImage(new object[] { hideToolBarToolStripMenuItem1 }, 2);

            initCurrMouseXY(new object[] { btn1PackingListMaintain1, btn2GenCarton2, btn3PrintCartonLabel3, btn21ScanCartronLabel21, btn24PIReports,
                                           linkLabel1, linkLabel2,linkLabel3,linkLabel4,linkLabel8});
            initlink(new object[] { linkLabel1, linkLabel2, linkLabel3, linkLabel4, linkLabel8 });
            //Control.CheckForIllegalCrossThreadCalls = false;

        }
        private void frmIDR_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_tuploadExcel != null)
            {
                if (_tuploadExcel.ThreadState == ThreadState.Running)
                {
                    _tuploadExcel.Abort();
                }
            }
            if (_tInitGDV != null)
            {
                if (_tInitGDV.ThreadState == ThreadState.Running)
                {
                    _tInitGDV.Abort();
                }
            }
            if (_tuploadERP != null)
            {
                if (_tuploadERP.ThreadState == ThreadState.Running)
                {
                    _tuploadERP.Abort();
                }
            }
            if (_tprintCtn != null)
            {
                if (_tprintCtn.ThreadState == ThreadState.Running)
                {
                    _tprintCtn.Abort();
                }
            }
            if (_tDoWorkBackClorThread != null)
            {
                if (_tDoWorkBackClorThread.ThreadState == ThreadState.Running)
                {
                    _tDoWorkBackClorThread.Abort();
                }
            }
            if (_logonDomain != null)
            {
                _logonDomain.Close();
                _logonDomain.Dispose();

            }
            if (_tRefresh != null)
            {
                if (_tRefresh.ThreadState == ThreadState.Running)
                {
                    _tRefresh.Abort();
                }

            }
            GC.Collect();
        }
        private void initlink(object[] obj)
        {
            foreach (var item in obj)
            {
                var lk = (LinkLabel)item;
                lk.Click += lk_Click;
            }

        }

        private void lk_Click(object sender, EventArgs e)
        {
            var lk = (LinkLabel)sender;
            lk.ContextMenuStrip.Show(lk, _icurrMouseX, _icurrMouseY);
        }
        private void txt0SearchID_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btn0Find9;
            if (txt0SearchID.Text.Length > 0)
            {
                lbl0SearchError.Text = "Length:" + txt0SearchID.Text.Length.ToString();
            }
            cf.initScanTXT(txt0SearchID, 20, 12);
        }
        //protected override bool ProcessCmdKey(ref   Message msg, Keys keyData)
        //{
        //    if (keyData == Keys.Down)
        //    {

        //        //keybd_event(9, 0, 0, 0);
        //        SendKeys.Send("{TAB}");

        //    }
        //    if (keyData == Keys.Up)
        //    {

        //        SendKeys.Send("+{TAB}");

        //    }
        //    return base.ProcessCmdKey(ref msg, keyData);

        //}


        private void toolBtnleft1_ButtonClick(object sender, EventArgs e)
        {
            HideOrShowLeftBar(splitContainer2, 1, hideLeftToolStripMenuItem3, "Hide Left &Bar", "Show Left &Bar");

            HideOrShowleftorToolImg(splitContainer2, new object[] { status11toolBtnleft, hideLeftBarToolStripMenuItem2, hideLeftToolStripMenuItem3 }, 1);

        }
        private void hideToolBarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            HideOrShowLeftBar(splitContainer1, 1, hideToolBarToolStripMenuItem1, "&Hide Tool Bar", "&Show Tool Bar");
            HideOrShowleftorToolImg(splitContainer1, new object[] { hideToolBarToolStripMenuItem1 }, 2);



        }

        private void hideLeftBarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            HideOrShowLeftBar(splitContainer2, 1, hideLeftBarToolStripMenuItem2, "Hide &Left Bar", "Show &Left Bar");
            HideOrShowleftorToolImg(splitContainer2, new object[] { status11toolBtnleft, hideLeftBarToolStripMenuItem2, hideLeftToolStripMenuItem3 }, 1);
        }
        private void hideLeftToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            HideOrShowLeftBar(splitContainer2, 1, hideLeftToolStripMenuItem3, "Hide Left &Bar", "Show Left &Bar");

            HideOrShowleftorToolImg(splitContainer2, new object[] { status11toolBtnleft, hideLeftBarToolStripMenuItem2, hideLeftToolStripMenuItem3 }, 1);
        }
        private void HideOrShowleftorToolImg(SplitContainer sc, object[] ts, int imagIndex)
        {
            if (imagIndex == 1)
            {
                foreach (var item in ts)
                {
                    ToolStripItem tsi = (ToolStripItem)item;
                    if (!sc.Panel1Collapsed)
                    {
                        tsi.Image = Resources._13;
                    }
                    else
                    {
                        tsi.Image = Resources._14;
                    }
                }

            }
            else if (imagIndex == 2)
            {
                foreach (var item in ts)
                {
                    ToolStripItem tsi = (ToolStripItem)item;
                    if (!sc.Panel1Collapsed)
                    {
                        tsi.Image = Resources._15;
                    }
                    else
                    {
                        tsi.Image = Resources._18;
                    }
                }
            }

        }
        public void initHideImage(object[] ts, int imagIndex)
        {
            if (imagIndex == 1)
            {
                foreach (var item in ts)
                {
                    ToolStripItem tsi = (ToolStripItem)item;
                    tsi.Image = Resources._13;
                }
            }
            else if (imagIndex == 2)
            {
                foreach (var item in ts)
                {
                    ToolStripItem tsi = (ToolStripItem)item;
                    tsi.Image = Resources._15;
                }
            }
        }

        private void HideOrShowLeftBar(SplitContainer sc, int PanelNum, ToolStripItem tsi, string Hidetest, string ShowText)
        {
            if (PanelNum == 1)
            {
                if (sc.Panel1Collapsed)
                {
                    tsi.Text = Hidetest;
                }
                else
                {
                    tsi.Text = ShowText;
                }
                sc.Panel1Collapsed = !sc.Panel1Collapsed;
            }
            if (PanelNum == 2)
            {
                if (sc.Panel2Collapsed)
                {
                    tsi.Text = Hidetest;
                }
                else
                {
                    tsi.Text = ShowText;
                }
                sc.Panel2Collapsed = !sc.Panel2Collapsed;
            }

        }


        private TabPage addNewTabPage(string pagename)
        {
            tabCtlRight1.TabPages.Add(tabCtlRight1.TabCount + ":" + pagename, tabCtlRight1.TabCount + ":" + pagename);

            tabCtlRight1.SelectedIndex = tabCtlRight1.TabCount - 1;
            status13toolSStatusLblMsg.Text = tabCtlRight1.SelectedIndex.ToString() + "," + pagename;

            tabCtlRight1.SelectedTab.AutoScroll = true;

            return tabCtlRight1.SelectedTab;

        }
        private TabPage addNewTabPage(string pagename, bool develop)
        {
            tabCtlRight1.TabPages.Add(tabCtlRight1.TabCount + pagename, tabCtlRight1.TabCount + pagename);

            tabCtlRight1.SelectedIndex = tabCtlRight1.TabCount - 1;
            status13toolSStatusLblMsg.Text = tabCtlRight1.SelectedIndex.ToString() + "," + pagename;

            tabCtlRight1.SelectedTab.AutoScroll = true;

            Label lb = new Label();
            lb.ForeColor = Color.Red;
            lb.Text = "Develop...";

            addGBToTC(tabCtlRight1, lb);

            return tabCtlRight1.SelectedTab;

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabCtlRight1.TabPages.RemoveAt(_icurrTabMouseUpIndex);
            tabCtlRight1.SelectedIndex = tabCtlRight1.TabCount - 1;
        }


        void tp_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {

                TabPage tp = (TabPage)sender;
                status13toolSStatusLblMsg.Text = tp.Name;
            }
        }

        private void tabCtlRight1_MouseUp(object sender, MouseEventArgs e)
        {
            if ((e.Y < tabCtlRight1.GetTabRect(0).Bottom) && (e.Button == MouseButtons.Right))
            {
                if (_icurrTabMouseUpIndex == 0)
                {
                    closeToolStripMenuItem1.Visible = false;
                    closeAllToolStripMenuItem2.Visible = false;
                }
                else
                {
                    closeToolStripMenuItem1.Visible = true;
                    closeAllToolStripMenuItem2.Visible = true;
                }
                ctmenusClose.Show(this.tabCtlRight1, e.X, e.Y);
                // TabPage tp = (TabPage)sender;
                status13toolSStatusLblMsg.Text = tabCtlRight1.TabPages[_icurrTabMouseUpIndex].Name;
                status14toolLabelCellRowColXY.Text = "";
            }
        }

        private void tabCtlRight1_MouseMove(object sender, MouseEventArgs e)
        {

            for (int i = 0; i < tabCtlRight1.TabCount; i++)
            {
                Rectangle rect = tabCtlRight1.GetTabRect(i);
                if (rect.Contains(e.Location))
                {
                    _icurrTabMouseUpIndex = i;
                    status13toolSStatusLblMsg.Text = i.ToString() + "," + tabCtlRight1.TabPages[i].Name;
                    status14toolLabelCellRowColXY.Text = "";
                    break;
                }
            }

        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = tabCtlRight1.TabCount - 1; i > 0; i--)
            {
                var tb = tabCtlRight1.TabPages[i];
                tabCtlRight1.TabPages.Remove(tb);
            }

            tabCtlRight1.SelectedIndex = tabCtlRight1.TabCount - 1;
        }

        private void closeAllButThisToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var tb = tabCtlRight1.TabPages[_icurrTabMouseUpIndex];
            for (int i = tabCtlRight1.TabCount - 1; i > 0; i--)
            {
                var tbnext = tabCtlRight1.TabPages[i];
                if (tb != tbnext)
                {
                    tabCtlRight1.TabPages.Remove(tbnext);
                }
            }

            tabCtlRight1.SelectedIndex = tabCtlRight1.TabCount - 1;
        }


        private void btnPackingListMaintain1_Click(object sender, EventArgs e)
        {
            cMenuStrip1PacklingListMain.Show(btn1PackingListMaintain1, _icurrMouseX, _icurrMouseY);
        }

        private void initCurrMouseXY(object[] buttonobjs)
        {
            foreach (var btnobj in buttonobjs)
            {
                Control btn = (Control)btnobj;
                btn.MouseMove += btn_MouseMove;

            }
        }

        void btn_MouseMove(object sender, MouseEventArgs e)
        {
            _icurrMouseX = e.X;
            _icurrMouseY = e.Y;
            //status13toolStripStatusLabel.Text = "Current Position: X:" + e.X + ",Y:" + e.Y;
        }

        private void btnGenCarton2_Click(object sender, EventArgs e)
        {
            cMenuStrip2CartonIDMain.Show(this.btn2GenCarton2, _icurrMouseX, _icurrMouseY);
        }

        private void btnPrintCartonLabel3_Click(object sender, EventArgs e)
        {
            cMenuStrip3PrintCartonLabel.Show(btn3PrintCartonLabel3, _icurrMouseX, _icurrMouseY);
        }

        private void btn1Home1_Click(object sender, EventArgs e)
        {
            tabCtlRight1.SelectedIndex = 0;
        }

        private void btn0Add_Click(object sender, EventArgs e)
        {
            //addNewTabPage("Add New", true);
            toolcMenu12AddOneByOneBatchID_Click(sender, e);

        }

        private void btn0Edit2_Click(object sender, EventArgs e)
        {
            //addNewTabPage("Edit", true);
            toolcMenu11UploadEPackingListExcel_Click(sender, e);
        }

        private void btn0Del3_Click(object sender, EventArgs e)
        {
            addNewTabPage("Delete", true);
        }

        private void btn0OK4_Click(object sender, EventArgs e)
        {
            addNewTabPage("Audit", true);
        }

        private void btn0Lock5_Click(object sender, EventArgs e)
        {
            addNewTabPage("Lock", true);
        }

        private void btn0Print6_Click(object sender, EventArgs e)
        {
            //addNewTabPage("Printing", true);
            toolStripMenuItem31btnPrintCartonLabel3_Click(sender, e);
        }

        private void btn0Down8_Click(object sender, EventArgs e)
        {
            addNewTabPage("Download", true);
        }

        private void btn0Find9_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt0SearchID.Text.Trim()))
            {
                if (cmb1SearchType.Text.Equals("BatchID"))
                {
                    var exist = new PIE.BLL.plr_batch_mstr().Exists(txt0SearchID.Text.Trim());
                    if (exist)
                    {
                        string strtitle = "Find " + cmb1SearchType.Text + ":" + txt0SearchID.Text.Trim() + "Result";
                        var tpg = addNewTabPage(strtitle);
                        this._plr_batch_mstr_model.batch_id = txt0SearchID.Text.Trim();
                        frm0BatchInfo bi = new frm0BatchInfo(this);
                        addGBToTC(tpg, bi.groupBox0BatchInfo0);
                    }
                    else
                    {
                        lbl0SearchError.Text = "Error:Batch Mstr " + txt0SearchID.Text + " is not exist.";
                        txt0SearchID.SelectionStart = txt0SearchID.Text.Length;
                    }

                }
                else if (cmb1SearchType.Text.Equals("PI ID"))
                {
                    var exist = new PI.BLL.pi_mstr().Exists(txt0SearchID.Text.Trim(), 1);
                    if (exist)
                    {
                        string strtitle = "Find " + cmb1SearchType.Text + ":" + txt0SearchID.Text.Trim() + "Result";
                        var tpg = addNewTabPage(strtitle);
                        this._pi_mstr_model.PI_ID = txt0SearchID.Text.Trim();
                        frmPI1ScanDataInquire bi = new frmPI1ScanDataInquire(this);
                        addGBToTC(tpg, bi.gb00PIScanPIDataitemInquire);
                    }
                    else
                    {
                        lbl0SearchError.Text = "Error:PI Mstr " + txt0SearchID.Text + " is not exist.";
                        txt0SearchID.SelectionStart = txt0SearchID.Text.Length;
                    }
                }
            }
        }
        public void addGBToTC(TabControl tc, GroupBox gb)
        {
            tc.SelectedTab.Controls.Add(gb);
        }
        public void addGBToTC(TabControl tc, Control cl)
        {
            tc.SelectedTab.Controls.Add(cl);
        }
        public void addGBToTC(TabPage tp, GroupBox gb)
        {
            tp.Controls.Add(gb);
        }
        private void toolcMenu11UploadEPackingListExcel_Click(object sender, EventArgs e)
        {
            addNewTabPage("Upload EPacking List From Excel");
            frmUploadExcel fu = new frmUploadExcel(this);
            addGBToTC(tabCtlRight1, fu.groupBox0frmUploadExcel);
        }

        private void toolcMenu10UploadEPackingListExcelForKYCA_Click(object sender, EventArgs e)
        {
            addNewTabPage("Upload EPacking List From Excel For KYCA");
            frm111UploadExcelForKYCA fus = new frm111UploadExcelForKYCA(this);
            addGBToTC(tabCtlRight1, fus.groupBox0frmUploadExcelForKYCA);
        }
        private void toolcMenu12AddOneByOneBatchID_Click(object sender, EventArgs e)
        {
            var tabpagenew = addNewTabPage("Add New(BatchID)");
            frm211AddNewBatchID fanb = new frm211AddNewBatchID(this);
            _icurrAddGBtop = fanb.groupBox0AddNewBatchID.Height;

            this.AcceptButton = fanb.btn1UpadeAddAddNewBatchID;
            addGBToTC(tabpagenew, fanb.groupBox0AddNewBatchID);
        }

        private void btn1ScanCartronLabel21_Click(object sender, EventArgs e)
        {
            cMenuStrip21ScanCartronLabel.Show(btn21ScanCartronLabel21, _icurrMouseX, _icurrMouseY);
        }

        private void tool1StripMenuItem21ScanCartronLabel_Click(object sender, EventArgs e)
        {
            addNewTabPage("Scan Cartron Label");
            frmPI0ScanWECCtnLable swcl = new frmPI0ScanWECCtnLable(this);
            addGBToTC(tabCtlRight1, swcl.groupBox1ScanWECCtnLable);
        }

        private void txt0SearchID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn0Find9_Click(sender, e);
            }
        }

        private void toolStripMenuItem22UploadCartonIDToERP_Click(object sender, EventArgs e)
        {
            addNewTabPage("Upload WEC Carton ID To ERP");
            frm412UploadToERP ute = new frm412UploadToERP(this);
            addGBToTC(tabCtlRight1, ute.gb0UploadToERP);
        }

        private void toolStripMenuItem31btnPrintCartonLabel3_Click(object sender, EventArgs e)
        {
            addNewTabPage("Print Carton Label");
            frm513PrintCartonLabel ute = new frm513PrintCartonLabel(this);
            addGBToTC(tabCtlRight1, ute.gb0PrintCartonLabel);

        }

        private void openPrintFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string allfileNamepath;
            string pathname = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "0labeltxt";
            if (string.IsNullOrEmpty(_strSaveLabelFile))
            {

                allfileNamepath = pathname;
            }
            else
            {

                allfileNamepath = System.IO.Path.Combine(pathname, _strSaveLabelFile);
            }
            cf.OpenFolderAndSelectFile(allfileNamepath);
        }

        private void clearNoticeMsgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //status13toolSStatusLblMsg.Text = "";
            status15toolLabelstrResult.Text = "";
            //status14toolLabelCellRowColXY.Text = "";
        }

        private void tool110StripMenuItemVoid_Click(object sender, EventArgs e)
        {
            if (_voidDGV != null)
            {
                DoWrokObject dwo = new DoWrokObject(_voidDGV, _voideX, _voideX, _voidhasLineID, "plr_status");
                cf.initVoid(dwo);
                _voidRefresh = true;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addNewTabPage("Enquire Pi Report");
            frmPI2Report swcl = new frmPI2Report(this);
            addGBToTC(tabCtlRight1, swcl.gb0PIReport);
        }

        private void btn24PIReports_Click(object sender, EventArgs e)
        {
            c22MenuStripPiSystem.Show(btn24PIReports, _icurrMouseX, _icurrMouseY);
        }

        private void t1AboutAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pathname = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "0PackingInformationEntry.pptx";           
            cf.OpenFolderAndSelectFile(pathname);
        }




    }
}
