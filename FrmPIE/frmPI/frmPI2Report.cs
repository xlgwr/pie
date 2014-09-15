using FrmPIE._0API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrmPIE.frmPI
{
    public partial class frmPI2Report : Form
    {
        frmIDR _idr_show;
        Commfunction cf;

        public frmPI2Report(frmIDR idr)
        {
            _idr_show = idr;
            cf = new Commfunction(idr);

            InitializeComponent();
        }
    }
}
