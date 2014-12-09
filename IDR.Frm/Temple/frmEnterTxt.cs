using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MessageBox = System.Windows.Forms.MessageBox;

using System.Data.Entity;
using IDR.Common;
using IDR.Common.DEncrypt;
using IDR.Frm.API;
using IDR.EF.PIE;
using IDR.EF.PIRemote;
using System.Threading;

namespace IDR.Frm.Temple
{
    public partial class frmEnterTxt : Form
    {
        CommonAPI _comm;
        public PIE _dbpie { get; set; }

        //frm win

        public frmEnterTxt()
        {
            InitializeComponent();
            initFrm();
        }
        void initFrm()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point { X = Control.MousePosition.X - this.Width / 2, Y = Control.MousePosition.Y - this.Height };
            this.AcceptButton = btn00More;
            this.FormClosing += frmEnterTxt_FormClosing;

            _comm = new CommonAPI();
            _dbpie = new PIE();
            //init param
        }

        void frmEnterTxt_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_dbpie != null)
            {
                _dbpie.Dispose();
            }
            //throw new NotImplementedException();
        }
    }
}
