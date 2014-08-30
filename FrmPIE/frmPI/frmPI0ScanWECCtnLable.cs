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
using System.Threading;

namespace FrmPIE.frmPI
{
    public partial class frmPI0ScanWECCtnLable : Form
    {
        frmIDR _idr_show;
        Commfunction cf;

        bool _addNextNewFalg = false;
        int _nextlineid = 1;
        DataSet cods;

        PI.Model.pi_mstr _pi_mstr_model = new PI.Model.pi_mstr();
        PI.Model.pi_det _pi_det_model = new PI.Model.pi_det();

        List<PIE.Model.plr_mstr_tran> _plr_mstr_tran_model_list;


        public frmPI0ScanWECCtnLable(frmIDR idr)
        {
            _idr_show = idr;
            cf = new Commfunction(idr);

            InitializeComponent();
            _idr_show.tabCtlRight1.SelectedTab.Layout += SelectedTab_Enter;
            _idr_show.tabCtlRight1.SelectedTab.Resize += SelectedTab_Resize;
            initWidth();
            initCoCmpData();

        }
        void initCoCmpData()
        {
            cods = new PIE.BLL.pkey_ctl().GetList("t_name='co'");
            cmb3CO_ScanWECCtnLable.BeginUpdate();
            foreach (DataRow item in cods.Tables[0].Rows)
            {
                cmb3CO_ScanWECCtnLable.Items.Add(item["t_value"]);
            }
            cmb3CO_ScanWECCtnLable.EndUpdate();
            //cmb3CO_ScanWECCtnLable.DataSource = cods.Tables[0].DefaultView;
            //cmb3CO_ScanWECCtnLable.DisplayMember = "t_value";
            //cmb3CO_ScanWECCtnLable.ValueMember = "t_desc";
            initCoDesc();

        }
        void SelectedTab_Resize(object sender, EventArgs e)
        {
            initWidth();
        }

        private void initWidth()
        {
            groupBox1.Width = groupBox1ScanWECCtnLable.Width - groupBox1.Left;
            groupBox2.Width = groupBox1.Width;
            group3BXdataGV1ScanList.Width = groupBox1.Width;

            group3BXdataGV1ScanList.Height = groupBox1ScanWECCtnLable.Height - group3BXdataGV1ScanList.Top - 5;
        }

        void SelectedTab_Enter(object sender, EventArgs e)
        {
            initWidth();
            //_idr_show.AcceptButton = btn0Scan;
            txt1PIID_ScanWECCtnLable.Focus();
        }

