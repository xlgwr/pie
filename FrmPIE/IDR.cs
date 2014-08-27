﻿using FrmPIE._0API;
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

namespace FrmPIE
{


    public partial class frmIDR : Form
    {

        public Thread _tuploadExcel;
        public Thread _tuploadExcelInitGDV;

        public DataSet _batchMstr;

        public models.plr_batch_mstr _plr_batch_mstr_model;

        public string _custip = Program.getClientIP();

        int _icurrTabMouseUpIndex = 1;
        int _icurrAddGBtop = 0;
        int _icurrMouseX = 0;
        int _icurrMouseY = 0;
        public frmIDR()
        {
            InitializeComponent();
            foreach (var item in tabCtlRight1.TabPages)
            {
                TabPage tp = (TabPage)item;
                tp.MouseDown += tp_MouseDown;
            }


        }
        public class iform
        {

            public iform(frmIDR idr) { }
        }
        private void frmIDR_Load(object sender, EventArgs e)
        {
            initHideImage(new object[] { hideLeftBarToolStripMenuItem2, hideLeftToolStripMenuItem3, status11toolBtnleft }, 1);
            initHideImage(new object[] { hideToolBarToolStripMenuItem1 }, 2);

            initCurrMouseXY(new object[] { btn1PackingListMaintain1, btn2GenCarton2, btn3PrintCartonLabel3 });
            //Control.CheckForIllegalCrossThreadCalls = false;

        }
        protected override bool ProcessCmdKey(ref   Message msg, Keys keyData)
        {
            if (keyData == Keys.Down)
            {

                //keybd_event(9, 0, 0, 0);
                SendKeys.Send("{TAB}");

            }
            if (keyData == Keys.Up)
            {

                SendKeys.Send("+{TAB}");

            }
            return base.ProcessCmdKey(ref msg, keyData);

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
            if (_tuploadExcelInitGDV != null)
            {
                if (_tuploadExcelInitGDV.ThreadState == ThreadState.Running)
                {
                    _tuploadExcelInitGDV.Abort();
                }
            }

        }

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
            tabCtlRight1.TabPages.Add(pagename + tabCtlRight1.TabCount, pagename + tabCtlRight1.TabCount);

            tabCtlRight1.SelectedIndex = tabCtlRight1.TabCount - 1;
            status12toolSStatusLblMsg.Text = tabCtlRight1.SelectedIndex.ToString() + "," + pagename;

            tabCtlRight1.SelectedTab.AutoScroll = true;

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
                status12toolSStatusLblMsg.Text = tp.Name;
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
                status12toolSStatusLblMsg.Text = tabCtlRight1.TabPages[_icurrTabMouseUpIndex].Name;
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
                    status12toolSStatusLblMsg.Text = i.ToString() + "," + tabCtlRight1.TabPages[i].Name;
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
                Button btn = (Button)btnobj;
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
            addNewTabPage("Add New");
        }

        private void btn0Edit2_Click(object sender, EventArgs e)
        {
            addNewTabPage("Edit");
        }

        private void btn0Del3_Click(object sender, EventArgs e)
        {
            addNewTabPage("Delete");
        }

        private void btn0OK4_Click(object sender, EventArgs e)
        {
            addNewTabPage("Audit");
        }

        private void btn0Lock5_Click(object sender, EventArgs e)
        {
            addNewTabPage("Lock");
        }

        private void btn0Print6_Click(object sender, EventArgs e)
        {
            addNewTabPage("Printing");
        }

        private void btn0Down8_Click(object sender, EventArgs e)
        {
            addNewTabPage("Download");
        }

        private void btn0Find9_Click(object sender, EventArgs e)
        {
            addNewTabPage("Find Result");
        }
        public void addGBToTC(TabControl tc, GroupBox gb)
        {
            tc.SelectedTab.Controls.Add(gb);
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
        private void toolcMenu12AddOneByOneBatchID_Click(object sender, EventArgs e)
        {
            var tabpagenew = addNewTabPage("Add New(BatchID)");
            frm2AddNewBatchID fanb = new frm2AddNewBatchID(this);
            _icurrAddGBtop = fanb.groupBox0AddNewBatchID.Height;

            this.AcceptButton = fanb.btn1UpadeAddAddNewBatchID;
            addGBToTC(tabpagenew, fanb.groupBox0AddNewBatchID);
        }

    }
}
