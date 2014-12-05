namespace FrmPIE
{
    partial class frmEnterForReference
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnterForReference));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn2OK = new System.Windows.Forms.Button();
            this.chkTop50 = new System.Windows.Forms.CheckBox();
            this.lbl1SelectNotice = new System.Windows.Forms.Label();
            this.lbl2SelectValue = new System.Windows.Forms.Label();
            this.gb0ForReference = new System.Windows.Forms.GroupBox();
            this.data0GVForReference = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gb0ForReference.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data0GVForReference)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn2OK);
            this.groupBox1.Controls.Add(this.chkTop50);
            this.groupBox1.Controls.Add(this.lbl1SelectNotice);
            this.groupBox1.Controls.Add(this.lbl2SelectValue);
            this.groupBox1.Controls.Add(this.gb0ForReference);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 350);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Resize += new System.EventHandler(this.groupBox1_Resize);
            // 
            // btn2OK
            // 
            this.btn2OK.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn2OK.ForeColor = System.Drawing.Color.Red;
            this.btn2OK.Location = new System.Drawing.Point(436, 15);
            this.btn2OK.Name = "btn2OK";
            this.btn2OK.Size = new System.Drawing.Size(75, 23);
            this.btn2OK.TabIndex = 105;
            this.btn2OK.Text = "&OK";
            this.btn2OK.UseVisualStyleBackColor = true;
            this.btn2OK.Click += new System.EventHandler(this.btn2OK_Click);
            // 
            // chkTop50
            // 
            this.chkTop50.AutoSize = true;
            this.chkTop50.Location = new System.Drawing.Point(356, 19);
            this.chkTop50.Name = "chkTop50";
            this.chkTop50.Size = new System.Drawing.Size(60, 16);
            this.chkTop50.TabIndex = 104;
            this.chkTop50.Text = "Top 50";
            this.chkTop50.UseVisualStyleBackColor = true;
            // 
            // lbl1SelectNotice
            // 
            this.lbl1SelectNotice.AutoSize = true;
            this.lbl1SelectNotice.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl1SelectNotice.ForeColor = System.Drawing.Color.Red;
            this.lbl1SelectNotice.Location = new System.Drawing.Point(20, 51);
            this.lbl1SelectNotice.Name = "lbl1SelectNotice";
            this.lbl1SelectNotice.Size = new System.Drawing.Size(0, 16);
            this.lbl1SelectNotice.TabIndex = 11;
            this.lbl1SelectNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2SelectValue
            // 
            this.lbl2SelectValue.AutoSize = true;
            this.lbl2SelectValue.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl2SelectValue.ForeColor = System.Drawing.Color.Red;
            this.lbl2SelectValue.Location = new System.Drawing.Point(392, 54);
            this.lbl2SelectValue.Name = "lbl2SelectValue";
            this.lbl2SelectValue.Size = new System.Drawing.Size(107, 16);
            this.lbl2SelectValue.TabIndex = 8;
            this.lbl2SelectValue.Text = "SelectValue";
            this.lbl2SelectValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl2SelectValue.Visible = false;
            // 
            // gb0ForReference
            // 
            this.gb0ForReference.Controls.Add(this.data0GVForReference);
            this.gb0ForReference.Location = new System.Drawing.Point(8, 73);
            this.gb0ForReference.Name = "gb0ForReference";
            this.gb0ForReference.Size = new System.Drawing.Size(543, 271);
            this.gb0ForReference.TabIndex = 7;
            this.gb0ForReference.TabStop = false;
            this.gb0ForReference.Text = "groupBox1";
            // 
            // data0GVForReference
            // 
            this.data0GVForReference.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.data0GVForReference.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data0GVForReference.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data0GVForReference.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data0GVForReference.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.data0GVForReference.Location = new System.Drawing.Point(3, 17);
            this.data0GVForReference.MultiSelect = false;
            this.data0GVForReference.Name = "data0GVForReference";
            this.data0GVForReference.RowTemplate.Height = 23;
            this.data0GVForReference.Size = new System.Drawing.Size(537, 251);
            this.data0GVForReference.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(17, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(95, 12);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "BatchID# OR IP:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "&Enquire";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 21);
            this.textBox1.TabIndex = 4;
            // 
            // frmEnterForReference
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(557, 350);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmEnterForReference";
            this.Load += new System.EventHandler(this.frmEnterForReference_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb0ForReference.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data0GVForReference)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        protected internal System.Windows.Forms.GroupBox gb0ForReference;
        protected internal System.Windows.Forms.DataGridView data0GVForReference;
        protected internal System.Windows.Forms.Label lblTitle;
        protected internal System.Windows.Forms.Button button1;
        protected internal System.Windows.Forms.TextBox textBox1;
        protected internal System.Windows.Forms.Label lbl2SelectValue;
        protected internal System.Windows.Forms.Label lbl1SelectNotice;
        protected internal System.Windows.Forms.CheckBox chkTop50;
        protected internal System.Windows.Forms.Button btn2OK;

    }
}