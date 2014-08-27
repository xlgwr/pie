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
            this.groupBox0frmUpload = new System.Windows.Forms.GroupBox();
            this.groupBox2mstr = new System.Windows.Forms.GroupBox();
            this.txt5batch_cre_date = new System.Windows.Forms.TextBox();
            this.txt4batch_dec01 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt3batch_status = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt2batch_doc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt1batch_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3det = new System.Windows.Forms.GroupBox();
            this.data1GV1ePackingDet1 = new System.Windows.Forms.DataGridView();
            this.btn2TempleFile = new System.Windows.Forms.Button();
            this.lbl1UploadExcelThreadMsg = new System.Windows.Forms.Label();
            this.groupBox1browse = new System.Windows.Forms.GroupBox();
            this.btnSelectfile = new System.Windows.Forms.Button();
            this.txtExcelFile = new System.Windows.Forms.TextBox();
            this.btnCmdUpd = new System.Windows.Forms.Button();
            this.groupBox0frmUpload.SuspendLayout();
            this.groupBox2mstr.SuspendLayout();
            this.groupBox3det.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data1GV1ePackingDet1)).BeginInit();
            this.groupBox1browse.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox0frmUpload
            // 
            this.groupBox0frmUpload.Controls.Add(this.groupBox2mstr);
            this.groupBox0frmUpload.Controls.Add(this.groupBox3det);
            this.groupBox0frmUpload.Controls.Add(this.btn2TempleFile);
            this.groupBox0frmUpload.Controls.Add(this.lbl1UploadExcelThreadMsg);
            this.groupBox0frmUpload.Controls.Add(this.groupBox1browse);
            this.groupBox0frmUpload.Controls.Add(this.btnCmdUpd);
            this.groupBox0frmUpload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox0frmUpload.Location = new System.Drawing.Point(0, 0);
            this.groupBox0frmUpload.Name = "groupBox0frmUpload";
            this.groupBox0frmUpload.Size = new System.Drawing.Size(723, 472);
            this.groupBox0frmUpload.TabIndex = 0;
            this.groupBox0frmUpload.TabStop = false;
            this.groupBox0frmUpload.Resize += new System.EventHandler(this.groupBox1frmUpload_Resize);
            // 
            // groupBox2mstr
            // 
            this.groupBox2mstr.Controls.Add(this.txt5batch_cre_date);
            this.groupBox2mstr.Controls.Add(this.txt4batch_dec01);
            this.groupBox2mstr.Controls.Add(this.label5);
            this.groupBox2mstr.Controls.Add(this.label4);
            this.groupBox2mstr.Controls.Add(this.txt3batch_status);
            this.groupBox2mstr.Controls.Add(this.label3);
            this.groupBox2mstr.Controls.Add(this.txt2batch_doc);
            this.groupBox2mstr.Controls.Add(this.label2);
            this.groupBox2mstr.Controls.Add(this.txt1batch_id);
            this.groupBox2mstr.Controls.Add(this.label1);
            this.groupBox2mstr.Location = new System.Drawing.Point(7, 172);
            this.groupBox2mstr.Name = "groupBox2mstr";
            this.groupBox2mstr.Size = new System.Drawing.Size(709, 55);
            this.groupBox2mstr.TabIndex = 16;
            this.groupBox2mstr.TabStop = false;
            this.groupBox2mstr.Text = "BatchID Info Mstr";
            // 
            // txt5batch_cre_date
            // 
            this.txt5batch_cre_date.Location = new System.Drawing.Point(545, 21);
            this.txt5batch_cre_date.Name = "txt5batch_cre_date";
            this.txt5batch_cre_date.Size = new System.Drawing.Size(158, 21);
            this.txt5batch_cre_date.TabIndex = 7;
            // 
            // txt4batch_dec01
            // 
            this.txt4batch_dec01.Location = new System.Drawing.Point(431, 21);
            this.txt4batch_dec01.Name = "txt4batch_dec01";
            this.txt4batch_dec01.Size = new System.Drawing.Size(37, 21);
            this.txt4batch_dec01.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(468, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "Create Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Items Count:";
            // 
            // txt3batch_status
            // 
            this.txt3batch_status.Location = new System.Drawing.Point(317, 21);
            this.txt3batch_status.Name = "txt3batch_status";
            this.txt3batch_status.Size = new System.Drawing.Size(37, 21);
            this.txt3batch_status.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Void:";
            // 
            // txt2batch_doc
            // 
            this.txt2batch_doc.Location = new System.Drawing.Point(188, 21);
            this.txt2batch_doc.Name = "txt2batch_doc";
            this.txt2batch_doc.Size = new System.Drawing.Size(94, 21);
            this.txt2batch_doc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type:";
            // 
            // txt1batch_id
            // 
            this.txt1batch_id.Location = new System.Drawing.Point(59, 21);
            this.txt1batch_id.Name = "txt1batch_id";
            this.txt1batch_id.Size = new System.Drawing.Size(94, 21);
            this.txt1batch_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "BatchID:";
            // 
            // groupBox3det
            // 
            this.groupBox3det.Controls.Add(this.data1GV1ePackingDet1);
            this.groupBox3det.Location = new System.Drawing.Point(7, 229);
            this.groupBox3det.Name = "groupBox3det";
            this.groupBox3det.Size = new System.Drawing.Size(709, 231);
            this.groupBox3det.TabIndex = 15;
            this.groupBox3det.TabStop = false;
            this.groupBox3det.Text = "Batch ePacking Det";
            // 
            // data1GV1ePackingDet1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data1GV1ePackingDet1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data1GV1ePackingDet1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data1GV1ePackingDet1.DefaultCellStyle = dataGridViewCellStyle2;
            this.data1GV1ePackingDet1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data1GV1ePackingDet1.Location = new System.Drawing.Point(3, 17);
            this.data1GV1ePackingDet1.MultiSelect = false;
            this.data1GV1ePackingDet1.Name = "data1GV1ePackingDet1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data1GV1ePackingDet1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.data1GV1ePackingDet1.RowTemplate.Height = 23;
            this.data1GV1ePackingDet1.Size = new System.Drawing.Size(703, 211);
            this.data1GV1ePackingDet1.TabIndex = 16;
            // 
            // btn2TempleFile
            // 
            this.btn2TempleFile.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn2TempleFile.Location = new System.Drawing.Point(15, 90);
            this.btn2TempleFile.Name = "btn2TempleFile";
            this.btn2TempleFile.Size = new System.Drawing.Size(91, 36);
            this.btn2TempleFile.TabIndex = 7;
            this.btn2TempleFile.Text = "&Temple File";
            this.btn2TempleFile.UseVisualStyleBackColor = true;
            this.btn2TempleFile.Click += new System.EventHandler(this.btn2TempleFile_Click);
            // 
            // lbl1UploadExcelThreadMsg
            // 
            this.lbl1UploadExcelThreadMsg.AutoSize = true;
            this.lbl1UploadExcelThreadMsg.ForeColor = System.Drawing.Color.Red;
            this.lbl1UploadExcelThreadMsg.Location = new System.Drawing.Point(52, 143);
            this.lbl1UploadExcelThreadMsg.Name = "lbl1UploadExcelThreadMsg";
            this.lbl1UploadExcelThreadMsg.Size = new System.Drawing.Size(0, 12);
            this.lbl1UploadExcelThreadMsg.TabIndex = 14;
            // 
            // groupBox1browse
            // 
            this.groupBox1browse.Controls.Add(this.btnSelectfile);
            this.groupBox1browse.Controls.Add(this.txtExcelFile);
            this.groupBox1browse.Location = new System.Drawing.Point(7, 14);
            this.groupBox1browse.Name = "groupBox1browse";
            this.groupBox1browse.Size = new System.Drawing.Size(709, 70);
            this.groupBox1browse.TabIndex = 13;
            this.groupBox1browse.TabStop = false;
            this.groupBox1browse.Text = "选择上传的Excel文件";
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
            this.txtExcelFile.Size = new System.Drawing.Size(543, 21);
            this.txtExcelFile.TabIndex = 8;
            // 
            // btnCmdUpd
            // 
            this.btnCmdUpd.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCmdUpd.Location = new System.Drawing.Point(304, 90);
            this.btnCmdUpd.Name = "btnCmdUpd";
            this.btnCmdUpd.Size = new System.Drawing.Size(114, 36);
            this.btnCmdUpd.TabIndex = 12;
            this.btnCmdUpd.Text = "&Upload";
            this.btnCmdUpd.UseVisualStyleBackColor = true;
            this.btnCmdUpd.Click += new System.EventHandler(this.btnCmdUpd_Click);
            // 
            // frmUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 472);
            this.Controls.Add(this.groupBox0frmUpload);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpload";
            this.Text = "e-Packing Upload";
            this.Load += new System.EventHandler(this.frmUpload_Load);
            this.groupBox0frmUpload.ResumeLayout(false);
            this.groupBox0frmUpload.PerformLayout();
            this.groupBox2mstr.ResumeLayout(false);
            this.groupBox2mstr.PerformLayout();
            this.groupBox3det.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data1GV1ePackingDet1)).EndInit();
            this.groupBox1browse.ResumeLayout(false);
            this.groupBox1browse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1browse;
        private System.Windows.Forms.Button btnSelectfile;
        private System.Windows.Forms.Button btnCmdUpd;
        protected internal System.Windows.Forms.GroupBox groupBox0frmUpload;
        private System.Windows.Forms.Label lbl1UploadExcelThreadMsg;
        private System.Windows.Forms.Button btn2TempleFile;
        protected internal System.Windows.Forms.TextBox txtExcelFile;
        private System.Windows.Forms.GroupBox groupBox2mstr;
        private System.Windows.Forms.TextBox txt5batch_cre_date;
        private System.Windows.Forms.TextBox txt4batch_dec01;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt3batch_status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt2batch_doc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt1batch_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3det;
        protected internal System.Windows.Forms.DataGridView data1GV1ePackingDet1;

    }
}