        private void frmPI0ScanWECCtnLable_Load(object sender, EventArgs e)
        {
            txt1PIID_ScanWECCtnLable.Focus();
        }
        public bool isnullempty(Control tb, string msg, string title)
        {
            if (string.IsNullOrEmpty(tb.Text))
            {
                ShowMsg(msg, title);
                tb.Focus();
                tb.Select();
                return true;
            }
            return false;
        }
        private bool isnulltxt()
        {
            if (isnullempty(txt1PIID_ScanWECCtnLable, "PI ID if is Null,System Will be Generate new one", "Notice"))
            {
                lbl0noticePiId.Text = "PI ID if is Null,System Will be Generate new one";
            }
            if (isnullempty(cmb1Plant_ScanWECCtnLable, "Plant must be has one.", "Error"))
            {
                return false;
            }
            if (isnullempty(cmb1Plant_ScanWECCtnLable, "Plant must be has one.", "Error"))
            {
                return false;
            }
            if (isnullempty(cmb2Type_ScanWECCTN, "Plant must be has one.", "Error"))
            {
                return false;
            }
            if (isnullempty(txt2SanWecCtnLable, "Please Scan the WEC Carton Label.", "Error"))
            {
                return false;
            }
            if (cmb3CO_ScanWECCtnLable.SelectedItem == null)
            {
                cmb3CO_ScanWECCtnLable.Focus();
                lbl0msg.Text = "Error:the CO is null, please enter the right one.";

                return false;
            }
            return true;
        }
        private void ShowMsg(string msg, string title)
        {
            lbl0msg.Visible = true;
            lbl0msg.Text = title + ":" + msg;
        }
        private void initDatasetToTxt(PI.Model.pi_mstr model)
        {
            txt1PIID_ScanWECCtnLable.Text = model.PI_ID;
            cmb1Plant_ScanWECCtnLable.Text = model.Plant;
            cmb2Type_ScanWECCTN.Text = model.pi_type;

        }
        private void initDGV(object strBatchID)
        {
            CartonFromTo ctftmstr = new CartonFromTo(data1GVSanWecCtnLable, (string)strBatchID, 1, "add", _idr_show._custip, _idr_show._custip);
            CartonFromTo ctftdet = new CartonFromTo(data1GVSanWecCtnLable, (string)strBatchID, 0, "add", _idr_show._custip, _idr_show._custip);

            var reobjmstr = cf.initDataGVpi_mstr(ctftmstr, false, "model");
            var reobjdet = cf.initDataGVpi_det(ctftdet, true, "nothing");
            if (reobjmstr != null)
            {
                initDatasetToTxt((PI.Model.pi_mstr)reobjmstr);
            }
        }
        private void initDGVDelegate(object strBatchID)
        {
            Commfunction.dinitDataGVSource me = new Commfunction.dinitDataGVSource(initDGV);
            _idr_show.BeginInvoke(me, strBatchID);
        }
        private void threadinitDVdelegate()
        {
            _idr_show._tInitGDV = new Thread(initDGVDelegate);
            if (_idr_show._tInitGDV.ThreadState == ThreadState.Running)
            {
                _idr_show._tInitGDV.Abort();
            }

            if (_idr_show._tInitGDV.ThreadState == ThreadState.Unstarted)
            {
                _idr_show._tInitGDV.Start(_pi_mstr_model.PI_ID);
            }
            if (_idr_show._tInitGDV.ThreadState == ThreadState.Stopped)
            {
                _idr_show._tInitGDV = new Thread(initDGVDelegate);
                _idr_show._tInitGDV.Start(_pi_mstr_model.PI_ID);
            }
        }

