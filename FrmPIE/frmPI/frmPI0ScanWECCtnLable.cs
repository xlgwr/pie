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
using FrmPIE;

namespace frmPI
{
    public partial class frmPI0ScanWECCtnLable : Form
    {

        frmEnterTxt _frmET;
        frmIDR _idr_show;
        Commfunction cf;

        bool _addNextNewFalg = false;
        bool _validateBatchid = false;
        int _nextlineid = 1;
        string _strCO;
        DataSet cods;
        DataSet webserviceDS;

        string _strWecCtnSn = "";
        public bool _coisnull = false;
        public string _strconext = "";
        public string _plr_wec_ctn = "";

        public List<PIE.Model.plr_mstr_tran> _plr_mstr_tran_co_list = new List<PIE.Model.plr_mstr_tran>();
        public List<PI.Model.pi_det> _pi_det_model_co_list = new List<PI.Model.pi_det>();

        public PI.Model.pi_mstr _pi_mstr_model = new PI.Model.pi_mstr();
        public PI.Model.pi_det _pi_det_model = new PI.Model.pi_det();

        List<PIE.Model.plr_mstr_tran> _plr_mstr_tran_model_list;


        public frmPI0ScanWECCtnLable(frmIDR idr)
        {
            _idr_show = idr;
            cf = new Commfunction(idr);

            InitializeComponent();

            data1GVSanWecCtnLable.ReadOnly = true;

            _idr_show.tabCtlRight1.SelectedTab.Layout += SelectedTab_Enter;
            _idr_show.tabCtlRight1.SelectedTab.Resize += SelectedTab_Resize;

            data1GVSanWecCtnLable.RowEnter += data1GVSanWecCtnLable_RowEnter;

            initWidth();
            initCoCmpData();

            cmb4Pallet_PIScan.Items.Add(" ");

        }

        void data1GVSanWecCtnLable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DoWrokObject dwo = new DoWrokObject(data1GVSanWecCtnLable, 3, e.RowIndex, Color.LightGreen, "CartonID", "pi_status", "Yes", Color.LightGray);
            cf.initThreadDowrokColor(dwo);
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
            if (isnullempty(cmb2Type_ScanWECCTN, "Type must be has one.", "Error"))
            {
                return false;
            }
            if (isnullempty(cmb4Pallet_PIScan, "Pallet must be has one.", "Error") && !string.IsNullOrEmpty(txt1PIID_ScanWECCtnLable.Text.Trim()))
            {
                return false;
            }
            if (isnullempty(txt2SanWecCtnLable, "Please Scan the WEC Carton Label.", "Error"))
            {
                return false;
            }
            //if (cmb3CO_ScanWECCtnLable.SelectedItem == null)
            //{
            //    cmb3CO_ScanWECCtnLable.Focus();
            //    lbl0msg.Text = "Error:the CO is null, please enter the right one.";

