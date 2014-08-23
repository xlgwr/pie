using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrmPIE
{
    public partial class EnterPassword : Form
    {
        public EnterPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (textBox1.Text=="xxx888")
                {
                    this.Hide();
                    AdminManage adminform = new AdminManage();
                    adminform.ShowDialog();
                } 
            }
        }
    }
}