        private void btn0Scan_Click(object sender, EventArgs e)
        {
            int intOutAffected;
            string strPIID = "";
            bool result_pi_det = false;
            if (!getCoValiteWecCtnID())
            {
                return;
            }
            if (!isnulltxt())
            {
                return;
            }
            if (!_addNextNewFalg || !_pi_mstr_model.PI_ID.Equals(txt1PIID_ScanWECCtnLable.Text.Trim()))
            {
                #region add New PIID



                PI.Model.pi_mstr pi_mstr_model = new PI.Model.pi_mstr();
                SqlParameter[] parameters = {
                                            new SqlParameter("@PIID",SqlDbType.NVarChar,11)
                                        };
                parameters[0].Direction = ParameterDirection.Output;

                DbHelperSQL.RunProcedure("sp_GetPIID", parameters, out intOutAffected);
                strPIID = parameters[0].Value != null ? parameters[0].Value.ToString() : "";
                if (string.IsNullOrEmpty(strPIID))
                {
                    ShowMsg("生成PIID,出错，无法新增。", "Error");
                    return;
                }
                pi_mstr_model.PI_ID = strPIID;
                pi_mstr_model.LineID = 1;
                pi_mstr_model.Plant = cmb1Plant_ScanWECCtnLable.Text.Trim();
                pi_mstr_model.pi_type = cmb2Type_ScanWECCTN.Text.Trim();

                pi_mstr_model.pi_cre_date = DbHelperSQL.getServerGetDate();
                pi_mstr_model.pi_update_date = pi_mstr_model.pi_cre_date;
                pi_mstr_model.pi_user_ip = _idr_show._custip;
                pi_mstr_model.pi_status = "No";

                var result_plr_batch = new PI.DAL.pi_mstr().Add(pi_mstr_model);
                if (!result_plr_batch)
                {
                    ShowMsg("Add PI Mstr info fail", "Error");
                    return;
                }
                _pi_mstr_model = pi_mstr_model;
                #endregion


            }
            if (_plr_mstr_tran_model_list.Count > 0)
            {
                foreach (var tran in _plr_mstr_tran_model_list)
                {
                    if (tran.plr_wec_ctn.Equals(txt2SanWecCtnLable.Text))
                    {
                        _pi_det_model.PI_ID = _pi_mstr_model.PI_ID;
                        _pi_det_model.pi_type = _pi_mstr_model.pi_type;
                        _pi_det_model.pi_LineID = _nextlineid;
                        _pi_det_model.pi_wec_ctn = tran.plr_wec_ctn;

                        _pi_det_model.plr_LineID_tran = tran.LineID;
                        _pi_det_model.pi_pallet_no = tran.plr_pallet_no;
                        _pi_det_model.CartonNo = tran.CartonNo;
                        _pi_det_model.CartonID = tran.CartonID;

                        _pi_det_model.pi_chr01 = cmb3CO_ScanWECCtnLable.Text;
                        _pi_det_model.pi_remark = "New";
                        _pi_det_model.pi_cre_date = DbHelperSQL.getServerGetDate();
                        _pi_det_model.pi_user_ip = _idr_show._custip;
                        _pi_det_model.pi_status = "No";

                        var existBatchidLine = true;
                        while (existBatchidLine)
                        {
                            existBatchidLine = new PI.DAL.pi_det().Exists(_pi_det_model.PI_ID, _pi_det_model.pi_LineID, _pi_det_model.pi_wec_ctn);
                            if (existBatchidLine)
                            {
                                ShowMsg("系统中已存在PIID：" + _pi_det_model.PI_ID + ",LineID:" + _pi_det_model.pi_LineID.ToString() + "，将修改LineID+1.", "Notice");

                                _pi_det_model.pi_LineID += 1;
                                //lbl3COScanWECCtnLable.Text = "下个为：PI ID:" + _pi_det_model.PI_ID + ",LineID:" + _pi_det_model.pi_LineID.ToString();
                            }


                        }
                        result_pi_det = new PI.DAL.pi_det().Add(_pi_det_model);
                        if (result_pi_det)
                        {
                            tran.plr_chr01 = "S";
                            tran.plr_update_date = DateTime.Now;
                            var updatescan = new PIE.BLL.plr_mstr_tran().Update(tran);
                        }
                        _nextlineid = _pi_det_model.pi_LineID;
                    }
                }
            }


            if (result_pi_det)
            {

                txt2SanWecCtnLable.Text = "";
                cmb3CO_ScanWECCtnLable.SelectedIndex = -1;
                lbl0msg.Text = "";
                txt2SanWecCtnLable.Focus();
                _addNextNewFalg = true;

                if (string.IsNullOrEmpty(_pi_mstr_model.PI_ID))
                {

                    ShowMsg("新增新的PI ID", "Notice");
                }
                else
                {
                    PI.Model.pi_det pi_det_new = new PI.Model.pi_det();
                    pi_det_new.PI_ID = _pi_det_model.PI_ID;
                    pi_det_new.pi_LineID = _pi_det_model.pi_LineID + 1;
                    _nextlineid = pi_det_new.pi_LineID;
                    txt1PIID_ScanWECCtnLable.Text = _pi_mstr_model.PI_ID;

                    //initModelForTextBox(pi_det_new);
                    _addNextNewFalg = true;
                    ShowMsg("新增相同的PI ID,\t上次新增的为：" + _pi_det_model.PI_ID + ",LineID:" + _pi_det_model.pi_LineID.ToString(), "Notice");

                    lbl3COScanWECCtnLable.Text = "";

                }
                //////////////************************
                threadinitDVdelegate();

            }
            else
            {
                ShowMsg("Scan Add fail", "Error");
            }

        }