            //    return false;
            //}
            return true;
        }
        private void ShowMsg(string msg, string title)
        {

            cf.SetCtlTextdelegate(lbl0msg, title + ":" + msg, true, true);
            //lbl0msg.Visible = true;
            //lbl0msg.Text = title + ":" + msg;
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
            var reobjdet = cf.initDataGVpi_det_join_grr(ctftdet, true, "nothing");
            if (reobjmstr != null)
            {
                initDatasetToTxt((PI.Model.pi_mstr)reobjmstr);
            }
        }
        private void pirefreshDelegate()
        {
            Commfunction.dvoidMethod me = new Commfunction.dvoidMethod(pirefresh);
            _idr_show.BeginInvoke(me);
        }
        private void initDGVDelegate(object strBatchID)
        {
            Commfunction.dinitDataGVSource me = new Commfunction.dinitDataGVSource(initDGV);
            _idr_show.BeginInvoke(me, strBatchID);
        }
        private void threadPiRefreshdeleget()
        {
            _idr_show._tRefresh = new Thread(pirefreshDelegate);
            if (_idr_show._tRefresh.ThreadState == ThreadState.Running)
            {
                _idr_show._tRefresh.Abort();
            }

            if (_idr_show._tRefresh.ThreadState == ThreadState.Unstarted)
            {
                _idr_show._tRefresh.Start();
            }
            if (_idr_show._tRefresh.ThreadState == ThreadState.Stopped)
            {
                _idr_show._tRefresh = new Thread(pirefreshDelegate);
                _idr_show._tRefresh.Start();
            }
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

            _coisnull = false;
            _pi_det_model_co_list.Clear();
            _plr_mstr_tran_co_list.Clear();

            if (!getCoValiteWecCtnID())
            {
                return;
            }
            if (!isnulltxt())
            {
                return;
            }
            _strWecCtnSn = txt2SanWecCtnLable.Text.Trim();
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

                cmb4Pallet_PIScan.Items.Clear();
                cmb4Pallet_PIScan.Items.Add("001");
                cmb4Pallet_PIScan.SelectedIndex = cmb4Pallet_PIScan.Items.Count - 1;

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
                if (string.IsNullOrEmpty(cmb4Pallet_PIScan.Text))
                {
                    cmb4Pallet_PIScan.Focus();
                    lbl0msg.Text = "Please select a Pallet Num.";
                    return;
                }
                foreach (var tran in _plr_mstr_tran_model_list)
                {
                    if (tran.plr_wec_ctn.Equals(txt2SanWecCtnLable.Text))
                    {


                        _pi_det_model.PI_ID = _pi_mstr_model.PI_ID;
                        _pi_det_model.pi_type = _pi_mstr_model.pi_type;
                        _pi_det_model.pi_LineID = _nextlineid;


                        _pi_det_model.pi_wec_ctn = tran.plr_wec_ctn;

                        _pi_det_model.plr_LineID_tran = tran.LineID;

                        //_pi_det_model.pi_pallet_no = tran.plr_pallet_no;

                        _pi_det_model.pi_deci1 = Convert.ToInt32(cmb4Pallet_PIScan.Text);
                        _pi_det_model.pi_pallet_no = txtPalletNW.Text;

                        _pi_det_model.CartonNo = tran.CartonNo;
                        _pi_det_model.CartonID = tran.CartonID;

                        _pi_det_model.pi_chr01 = _strCO;

                        _pi_det_model.pi_chr02 = tran.plr_po;
                        _pi_det_model.pi_remark = "New";
                        _pi_det_model.pi_cre_date = DbHelperSQL.getServerGetDate();
                        _pi_det_model.pi_user_ip = _idr_show._custip;
                        _pi_det_model.pi_status = "No";


                        var existBatchidLine = true;
                        while (existBatchidLine)
                        {
                            existBatchidLine = new PI.DAL.pi_det_ext().Exists(_pi_det_model.PI_ID, _pi_det_model.pi_LineID);
                            if (existBatchidLine)
                            {
                                ShowMsg("系统中已存在PIID：" + _pi_det_model.PI_ID + ",LineID:" + _pi_det_model.pi_LineID.ToString() + "，将修改LineID+1.", "Notice");

                                _pi_det_model.pi_LineID += 1;
                                //lbl3COScanWECCtnLable.Text = "下个为：PI ID:" + _pi_det_model.PI_ID + ",LineID:" + _pi_det_model.pi_LineID.ToString();
                            }


                        }
                        if (string.IsNullOrEmpty(tran.plr_co))
                        {
                            _coisnull = true;
                            _strconext = "";
                            _plr_mstr_tran_co_list.Add(tran);
                            _pi_det_model_co_list.Add(_pi_det_model);
                        }
                        else
                        {
                            PIE.Model.pkey_ctl existco = new PIE.DAL.pkey_ctl().GetModel("co", tran.plr_co, true);
                            if (existco == null)
                            {
                                _coisnull = true;
                                _strconext = "";
                                _plr_mstr_tran_co_list.Add(tran);
                                _pi_det_model_co_list.Add(_pi_det_model);
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
                        _strWecCtnSn = _pi_det_model.pi_wec_ctn;
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
                    ShowMsg("新增相同的PI ID,\t上次新增的为：" + _pi_det_model.PI_ID + ",LineID:" + _pi_det_model.pi_LineID.ToString() + "\nScanSN:" + _pi_det_model.pi_wec_ctn + ",Pallet#:" + _pi_det_model.pi_deci1.ToString("000"), "Notice");

                    lbl3COScanWECCtnLable.Text = "";

                }
                // co init
                if (_coisnull)
                {
                    frmCoMaint frmcomain = new frmCoMaint(this);
                    frmcomain.ShowDialog();
                }
                //////////////************************
                threadinitDVdelegate();


                if (string.IsNullOrEmpty(txtPalletNW.Text.Trim()))
                {
                    if (MessageBox.Show("Pallet# " + cmb4Pallet_PIScan.Text + " TTL NW is Null, are you add that?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        txtPalletNW.Focus();
                    }
                }


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
                var exist = new PIE.DAL.plr_mstr_tran_ext().Exists(txt2SanWecCtnLable.Text);
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
                        if (!_plr_mstr_tran_model_list[0].plr_deci1.ToString().Equals("1"))
                        {
                            ShowMsg(txt2SanWecCtnLable.Text + " has not Print Label, Can't Scan.", "Error");
                            return false;

                        }
                        if (!string.IsNullOrEmpty(_plr_mstr_tran_model_list[0].plr_chr01) && _plr_mstr_tran_model_list[0].plr_chr01.Equals("S"))
                        {
                            ShowMsg(txt2SanWecCtnLable.Text + " has being Scaning.", "Error");
                            //initfalse();
                            return false;

                        }
                        var strco = _plr_mstr_tran_model_list[0].plr_co;
                        if (string.IsNullOrEmpty(strco))
                        {
                            //initfalse();
                            if (string.IsNullOrEmpty(cmb3CO_ScanWECCtnLable.Text))
                            {
                                ShowMsg(txt2SanWecCtnLable.Text + " has no CO.", "Error");
                                //_coisnull = true;
                                //cmb3CO_ScanWECCtnLable.Focus();
                                //return false;
                            }
                            else
                            {
                                PIE.Model.pkey_ctl existco = new PIE.DAL.pkey_ctl().GetModel("co", cmb3CO_ScanWECCtnLable.Text, true);
                                if (existco != null)
                                {
                                    cmb3CO_ScanWECCtnLable.Text = existco.t_value + ":" + existco.t_desc;
                                    strco = existco.t_value + ":" + existco.t_desc;
                                    _strCO = strco;
                                    //return false;
                                }
                                else
                                {
                                    ShowMsg(cmb3CO_ScanWECCtnLable.Text + " has no Desc.", "Error: ");
                                    strco = "";
                                    //_coisnull = true;
                                    //cmb3CO_ScanWECCtnLable.Focus();
                                    //return false;
                                }
                            }
                        }
                        else
                        {
                            cmb3CO_ScanWECCtnLable.Text = strco;
                            for (int i = 0; i < cmb3CO_ScanWECCtnLable.Items.Count; i++)
                            {


                                var dindex = cmb3CO_ScanWECCtnLable.Items[i].ToString().StartsWith(strco);
                                if (dindex)
                                {
                                    cmb3CO_ScanWECCtnLable.SelectedIndex = i;
                                    break;
                                }
                            }
                            if (cmb3CO_ScanWECCtnLable.Text.Length > 0)
                            {
                                PIE.Model.pkey_ctl existco = new PIE.DAL.pkey_ctl().GetModel("co", cmb3CO_ScanWECCtnLable.Text, true);
                                if (existco != null)
                                {
                                    lbl3COScanWECCtnLable.Text = existco.t_value + ":" + existco.t_desc;
                                    strco = existco.t_value + ":" + existco.t_desc;
                                    _strCO = strco;
                                }
                                else
                                {
                                    ShowMsg(cmb3CO_ScanWECCtnLable.Text + " has no Desc.", "Error: ");
                                    cmb3CO_ScanWECCtnLable.Text = "";
                                    strco = "";
                                    //_coisnull = true;
                                    //cmb3CO_ScanWECCtnLable.Focus();
                                    // return false;
                                }
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

                        cmb4Pallet_PIScan.Items.Clear();
                        cmb4Pallet_PIScan.Items.Add(" ");

                        var ds = new PI.BLL.pi_det().GetList("PI_ID='" + txt1PIID_ScanWECCtnLable.Text.Trim() + "'");

                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                if (ds.Tables[0].Rows[i]["pi_deci1"] == DBNull.Value)
                                {
                                    continue;
                                }
                                var pallet = Convert.ToInt32(ds.Tables[0].Rows[i]["pi_deci1"]).ToString("000");
                                var strnw = ds.Tables[0].Rows[i]["pi_pallet_no"].ToString();

                                if (!cmb4Pallet_PIScan.Items.Contains(pallet))
                                {
                                    cmb4Pallet_PIScan.Items.Add(pallet);
                                    //var index = txtPalletNum.Items.IndexOf(li);
                                    //txtPalletNum.SelectedIndex = index;
                                }
                            }
                        }
                        cmb4Pallet_PIScan.SelectedIndex = -1;
                        cmb4Pallet_PIScan.Text = "";
                        //txt1PIID_ScanWECCtnLable.Text = _pi_mstr_model.PI_ID;
                        //initModelForTextBox(pi_det_new);

                        _addNextNewFalg = true;
                        var pre_pi_det = new PI.DAL.pi_det_ext().GetModel(pi_det_new.PI_ID, (_nextlineid - 1));
                        string premsg = "继续新增相同的PI ID";
                        if (pre_pi_det != null)
                        {
                            premsg += ",继续新增相同的PI ID,\t上次新增的为：" + pre_pi_det.PI_ID + ",LineID:" + pre_pi_det.pi_LineID + "\nScanSN:" + pre_pi_det.pi_wec_ctn + ",Pallet#:" + pre_pi_det.pi_deci1.ToString("000");

                        }
                        else
                        {
                            premsg += "，无上次扫描记录。";
                        }
                        ShowMsg(premsg, "Notice");
                        lbl0noticePiId.Text = premsg;
                        lbl3COScanWECCtnLable.Text = "";
                        //lbl0noticePiId.Text = "changed";
                        //////////////************************
                        threadinitDVdelegate();


                    }
                    else
                    {
                        ShowMsg(txt1PIID_ScanWECCtnLable.Text + " is not exist.", "Notice");
                        lbl0noticePiId.Text = txt1PIID_ScanWECCtnLable.Text + " is not exist.";
                        if (!string.IsNullOrEmpty(txt1PIID_ScanWECCtnLable.Text.Trim()))
                        {  //!string.IsNullOrEmpty(cmb4Pallet_PIScan.Text.Trim()) && 
                            txt1PIID_ScanWECCtnLable.Focus();
                            txt1PIID_ScanWECCtnLable.SelectionStart = txt1PIID_ScanWECCtnLable.Text.Length;
                        }
                        else
                        {
                            cmb4Pallet_PIScan.Focus();
                        }

                        return;
                    }
                }
                if (!string.IsNullOrEmpty(cmb4Pallet_PIScan.Text.Trim()))
                {
                    txt1PIID_ScanWECCtnLable.Focus();
                    txt1PIID_ScanWECCtnLable.SelectionStart = txt1PIID_ScanWECCtnLable.Text.Length;
                }
                else
                {
                    cmb4Pallet_PIScan.Focus();
                }
                txt2SanWecCtnLable.Text = "";
                cmb3CO_ScanWECCtnLable.SelectedIndex = -1;
                //txt2SanWecCtnLable.SelectAll();
            }
        }
        private void cmb3CO_ScanWECCtnLable_SelectedIndexChanged(object sender, EventArgs e)
        {
            // initCoDesc(sender, e);
        }
        private void cmb3CO_ScanWECCtnLable_SelectedValueChanged(object sender, EventArgs e)
        {
            // initCoDesc(sender, e);
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
            // initCoDesc(sender, e);
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
            if (txt2SanWecCtnLable.Text.Length >= 12)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btn0Scan_Click(sender, e);
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strmsg = "";
            if (txt2SanWecCtnLable.Text.Length > 0)
            {
                string strwhere = "pi_wec_ctn = '" + txt2SanWecCtnLable.Text.Trim() + "'";
                var pidetds = new PI.BLL.pi_det().GetList(strwhere);
                if (pidetds != null)
                {
                    data1GVSanWecCtnLable.DataSource = pidetds.Tables[0].DefaultView;
                    data1GVSanWecCtnLable.Refresh();
                    strmsg = "Notice: Inquire " + txt2SanWecCtnLable.Text + ", success.";
                }
                else
                {
                    data1GVSanWecCtnLable.DataSource = null;
                    data1GVSanWecCtnLable.Refresh();
                    strmsg = "Error: " + txt2SanWecCtnLable.Text + " is not exist.";
                }
            }
            else
            {

                strmsg = "Error: Scan SN is not exist.";
            }
            lbl0msg.Text = strmsg;
        }

        private void pirefresh()
        {
            cf.SetCtlTextdelegate(btn1RefreshPI, "Refresh....", false, true);
            ShowMsg(" Refresh ......", "Notice");
            DataSet ds;
            FrmPIE.WebReference100.Service server100 = new FrmPIE.WebReference100.Service();
            server100.Timeout = 90000;
            string existrir = "";
            string existrirsuccess = "";
            try
            {
                if (!string.IsNullOrEmpty(_pi_mstr_model.PI_ID))
                {
                    List<PI.Model.pi_det> pi_det_list = new PI.BLL.pi_det_ext().GetModelList("PI_ID='" + _pi_mstr_model.PI_ID + "'", true);
                    PI.Model.pisr_grr pisr_grr_model = new PI.Model.pisr_grr();


                    if (pi_det_list.Count > 0)
                    {
                        for (int i = 0; i < pi_det_list.Count; i++)
                        {
                            PIE.Model.plr_mstr_tran plr_mstr_tran_model = new PIE.DAL.plr_mstr_tran_ext().GetModel(pi_det_list[i].pi_wec_ctn);
                            if (plr_mstr_tran_model != null)
                            {

                                var existinit = cf.initWebServer(plr_mstr_tran_model.plr_po, server100, "wsas017", pi_det_list[i].pi_wec_ctn, out ds);
                                if (existinit)
                                {
                                    if (ds != null)
                                    {
                                        if (ds.Tables[0].Rows.Count > 0)
                                        {
                                            int dsexist = 0;
                                            int dscount = ds.Tables[0].Rows.Count;
                                            var addPisgrr = false;
                                            for (int y = 0; y < ds.Tables[0].Rows.Count; y++)
                                            {
                                                pisr_grr_model.pi_wec_ctn = ds.Tables[0].Rows[y]["wsas017_wec_id"].ToString();
                                                pisr_grr_model.plr_LineID_tran = Convert.ToInt32(ds.Tables[0].Rows[y]["wsas017_line"]);

                                                var existgrr = new PI.BLL.pisr_grr().Exists(pisr_grr_model.pi_wec_ctn, pisr_grr_model.plr_LineID_tran);
                                                pisr_grr_model.Plant = "0";

                                                if (existgrr)
                                                {
                                                    //if (i % 5 == 0)
                                                    //{

                                                    //    existrirsuccess += pi_det_list[i].pi_wec_ctn + ":" + pisr_grr_model.plr_LineID_tran + ",\n\t";
                                                    //}
                                                    //else
                                                    //{
                                                    //    existrirsuccess += pi_det_list[i].pi_wec_ctn + ":" + pisr_grr_model.plr_LineID_tran + ",";

                                                    //}
                                                    //if (string.IsNullOrEmpty(existrir))
                                                    //{

                                                    //    ShowMsg(existrirsuccess + " RiR 已更新.", "Notice0");
                                                    //}
                                                    //else
                                                    //{
                                                    //    ShowMsg(existrirsuccess + " RiR 已更新.\n\t" + existrir, "Notice0");
                                                    //}
                                                    dsexist++;
                                                    if (dsexist >= dscount)
                                                    {

                                                        ShowMsg(" All rows has alread Refresh RiR OK.", "Notice0");
                                                    }
                                                    continue;
                                                }
                                                pisr_grr_model.pisr_rir = ds.Tables[0].Rows[y]["wsas017_rir"].ToString();
                                                pisr_grr_model.pisr_invoice = ds.Tables[0].Rows[y]["wsas017_invoice"].ToString();

                                                pisr_grr_model.pisr_part = ds.Tables[0].Rows[y]["wsas017_part"].ToString();
                                                pisr_grr_model.pisr_site = ds.Tables[0].Rows[y]["wsas017_site"].ToString();
                                                pisr_grr_model.Pisr_receiver = ds.Tables[0].Rows[y]["wsas017_receiver"].ToString();
                                                pisr_grr_model.pisr_po_nbr = ds.Tables[0].Rows[y]["wsas017_po_nbr"].ToString();
                                                pisr_grr_model.pisr_qty = Convert.ToDecimal(ds.Tables[0].Rows[y]["wsas017_qty"].ToString());
                                                pisr_grr_model.pisr_curr = ds.Tables[0].Rows[y]["wsas017_curr"].ToString();
                                                pisr_grr_model.pisr_base_cost = Convert.ToDecimal(ds.Tables[0].Rows[y]["wsas017_base_cost"].ToString());
                                                pisr_grr_model.pisr_us_cost = Convert.ToDecimal(ds.Tables[0].Rows[y]["wsas017_us_cost"].ToString());
                                                pisr_grr_model.pisr_seq = ds.Tables[0].Rows[y]["wsas017_seq"].ToString();
                                                pisr_grr_model.pisr_con_code = ds.Tables[0].Rows[y]["wsas017_con_code"].ToString();
                                                pisr_grr_model.pisr_ch_desc = ds.Tables[0].Rows[y]["wsas017_ch_desc"].ToString();
                                                pisr_grr_model.pisr_net_wt = Convert.ToDecimal(ds.Tables[0].Rows[y]["wsas017_net_wt"].ToString());
                                                pisr_grr_model.pisr_rec_type = ds.Tables[0].Rows[y]["wsas017_rec_type"].ToString();
                                                pisr_grr_model.pisr_abc = ds.Tables[0].Rows[y]["wsas017_abc"].ToString();
                                                pisr_grr_model.pisr_code = ds.Tables[0].Rows[y]["wsas017_code"].ToString();
                                                pisr_grr_model.pisr_lic_req = ds.Tables[0].Rows[y]["wsas017_lic_req"].ToString();

                                                pisr_grr_model.pisr_sbu = ds.Tables[0].Rows[y]["wsas017_sbu"].ToString();
                                                pisr_grr_model.pisr_vend = ds.Tables[0].Rows[y]["wsas017_vend"].ToString();
                                                pisr_grr_model.pisr_mfgr_name = ds.Tables[0].Rows[y]["wsas017_mfgr_name"].ToString();

                                                pisr_grr_model.pisr_dec01 = Convert.ToDecimal(ds.Tables[0].Rows[y]["wsas017_k200_nw"].ToString()) / 1000;
                                                pisr_grr_model.pisr_dec02 = Convert.ToDecimal(ds.Tables[0].Rows[y]["wsas017_nw"].ToString()) / 1000;

                                                pisr_grr_model.pi_cre_date = DateTime.Now;
                                                pisr_grr_model.pi_update_date = DateTime.Now;
                                                pisr_grr_model.pi_user_ip = _idr_show._custip;
                                                pisr_grr_model.pi_cre_userid = _idr_show._sys_user_model.user_name;

                                                addPisgrr = new PI.BLL.pisr_grr().Add(pisr_grr_model);

                                            }
                                            if (addPisgrr)
                                            {
                                                ShowMsg(" Refresh RiR OK.", "Notice1");
                                            }
                                        }
                                        else
                                        {
                                            if (i > 0 && i % 8 == 0)
                                            {
                                                existrir += pi_det_list[i].pi_wec_ctn + ",\n\t";
                                            }
                                            else
                                            {
                                                existrir += pi_det_list[i].pi_wec_ctn + ",";

                                            }

                                            if (string.IsNullOrEmpty(existrirsuccess))
                                            {
                                                ShowMsg(existrir + " ERP 中 无 RiR 记录.", "Error0");
                                            }
                                            else
                                            {

                                                ShowMsg(existrir + " ERP 中 无 RiR 记录.\n\t" + existrirsuccess + " RiR 已更新.", "Error0");
                                            }
                                        }

                                    }
                                    else
                                    {
                                        ShowMsg(pi_det_list[i].pi_wec_ctn + " ERP 中 无 RiR 没有记录.", "Error1");
                                    }
                                }
                                else
                                {
                                    ShowMsg("WebServer 连接错误.", "Error2");
                                    break;
                                }
                            }
                            else
                            {
                                ShowMsg("没有扫描记录.", "Error3");
                            }
                        }

                    }
                    else
                    {
                        ShowMsg(" is no exist.", "Error4");

                    }


                }
                else
                {
                    ShowMsg("Ctn SN is null.", "Error");
                }

                cf.SetCtlTextdelegate(btn1RefreshPI, "Refresh", true, true);
                //////////////************************
                threadinitDVdelegate();
            }
            catch (Exception ex)
            {

                cf.SetCtlTextdelegate(btn1RefreshPI, "Refresh", true, true);
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            threadPiRefreshdeleget();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pis_grr_ds = new PI.BLL.pisr_grr().GetAllList();
            var pisr_ch_desc = pis_grr_ds.Tables[0].Rows[0]["pisr_ch_desc"].ToString();

            var pisr_ch_descutf8 = Encoding.GetEncoding("utf-8");
            var pisr_ch_desciso88 = Encoding.GetEncoding("GBK");
            byte[] temp = pisr_ch_descutf8.GetBytes(pisr_ch_desc);
            byte[] temp1 = Encoding.Convert(pisr_ch_descutf8, pisr_ch_desciso88, temp);
            string result = pisr_ch_descutf8.GetString(temp1);
            MessageBox.Show(result);
        }

        private void btnAddPalletNum_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt1PIID_ScanWECCtnLable.Text))
            {
                lbl0msg.Text = "PI ID is null";
                return;

            }
            var maxpallernum = new PI.DAL.pi_det_ext().GetMaxId(txt1PIID_ScanWECCtnLable.Text).ToString("000");
            if (!cmb4Pallet_PIScan.Items.Contains(maxpallernum))
            {

                cmb4Pallet_PIScan.Items.Add(maxpallernum);
            }

