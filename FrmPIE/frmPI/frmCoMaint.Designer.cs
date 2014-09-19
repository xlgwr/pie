namespace FrmPIE.frmPI
{
    partial class frmCoMaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCoMaint));
            this.gb0CoMaint = new System.Windows.Forms.GroupBox();
            this.cmb3CO_Maint = new System.Windows.Forms.ComboBox();
            this.btn0Scan_coMaint = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt1PIID_CoMaint = new System.Windows.Forms.TextBox();
            this.txt3SanWecCtnLable_CoMaint = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt2Pallet_CoMaint = new System.Windows.Forms.TextBox();
            this.txt4part_CoMaint = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl0msg = new System.Windows.Forms.Label();
            this.lbl3COScanWECCtnLable = new System.Windows.Forms.Label();
            this.gb0CoMaint.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb0CoMaint
            // 
            this.gb0CoMaint.Controls.Add(this.lbl3COScanWECCtnLable);
            this.gb0CoMaint.Controls.Add(this.lbl0msg);
            this.gb0CoMaint.Controls.Add(this.txt4part_CoMaint);
            this.gb0CoMaint.Controls.Add(this.label2);
            this.gb0CoMaint.Controls.Add(this.txt2Pallet_CoMaint);
            this.gb0CoMaint.Controls.Add(this.label6);
            this.gb0CoMaint.Controls.Add(this.txt3SanWecCtnLable_CoMaint);
            this.gb0CoMaint.Controls.Add(this.label5);
            this.gb0CoMaint.Controls.Add(this.label1);
            this.gb0CoMaint.Controls.Add(this.txt1PIID_CoMaint);
            this.gb0CoMaint.Controls.Add(this.label4);
            this.gb0CoMaint.Controls.Add(this.cmb3CO_Maint);
            this.gb0CoMaint.Controls.Add(this.btn0Scan_coMaint);
            this.gb0CoMaint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb0CoMaint.Location = new System.Drawing.Point(0, 0);
            this.gb0CoMaint.Name = "gb0CoMaint";
            this.gb0CoMaint.Size = new System.Drawing.Size(333, 325);
            this.gb0CoMaint.TabIndex = 0;
            this.gb0CoMaint.TabStop = false;
            // 
            // cmb3CO_Maint
            // 
            this.cmb3CO_Maint.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb3CO_Maint.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb3CO_Maint.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb3CO_Maint.FormattingEnabled = true;
            this.cmb3CO_Maint.Location = new System.Drawing.Point(98, 179);
            this.cmb3CO_Maint.Name = "cmb3CO_Maint";
            this.cmb3CO_Maint.Size = new System.Drawing.Size(144, 24);
            this.cmb3CO_Maint.TabIndex = 209;
            this.cmb3CO_Maint.TextChanged += new System.EventHandler(this.cmb3CO_Maint_TextChanged);
            this.cmb3CO_Maint.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmb3CO_Maint_KeyUp);
            // 
            // btn0Scan_coMaint
            // 
            this.btn0Scan_coMaint.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn0Scan_coMaint.Location = new System.Drawing.Point(127, 215);
            this.btn0Scan_coMaint.Name = "btn0Scan_coMaint";
            this.btn0Scan_coMaint.Size = new System.Drawing.Size(78, 34);
            this.btn0Scan_coMaint.TabIndex = 210;
            this.btn0Scan_coMaint.Text = "&OK";
            this.btn0Scan_coMaint.UseVisualStyleBackColor = true;
            this.btn0Scan_coMaint.Click += new System.EventHandler(this.btn0Scan_coMaint_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(60, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 211;
            this.label4.Text = "CO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 212;
            this.label1.Text = "PI ID:";
            // 
            // txt1PIID_CoMaint
            // 
            this.txt1PIID_CoMaint.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt1PIID_CoMaint.Location = new System.Drawing.Point(98, 28);
            this.txt1PIID_CoMaint.Name = "txt1PIID_CoMaint";
            this.txt1PIID_CoMaint.ReadOnly = true;
            this.txt1PIID_CoMaint.Size = new System.Drawing.Size(196, 27);
            this.txt1PIID_CoMaint.TabIndex = 213;
            // 
            // txt3SanWecCtnLable_CoMaint
            // 
            this.txt3SanWecCtnLable_CoMaint.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt3SanWecCtnLable_CoMaint.Location = new System.Drawing.Point(98, 90);
            this.txt3SanWecCtnLable_CoMaint.MaxLength = 12;
            this.txt3SanWecCtnLable_CoMaint.Name = "txt3SanWecCtnLable_CoMaint";
            this.txt3SanWecCtnLable_CoMaint.ReadOnly = true;
            this.txt3SanWecCtnLable_CoMaint.Size = new System.Drawing.Size(196, 27);
            this.txt3SanWecCtnLable_CoMaint.TabIndex = 215;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(20, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 214;
            this.label5.Text = "Scan SN:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(20, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 216;
            this.label6.Text = "Pallet#:";
            // 
            // txt2Pallet_CoMaint
            // 
            this.txt2Pallet_CoMaint.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt2Pallet_CoMaint.Location = new System.Drawing.Point(98, 59);
            this.txt2Pallet_CoMaint.Name = "txt2Pallet_CoMaint";
            this.txt2Pallet_CoMaint.ReadOnly = true;
            this.txt2Pallet_CoMaint.Size = new System.Drawing.Size(196, 27);
            this.txt2Pallet_CoMaint.TabIndex = 217;
            // 
            // txt4part_CoMaint
            // 
            this.txt4part_CoMaint.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt4part_CoMaint.Location = new System.Drawing.Point(98, 123);
            this.txt4part_CoMaint.MaxLength = 12;
            this.txt4part_CoMaint.Name = "txt4part_CoMaint";
            this.txt4part_CoMaint.ReadOnly = true;
            this.txt4part_CoMaint.Size = new System.Drawing.Size(196, 27);
            this.txt4part_CoMaint.TabIndex = 219;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(36, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 218;
            this.label2.Text = "Part#:";
            // 
            // lbl0msg
            // 
            this.lbl0msg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl0msg.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl0msg.ForeColor = System.Drawing.Color.Red;
            this.lbl0msg.Location = new System.Drawing.Point(3, 251);
            this.lbl0msg.Name = "lbl0msg";
            this.lbl0msg.Size = new System.Drawing.Size(327, 71);
            this.lbl0msg.TabIndex = 220;
            this.lbl0msg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl3COScanWECCtnLable
            // 
            this.lbl3COScanWECCtnLable.AutoSize = true;
            this.lbl3COScanWECCtnLable.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl3COScanWECCtnLable.ForeColor = System.Drawing.Color.Red;
            this.lbl3COScanWECCtnLable.Location = new System.Drawing.Point(248, 186);
            this.lbl3COScanWECCtnLable.Name = "lbl3COScanWECCtnLable";
            this.lbl3COScanWECCtnLable.Size = new System.Drawing.Size(0, 12);
            this.lbl3COScanWECCtnLable.TabIndex = 221;
            // 
            // frmCoMaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(333, 325);
            this.Controls.Add(this.gb0CoMaint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCoMaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoMaint";
            this.Load += new System.EventHandler(this.frmCoMaint_Load);
            this.gb0CoMaint.ResumeLayout(false);
            this.gb0CoMaint.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb0CoMaint;
        private System.Windows.Forms.ComboBox cmb3CO_Maint;
        private System.Windows.Forms.Button btn0Scan_coMaint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt1PIID_CoMaint;
        private System.Windows.Forms.TextBox txt3SanWecCtnLable_CoMaint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt2Pallet_CoMaint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt4part_CoMaint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl0msg;
        private System.Windows.Forms.Label lbl3COScanWECCtnLable;
    }
}