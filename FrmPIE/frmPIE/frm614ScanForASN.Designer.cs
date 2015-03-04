using System.Windows.Forms;
namespace FrmPIE.frmPIE
{
    partial class frm614ScanForASN<T,G>
        where T:Form
        where G:DataGridView
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
            this.txt3PalletNoAddNewBatchID = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt12CartonprifixAddNewBatchID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt8CartonQtyAddNewBatchID = new System.Windows.Forms.TextBox();
            this.txt14CartonIDFromAddNewBatchID = new System.Windows.Forms.TextBox();
            this.txt15CartonIDToAddNewBatchID = new System.Windows.Forms.TextBox();
            this.txt9QTYAddNewBatchID = new System.Windows.Forms.TextBox();
            this.txt10CartonIDAddNewBatchID = new System.Windows.Forms.TextBox();
            this.txt2LineIDAddNewBatchID = new System.Windows.Forms.TextBox();
            this.txt7PartAddNewBatchID = new System.Windows.Forms.TextBox();
            this.txt5POAddNewBatchID = new System.Windows.Forms.TextBox();
            this.txt1BatchIDAddNewBatchID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox0BatchInfo0 = new System.Windows.Forms.GroupBox();
            this.gb0ScanTxt = new System.Windows.Forms.GroupBox();
            this.txt0Scan = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.gb2det_BatchInfo = new System.Windows.Forms.GroupBox();
            this.btn1Clear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox0BatchInfo0.SuspendLayout();
            this.gb0ScanTxt.SuspendLayout();
            this.gb2det_BatchInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt3PalletNoAddNewBatchID
            // 
            this.txt3PalletNoAddNewBatchID.AcceptsTab = true;
            this.txt3PalletNoAddNewBatchID.Location = new System.Drawing.Point(88, 39);
            this.txt3PalletNoAddNewBatchID.Name = "txt3PalletNoAddNewBatchID";
            this.txt3PalletNoAddNewBatchID.Size = new System.Drawing.Size(152, 21);
            this.txt3PalletNoAddNewBatchID.TabIndex = 91;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 12);
            this.label18.TabIndex = 120;
            this.label18.Text = " Pallet No:";
            // 
            // txt12CartonprifixAddNewBatchID
            // 
            this.txt12CartonprifixAddNewBatchID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt12CartonprifixAddNewBatchID.Location = new System.Drawing.Point(342, 13);
            this.txt12CartonprifixAddNewBatchID.Name = "txt12CartonprifixAddNewBatchID";
            this.txt12CartonprifixAddNewBatchID.Size = new System.Drawing.Size(152, 21);
            this.txt12CartonprifixAddNewBatchID.TabIndex = 97;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(249, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 12);
            this.label17.TabIndex = 118;
            this.label17.Text = "Carton prifix:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 12);
            this.label13.TabIndex = 117;
            this.label13.Text = "Qty/Carton:";
            // 
            // txt8CartonQtyAddNewBatchID
            // 
            this.txt8CartonQtyAddNewBatchID.Location = new System.Drawing.Point(88, 150);
            this.txt8CartonQtyAddNewBatchID.Name = "txt8CartonQtyAddNewBatchID";
            this.txt8CartonQtyAddNewBatchID.Size = new System.Drawing.Size(152, 21);
            this.txt8CartonQtyAddNewBatchID.TabIndex = 95;
            // 
            // txt14CartonIDFromAddNewBatchID
            // 
            this.txt14CartonIDFromAddNewBatchID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt14CartonIDFromAddNewBatchID.Location = new System.Drawing.Point(342, 40);
            this.txt14CartonIDFromAddNewBatchID.Name = "txt14CartonIDFromAddNewBatchID";
            this.txt14CartonIDFromAddNewBatchID.Size = new System.Drawing.Size(152, 21);
            this.txt14CartonIDFromAddNewBatchID.TabIndex = 98;
            this.txt14CartonIDFromAddNewBatchID.Text = "0";
            // 
            // txt15CartonIDToAddNewBatchID
            // 
            this.txt15CartonIDToAddNewBatchID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt15CartonIDToAddNewBatchID.Location = new System.Drawing.Point(342, 67);
            this.txt15CartonIDToAddNewBatchID.Name = "txt15CartonIDToAddNewBatchID";
            this.txt15CartonIDToAddNewBatchID.Size = new System.Drawing.Size(152, 21);
            this.txt15CartonIDToAddNewBatchID.TabIndex = 99;
            this.txt15CartonIDToAddNewBatchID.Text = "0";
            // 
            // txt9QTYAddNewBatchID
            // 
            this.txt9QTYAddNewBatchID.Location = new System.Drawing.Point(88, 120);
            this.txt9QTYAddNewBatchID.Name = "txt9QTYAddNewBatchID";
            this.txt9QTYAddNewBatchID.Size = new System.Drawing.Size(152, 21);
            this.txt9QTYAddNewBatchID.TabIndex = 94;
            // 
            // txt10CartonIDAddNewBatchID
            // 
            this.txt10CartonIDAddNewBatchID.Location = new System.Drawing.Point(88, 177);
            this.txt10CartonIDAddNewBatchID.Name = "txt10CartonIDAddNewBatchID";
            this.txt10CartonIDAddNewBatchID.Size = new System.Drawing.Size(152, 21);
            this.txt10CartonIDAddNewBatchID.TabIndex = 96;
            // 
            // txt2LineIDAddNewBatchID
            // 
            this.txt2LineIDAddNewBatchID.Enabled = false;
            this.txt2LineIDAddNewBatchID.Location = new System.Drawing.Point(211, 13);
            this.txt2LineIDAddNewBatchID.Name = "txt2LineIDAddNewBatchID";
            this.txt2LineIDAddNewBatchID.Size = new System.Drawing.Size(29, 21);
            this.txt2LineIDAddNewBatchID.TabIndex = 90;
            // 
            // txt7PartAddNewBatchID
            // 
            this.txt7PartAddNewBatchID.Location = new System.Drawing.Point(88, 93);
            this.txt7PartAddNewBatchID.Name = "txt7PartAddNewBatchID";
            this.txt7PartAddNewBatchID.Size = new System.Drawing.Size(152, 21);
            this.txt7PartAddNewBatchID.TabIndex = 93;
            // 
            // txt5POAddNewBatchID
            // 
            this.txt5POAddNewBatchID.Location = new System.Drawing.Point(88, 66);
            this.txt5POAddNewBatchID.Name = "txt5POAddNewBatchID";
            this.txt5POAddNewBatchID.Size = new System.Drawing.Size(152, 21);
            this.txt5POAddNewBatchID.TabIndex = 92;
            this.txt5POAddNewBatchID.TextChanged += new System.EventHandler(this.txt5POAddNewBatchID_TextChanged);
            // 
            // txt1BatchIDAddNewBatchID
            // 
            this.txt1BatchIDAddNewBatchID.Enabled = false;
            this.txt1BatchIDAddNewBatchID.Location = new System.Drawing.Point(88, 13);
            this.txt1BatchIDAddNewBatchID.Name = "txt1BatchIDAddNewBatchID";
            this.txt1BatchIDAddNewBatchID.Size = new System.Drawing.Size(117, 21);
            this.txt1BatchIDAddNewBatchID.TabIndex = 89;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(315, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 12);
            this.label11.TabIndex = 113;
            this.label11.Text = "To:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(243, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 12);
            this.label9.TabIndex = 115;
            this.label9.Text = "Carton ID From:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 109;
            this.label5.Text = "Total Qty:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 108;
            this.label6.Text = "Part:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 107;
            this.label7.Text = "Carton ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 104;
            this.label8.Text = "PO#:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 101;
            this.label1.Text = "Batch ID:";
            // 
            // groupBox0BatchInfo0
            // 
            this.groupBox0BatchInfo0.Controls.Add(this.gb0ScanTxt);
            this.groupBox0BatchInfo0.Controls.Add(this.gb2det_BatchInfo);
            this.groupBox0BatchInfo0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox0BatchInfo0.Location = new System.Drawing.Point(0, 0);
            this.groupBox0BatchInfo0.Name = "groupBox0BatchInfo0";
            this.groupBox0BatchInfo0.Size = new System.Drawing.Size(519, 373);
            this.groupBox0BatchInfo0.TabIndex = 121;
            this.groupBox0BatchInfo0.TabStop = false;
            // 
            // gb0ScanTxt
            // 
            this.gb0ScanTxt.Controls.Add(this.txt0Scan);
            this.gb0ScanTxt.Controls.Add(this.lblMsg);
            this.gb0ScanTxt.Location = new System.Drawing.Point(6, 0);
            this.gb0ScanTxt.Name = "gb0ScanTxt";
            this.gb0ScanTxt.Size = new System.Drawing.Size(508, 154);
            this.gb0ScanTxt.TabIndex = 0;
            this.gb0ScanTxt.TabStop = false;
            this.gb0ScanTxt.Text = "Scan TxT";
            // 
            // txt0Scan
            // 
            this.txt0Scan.Font = new System.Drawing.Font("SimSun", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt0Scan.Location = new System.Drawing.Point(6, 16);
            this.txt0Scan.Multiline = true;
            this.txt0Scan.Name = "txt0Scan";
            this.txt0Scan.Size = new System.Drawing.Size(488, 84);
            this.txt0Scan.TabIndex = 0;
            this.txt0Scan.TextChanged += new System.EventHandler(this.txt0Scan_TextChanged);
            this.txt0Scan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt0Scan_KeyDown);
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(6, 103);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(488, 45);
            this.lblMsg.TabIndex = 1;
            // 
            // gb2det_BatchInfo
            // 
            this.gb2det_BatchInfo.Controls.Add(this.btn1Clear);
            this.gb2det_BatchInfo.Controls.Add(this.button1);
            this.gb2det_BatchInfo.Controls.Add(this.label1);
            this.gb2det_BatchInfo.Controls.Add(this.txt3PalletNoAddNewBatchID);
            this.gb2det_BatchInfo.Controls.Add(this.label8);
            this.gb2det_BatchInfo.Controls.Add(this.label18);
            this.gb2det_BatchInfo.Controls.Add(this.label7);
            this.gb2det_BatchInfo.Controls.Add(this.txt12CartonprifixAddNewBatchID);
            this.gb2det_BatchInfo.Controls.Add(this.label6);
            this.gb2det_BatchInfo.Controls.Add(this.label17);
            this.gb2det_BatchInfo.Controls.Add(this.label5);
            this.gb2det_BatchInfo.Controls.Add(this.label13);
            this.gb2det_BatchInfo.Controls.Add(this.label9);
            this.gb2det_BatchInfo.Controls.Add(this.txt8CartonQtyAddNewBatchID);
            this.gb2det_BatchInfo.Controls.Add(this.label11);
            this.gb2det_BatchInfo.Controls.Add(this.txt14CartonIDFromAddNewBatchID);
            this.gb2det_BatchInfo.Controls.Add(this.txt1BatchIDAddNewBatchID);
            this.gb2det_BatchInfo.Controls.Add(this.txt15CartonIDToAddNewBatchID);
            this.gb2det_BatchInfo.Controls.Add(this.txt5POAddNewBatchID);
            this.gb2det_BatchInfo.Controls.Add(this.txt9QTYAddNewBatchID);
            this.gb2det_BatchInfo.Controls.Add(this.txt7PartAddNewBatchID);
            this.gb2det_BatchInfo.Controls.Add(this.txt10CartonIDAddNewBatchID);
            this.gb2det_BatchInfo.Controls.Add(this.txt2LineIDAddNewBatchID);
            this.gb2det_BatchInfo.Location = new System.Drawing.Point(6, 157);
            this.gb2det_BatchInfo.Name = "gb2det_BatchInfo";
            this.gb2det_BatchInfo.Size = new System.Drawing.Size(508, 211);
            this.gb2det_BatchInfo.TabIndex = 17;
            this.gb2det_BatchInfo.TabStop = false;
            this.gb2det_BatchInfo.Text = "Scan Det";
            // 
            // btn1Clear
            // 
            this.btn1Clear.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn1Clear.Location = new System.Drawing.Point(263, 151);
            this.btn1Clear.Name = "btn1Clear";
            this.btn1Clear.Size = new System.Drawing.Size(75, 47);
            this.btn1Clear.TabIndex = 121;
            this.btn1Clear.Text = "Clear";
            this.btn1Clear.UseVisualStyleBackColor = true;
            this.btn1Clear.Click += new System.EventHandler(this.btn1Clear_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(263, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 100;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frm614ScanForASN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 373);
            this.Controls.Add(this.groupBox0BatchInfo0);
            this.Name = "frm614ScanForASN";
            this.Text = "frm614ScanForASN";
            this.Load += new System.EventHandler(this.frm614ScanForASN_Load);
            this.groupBox0BatchInfo0.ResumeLayout(false);
            this.gb0ScanTxt.ResumeLayout(false);
            this.gb0ScanTxt.PerformLayout();
            this.gb2det_BatchInfo.ResumeLayout(false);
            this.gb2det_BatchInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt3PalletNoAddNewBatchID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt12CartonprifixAddNewBatchID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt8CartonQtyAddNewBatchID;
        private System.Windows.Forms.TextBox txt14CartonIDFromAddNewBatchID;
        private System.Windows.Forms.TextBox txt15CartonIDToAddNewBatchID;
        private System.Windows.Forms.TextBox txt9QTYAddNewBatchID;
        private System.Windows.Forms.TextBox txt10CartonIDAddNewBatchID;
        private System.Windows.Forms.TextBox txt2LineIDAddNewBatchID;
        private System.Windows.Forms.TextBox txt7PartAddNewBatchID;
        private System.Windows.Forms.TextBox txt5POAddNewBatchID;
        private System.Windows.Forms.TextBox txt1BatchIDAddNewBatchID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.GroupBox groupBox0BatchInfo0;
        private System.Windows.Forms.GroupBox gb2det_BatchInfo;
        protected internal System.Windows.Forms.TextBox txt0Scan;
        private GroupBox gb0ScanTxt;
        protected internal Label lblMsg;
        private Button button1;
        private Button btn1Clear;
    }
}