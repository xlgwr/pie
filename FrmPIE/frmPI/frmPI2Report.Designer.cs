namespace frmPI
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
            this.components = new System.ComponentModel.Container();
            this.gb0PIReport = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.data0GVPiReport = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblpino = new System.Windows.Forms.Label();
            this.btn3Change = new System.Windows.Forms.Button();
            this.btn2UploadToHKPIDB = new System.Windows.Forms.Button();
            this.txt1Change = new System.Windows.Forms.TextBox();
            this.btn00More = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btn0_enquire_piReport = new System.Windows.Forms.Button();
            this.txt0PINum_piReport = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctmenu0EnquireByPart = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.enquireByPartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downLoad1ToExceltoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.gb0PIReport.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data0GVPiReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.ctmenu0EnquireByPart.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb0PIReport
            // 
            this.gb0PIReport.Controls.Add(this.groupBox2);
            this.gb0PIReport.Controls.Add(this.groupBox1);
            this.gb0PIReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb0PIReport.Location = new System.Drawing.Point(0, 0);
            this.gb0PIReport.Name = "gb0PIReport";
            this.gb0PIReport.Size = new System.Drawing.Size(703, 392);
            this.gb0PIReport.TabIndex = 0;
            this.gb0PIReport.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.data0GVPiReport);
            this.groupBox2.Location = new System.Drawing.Point(6, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(674, 270);
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
            this.data0GVPiReport.Size = new System.Drawing.Size(668, 250);
            this.data0GVPiReport.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblpino);
            this.groupBox1.Controls.Add(this.btn3Change);
            this.groupBox1.Controls.Add(this.btn2UploadToHKPIDB);
            this.groupBox1.Controls.Add(this.txt1Change);
            this.groupBox1.Controls.Add(this.btn00More);
            this.groupBox1.Controls.Add(this.lblMsg);
            this.groupBox1.Controls.Add(this.btn0_enquire_piReport);
            this.groupBox1.Controls.Add(this.txt0PINum_piReport);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 84);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enquire ";
            // 
            // lblpino
            // 
            this.lblpino.AutoSize = true;
            this.lblpino.Location = new System.Drawing.Point(454, 31);
            this.lblpino.Name = "lblpino";
            this.lblpino.Size = new System.Drawing.Size(41, 12);
            this.lblpino.TabIndex = 11;
            this.lblpino.Text = "PI NO:";
            this.lblpino.Visible = false;
            // 
            // btn3Change
            // 
            this.btn3Change.Location = new System.Drawing.Point(609, 22);
            this.btn3Change.Name = "btn3Change";
            this.btn3Change.Size = new System.Drawing.Size(75, 34);
            this.btn3Change.TabIndex = 10;
            this.btn3Change.Text = "&Change";
            this.btn3Change.UseVisualStyleBackColor = true;
            this.btn3Change.Visible = false;
            this.btn3Change.Click += new System.EventHandler(this.btn3Change_Click);
            // 
            // btn2UploadToHKPIDB
            // 
            this.btn2UploadToHKPIDB.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn2UploadToHKPIDB.ForeColor = System.Drawing.Color.Red;
            this.btn2UploadToHKPIDB.Location = new System.Drawing.Point(310, 18);
            this.btn2UploadToHKPIDB.Name = "btn2UploadToHKPIDB";
            this.btn2UploadToHKPIDB.Size = new System.Drawing.Size(127, 34);
            this.btn2UploadToHKPIDB.TabIndex = 5;
            this.btn2UploadToHKPIDB.Text = "&UpLoad[HK,PI_DB]";
            this.btn2UploadToHKPIDB.UseVisualStyleBackColor = true;
            this.btn2UploadToHKPIDB.Click += new System.EventHandler(this.btn2UploadToHKPIDB_Click);
            // 
            // txt1Change
            // 
            this.txt1Change.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt1Change.Location = new System.Drawing.Point(499, 23);
            this.txt1Change.Name = "txt1Change";
            this.txt1Change.Size = new System.Drawing.Size(107, 29);
            this.txt1Change.TabIndex = 9;
            this.txt1Change.Visible = false;
            // 
            // btn00More
            // 
            this.btn00More.BackgroundImage = global::FrmPIE.Properties.Resources._26;
            this.btn00More.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn00More.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn00More.FlatAppearance.BorderSize = 0;
            this.btn00More.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn00More.ForeColor = System.Drawing.SystemColors.Control;
            this.btn00More.Location = new System.Drawing.Point(188, 26);
            this.btn00More.Name = "btn00More";
            this.btn00More.Size = new System.Drawing.Size(23, 23);
            this.btn00More.TabIndex = 8;
            this.btn00More.UseVisualStyleBackColor = true;
            // 
            // lblMsg
            // 
            this.lblMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(3, 58);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(679, 23);
            this.lblMsg.TabIndex = 3;
            // 
            // btn0_enquire_piReport
            // 
            this.btn0_enquire_piReport.Location = new System.Drawing.Point(217, 20);
            this.btn0_enquire_piReport.Name = "btn0_enquire_piReport";
            this.btn0_enquire_piReport.Size = new System.Drawing.Size(75, 34);
            this.btn0_enquire_piReport.TabIndex = 2;
            this.btn0_enquire_piReport.Text = "&Enquire";
            this.btn0_enquire_piReport.UseVisualStyleBackColor = true;
            this.btn0_enquire_piReport.Click += new System.EventHandler(this.btn_enquire_piReport_Click);
            // 
            // txt0PINum_piReport
            // 
            this.txt0PINum_piReport.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt0PINum_piReport.Location = new System.Drawing.Point(58, 23);
            this.txt0PINum_piReport.Name = "txt0PINum_piReport";
            this.txt0PINum_piReport.Size = new System.Drawing.Size(129, 29);
            this.txt0PINum_piReport.TabIndex = 1;
            this.txt0PINum_piReport.TextChanged += new System.EventHandler(this.txt0PINum_piReport_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pi ID:";
            // 
            // ctmenu0EnquireByPart
            // 
            this.ctmenu0EnquireByPart.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enquireByPartToolStripMenuItem,
            this.downLoad1ToExceltoolStripMenuItem2});
            this.ctmenu0EnquireByPart.Name = "ctmenu0EnquireByPart";
            this.ctmenu0EnquireByPart.Size = new System.Drawing.Size(191, 48);
            // 
            // enquireByPartToolStripMenuItem
            // 
            this.enquireByPartToolStripMenuItem.Image = global::FrmPIE.Properties.Resources.find;
            this.enquireByPartToolStripMenuItem.Name = "enquireByPartToolStripMenuItem";
            this.enquireByPartToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.enquireByPartToolStripMenuItem.Text = "Enquire by &Part";
            // 
            // downLoad1ToExceltoolStripMenuItem2
            // 
            this.downLoad1ToExceltoolStripMenuItem2.Image = global::FrmPIE.Properties.Resources.down;
            this.downLoad1ToExceltoolStripMenuItem2.Name = "downLoad1ToExceltoolStripMenuItem2";
            this.downLoad1ToExceltoolStripMenuItem2.Size = new System.Drawing.Size(190, 22);
            this.downLoad1ToExceltoolStripMenuItem2.Text = "&DownLoad To Excel";
            this.downLoad1ToExceltoolStripMenuItem2.Click += new System.EventHandler(this.downLoad1ToExceltoolStripMenuItem2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmPI2Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 392);
            this.Controls.Add(this.gb0PIReport);
            this.Name = "frmPI2Report";
            this.Text = "frmPI2Report";
            this.Load += new System.EventHandler(this.frmPI2Report_Load);
            this.gb0PIReport.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data0GVPiReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ctmenu0EnquireByPart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.GroupBox gb0PIReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView data0GVPiReport;
        private System.Windows.Forms.Button btn2UploadToHKPIDB;
        private System.Windows.Forms.ContextMenuStrip ctmenu0EnquireByPart;
        private System.Windows.Forms.ToolStripMenuItem enquireByPartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downLoad1ToExceltoolStripMenuItem2;
        private System.Windows.Forms.Button btn00More;
        protected internal System.Windows.Forms.TextBox txt0PINum_piReport;
        protected internal System.Windows.Forms.Button btn0_enquire_piReport;
        protected internal System.Windows.Forms.Button btn3Change;
        protected internal System.Windows.Forms.TextBox txt1Change;
        private System.Windows.Forms.Label lblpino;
        private System.Windows.Forms.Button button1;

    }
}