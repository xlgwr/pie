using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MessageBox = System.Windows.Forms.MessageBox;

using IDR.Frm.Logon;
using IDR.Frm.Properties;

using System.Data.Entity;
using IDR.Common;
using IDR.Common.DEncrypt;
using IDR.Frm.API;

using IDR.EF.PIE;
using IDR.EF.PIRemote;
using IDR.Frm.frmPIE;
using IDR.Frm.frmPI;

using System.Data.SqlClient;

namespace IDR.Frm
{
    public partial class Default : Form
    {
        CommonAPI cf;
        public PIE _dbpie { get; set; }
        public sys_user _system_user_exists { get; set; }
        //attribute

        public int _icurrMouseX { get; set; }
        public int _icurrMouseY { get; set; }

        public string _clientIP { get; set; }
        //model
        public plr_batch_mstr _plr_batch_mstr_model { get; set; }
        public pi_mstr _pi_mstr_model { get; set; }

        //attr for excel 
        public NPOI.HSSF.UserModel.HSSFWorkbook _hssfworkbook { get; set; }//xls
        public NPOI.XSSF.UserModel.XSSFWorkbook _xssfworkbook { get; set; }//xlsx

        //mouse move
        public int _icurrTabMouseUpIndex { get; set; }

        //frm win
        LogonDomain _logonDomain;

        public Default()
        {
            InitializeComponent();
            initFrm();
        }
        public Default(LogonDomain logonDomain, sys_user system_user_exists)
        {
            /////////////////init
            InitializeComponent();
            //////////////////////

            initFrm(logonDomain._dbpie);
            //////end

            _logonDomain = logonDomain;
            _system_user_exists = system_user_exists;
        }
        #region init
        private void initPara()
        {
            cf = new CommonAPI(this);
            _dbpie = new PIE();
            //param menu image
            initHideImage(new object[] { hideLeftBarToolStripMenuItem2, hideLeftToolStripMenuItem3, status11toolBtnleft }, 1);
            initHideImage(new object[] { hideToolBarToolStripMenuItem1 }, 2);
            //button menu
            initCurrMouseXY(new object[] { btn1PackingListMaintain1, btn2GenCarton2, btn3PrintCartonLabel3, btn21ScanCartronLabel21, btn24PIReports,
                                           linkLabel1, linkLabel2,linkLabel3,linkLabel4,linkLabel8});
            initContextMenuStrip(new object[] { btn1PackingListMaintain1, btn2GenCarton2, btn3PrintCartonLabel3, btn21ScanCartronLabel21, btn24PIReports,
                                           linkLabel1, linkLabel2,linkLabel3,linkLabel4,linkLabel8 });
            //tab mouse right
            this.tabCtlRight1.MouseMove += tabCtlRight1_MouseMove;
            this.tabCtlRight1.MouseUp += tabCtlRight1_MouseUp;
            //init param
            _clientIP = Program._clientIP;
            _plr_batch_mstr_model = new plr_batch_mstr();
            _pi_mstr_model = new pi_mstr();
            _system_user_exists = new sys_user();
        }
        void initFrm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;

