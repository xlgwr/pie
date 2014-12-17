namespace FrmPIE.frmPI
{
    partial class frmPI4AddCoForPallet
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
            this.data1GV1_PIPalletList = new System.Windows.Forms.DataGridView();
            this.gb2det_PIdet = new System.Windows.Forms.GroupBox();
            this.lbl0Msg = new System.Windows.Forms.Label();
            this.gb1mstr_PIMstr = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn0Add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt3CO_Value = new System.Windows.Forms.TextBox();
            this.txt1Co_Name_PIMstr = new System.Windows.Forms.TextBox();
            this.btn1Search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt4PIID_search = new System.Windows.Forms.TextBox();
            this.gb0PIAddCoForPallet = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.data1GV1_PIPalletList)).BeginInit();
            this.gb2det_PIdet.SuspendLayout();
            this.gb1mstr_PIMstr.SuspendLayout();
            this.gb0PIAddCoForPallet.SuspendLayout();
            this.SuspendLayout();
            // 
            // data1GV1_PIPalletList
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data1GV1_PIPalletList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data1GV1_PIPalletList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data1GV1_PIPalletList.DefaultCellStyle = dataGridViewCellStyle2;
            this.data1GV1_PIPalletList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data1GV1_PIPalletList.Location = new System.Drawing.Point(3, 17);
            this.data1GV1_PIPalletList.MultiSelect = false;
            this.data1GV1_PIPalletList.Name = "data1GV1_PIPalletList";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data1GV1_PIPalletList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.data1GV1_PIPalletList.RowTemplate.Height = 23;
            this.data1GV1_PIPalletList.Size = new System.Drawing.Size(437, 221);
            this.data1GV1_PIPalletList.TabIndex = 16;
            // 
            // gb2det_PIdet
            // 
            this.gb2det_PIdet.Controls.Add(this.data1GV1_PIPalletList);
            this.gb2det_PIdet.Location = new System.Drawing.Point(6, 196);
            this.gb2det_PIdet.Name = "gb2det_PIdet";
            this.gb2det_PIdet.Size = new System.Drawing.Size(443, 241);
            this.gb2det_PIdet.TabIndex = 19;
            this.gb2det_PIdet.TabStop = false;
            this.gb2det_PIdet.Text = "Co List";
            // 
            // lbl0Msg
            // 
            this.lbl0Msg.AutoSize = true;
            this.lbl0Msg.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl0Msg.ForeColor = System.Drawing.Color.Red;
            this.lbl0Msg.Location = new System.Drawing.Point(17, 135);
            this.lbl0Msg.Name = "lbl0Msg";
            this.lbl0Msg.Size = new System.Drawing.Size(0, 14);
            this.lbl0Msg.TabIndex = 12;
            // 
            // gb1mstr_PIMstr
            // 
            this.gb1mstr_PIMstr.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb1mstr_PIMstr.Controls.Add(this.button1);
            this.gb1mstr_PIMstr.Controls.Add(this.lbl0Msg);
            this.gb1mstr_PIMstr.Controls.Add(this.btn0Add);
            this.gb1mstr_PIMstr.Controls.Add(this.label6);
            this.gb1mstr_PIMstr.Controls.Add(this.label1);
            this.gb1mstr_PIMstr.Controls.Add(this.txt3CO_Value);
            this.gb1mstr_PIMstr.Controls.Add(this.txt1Co_Name_PIMstr);
            this.gb1mstr_PIMstr.Location = new System.Drawing.Point(6, 7);
            this.gb1mstr_PIMstr.Name = "gb1mstr_PIMstr";
            this.gb1mstr_PIMstr.Size = new System.Drawing.Size(443, 155);
            this.gb1mstr_PIMstr.TabIndex = 20;
            this.gb1mstr_PIMstr.TabStop = false;
            this.gb1mstr_PIMstr.Text = "Add Co for PI Pallet:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "&New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn0Add
            // 
            this.btn0Add.Location = new System.Drawing.Point(228, 106);
            this.btn0Add.Name = "btn0Add";
            this.btn0Add.Size = new System.Drawing.Size(75, 23);
            this.btn0Add.TabIndex = 11;
            this.btn0Add.Text = "&Add";
            this.btn0Add.UseVisualStyleBackColor = true;
            this.btn0Add.Click += new System.EventHandler(this.btn0Add_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(56, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Co Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(48, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Co Value:";
            // 
            // txt3CO_Value
            // 
            this.txt3CO_Value.Location = new System.Drawing.Point(128, 79);
            this.txt3CO_Value.Name = "txt3CO_Value";
            this.txt3CO_Value.Size = new System.Drawing.Size(175, 21);
            this.txt3CO_Value.TabIndex = 11;
            this.txt3CO_Value.Enter += new System.EventHandler(this.txt3CO_Value_Enter);
            // 
            // txt1Co_Name_PIMstr
            // 
            this.txt1Co_Name_PIMstr.Location = new System.Drawing.Point(128, 35);
            this.txt1Co_Name_PIMstr.Name = "txt1Co_Name_PIMstr";
            this.txt1Co_Name_PIMstr.Size = new System.Drawing.Size(175, 21);
            this.txt1Co_Name_PIMstr.TabIndex = 10;
            this.txt1Co_Name_PIMstr.Enter += new System.EventHandler(this.txt1Co_Name_PIMstr_Enter);
            // 
            // btn1Search
            // 
            this.btn1Search.Location = new System.Drawing.Point(282, 166);
            this.btn1Search.Name = "btn1Search";
            this.btn1Search.Size = new System.Drawing.Size(75, 23);
            this.btn1Search.TabIndex = 1;
            this.btn1Search.Text = "Search";
            this.btn1Search.UseVisualStyleBackColor = true;
            this.btn1Search.Click += new System.EventHandler(this.btn1Search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(8, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Co Name:";
            // 
            // txt4PIID_search
            // 
            this.txt4PIID_search.Location = new System.Drawing.Point(78, 167);
            this.txt4PIID_search.Name = "txt4PIID_search";
            this.txt4PIID_search.Size = new System.Drawing.Size(175, 21);
            this.txt4PIID_search.TabIndex = 0;
            this.txt4PIID_search.TextChanged += new System.EventHandler(this.txt4PIID_search_TextChanged);
            // 
            // gb0PIAddCoForPallet
            // 
            this.gb0PIAddCoForPallet.Controls.Add(this.btn1Search);
            this.gb0PIAddCoForPallet.Controls.Add(this.label2);
            this.gb0PIAddCoForPallet.Controls.Add(this.txt4PIID_search);
            this.gb0PIAddCoForPallet.Controls.Add(this.gb1mstr_PIMstr);
            this.gb0PIAddCoForPallet.Controls.Add(this.gb2det_PIdet);
            this.gb0PIAddCoForPallet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb0PIAddCoForPallet.Location = new System.Drawing.Point(0, 0);
            this.gb0PIAddCoForPallet.Name = "gb0PIAddCoForPallet";
            this.gb0PIAddCoForPallet.Size = new System.Drawing.Size(455, 443);
            this.gb0PIAddCoForPallet.TabIndex = 2;
            this.gb0PIAddCoForPallet.TabStop = false;
            // 
            // frmPI4AddCoForPallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 443);
            this.Controls.Add(this.gb0PIAddCoForPallet);
            this.Name = "frmPI4AddCoForPallet";
            this.Text = "AddCoForPallet";
            ((System.ComponentModel.ISupportInitialize)(this.data1GV1_PIPalletList)).EndInit();
            this.gb2det_PIdet.ResumeLayout(false);
            this.gb1mstr_PIMstr.ResumeLayout(false);
            this.gb1mstr_PIMstr.PerformLayout();
            this.gb0PIAddCoForPallet.ResumeLayout(false);
            this.gb0PIAddCoForPallet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.DataGridView data1GV1_PIPalletList;
        private System.Windows.Forms.GroupBox gb2det_PIdet;
        private System.Windows.Forms.Label lbl0Msg;
        private System.Windows.Forms.GroupBox gb1mstr_PIMstr;
        protected internal System.Windows.Forms.Button btn0Add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt3CO_Value;
        private System.Windows.Forms.TextBox txt1Co_Name_PIMstr;
        protected internal System.Windows.Forms.Button btn1Search;
        private System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.TextBox txt4PIID_search;
        protected internal System.Windows.Forms.GroupBox gb0PIAddCoForPallet;
        private System.Windows.Forms.Button button1;
    }
}