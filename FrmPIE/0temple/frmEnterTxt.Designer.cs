namespace FrmPIE
{
    partial class frmEnterTxt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnterTxt));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btn00More = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 21);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "&OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(27, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(41, 12);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "label1";
            // 
            // btn00More
            // 
            this.btn00More.BackgroundImage = global::FrmPIE.Properties.Resources._26;
            this.btn00More.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn00More.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn00More.FlatAppearance.BorderSize = 0;
            this.btn00More.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn00More.ForeColor = System.Drawing.SystemColors.Control;
            this.btn00More.Location = new System.Drawing.Point(235, 10);
            this.btn00More.Name = "btn00More";
            this.btn00More.Size = new System.Drawing.Size(23, 23);
            this.btn00More.TabIndex = 8;
            this.btn00More.UseVisualStyleBackColor = true;
            this.btn00More.Visible = false;
            // 
            // frmEnterTxt
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(380, 52);
            this.Controls.Add(this.btn00More);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEnterTxt";
            this.Load += new System.EventHandler(this.frmEnterTxt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.TextBox textBox1;
        protected internal System.Windows.Forms.Label lblTitle;
        protected internal System.Windows.Forms.Button button1;
        protected internal System.Windows.Forms.Button btn00More;
    }
}