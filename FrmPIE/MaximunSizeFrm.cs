using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FrmPIE
{
    public partial class MaximunSizeFrm : Form
    {
        DataSet _ds;
        public int _selectedindexrow;
        public int _selectedindexcol;
        string _strcolumn;
        string _strSameColumn;
        //public int _currentNewform = -1;
        Color _colors;

        public FrmPIE _FrmPIE_show;
        public MaximunSizeFrm(DataSet ds, string formText, int selectedindex, string strSamecolumn, string strcolumn, Color colors, FrmPIE FrmPIE_show)
        {
            _selectedindexrow = selectedindex;
            _strcolumn = strcolumn;
            _ds = ds;
            _strSameColumn = strSamecolumn;
            _colors = colors;

            _FrmPIE_show = FrmPIE_show;

            InitializeComponent();

            Text = formText;
            dataGVMax.DataSource = ds.Tables[0].DefaultView;

            dataGVMax.Refresh();


        }
        public MaximunSizeFrm()
        {
            InitializeComponent();
        }

        private void MaximunSizeFrm_Load(object sender, EventArgs e)
        {
            initWithHeight();
            if (_selectedindexrow > 0)
            {
                dataGVMax.Rows[_selectedindexrow].Cells[0].Selected = true;
            }
            dataGVMax.Columns[0].Frozen = true;
            dataGVMax.Columns[1].Frozen = true;
            lblmessage.Text = "RowsCount:" + _ds.Tables[0].Rows.Count;
        }

        private void initWithHeight()
        {
            groupBox1.Width = Width - groupBox1.Left - 30;

            groupBox1.Height = Height - groupBox1.Top - 50;

            dataGVMax.Width = groupBox1.Width - dataGVMax.Left - 10;

            dataGVMax.Height = groupBox1.Height - 20;
        }

        private void MaximunSizeFrm_Resize(object sender, EventArgs e)
        {
            initWithHeight();
        }


        private void MaximunSizeFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _FrmPIE_show._maximunfrm = null;
        }

        private void MaximunSizeFrm_Activated(object sender, EventArgs e)
        {
            _FrmPIE_show._maxactive = true;
        }

        private void dataGVMax_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGVMax.Rows.Count - 1)
            {
                _selectedindexrow = e.RowIndex;
                _FrmPIE_show._intVoidRightMenu2row = e.RowIndex;
                _FrmPIE_show.initEditMstr(dataGVMax, e.RowIndex, "e-Packing list Maintenance GVMax2");
            }
        }

        private void dataGVMax_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (dataGVMax.DataSource != null)
            {
                if (e.RowIndex >= 0 && e.RowIndex < dataGVMax.Rows.Count - 1)
                {
                    _selectedindexrow = e.RowIndex;
                    _selectedindexcol = e.ColumnIndex;
                    dataGVMax.ContextMenuStrip = _FrmPIE_show.contextMenuStripDataGVEdit;

                }
            }
        }

        private void dataGVMax_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            lblmessage.Text = "总计:" + (dataGVMax.Rows.Count - 1) + ",当前行:" + (e.RowIndex + 1) + ",当前列:" + (e.ColumnIndex + 1);
            string frmflag = Text.Substring(Text.Length - 1, 1);

            if (e.RowIndex >= 0 && e.RowIndex < dataGVMax.Rows.Count - 1)
            {
                string selectBatchID = dataGVMax.Rows[e.RowIndex].Cells["Batch_ID"].Value.ToString();


                //
                if (_FrmPIE_show._tDoWorkBackClorThread.ThreadState == ThreadState.Running)
                {
                    _FrmPIE_show._tDoWorkBackClorThread.Abort();
                }
                if (_FrmPIE_show._tDoWorkBackClorThread.ThreadState == ThreadState.Unstarted)
                {
                    DoWrokObject dwo = new DoWrokObject(dataGVMax, 3, e.RowIndex, _colors, _strSameColumn, _strcolumn, "Yes", Color.LightGray);
                    _FrmPIE_show._tDoWorkBackClorThread.Start(dwo);

                }
                if (_FrmPIE_show._tDoWorkBackClorThread.ThreadState == ThreadState.Stopped)
                {
                    _FrmPIE_show._tDoWorkBackClorThread = new Thread(new ParameterizedThreadStart(_FrmPIE_show.DoWorkdelegate));
                    DoWrokObject dwo = new DoWrokObject(dataGVMax, 3, e.RowIndex, _colors, _strSameColumn, _strcolumn, "Yes", Color.LightGray);
                    _FrmPIE_show._tDoWorkBackClorThread.Start(dwo);

                }
                // _FrmPIE_show.DoWorkdelegate(dataGVMax, 3, e.RowIndex, _colors, _strSameColumn, _strcolumn, "Yes", Color.LightGray);


                if (frmflag.Equals("2"))
                {
                    string selectCartonID = dataGVMax.Rows[e.RowIndex].Cells["CartonID"].Value.ToString();
                    _FrmPIE_show._intVoidRightMenu2row = e.RowIndex;
                    _FrmPIE_show._intVoidRightMenu2col = e.ColumnIndex;
                    _FrmPIE_show.data1GV2PackingListDetailTransferInfo2.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                    _FrmPIE_show.initDataGV_Tran4(selectBatchID, selectCartonID);
                }
                else if (frmflag.Equals("1"))
                {
                    _FrmPIE_show._intVoidRightMenu1row = e.RowIndex;
                    _FrmPIE_show._intVoidRightMenu1col = e.ColumnIndex;
                    _FrmPIE_show.data1GV1PackingListMasterInfo1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                    _FrmPIE_show.initDataGV_Tran4(selectBatchID);
                }
                else if (frmflag.Equals("3"))
                {
                    _FrmPIE_show._intVoidRightMenu3row = e.RowIndex;
                    _FrmPIE_show._intVoidRightMenu3col = e.ColumnIndex;
                    _FrmPIE_show.data2GV1CartonDetailInfo3.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                }

            }
        }
    }
}