            this.txt0SearchID.Enter += txt0SearchID_Enter;
            //init fun,para;
            initPara();
        }
        void initFrm(PIE dbpie)
        {
            initFrm();
            _dbpie = dbpie;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            //
            if (this._logonDomain != null)
            {
                this._logonDomain.Dispose();

            }
            if (this._dbpie != null)
            {
                this._dbpie.Dispose();
            }
            GC.Collect();
            
        }
        void txt0SearchID_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btn0Find9;
            //throw new NotImplementedException();
        }
        void tabCtlRight1_MouseMove(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < tabCtlRight1.TabCount; i++)
            {
                Rectangle rect = tabCtlRight1.GetTabRect(i);
                if (rect.Contains(e.Location))
                {
                    _icurrTabMouseUpIndex = i;
                    status13toolSStatusLblMsg.Text = i.ToString() + "," + tabCtlRight1.TabPages[i].Name;
                    status14toolLabelCellRowColXY.Text = "";
                    status15toolLabelstrResult.Text = "";
                    break;
                }
            }
        }
        void tabCtlRight1_MouseUp(object sender, MouseEventArgs e)
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
            //throw new NotImplementedException();
        }

        public DateTime getServerGetDate()
        {
            try
            {
                SqlParameter[] parameters = {
                                            new SqlParameter("@date",SqlDbType.DateTime)
                                        };
                parameters[0].Direction = ParameterDirection.Output;
                var dateTmp = _dbpie.Database.SqlQuery<DateTime>("select getdate();", parameters[0]).SingleOrDefault();

                return Convert.ToDateTime(dateTmp);
            }
            catch (Exception)
            {
                return DateTime.Now;
            }

        }
        #endregion

        #region menu

        private void initHideImage(object[] ts, int imagIndex)
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
            //throw new NotImplementedException();
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

            //throw new NotImplementedException();
        }

        private void HideOrShowLeftBar(SplitContainer sc, int PanelNum, ToolStripMenuItem tsi, string Hidetest, string ShowText)
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
            //throw new NotImplementedException();
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

        private void status11toolBtnleft_ButtonClick(object sender, EventArgs e)
        {
            HideOrShowLeftBar(splitContainer2, 1, hideLeftToolStripMenuItem3, "Hide Left &Bar", "Show Left &Bar");
            HideOrShowleftorToolImg(splitContainer2, new object[] { status11toolBtnleft, hideLeftBarToolStripMenuItem2, hideLeftToolStripMenuItem3 }, 1);
        }
        private void hideLeftToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            HideOrShowLeftBar(splitContainer2, 1, hideLeftToolStripMenuItem3, "Hide Left &Bar", "Show Left &Bar");
            HideOrShowleftorToolImg(splitContainer2, new object[] { status11toolBtnleft, hideLeftBarToolStripMenuItem2, hideLeftToolStripMenuItem3 }, 1);
        }
        private void t1AboutAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pathname = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "0PackingInformationEntry.pptx";
            cf.OpenFolderAndSelectFile(pathname);
        }
        #endregion

        #region button menu

        private void initContextMenuStrip_Click(object sender, EventArgs e)
        {
            var lk = (Control)sender;
            lk.ContextMenuStrip.Show(lk, _icurrMouseX, _icurrMouseY);
        }
        private void initContextMenuStrip(object[] p)
        {
            foreach (var item in p)
            {
                var lk = (Control)item;
                lk.Click += initContextMenuStrip_Click;
            }
        }
        void btn_MouseMove(object sender, MouseEventArgs e)
        {
            _icurrMouseX = e.X;
            _icurrMouseY = e.Y;
            //status13toolStripStatusLabel.Text = "Current Position: X:" + e.X + ",Y:" + e.Y;
        }
        private void initCurrMouseXY(object[] buttonobjs)
        {
            foreach (var btnobj in buttonobjs)
            {
                Control btn = (Control)btnobj;
                btn.MouseMove += btn_MouseMove;
            }
            //throw new NotImplementedException();
        }
        #endregion

        #region ContextMenuStrip
        public void addGBToTC(TabControl tc, Control cl)
        {
            tc.SelectedTab.Controls.Add(cl);
            clearnotice();
        }
        public void addGBToTC(TabPage tp, GroupBox gb)
        {
            tp.Controls.Add(gb);
            clearnotice();
        }
        private TabPage addNewTabPage(string pagename)
        {
            tabCtlRight1.TabPages.Add(tabCtlRight1.TabCount + ":" + pagename, tabCtlRight1.TabCount + ":" + pagename);

            tabCtlRight1.SelectedIndex = tabCtlRight1.TabCount - 1;
            status13toolSStatusLblMsg.Text = tabCtlRight1.SelectedIndex.ToString() + "," + pagename;

            tabCtlRight1.SelectedTab.AutoScroll = true;

            return tabCtlRight1.SelectedTab;
            //throw new NotImplementedException();
        }
        public TabPage addNewTabPage(string pagename, bool develop)
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
        void clearnotice()
        {
            //status13toolSStatusLblMsg.Text = "";
            status14toolLabelCellRowColXY.Text = "";
            status15toolLabelstrResult.Text = "";
            status16toolLabelstrSameColumnCount.Text = "";
        }
        private void toolcMenu11UploadEPackingListExcel_Click(object sender, EventArgs e)
        {
            addNewTabPage("Upload EPacking List From Excel");
            frm111UploadExcel fu = new frm111UploadExcel(this);
            addGBToTC(tabCtlRight1, fu.gb0frmUploadExcel);
        }

        #endregion
        #region tab control right click
        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabCtlRight1.TabPages.RemoveAt(_icurrTabMouseUpIndex);
            tabCtlRight1.SelectedIndex = tabCtlRight1.TabCount - 1;
        }
        private void closeAllToolStripMenuItem2_Click(object sender, EventArgs e)
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
        #endregion

        #region left button menu
        private void btn1Home1_Click(object sender, EventArgs e)
        {
            tabCtlRight1.SelectedIndex = 0;
            clearnotice();
        }
        #endregion

        private void btn0Find9_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt0SearchID.Text.Trim()))
            {
                if (cmb1SearchType.Text.Equals("BatchID"))
                {
                    var exist = _dbpie.plr_batch_mstr.Find(txt0SearchID.Text.Trim());
                    if (exist != null)
                    {
                        string strtitle = "Find " + cmb1SearchType.Text + ":" + txt0SearchID.Text.Trim() + "Result";
                        var tpg = addNewTabPage(strtitle);
                        this._plr_batch_mstr_model.batch_id = txt0SearchID.Text.Trim();
                        frm0BatchInfo bi = new frm0BatchInfo(this);
                        addGBToTC(tpg, bi.gb0BatchInfo0);
                    }
                    else
                    {
                        lbl0SearchError.Text = "Error:Batch Mstr " + txt0SearchID.Text + " is not exist.";
                        txt0SearchID.SelectionStart = txt0SearchID.Text.Length;
                    }

                }
                else if (cmb1SearchType.Text.Equals("PI ID"))
                {
                    var exist = _dbpie.pi_mstr.Find(txt0SearchID.Text.Trim(), 1);
                    if (exist != null)
                    {
                        string strtitle = "Find " + cmb1SearchType.Text + ":" + txt0SearchID.Text.Trim() + "Result";
                        var tpg = addNewTabPage(strtitle);
                        this._pi_mstr_model.PI_ID = txt0SearchID.Text.Trim();
                        frmPI0PIInfo bi = new frmPI0PIInfo(this);
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

    }
}
