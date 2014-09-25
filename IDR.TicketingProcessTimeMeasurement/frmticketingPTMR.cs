using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IDR.TicketingProcessTimeMeasurement
{
    public partial class frmticketingPTMR : Form
    {
        public string _clientIP = Program.getClientIP();
        public frmticketingPTMR()
        {
            InitializeComponent();
        }
        private void showScanID(int doType)
        {
            ScanID scanid = new ScanID(this, doType);
            scanid.Show();
            this.Hide();
        }
        private void btn1In_Click(object sender, EventArgs e)
        {
            showScanID(1);
        }

        private void btn2Back_Click(object sender, EventArgs e)
        {
            showScanID(2);
        }

        private void btn3Rece_Click(object sender, EventArgs e)
        {
            showScanID(3);
        }

        private void btn4Leave_Click(object sender, EventArgs e)
        {
            showScanID(4);
        }

        private void btn5PrintBar_Click(object sender, EventArgs e)
        {
            frmPrintLable frmpl = new frmPrintLable();
            frmpl.Show();
        }



    }
}