        private void txt2SanWecCtnLable_TextChanged(object sender, EventArgs e)
        {
            lbl5lengthWecCtn.Text = txt2SanWecCtnLable.Text.Length.ToString();
            cf.initScanTXT(txt2SanWecCtnLable, 15, 12);
            if (txt2SanWecCtnLable.Text.Length >= 12)
            {
                if (!getCoValiteWecCtnID())
                {
                    return;
                }
            }

        }


        private bool getCoValiteWecCtnID()
        {
            if (string.IsNullOrEmpty(txt2SanWecCtnLable.Text))
            {
                return false;
            }
            if (txt2SanWecCtnLable.Text.Length >= 12)
            {
                var exist = new PIE.DAL.plr_mstr_tran().Exists(txt2SanWecCtnLable.Text);
                if (!exist)
                {
                    ShowMsg(txt2SanWecCtnLable.Text + "(len:" + txt2SanWecCtnLable.Text.Length + ") Wec Ctn Lable ID（len must be 12) is not exist.", "Error");
                    initfalse();
                    return false;
                }
                _plr_mstr_tran_model_list = new PIE.BLL.plr_mstr_tran().GetModelList("plr_wec_ctn='" + txt2SanWecCtnLable.Text + "'");
                if (_plr_mstr_tran_model_list != null)
                {

                    if (_plr_mstr_tran_model_list.Count > 0)
                    {
                        if (!string.IsNullOrEmpty(_plr_mstr_tran_model_list[0].plr_chr01) && _plr_mstr_tran_model_list[0].plr_chr01.Equals("S"))
                        {
                            ShowMsg(txt2SanWecCtnLable.Text + " has being Scaning.", "Error");
                            initfalse();
                            return false;

                        }
                        var strco = _plr_mstr_tran_model_list[0].plr_co;
                        if (string.IsNullOrEmpty(strco))
                        {
                            ShowMsg(txt2SanWecCtnLable.Text + " has no Co.", "Error");
                            cmb3CO_ScanWECCtnLable.Focus();
                            initfalse();
                            return false;
                        }
                        for (int i = 0; i < cmb3CO_ScanWECCtnLable.Items.Count; i++)
                        {

                            var dindex = cmb3CO_ScanWECCtnLable.Items[i].ToString().StartsWith(strco);
                            if (dindex)
                            {
                                cmb3CO_ScanWECCtnLable.SelectedIndex = i;
                                break;
                            }
                        }
                        return true;
                    }
                    else
                    {
                        ShowMsg(txt2SanWecCtnLable.Text + " Wec Ctn Lable ID has be Scaning over.", "Notice");
                        initfalse();
                        return false;
                    }

                }
                else
                {

                    ShowMsg(txt2SanWecCtnLable.Text + "(len:" + txt2SanWecCtnLable.Text.Length + ") Wec Ctn Lable ID（len must be 12) is not exist.", "Error");
                    initfalse();
                    return false;
                }

            }


            initfalse();
            return false;
        }

        private void initfalse()
        {
            txt2SanWecCtnLable.Focus();
            txt2SanWecCtnLable.SelectionStart = txt2SanWecCtnLable.Text.Length;
            lbl3COScanWECCtnLable.Text = "";
        }