            cmb4Pallet_PIScan.SelectedIndex = cmb4Pallet_PIScan.Items.Count - 1;
            txt2SanWecCtnLable.Focus();
            txtPalletNW.Text = "";
        }

        private void btnAddPalletNW_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmb4Pallet_PIScan.Text) || string.IsNullOrEmpty(txtPalletNW.Text))
            {
                lbl0msg.Text = " Please select Pallet and NW must no null";
                return;
            }
            var strupdatenw = "update pi_det set pi_pallet_no='" + txtPalletNW.Text + "' where PI_ID='" + txt1PIID_ScanWECCtnLable.Text.Trim() + "' and pi_deci1='" + cmb4Pallet_PIScan.Text + "'";
            var intresult = DbHelperSQL.ExecuteSql(strupdatenw);
            if (intresult > 0)
            {
                txt2SanWecCtnLable.Focus();
                lbl0msg.Text = "Update NW of Pallet#: " + cmb4Pallet_PIScan.Text + " success.";
            }

        }

        private void cmb4Pallet_PIScan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmb4Pallet_PIScan.Text.Trim()))
            {

                txtPalletNW.Text = "";
                return;
            }
            var existpidet = new PI.DAL.pi_det_ext().GetModel(txt1PIID_ScanWECCtnLable.Text, Convert.ToInt32(cmb4Pallet_PIScan.SelectedItem), true);
            if (existpidet != null)
            {
                txtPalletNW.Text = existpidet.pi_pallet_no;
                if (string.IsNullOrEmpty(txtPalletNW.Text.Trim()))
                {
                    if (MessageBox.Show("Pallet TTL NW is Null, are you add that?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        txtPalletNW.Focus();
                    }
                }
            }
        }

        private void cmb4Pallet_PIScan_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(cmb4Pallet_PIScan.Text.Trim()) && !string.IsNullOrEmpty(txt1PIID_ScanWECCtnLable.Text.Trim()))
            {
                return;
            }
            if (e.KeyCode == Keys.Enter)
            {
                btn0Scan_Click(sender, e);
                if (string.IsNullOrEmpty(txt2SanWecCtnLable.Text.Trim()))
                {
                    txt2SanWecCtnLable.Focus();
                }
            }
        }

        private void txtPalletNW_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddPalletNW_Click(sender, e);
            }
        }


        void enquireByPart(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_frmET.textBox1.Text))
            {
                _frmET.textBox1.Focus();
                _validateBatchid = false;
                return;
            }
            var existPIAdd = new PI.DAL.pi_mstr_ext().GetModel(_frmET.textBox1.Text.Trim());

            if (existPIAdd != null)
            {
                ShowMsg(_frmET.textBox1.Text + "already has been Add with PI ID: " + existPIAdd.PI_ID, "Notice");
                _frmET.textBox1.Focus();
                _validateBatchid = false;
                return;
            }
            webserviceDS = cf.initWebServer("TESTOLDWEC", "wsas018", _frmET.textBox1.Text.Trim());

            if (webserviceDS == null)
            {
                lbl0msg.Text = _frmET.textBox1.Text + " is no exist.";
                _frmET.textBox1.Focus();
                _validateBatchid = false;
                return;
            }
            //else
            //{
            //    lbl0msg.Text = _frmET.textBox1.Text + " is add ok.";
            //    // data1GVSanWecCtnLable.DataSource = webserviceDS.Tables[0].DefaultView;

            //}
            //cf.EnquireByPart(data1GV1ePackingDet1_BatchInfo, "plr_partno", _frmET.textBox1.Text.Trim());
            _validateBatchid = true;
            _frmET.Close();
        }
        private void btn0AddFromePackingList0_Click(object sender, EventArgs e)
        {
            //btn0AddFromePackingList0.Enabled = false;

            _frmET = new frmEnterTxt(_idr_show, this);
            _frmET.button1.Click += enquireByPart;
            _frmET.lblTitle.Text = "BatchID:";
            _frmET.Text = "Add From ePacking List:";
            _frmET.ShowDialog();
            if (!_validateBatchid)
            {
                return;

            }
            if (webserviceDS != null)
            {
                #region add New PIID

                int intOutAffected;
                string strPIID = "";

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

                pi_mstr_model.pi_remark = "from ePakcking list";

                pi_mstr_model.pi_chr01 = _frmET.textBox1.Text.Trim();

                var result_plr_batch = new PI.DAL.pi_mstr().Add(pi_mstr_model);
                if (!result_plr_batch)
                {
                    ShowMsg("Add PI Mstr info fail", "Error");
                    return;
                }
                _pi_mstr_model = pi_mstr_model;
                #endregion
                for (int i = 0; i < webserviceDS.Tables[0].Rows.Count; i++)
                {
                    DataRow dr = webserviceDS.Tables[0].Rows[i];
                    var pi_det_model_add = new PI.Model.pi_det();
                    var pisr_grr_model_add = new PI.Model.pisr_grr();

                    #region add pi_det_model_from_batchid

                    pi_det_model_add.PI_ID = strPIID;
                    pi_det_model_add.pi_LineID = i + 1;
                    pi_det_model_add.pi_wec_ctn = dr["wsas018_wec_id"].ToString();
                    pi_det_model_add.plr_LineID_tran = dr["wsas018_line"] == DBNull.Value ? 0 : Convert.ToInt32(dr["wsas018_line"]);

                    pi_det_model_add.pi_type = "N";
                    pi_det_model_add.pi_deci1 = 0;
                    pi_det_model_add.pi_pallet_no = "";

                    pi_det_model_add.CartonNo = "0";
                    pi_det_model_add.CartonID = "0";

                    pi_det_model_add.pi_chr01 = "";


                    pi_det_model_add.pi_chr02 = dr["wsas018_po_nbr"].ToString();

                    pi_det_model_add.pi_remark = "Add From ePacking List:BatchID->" + dr["wsas018_batch"].ToString();

                    pi_det_model_add.pi_cre_date = DbHelperSQL.getServerGetDate();
                    pi_det_model_add.pi_user_ip = _idr_show._custip;
                    pi_det_model_add.pi_status = "No";

                    var result_pi_det_add = new PI.DAL.pi_det().Add(pi_det_model_add);
                    #endregion
                    #region add pisr_grr_model_add_fromBatchid
                    pisr_grr_model_add.pi_wec_ctn = dr["wsas018_wec_id"].ToString();
                    pisr_grr_model_add.plr_LineID_tran = dr["wsas018_line"] == DBNull.Value ? 0 : Convert.ToInt32(dr["wsas018_line"]);


                    pisr_grr_model_add.pisr_rir = dr["wsas018_rir"].ToString();
                    pisr_grr_model_add.pisr_invoice = dr["wsas018_invoice"].ToString();

                    pisr_grr_model_add.pisr_part = dr["wsas018_part"].ToString();
                    pisr_grr_model_add.pisr_site = dr["wsas018_site"].ToString();
                    pisr_grr_model_add.Pisr_receiver = dr["wsas018_receiver"].ToString();
                    pisr_grr_model_add.pisr_po_nbr = dr["wsas018_po_nbr"].ToString();
                    pisr_grr_model_add.pisr_qty = Convert.ToDecimal(dr["wsas018_qty"].ToString());
                    pisr_grr_model_add.pisr_curr = dr["wsas018_curr"].ToString();
                    pisr_grr_model_add.pisr_base_cost = Convert.ToDecimal(dr["wsas018_base_cost"].ToString());
                    pisr_grr_model_add.pisr_us_cost = Convert.ToDecimal(dr["wsas018_us_cost"].ToString());
                    pisr_grr_model_add.pisr_seq = dr["wsas018_seq"].ToString();
                    pisr_grr_model_add.pisr_con_code = dr["wsas018_con_code"].ToString();
                    pisr_grr_model_add.pisr_ch_desc = dr["wsas018_ch_desc"].ToString();
                    pisr_grr_model_add.pisr_net_wt = Convert.ToDecimal(dr["wsas018_net_wt"].ToString());
                    pisr_grr_model_add.pisr_rec_type = dr["wsas018_rec_type"].ToString();
                    pisr_grr_model_add.pisr_abc = dr["wsas018_abc"].ToString();
                    pisr_grr_model_add.pisr_code = dr["wsas018_code"].ToString();
                    pisr_grr_model_add.pisr_lic_req = dr["wsas018_lic_req"].ToString();

                    pisr_grr_model_add.pisr_sbu = dr["wsas018_sbu"].ToString();
                    pisr_grr_model_add.pisr_vend = dr["wsas018_vend"].ToString();
                    pisr_grr_model_add.pisr_mfgr_name = dr["wsas018_mfgr_name"].ToString();

                    pisr_grr_model_add.pisr_dec01 = Convert.ToDecimal(dr["wsas018_k200_nw"].ToString()) / 1000;
                    pisr_grr_model_add.pisr_dec02 = Convert.ToDecimal(dr["wsas018_nw"].ToString()) / 1000;

                    pisr_grr_model_add.pi_cre_date = DateTime.Now;
                    pisr_grr_model_add.pi_update_date = DateTime.Now;
                    pisr_grr_model_add.pi_user_ip = _idr_show._custip;
                    pisr_grr_model_add.pi_cre_userid = _idr_show._sys_user_model.user_name;

                    var pisgrradd = new PI.BLL.pisr_grr().Add(pisr_grr_model_add);
                    #endregion


                }
                ShowMsg("Add PI Mstr info Success", "Success");
            }
            else
            {
                ShowMsg("Add PI Mstr info fail,ERP WebService return null", "Error");
            }
            btn0AddFromePackingList0.Enabled = true;

        }












    }
}
