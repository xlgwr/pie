using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrmPIE.frmPI
{
    public partial class frmCoMaint : Form
    {
        frmPI0ScanWECCtnLable _frmPI0ScanWECCtnLable;
        DataSet cods;
        int _intPlrLine;
        int _intNextPlrTranPart;
        int _countAllTranList;

        PI.Model.pi_det _pi_det_model_co = new PI.Model.pi_det();

        public frmCoMaint(frmPI0ScanWECCtnLable frm_PI0ScanWECCtnLable)
        {
            _frmPI0ScanWECCtnLable = frm_PI0ScanWECCtnLable;

            InitializeComponent();

            initCoCmpData();

            _countAllTranList = _frmPI0ScanWECCtnLable._plr_mstr_tran_co_list.Count;
        }

        private void frmCoMaint_Load(object sender, EventArgs e)
        {
            this.Text = "Update ScanSN: " + _frmPI0ScanWECCtnLable._pi_det_model.pi_wec_ctn + " CO ";
            txt1PIID_CoMaint.Text = _frmPI0ScanWECCtnLable._pi_det_model.PI_ID;
            txt2Pallet_CoMaint.Text = _frmPI0ScanWECCtnLable._pi_det_model.pi_deci1.ToString();
            txt3SanWecCtnLable_CoMaint.Text = _frmPI0ScanWECCtnLable._pi_det_model.pi_wec_ctn;
            if (_countAllTranList > 0)
            {
                txt4part_CoMaint.Text = _frmPI0ScanWECCtnLable._plr_mstr_tran_co_list[0].plr_partno;
                _intPlrLine = _frmPI0ScanWECCtnLable._plr_mstr_tran_co_list[0].LineID;
            }
            _intNextPlrTranPart = 0;

            cmb3CO_Maint.SelectedIndex = -1;
        }

        void initCoCmpData()
        {
            cods = new PIE.BLL.pkey_ctl().GetList("t_name='co'");
            cmb3CO_Maint.BeginUpdate();
            foreach (DataRow item in cods.Tables[0].Rows)
            {
                cmb3CO_Maint.Items.Add(item["t_value"]);
            }
            cmb3CO_Maint.EndUpdate();
            //cmb3CO_Maint.DataSource = cods.Tables[0].DefaultView;
            //cmb3CO_Maint.DisplayMember = "t_value";
            //cmb3CO_Maint.ValueMember = "t_desc";
            initCoDesc();

        }
        private void initCoDesc()
        {
            if (cmb3CO_Maint.SelectedItem != null)
            {
                PIE.Model.pkey_ctl pkey_model = new PIE.DAL.pkey_ctl().GetModel("co", cmb3CO_Maint.Text.ToLower(), true);
                if (pkey_model != null)
                {

                    lbl3COScanWECCtnLable.Text = pkey_model.t_desc;
                }
            }
        }

        private void btn0Scan_coMaint_Click(object sender, EventArgs e)
        {
            if (cmb3CO_Maint.SelectedItem != null)
            {
                _pi_det_model_co = new PI.DAL.pi_det_ext().GetModel(_frmPI0ScanWECCtnLable._pi_det_model.PI_ID, _frmPI0ScanWECCtnLable._pi_det_model.pi_wec_ctn, _intPlrLine);
                _pi_det_model_co.pi_chr01 = cmb3CO_Maint.Text;
                if (string.IsNullOrWhiteSpace(_pi_det_model_co.pi_chr01))
                {
                    lbl0msg.Text = "Please select the right CO.";
                    cmb3CO_Maint.Focus();
                    return;
                }
                var updatecoPi_dec = new PI.BLL.pi_det().Update(_pi_det_model_co);
                if (updatecoPi_dec)
                {
                    _intNextPlrTranPart++;

                    if (_intNextPlrTranPart >= _countAllTranList)
                    {
                        this.Hide();
                        return;
                    }
                    string nextpart = _frmPI0ScanWECCtnLable._plr_mstr_tran_co_list[_intNextPlrTranPart].plr_partno;
                    _intPlrLine = _frmPI0ScanWECCtnLable._plr_mstr_tran_co_list[_intNextPlrTranPart].LineID;

                    if (_intNextPlrTranPart < _countAllTranList)
                    {
                        lbl0msg.Text = "\tNotice,Update: " + txt4part_CoMaint.Text + " of Co:" + cmb3CO_Maint.Text + " Success.\nContinue next Part#: " + nextpart;
                        txt4part_CoMaint.Text = nextpart;
                        cmb3CO_Maint.SelectedIndex = -1;
                        cmb3CO_Maint.Text = "";
                        lbl3COScanWECCtnLable.Text = "";
                        cmb3CO_Maint.Focus();
                    }

                }
                else
                {
                    lbl0msg.Text = "Update fail.";
                    btn0Scan_coMaint.Focus();
                }
            }
            else
            {
                cmb3CO_Maint.Focus();
                lbl0msg.Text = "Error: Please select the right CO.";
            }
        }

        private void cmb3CO_Maint_TextChanged(object sender, EventArgs e)
        {
            if (cmb3CO_Maint.SelectedItem == null)
            {
                lbl3COScanWECCtnLable.Text = "";
            }
        }

        private void cmb3CO_Maint_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                initCoDesc();
                btn0Scan_coMaint_Click(sender, e);
            }
        }
    }
}