        private void txt1PIID_ScanWECCtnLable_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt1PIID_ScanWECCtnLable.Text.Length > 0)
                {
                    lbl0noticePiId.Text = "";

                    var strexist = new PI.BLL.pi_mstr().Exists(txt1PIID_ScanWECCtnLable.Text.Trim(), 1);
                    if (strexist)
                    {
                        _pi_mstr_model = new PI.BLL.pi_mstr().GetModel(txt1PIID_ScanWECCtnLable.Text.Trim(), 1);
                        var detds = new PI.BLL.pi_det().GetList("PI_ID='" + txt1PIID_ScanWECCtnLable.Text.Trim() + "'");

                        PI.Model.pi_det pi_det_new = new PI.Model.pi_det();

                        pi_det_new.PI_ID = _pi_mstr_model.PI_ID;

                        _nextlineid = cf.getMaxOrMinColumnFromDataTable(detds.Tables[0], "pi_LineID", true, false) + 1;

                        pi_det_new.pi_LineID = _nextlineid;


                        //txt1PIID_ScanWECCtnLable.Text = _pi_mstr_model.PI_ID;
                        //initModelForTextBox(pi_det_new);

                        _addNextNewFalg = true;
                        ShowMsg("继续新增相同的PI ID,\t上次新增的为：" + pi_det_new.PI_ID + ",LineID:" + (_nextlineid - 1), "Notice");
                        lbl0noticePiId.Text = "Notice: 继续新增相同的PI ID,\t上次新增的为：" + pi_det_new.PI_ID + ",LineID:" + (_nextlineid - 1);
                        lbl3COScanWECCtnLable.Text = "";
                        //lbl0noticePiId.Text = "changed";
                        //////////////************************
                        threadinitDVdelegate();
                    }
                    else
                    {

                        lbl0noticePiId.Text = txt1PIID_ScanWECCtnLable.Text + " is not exist.";
                    }
                }
                txt2SanWecCtnLable.Text = "";
                cmb3CO_ScanWECCtnLable.SelectedIndex = -1;
                txt2SanWecCtnLable.Focus();
                //txt2SanWecCtnLable.SelectAll();
            }
        }
        private void cmb3CO_ScanWECCtnLable_SelectedIndexChanged(object sender, EventArgs e)
        {
            initCoDesc(sender, e);
        }
        private void cmb3CO_ScanWECCtnLable_SelectedValueChanged(object sender, EventArgs e)
        {
            initCoDesc(sender, e);
        }
        private void initCoDesc()
        {
            if (cmb3CO_ScanWECCtnLable.SelectedItem != null)
            {
                PIE.Model.pkey_ctl pkey_model = new PIE.DAL.pkey_ctl().GetModel("co", cmb3CO_ScanWECCtnLable.Text.ToLower(), true);
                if (pkey_model != null)
                {

                    lbl3COScanWECCtnLable.Text = pkey_model.t_desc;
                }
            }
        }
        private void initCoDesc(object sender, EventArgs e)
        {
            if (cmb3CO_ScanWECCtnLable.SelectedItem != null)
            {
                PIE.Model.pkey_ctl pkey_model = new PIE.DAL.pkey_ctl().GetModel("co", cmb3CO_ScanWECCtnLable.Text.ToLower(), true);
                if (pkey_model != null)
                {

                    lbl3COScanWECCtnLable.Text = pkey_model.t_desc;
                }
            }
            btn0Scan_Click(sender, e);
        }

        private void cmb3CO_ScanWECCtnLable_TextChanged(object sender, EventArgs e)
        {
            if (cmb3CO_ScanWECCtnLable.SelectedItem == null)
            {
                lbl3COScanWECCtnLable.Text = "";
            }
            initCoDesc(sender, e);
        }

        private void cmb3CO_ScanWECCtnLable_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn0Scan_Click(sender, e);
            }
        }

        private void txt2SanWecCtnLable_Enter(object sender, EventArgs e)
        {
            lbl0msg.Text = "";
            lbl0noticePiId.Text = "";
            if (txt2SanWecCtnLable.Text.Length >= 12)
            {
                if (!getCoValiteWecCtnID())
                {
                    return;
                }
                else
                {
                    btn0Scan_Click(sender, e);
                }
            }


            txt2SanWecCtnLable.SelectionStart = txt2SanWecCtnLable.Text.Length;
        }

        private void txt2SanWecCtnLable_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!getCoValiteWecCtnID())
                {
                    return;
                }
                else
                {
                    btn0Scan_Click(sender, e);
                }
            }

        }












    }
}
