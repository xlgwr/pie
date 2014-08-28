using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using MessageBox = System.Windows.Forms.MessageBox;

using FrmPIE._0API;
using PIE.DBUtility;
using System.Data.SqlClient;
using PIE.Common;

namespace FrmPIE.frmPI
{
    public partial class frmPI0ScanWECCtnLable : Form
    {
        frmIDR _idr_show;
        commfunction cf;

        public frmPI0ScanWECCtnLable(frmIDR idr)
        {
            _idr_show = idr;
            cf = new commfunction();

            InitializeComponent();
        }

        private void frmPI0ScanWECCtnLable_Load(object sender, EventArgs e)
        {

        }
    }
}
