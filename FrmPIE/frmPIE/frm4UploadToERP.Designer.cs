namespace FrmPIE.frmPIE
{
    partial class frm4UploadToERP
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
            this.gb0UploadToERP = new System.Windows.Forms.GroupBox();
            this.gb1UploadToERP = new System.Windows.Forms.GroupBox();
            this.data1GVUploadToERP = new System.Windows.Forms.DataGridView();
            this.lbl0MsgUploadToERP = new System.Windows.Forms.Label();
            this.chk0UploadToERP = new System.Windows.Forms.CheckBox();
            this.txt0BatchIDUploadToERP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn1UploadToERP = new System.Windows.Forms.Button();
            this.gb0UploadToERP.SuspendLayout();
            this.gb1UploadToERP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data1GVUploadToERP)).BeginInit();
            this.SuspendLayout();
            // 
            // gb0UploadToERP
            // 
            this.gb0UploadToERP.Controls.Add(this.gb1UploadToERP);
            this.gb0UploadToERP.Controls.Add(this.lbl0MsgUploadToERP);
            this.gb0UploadToERP.Controls.Add(this.chk0UploadToERP);
            this.gb0UploadToERP.Controls.Add(this.txt0BatchIDUploadToERP);
            this.gb0UploadToERP.Controls.Add(this.btn1UploadToERP);
            this.gb0UploadToERP.Controls.Add(this.label1);
            this.gb0UploadToERP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb0UploadToERP.Location = new System.Drawing.Point(0, 0);
            this.gb0UploadToERP.Name = "gb0UploadToERP";
            this.gb0UploadToERP.Size = new System.Drawing.Size(639, 529);
            this.gb0UploadToERP.TabIndex = 0;
            this.gb0UploadToERP.TabStop = false;
            // 
            // gb1UploadToERP
            // 
            this.gb1UploadToERP.Controls.Add(this.data1GVUploadToERP);
            this.gb1UploadToERP.Location = new System.Drawing.Point(3, 117);
            this.gb1UploadToERP.Name = "gb1UploadToERP";
            this.gb1UploadToERP.Size = new System.Drawing.Size(633, 412);
            this.gb1UploadToERP.TabIndex = 4;
            this.gb1UploadToERP.TabStop = false;
            this.gb1UploadToERP.Text = "Wec Carton ID Status";
            // 
            // data1GVUploadToERP
            // 
            this.data1GVUploadToERP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data1GVUploadToERP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data1GVUploadToERP.Location = new System.Drawing.Point(3, 17);
            this.data1GVUploadToERP.Name = "data1GVUploadToERP";
            this.data1GVUploadToERP.RowTemplate.Height = 23;
            this.data1GVUploadToERP.Size = new System.Drawing.Size(627, 392);
            this.data1GVUploadToERP.TabIndex = 0;
            // 
            // lbl0MsgUploadToERP
            // 
            this.lbl0MsgUploadToERP.AutoSize = true;
            this.lbl0MsgUploadToERP.ForeColor = System.Drawing.Color.Red;
            this.lbl0MsgUploadToERP.Location = new System.Drawing.Point(61, 92);
            this.lbl0MsgUploadToERP.Name = "lbl0MsgUploadToERP";
            this.lbl0MsgUploadToERP.Size = new System.Drawing.Size(0, 12);
            this.lbl0MsgUploadToERP.TabIndex = 3;
            // 
            // chk0UploadToERP
            // 
            this.chk0UploadToERP.AutoSize = true;
            this.chk0UploadToERP.Location = new System.Drawing.Point(225, 48);
            this.chk0UploadToERP.Name = "chk0UploadToERP";
            this.chk0UploadToERP.Size = new System.Drawing.Size(84, 16);
            this.chk0UploadToERP.TabIndex = 2;
            this.chk0UploadToERP.Text = "Upload All";
            this.chk0UploadToERP.UseVisualStyleBackColor = true;
            this.chk0UploadToERP.CheckedChanged += new System.EventHandler(this.chk0UploadToERP_CheckedChanged);
            // 
            // txt0BatchIDUploadToERP
            // 
            this.txt0BatchIDUploadToERP.Location = new System.Drawing.Point(86, 46);
            this.txt0BatchIDUploadToERP.Name = "txt0BatchIDUploadToERP";
            this.txt0BatchIDUploadToERP.Size = new System.Drawing.Size(124, 21);
            this.txt0BatchIDUploadToERP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "BatchID: ";
            // 
            // btn1UploadToERP
            // 
            this.btn1UploadToERP.Location = new System.Drawing.Point(315, 28);
            this.btn1UploadToERP.Name = "btn1UploadToERP";
            this.btn1UploadToERP.Size = new System.Drawing.Size(107, 54);
            this.btn1UploadToERP.TabIndex = 0;
            this.btn1UploadToERP.Text = "&Upload To ERP";
            this.btn1UploadToERP.UseVisualStyleBackColor = true;
            this.btn1UploadToERP.Click += new System.EventHandler(this.btn0UploadToERP_Click);
            // 
            // frm4UploadToERP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 529);
            this.Controls.Add(this.gb0UploadToERP);
            this.Name = "frm4UploadToERP";
            this.Text = "frm4UploadToERP";
            this.Load += new System.EventHandler(this.frm4UploadToERP_Load);
            this.gb0UploadToERP.ResumeLayout(false);
            this.gb0UploadToERP.PerformLayout();
            this.gb1UploadToERP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data1GVUploadToERP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1UploadToERP;
        private System.Windows.Forms.DataGridView data1GVUploadToERP;
        private System.Windows.Forms.CheckBox chk0UploadToERP;
        private System.Windows.Forms.TextBox txt0BatchIDUploadToERP;
        protected internal System.Windows.Forms.GroupBox gb0UploadToERP;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.Label lbl0MsgUploadToERP;
        private System.Windows.Forms.Button btn1UploadToERP;
    }
}