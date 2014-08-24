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
        public IndexTemple()
        {
            InitializeComponent();
        }
        private void hideToolBarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            HideOrShowLeftBar(splitContainer1, 1, hideToolBarToolStripMenuItem1, "&Hide Tool Bar", "&Show Tool Bar");
        }

        private void hideLeftBarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            HideOrShowLeftBar(splitContainer2, 1, hideLeftBarToolStripMenuItem2, "Hide &Left Bar", "Show &Left Bar");
        }
        private void hideLeftToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            HideOrShowLeftBar(splitContainer2, 1, hideLeftToolStripMenuItem3, "Hide Left &Bar", "Show Left &Bar");
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


    }
}
