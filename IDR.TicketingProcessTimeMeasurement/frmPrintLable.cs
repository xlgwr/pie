using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using PIE.Common;

namespace IDR.TicketingProcessTimeMeasurement
{
    public partial class frmPrintLable : Form
    {
        StringBuilder strtxt;

        public frmPrintLable()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(comboBox1.Text))
            {
                comboBox1.Focus();
                lblMsg.Text = "Please select the size.";
                return;
            }
            if (!PageValidate.IsNumber(txt0From.Text.Trim()))
            {
                txt0From.Focus();
                lblMsg.Text = "Please enter the right number.";
                return;
            }
            if (!PageValidate.IsNumber(txt2To.Text.Trim()))
            {
                txt2To.Focus();
                lblMsg.Text = "Please enter the right number.";
                return;
            }
            var numfrom = Convert.ToInt32(txt0From.Text.Trim());
            var numto = Convert.ToInt32(txt2To.Text.Trim());

            string strBar;
            string print_port = "LPT1";
            string resultmsg = "Notice: 打印 " + comboBox1.Text + numfrom.ToString() + " To " + comboBox1.Text + numto.ToString();
            if (numto < numfrom)
            {
                txt2To.Focus();
                lblMsg.Text = "To must be more than from.";
                return;
            }
            while (numfrom <= numto)
            {
                strBar = comboBox1.Text + numfrom;
                printtwc(strBar);
                numfrom++;
            }

            if (Xprint.XPrint.Print(strtxt.ToString(), print_port))
            {
                resultmsg += " 成功。";
            }
            else
            {
                resultmsg += " 失败,本地打印端口:" + print_port + "打开失败或打印机未就绪。";
            }
            lblMsg.Text = resultmsg;
        }
        public void printtwc(string strXBRB)
        {

            strtxt = new StringBuilder();

            int x = 0;
            int y = 60;
            int xoff = 0;
            int yoff = 35;
            #region TEC
            strtxt.AppendLine("{D0410,0762,0380|}");
            strtxt.AppendLine("{C|}");
            strtxt.AppendLine("{U2;0030|}");
            strtxt.AppendLine("{AX;+000,+000,+00|}");
            strtxt.AppendLine("{AY;+10,0|}");

            strtxt.AppendLine("{XB01;0065,0020,9,3,02,1,0105,+0000000000,000,1,00|}");
            strtxt.AppendLine("{RB01;>8" + strXBRB + "|}");

            strtxt.AppendLine(@"{PC005;0165,0200,07,07,D,33,B|}");
            strtxt.AppendLine(@"{RC005;WEC|}");


            strtxt.AppendLine("{XB01;0450,0020,9,3,02,3,0105,+0000000000,000,1,00|}");
            strtxt.AppendLine("{RB01;>8" + strXBRB + "|}");

            strtxt.AppendLine("{XS;I,0001,0002C3200|}");
            strtxt.AppendLine("{U1;0030|}");
            #endregion
        }

        private void frmPrintLable_Load(object sender, EventArgs e)
        {
            txt0From.Focus();
            this.AcceptButton = button1;
        }
    }
}
