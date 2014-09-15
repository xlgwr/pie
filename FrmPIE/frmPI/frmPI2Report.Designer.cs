namespace FrmPIE.frmPI
{
    partial class frmPI2Report
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
            this.gb0PIReport = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.data0GVPiReport = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btn_enquire_piReport = new System.Windows.Forms.Button();
            this.txt0PINum_piReport = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb0PIReport.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data0GVPiReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb0PIReport
            // 
            this.gb0PIReport.Controls.Add(this.groupBox2);
            this.gb0PIReport.Controls.Add(this.groupBox1);
            this.gb0PIReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb0PIReport.Location = new System.Drawing.Point(0, 0);
            this.gb0PIReport.Name = "gb0PIReport";
            this.gb0PIReport.Size = new System.Drawing.Size(592, 392);
            this.gb0PIReport.TabIndex = 0;
            this.gb0PIReport.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.data0GVPiReport);
            this.groupBox2.Location = new System.Drawing.Point(6, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 254);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Report";
            // 
            // data0GVPiReport
            // 
            this.data0GVPiReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data0GVPiReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data0GVPiReport.Location = new System.Drawing.Point(3, 17);
            this.data0GVPiReport.Name = "data0GVPiReport";
            this.data0GVPiReport.RowTemplate.Height = 23;
            this.data0GVPiReport.Size = new System.Drawing.Size(574, 234);
            this.data0GVPiReport.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblMsg);
            this.groupBox1.Controls.Add(this.btn_enquire_piReport);
            this.groupBox1.Controls.Add(this.txt0PINum_piReport);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enquire ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(448, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "DownLoadToExcel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(3, 74);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(573, 23);
            this.lblMsg.TabIndex = 3;
            // 
            // btn_enquire_piReport
            // 
            this.btn_enquire_piReport.Location = new System.Drawing.Point(354, 23);
            this.btn_enquire_piReport.Name = "btn_enquire_piReport";
            this.btn_enquire_piReport.Size = new System.Drawing.Size(75, 34);
            this.btn_enquire_piReport.TabIndex = 2;
            this.btn_enquire_piReport.Text = "&Enquire";
            this.btn_enquire_piReport.UseVisualStyleBackColor = true;
            this.btn_enquire_piReport.Click += new System.EventHandler(this.btn_enquire_piReport_Click);
            // 
            // txt0PINum_piReport
            // 
            this.txt0PINum_piReport.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt0PINum_piReport.Location = new System.Drawing.Point(169, 26);
            this.txt0PINum_piReport.Name = "txt0PINum_piReport";
            this.txt0PINum_piReport.Size = new System.Drawing.Size(179, 29);
            this.txt0PINum_piReport.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pi ID:";
            // 
            // frmPI2Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 392);
            this.Controls.Add(this.gb0PIReport);
            this.Name = "frmPI2Report";
            this.Text = "frmPI2Report";
            this.Load += new System.EventHandler(this.frmPI2Report_Load);
            this.gb0PIReport.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data0GVPiReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.GroupBox gb0PIReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btn_enquire_piReport;
        private System.Windows.Forms.TextBox txt0PINum_piReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView data0GVPiReport;
        private System.Windows.Forms.Button button1;

    }
}