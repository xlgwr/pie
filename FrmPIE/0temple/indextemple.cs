using FrmPIE.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrmPIE
{

    public partial class Indextemple : Form
    {
        int currTabMouseUpIndex = 1;

        int currMouseX = 0;
        int currMouseY = 0;
        public Indextemple()
        {
            InitializeComponent();
            foreach (var item in tabCtlRight1.TabPages)
            {
                TabPage tp = (TabPage)item;
                tp.MouseDown += tp_MouseDown;
            }


        }
        private void Indextemple_Load(object sender, EventArgs e)
        {
            initHideImage(new object[] { hideLeftBarToolStripMenuItem2, hideLeftToolStripMenuItem3, status11toolBtnleft }, 1);

            initHideImage(new object[] { hideToolBarToolStripMenuItem1 }, 2);

            initCurrMouseXY(new object[] { btn1PackingListMaintain1, btn2GenCarton2, btn3PrintCartonLabel3 });

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

        private void button9_Click(object sender, EventArgs e)
        {
            addNewTabPage("NewPage");
        }

        private void addNewTabPage(string pagename)
        {
            tabCtlRight1.TabPages.Add(pagename + tabCtlRight1.TabCount, pagename + tabCtlRight1.TabCount);
            tabCtlRight1.SelectedIndex = tabCtlRight1.TabCount - 1;
            status12toolSStatusLblMsg.Text = tabCtlRight1.SelectedIndex.ToString() + "," + pagename;
        }


        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabCtlRight1.TabPages.RemoveAt(currTabMouseUpIndex);
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
                if (currTabMouseUpIndex == 0)
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
                status12toolSStatusLblMsg.Text = tabCtlRight1.TabPages[currTabMouseUpIndex].Name;
            }
        }

        private void tabCtlRight1_MouseMove(object sender, MouseEventArgs e)
        {

            for (int i = 0; i < tabCtlRight1.TabCount; i++)
            {
                Rectangle rect = tabCtlRight1.GetTabRect(i);
                if (rect.Contains(e.Location))
                {
                    currTabMouseUpIndex = i;
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
            var tb = tabCtlRight1.TabPages[currTabMouseUpIndex];
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

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void btnPackingListMaintain1_Click(object sender, EventArgs e)
        {
            cMenuStrip1PacklingListMain.Show(btn1PackingListMaintain1, currMouseX, currMouseY);
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
            currMouseX = e.X;
            currMouseY = e.Y;
            status13toolStripStatusLabel.Text = "Current Position: X:" + e.X + ",Y:" + e.Y;
        }

        private void btnGenCarton2_Click(object sender, EventArgs e)
        {
            cMenuStrip2CartonIDMain.Show(this.btn2GenCarton2, currMouseX, currMouseY);
        }

        private void btnPrintCartonLabel3_Click(object sender, EventArgs e)
        {
            cMenuStrip3PrintCartonLabel.Show(btn3PrintCartonLabel3, currMouseX, currMouseY);
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



    }
}
