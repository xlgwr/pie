namespace FrmPIE
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn00More = new System.Windows.Forms.Button();
            this.btn2UploadToHKPIDB = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btn_enquire_piReport = new System.Windows.Forms.Button();
            this.txt0PINum_piReport = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb0PIReport.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.gb0PIReport.Size = new System.Drawing.Size(600, 404);
            this.gb0PIReport.TabIndex = 0;
            this.gb0PIReport.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reportViewer1);
            this.groupBox2.Location = new System.Drawing.Point(6, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 274);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Report";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "";
            this.reportViewer1.Location = new System.Drawing.Point(3, 17);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(581, 254);
            this.reportViewer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn00More);
            this.groupBox1.Controls.Add(this.btn2UploadToHKPIDB);
            this.groupBox1.Controls.Add(this.lblMsg);
            this.groupBox1.Controls.Add(this.btn_enquire_piReport);
            this.groupBox1.Controls.Add(this.txt0PINum_piReport);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enquire ";
            // 
            // btn00More
            // 
            this.btn00More.BackgroundImage = global::FrmPIE.Properties.Resources._26;
            this.btn00More.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn00More.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn00More.FlatAppearance.BorderSize = 0;
            this.btn00More.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn00More.ForeColor = System.Drawing.SystemColors.Control;
            this.btn00More.Location = new System.Drawing.Point(294, 32);
            this.btn00More.Name = "btn00More";
            this.btn00More.Size = new System.Drawing.Size(23, 23);
            this.btn00More.TabIndex = 9;
            this.btn00More.UseVisualStyleBackColor = true;
            // 
            // btn2UploadToHKPIDB
            // 
            this.btn2UploadToHKPIDB.Location = new System.Drawing.Point(449, 26);
            this.btn2UploadToHKPIDB.Name = "btn2UploadToHKPIDB";
            this.btn2UploadToHKPIDB.Size = new System.Drawing.Size(110, 34);
            this.btn2UploadToHKPIDB.TabIndex = 6;
            this.btn2UploadToHKPIDB.Text = "&UpLoad[HK,PI_DB]";
            this.btn2UploadToHKPIDB.UseVisualStyleBackColor = true;
            this.btn2UploadToHKPIDB.Click += new System.EventHandler(this.btn2UploadToHKPIDB_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(3, 74);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(581, 23);
            this.lblMsg.TabIndex = 3;
            // 
            // btn_enquire_piReport
            // 
            this.btn_enquire_piReport.Location = new System.Drawing.Point(335, 26);
            this.btn_enquire_piReport.Name = "btn_enquire_piReport";
            this.btn_enquire_piReport.Size = new System.Drawing.Size(85, 34);
            this.btn_enquire_piReport.TabIndex = 2;
            this.btn_enquire_piReport.Text = "&Enquire";
            this.btn_enquire_piReport.UseVisualStyleBackColor = true;
            this.btn_enquire_piReport.Click += new System.EventHandler(this.btn_enquire_piReport_Click);
            // 
            // txt0PINum_piReport
            // 
            this.txt0PINum_piReport.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt0PINum_piReport.Location = new System.Drawing.Point(115, 29);
            this.txt0PINum_piReport.Name = "txt0PINum_piReport";
            this.txt0PINum_piReport.Size = new System.Drawing.Size(179, 29);
            this.txt0PINum_piReport.TabIndex = 1;
            this.txt0PINum_piReport.TextChanged += new System.EventHandler(this.txt0PINum_piReport_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pi ID:";
            // 
            // frmPI2Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 404);
            this.Controls.Add(this.gb0PIReport);
            this.Name = "frmPI2Report";
            this.Text = "frmPI2Report";
            this.Load += new System.EventHandler(this.frmPI2Report_Load);
            this.gb0PIReport.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.GroupBox gb0PIReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_enquire_piReport;
        private System.Windows.Forms.TextBox txt0PINum_piReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMsg;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btn00More;
        private System.Windows.Forms.Button btn2UploadToHKPIDB;

    }
}