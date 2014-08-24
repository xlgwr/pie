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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpload));
            this.txtExcelFile = new System.Windows.Forms.TextBox();
            this.btnSelectfile = new System.Windows.Forms.Button();
            this.btnCmdUpd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCartonIDTo = new System.Windows.Forms.TextBox();
            this.txtCartonIDFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtExcelFile
            // 
            this.txtExcelFile.Location = new System.Drawing.Point(118, 30);
            this.txtExcelFile.Name = "txtExcelFile";
            this.txtExcelFile.Size = new System.Drawing.Size(411, 21);
            this.txtExcelFile.TabIndex = 8;
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
            // 
            // btnCmdUpd
            // 
            this.btnCmdUpd.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCmdUpd.Location = new System.Drawing.Point(231, 197);
            this.btnCmdUpd.Name = "btnCmdUpd";
            this.btnCmdUpd.Size = new System.Drawing.Size(114, 36);
            this.btnCmdUpd.TabIndex = 9;
            this.btnCmdUpd.Text = "&Upload";
            this.btnCmdUpd.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelectfile);
            this.groupBox1.Controls.Add(this.txtExcelFile);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 70);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择上传的文件";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtCartonIDTo);
            this.groupBox2.Controls.Add(this.txtCartonIDFrom);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(553, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Suppliers Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "To：";
            // 
            // txtCartonIDTo
            // 
            this.txtCartonIDTo.Location = new System.Drawing.Point(423, 40);
            this.txtCartonIDTo.Name = "txtCartonIDTo";
            this.txtCartonIDTo.Size = new System.Drawing.Size(125, 21);
            this.txtCartonIDTo.TabIndex = 15;
            // 
            // txtCartonIDFrom
            // 
            this.txtCartonIDFrom.Location = new System.Drawing.Point(164, 40);
            this.txtCartonIDFrom.Name = "txtCartonIDFrom";
            this.txtCartonIDFrom.Size = new System.Drawing.Size(125, 21);
            this.txtCartonIDFrom.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "SuppliersID";
            // 
            // frmUpload
            // 
            this.AcceptButton = this.btnCmdUpd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 250);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCmdUpd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpload";
            this.Text = "e-Packing Upload";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtExcelFile;
        private System.Windows.Forms.Button btnSelectfile;
        private System.Windows.Forms.Button btnCmdUpd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCartonIDTo;
        private System.Windows.Forms.TextBox txtCartonIDFrom;
        private System.Windows.Forms.Label label2;
    }
}