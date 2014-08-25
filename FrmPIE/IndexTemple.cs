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

    public partial class IndexTemple : Form
    {
        int currTabMouseUpIndex = 1;
        public IndexTemple()
        {
            InitializeComponent();
            foreach (var item in tabCtlRight1.TabPages)
            {
                TabPage tp = (TabPage)item;
                tp.MouseDown += tp_MouseDown;
            }


        }
        private void IndexTemple_Load(object sender, EventArgs e)
        {
            initHideImage(new object[] { hideLeftBarToolStripMenuItem2, hideLeftToolStripMenuItem3, toolBtnleft1 }, 1);

            initHideImage(new object[] { hideToolBarToolStripMenuItem1 }, 2);
        }

        private void toolBtnleft1_ButtonClick(object sender, EventArgs e)
        {
            HideOrShowLeftBar(splitContainer2, 1, hideLeftToolStripMenuItem3, "Hide Left &Bar", "Show Left &Bar");

            HideOrShowleftorToolImg(splitContainer2, new object[] { toolBtnleft1, hideLeftBarToolStripMenuItem2, hideLeftToolStripMenuItem3 }, 1);
       
        }
        private void hideToolBarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            HideOrShowLeftBar(splitContainer1, 1, hideToolBarToolStripMenuItem1, "&Hide Tool Bar", "&Show Tool Bar");
            HideOrShowleftorToolImg(splitContainer1, new object[] { hideToolBarToolStripMenuItem1  }, 2);
        

           
        }

        private void hideLeftBarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            HideOrShowLeftBar(splitContainer2, 1, hideLeftBarToolStripMenuItem2, "Hide &Left Bar", "Show &Left Bar");
            HideOrShowleftorToolImg(splitContainer2, new object[] { toolBtnleft1, hideLeftBarToolStripMenuItem2, hideLeftToolStripMenuItem3 }, 1);
        }
        private void hideLeftToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            HideOrShowLeftBar(splitContainer2, 1, hideLeftToolStripMenuItem3, "Hide Left &Bar", "Show Left &Bar");

            HideOrShowleftorToolImg(splitContainer2, new object[] { toolBtnleft1, hideLeftBarToolStripMenuItem2, hideLeftToolStripMenuItem3 }, 1);
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
            toolSStatusLblMsg.Text = tabCtlRight1.SelectedIndex.ToString() + "," + pagename;
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
                toolSStatusLblMsg.Text = tp.Name;
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
                toolSStatusLblMsg.Text = tabCtlRight1.TabPages[currTabMouseUpIndex].Name;
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
                    toolSStatusLblMsg.Text = i.ToString() + "," + tabCtlRight1.TabPages[i].Name;
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


       


    }
}
