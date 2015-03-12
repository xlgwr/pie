using FrmIDR._0API;
using FrmPIE.Properties;
using PIE.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrmPIE.frmPIE
{
    public partial class frm614ScanForASN<T, G> : Form
        where T : Form, iform
        where G : DataGridView
    {
        frmIDR _idr_show;
        T _obj0from;
        G _obj1DGV;
        IList<string> _tmpSearchTxT;
        Commfunction<T> cf;
        public frm614ScanForASN()
        {
            InitializeComponent();
        }
        public frm614ScanForASN(frmIDR idr, T objform, G tmpDGV, string subject)
        {
            cf = new Commfunction<T>(idr, objform);
            _idr_show = idr;
            _obj0from = objform;
            _obj1DGV = tmpDGV;

            InitializeComponent();

            this.Text = subject;
            _tmpSearchTxT = new List<string>{
                "plr_po",
                "plr_partno"
            };

            if (tmpDGV.RowCount > 0)
            {
                txt1BatchIDAddNewBatchID.Text = tmpDGV.Rows[0].Cells[0].Value.ToString().Trim();
            }
            initVal();
            initWidth();
        }

        private void initVal()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point { X = Control.MousePosition.X - this.Width / 3, Y = Control.MousePosition.Y + 15 };
            this.Icon = Resources.t__13_;

            this.Resize += frm614ScanForASN_Resize;
        }

        void frm614ScanForASN_Resize(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            initWidth();
        }

        private void initWidth()
        {
            gb0ScanTxt.Width = this.Width - 30;

            txt0Scan.Width = gb0ScanTxt.Width - 65;
            btn1Clear.Left = gb0ScanTxt.Width - 55;
            lblMsg.Width = txt0Scan.Width;

            gb2det_BatchInfo.Width = gb0ScanTxt.Width;
            gb2det_BatchInfo.Height = this.Height - gb2det_BatchInfo.Top - 50;
        }

        private void frm614ScanForASN_Load(object sender, EventArgs e)
        {

        }
        public string[] removePrefxi(string scantxt)
        {
            string tmpprefix = "3N3;3N4;3N5";
            string tmpSplit = "/ ";

            var tmpPF = tmpprefix.Split(';');

            foreach (var item in tmpPF)
            {
                if (scantxt.StartsWith(item, StringComparison.CurrentCultureIgnoreCase))
                {
                    scantxt = scantxt.Substring(item.Length);
                }
            }
            return scantxt.Split(tmpSplit.ToCharArray());
        }
        private void txt0Scan_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt0Scan_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                string tmpScanTxt = txt0Scan.Text.Trim();

                var tmpScanTxtSplit = removePrefxi(tmpScanTxt);
                foreach (var item in tmpScanTxtSplit)
                {
                    tmpScanTxt = item;
                    if (tmpScanTxt.Length < 8)
                    {
                        if (PageValidate.IsNumber(tmpScanTxt))
                        {
                            findinDgvCheckScanQty(txt9QTYAddNewBatchID, txt8CartonQtyAddNewBatchID, tmpScanTxt);
                            txt0Scan.Text = "";
                            return;
                        }
                        else
                        {
                            if (tmpScanTxt.Length == 5 || tmpScanTxt.Length == 4)
                            {
                                if (PageValidate.IsNumber(tmpScanTxt.Substring(1)))
                                {
                                    txt10CartonIDAddNewBatchID.Text = tmpScanTxt;
                                    txt0Scan.Text = "";
                                    return;
                                }
                            }
                        }

                    }
                    if (string.IsNullOrEmpty(txt7PartAddNewBatchID.Text)
                    || string.IsNullOrEmpty(txt5POAddNewBatchID.Text))
                    {
                        var tmpresult = findinDgv(tmpScanTxt, _tmpSearchTxT);

                        if (tmpresult.Equals("plr_partno"))
                        {
                            txt7PartAddNewBatchID.Text = tmpScanTxt;
                            lblMsg.Text = "Success: Find PartNo->" + tmpScanTxt + " in Data Items.";
                            findinDgvCheck(txt5POAddNewBatchID, txt7PartAddNewBatchID);
                        }
                        else if (tmpresult.Equals("plr_po"))
                        {
                            txt5POAddNewBatchID.Text = tmpScanTxt;
                            lblMsg.Text = "Success: Find Po->" + tmpScanTxt + " in Data Items.";
                            findinDgvCheck(txt5POAddNewBatchID, txt7PartAddNewBatchID);
                        }
                        else
                        {
                            lblMsg.Text = "Error: Can't Find " + tmpScanTxt + " in Data Items.";
                        }
                    }
                    else
                    {
                        findinDgvCheck(txt5POAddNewBatchID, txt7PartAddNewBatchID);
                    }

                }

                txt0Scan.Text = "";
            }
        }
        private void findinDgvCheckScanQty(TextBox tbqty, TextBox tbqtyCarton, string scanNum)
        {
            if (string.IsNullOrEmpty(tbqtyCarton.Text))
            {
                tbqtyCarton.Text = scanNum;
            }
            else if (string.IsNullOrEmpty(tbqty.Text))
            {
                tbqty.Text = scanNum;
            }

            if (!string.IsNullOrEmpty(tbqty.Text) && !string.IsNullOrEmpty(tbqtyCarton.Text))
            {
                var tmpqty = Convert.ToInt32(tbqty.Text);
                var tmpqtycarton = Convert.ToInt32(tbqtyCarton.Text);
                var maxmin = 0;
                var tmpscanqty = Convert.ToInt32(scanNum);

                if (tmpqty < tmpqtycarton)
                {
                    tbqty.Text = tmpqtycarton.ToString();
                    tbqtyCarton.Text = tmpqty.ToString();
                    maxmin = tmpqty;
                    tmpqty = tmpqtycarton;
                    tmpqtycarton = maxmin;
                }

                if (tmpscanqty > tmpqty)
                {
                    tbqty.Text = scanNum;
                }
                else if (tmpscanqty < tmpqty && tmpscanqty < tmpqtycarton)
                {
                    tbqtyCarton.Text = scanNum;
                }
                else if (tmpscanqty < tmpqty && tmpscanqty > tmpqtycarton)
                {
                    tbqtyCarton.Text = scanNum;
                }


            }
        }
        private void findinDgvCheck(TextBox tbpo, TextBox tbpart)
        {
            if (!string.IsNullOrEmpty(tbpart.Text) && !string.IsNullOrEmpty(tbpo.Text))
            {
                if (findinDgv(tbpo.Text.Trim(), tbpart.Text.Trim()))
                {
                    lblMsg.Text = "Notice: Po and PartNo has been find OK.";
                }
                else
                {
                    lblMsg.Text = "Error: Po->" + tbpo.Text +
                        " and PartNo->" + tbpart.Text + " is not find in Data items.Please Checking.";
                    tbpo.Text = "";
                    tbpart.Text = "";

                }
            }

        }
        public bool findinDgv(string tmpo, string tmppart)
        {
            //"plr_po",
            //  "plr_partno"
            for (int i = 0; i < _obj1DGV.RowCount - 1; i++)
            {
                DataGridViewRow tmpRow = _obj1DGV.Rows[i];
                if (tmpRow.Cells["plr_po"].Value.ToString().ToUpper().Equals(tmpo.ToUpper())
                    && tmpRow.Cells["plr_partno"].Value.ToString().ToUpper().Equals(tmppart.ToUpper()))
                {
                    _obj1DGV.Rows[i].Cells[0].Selected = true;
                    txt2LineIDAddNewBatchID.Text = _obj1DGV.Rows[i].Cells[1].Value.ToString();
                    return true;
                }
            }
            return false;
        }
        public string findinDgv(string tmpsearch, IList<string> tColname)
        {

            if (tColname.Count > 0)
            {
                for (int i = 0; i < _obj1DGV.RowCount - 1; i++)
                {
                    DataGridViewRow tmpRow = _obj1DGV.Rows[i];
                    foreach (string item in tColname)
                    {
                        if (tmpRow.Cells[item].Value.ToString().ToUpper().Equals(tmpsearch.ToUpper()))
                        {
                            _obj1DGV.Rows[i].Cells[0].Selected = true;
                            return item;
                        }
                    }

                }
            }
            return "nothing";
        }

        private void txt5POAddNewBatchID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1Clear_Click(object sender, EventArgs e)
        {
            clear();

        }
        void clear()
        {
            txt0Scan.Text = "";
            txt2LineIDAddNewBatchID.Text = "";
            txt3PalletNoAddNewBatchID.Text = "";
            txt5POAddNewBatchID.Text = "";
            txt7PartAddNewBatchID.Text = "";
            txt8CartonQtyAddNewBatchID.Text = "";
            txt9QTYAddNewBatchID.Text = "";
            txt10CartonIDAddNewBatchID.Text = "";
            txt12CartonprifixAddNewBatchID.Text = "";
            txt14CartonIDFromAddNewBatchID.Text = "0";
            txt15CartonIDToAddNewBatchID.Text = "0";

            txt0Scan.Focus();

        }
        private void ShowMsg(string msg, string title)
        {
            this.lblMsg.Visible = true;
            this.lblMsg.Text = title + ":" + msg;
        }
        private void ShowMsg(Control ct, string msg, string title)
        {
            ct.Visible = true;
            ct.Text = title + ":" + msg;
        }
        public bool isNumber(TextBox tb)
        {
            if (!PageValidate.IsNumber(tb.Text))
            {
                tb.Focus();
                tb.SelectAll();
                ShowMsg("请输入正确的数字，谢谢.", "Notice");

                return true;
            }
            return false;
        }
        public bool isnullempty(TextBox tb, string msg, string title)
        {
            if (string.IsNullOrEmpty(tb.Text))
            {
                ShowMsg(msg, title);
                tb.Focus();
                return true;
            }
            return false;
        }

        private bool isnulltxt()
        {
            if (isnullempty(txt1BatchIDAddNewBatchID, "BatchID must has one", "Error"))
            {
                return false;
            }
            if (isnullempty(txt2LineIDAddNewBatchID, "LineId must has one", "Error"))
            {
                return false;
            }
            if (isnullempty(txt3PalletNoAddNewBatchID, "PalletNo must has one", "Error"))
            {
                return false;
            }
            //if (isnullempty(txt4InvoiceIDAddNewBatchID, "InvoiceID must has one", "Error"))
            //{
            //    return false;
            //}
            if (isnullempty(txt5POAddNewBatchID, "PO must be has.", "Error"))
            {
                return false;
            }
            //if (isnullempty(txt6PackingListIDAddNewBatchID, " PackingListID  must has one", "Error"))
            //{
            //    return false;
            //}
            if (isnullempty(txt7PartAddNewBatchID, "Part must be has.", "Error"))
            {
                return false;
            }
            if (isnullempty(txt8CartonQtyAddNewBatchID, "CartonQty must be has.", "Error"))
            {
                return false;
            }
            //number
            if (isNumber(txt8CartonQtyAddNewBatchID))
            {
                return false;
            }
            if (isnullempty(txt9QTYAddNewBatchID, "QTY must be has.", "Error"))
            {
                return false;
            }
            //number 
            if (isNumber(txt9QTYAddNewBatchID))
            {
                return false;
            }
            if (isnullempty(txt10CartonIDAddNewBatchID, "CartonID must be has.", "Error"))
            {
                return false;
            }
            //if (isnullempty(txt11CartonTypeAddNewBatchID, "Number of Carton must be has.", "Error"))
            //{
            //    return false;
            //}
            ////number
            //if (isNumber(txt11CartonTypeAddNewBatchID))
            //{
            //    return false;
            //}


            if (!PageValidate.IsNumber(txt14CartonIDFromAddNewBatchID.Text) || !PageValidate.IsNumber(txt15CartonIDToAddNewBatchID.Text))
            {
                ShowMsg("Carton ID must like Numert or NumA-NumB,example C1-10 or 10 or 1-10.", "Error");
                txt10CartonIDAddNewBatchID.SelectAll();
                txt10CartonIDAddNewBatchID.Focus();
                return false;
            }
            var cartonfrom = Convert.ToInt32(txt14CartonIDFromAddNewBatchID.Text);
            var cartonto = Convert.ToInt32(txt15CartonIDToAddNewBatchID.Text);

            if (cartonfrom > cartonto)
            {
                ShowMsg("Carton ID must like 10 or 1-10", "Error");
                txt10CartonIDAddNewBatchID.SelectAll();
                txt10CartonIDAddNewBatchID.Focus();
                return false;
            }
            return true;

        }
        private void btn0Save_Click(object sender, EventArgs e)
        {
            if (!isnulltxt())
            {
                return;
            };

            PIE.Model.plr_mstr plr_mstr_model = new PIE.Model.plr_mstr();

            plr_mstr_model.plr_doc_type = "e-Packing-asn";
            plr_mstr_model.CartonType = "";

            plr_mstr_model.Batch_ID = txt1BatchIDAddNewBatchID.Text.Trim();
            plr_mstr_model.LineID = Convert.ToInt32(txt2LineIDAddNewBatchID.Text.Trim());
            plr_mstr_model.plr_pallet_no = txt3PalletNoAddNewBatchID.Text.Trim();
            plr_mstr_model.plr_po = txt5POAddNewBatchID.Text.Trim();
            plr_mstr_model.plr_partno = txt7PartAddNewBatchID.Text.Trim();
            plr_mstr_model.plr_carton_qty = Convert.ToDecimal(txt8CartonQtyAddNewBatchID.Text.Trim());
            plr_mstr_model.plr_qty = Convert.ToDecimal(txt9QTYAddNewBatchID.Text.Trim());
            plr_mstr_model.CartonID = txt10CartonIDAddNewBatchID.Text.Trim();
            plr_mstr_model.carton_id_prifix = txt12CartonprifixAddNewBatchID.Text.Trim();
            plr_mstr_model.carton_id_from = Convert.ToInt32(txt14CartonIDFromAddNewBatchID.Text.Trim());
            plr_mstr_model.carton_id_to = Convert.ToInt32(txt15CartonIDToAddNewBatchID.Text.Trim());


            var intresutl = Program.GenCartonNoAsn(plr_mstr_model);
            if (intresutl == 0)
            {
                _obj0from.refreshDGV();
                clear();
                lblMsg.Text = "Success: Save Ok,Scan Next";

            }
            else if (intresutl == 3)
            {
                lblMsg.Text = "Error: Carton ID->" + txt10CartonIDAddNewBatchID.Text + " is exist";
            }
        }
    }
}
