namespace FrmPIE
{
    partial class frmUpload
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpload));
            this.groupBox1frmUpload = new System.Windows.Forms.GroupBox();
            this.data1GV1PackingListMasterInfo1 = new System.Windows.Forms.DataGridView();
            this.lbl1UploadExcelThreadMsg = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelectfile = new System.Windows.Forms.Button();
            this.txtExcelFile = new System.Windows.Forms.TextBox();
            this.btnCmdUpd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1frmUpload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data1GV1PackingListMasterInfo1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1frmUpload
            // 
            this.groupBox1frmUpload.Controls.Add(this.button1);
            this.groupBox1frmUpload.Controls.Add(this.data1GV1PackingListMasterInfo1);
            this.groupBox1frmUpload.Controls.Add(this.lbl1UploadExcelThreadMsg);
            this.groupBox1frmUpload.Controls.Add(this.groupBox2);
            this.groupBox1frmUpload.Controls.Add(this.btnCmdUpd);
            this.groupBox1frmUpload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1frmUpload.Location = new System.Drawing.Point(0, 0);
            this.groupBox1frmUpload.Name = "groupBox1frmUpload";
            this.groupBox1frmUpload.Size = new System.Drawing.Size(781, 472);
            this.groupBox1frmUpload.TabIndex = 0;
            this.groupBox1frmUpload.TabStop = false;
            this.groupBox1frmUpload.Resize += new System.EventHandler(this.groupBox1frmUpload_Resize);
            // 
            // data1GV1PackingListMasterInfo1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data1GV1PackingListMasterInfo1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data1GV1PackingListMasterInfo1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data1GV1PackingListMasterInfo1.DefaultCellStyle = dataGridViewCellStyle2;
            this.data1GV1PackingListMasterInfo1.Location = new System.Drawing.Point(6, 149);
            this.data1GV1PackingListMasterInfo1.MultiSelect = false;
            this.data1GV1PackingListMasterInfo1.Name = "data1GV1PackingListMasterInfo1";
            this.data1GV1PackingListMasterInfo1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data1GV1PackingListMasterInfo1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.data1GV1PackingListMasterInfo1.RowTemplate.Height = 23;
            this.data1GV1PackingListMasterInfo1.Size = new System.Drawing.Size(769, 317);
            this.data1GV1PackingListMasterInfo1.TabIndex = 15;
            // 
            // lbl1UploadExcelThreadMsg
            // 
            this.lbl1UploadExcelThreadMsg.AutoSize = true;
            this.lbl1UploadExcelThreadMsg.ForeColor = System.Drawing.Color.Red;
            this.lbl1UploadExcelThreadMsg.Location = new System.Drawing.Point(52, 133);
            this.lbl1UploadExcelThreadMsg.Name = "lbl1UploadExcelThreadMsg";
            this.lbl1UploadExcelThreadMsg.Size = new System.Drawing.Size(0, 12);
            this.lbl1UploadExcelThreadMsg.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSelectfile);
            this.groupBox2.Controls.Add(this.txtExcelFile);
            this.groupBox2.Location = new System.Drawing.Point(48, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 70);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "选择上传的Excel文件";
            // 
            // btnSelectfile
            // 
            this.btnSelectfile.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectfile.Location = new System.Drawing.Point(6, 21);
            this.btnSelectfile.Name = "btnSelectfile";
            this.btnSelectfile.Size = new System.Drawing.Size(91, 36);
            this.btnSelectfile.TabIndex = 7;
            this.btnSelectfile.Text = "&Browse";
            this.btnSelectfile.UseVisualStyleBackColor = true;
            this.btnSelectfile.Click += new System.EventHandler(this.btnSelectfile_Click);
            // 
            // txtExcelFile
            // 
            this.txtExcelFile.Location = new System.Drawing.Point(118, 30);
            this.txtExcelFile.Name = "txtExcelFile";
            this.txtExcelFile.Size = new System.Drawing.Size(532, 21);
            this.txtExcelFile.TabIndex = 8;
            // 
            // btnCmdUpd
            // 
            this.btnCmdUpd.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCmdUpd.Location = new System.Drawing.Point(316, 90);
            this.btnCmdUpd.Name = "btnCmdUpd";
            this.btnCmdUpd.Size = new System.Drawing.Size(114, 36);
            this.btnCmdUpd.TabIndex = 12;
            this.btnCmdUpd.Text = "&Upload";
            this.btnCmdUpd.UseVisualStyleBackColor = true;
            this.btnCmdUpd.Click += new System.EventHandler(this.btnCmdUpd_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(54, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "&Temple File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSelectfile_Click);
            // 
            // frmUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 472);
            this.Controls.Add(this.groupBox1frmUpload);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpload";
            this.Text = "e-Packing Upload";
            this.Load += new System.EventHandler(this.frmUpload_Load);
            this.groupBox1frmUpload.ResumeLayout(false);
            this.groupBox1frmUpload.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data1GV1PackingListMasterInfo1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSelectfile;
        private System.Windows.Forms.TextBox txtExcelFile;
        private System.Windows.Forms.Button btnCmdUpd;
        protected internal System.Windows.Forms.GroupBox groupBox1frmUpload;
        private System.Windows.Forms.Label lbl1UploadExcelThreadMsg;
        protected internal System.Windows.Forms.DataGridView data1GV1PackingListMasterInfo1;
        private System.Windows.Forms.Button button1;

    }
}