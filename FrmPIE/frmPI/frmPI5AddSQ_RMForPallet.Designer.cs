namespace FrmPIE.frmPI
{
    partial class frmPI5AddSQ_RMForPallet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb0PIAddCoForPallet = new System.Windows.Forms.GroupBox();
            this.btn1Search = new System.Windows.Forms.Button();
            this.txt4PIID_search = new System.Windows.Forms.TextBox();
            this.gb1mstr_PIMstr = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSQ3Desc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl0Msg = new System.Windows.Forms.Label();
            this.btn0Add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSQ2Name = new System.Windows.Forms.TextBox();
            this.txt1SQID_PIMstr = new System.Windows.Forms.TextBox();
            this.gb2det_PIdet = new System.Windows.Forms.GroupBox();
            this.data1GV1_PIPalletList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.gb0PIAddCoForPallet.SuspendLayout();
            this.gb1mstr_PIMstr.SuspendLayout();
            this.gb2det_PIdet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data1GV1_PIPalletList)).BeginInit();
            this.SuspendLayout();
            // 
            // gb0PIAddCoForPallet
            // 
            this.gb0PIAddCoForPallet.Controls.Add(this.btn1Search);
            this.gb0PIAddCoForPallet.Controls.Add(this.txt4PIID_search);
            this.gb0PIAddCoForPallet.Controls.Add(this.gb1mstr_PIMstr);
            this.gb0PIAddCoForPallet.Controls.Add(this.gb2det_PIdet);
            this.gb0PIAddCoForPallet.Controls.Add(this.label2);
            this.gb0PIAddCoForPallet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb0PIAddCoForPallet.Location = new System.Drawing.Point(0, 0);
            this.gb0PIAddCoForPallet.Name = "gb0PIAddCoForPallet";
            this.gb0PIAddCoForPallet.Size = new System.Drawing.Size(455, 443);
            this.gb0PIAddCoForPallet.TabIndex = 3;
            this.gb0PIAddCoForPallet.TabStop = false;
            // 
            // btn1Search
            // 
            this.btn1Search.Location = new System.Drawing.Point(286, 197);
            this.btn1Search.Name = "btn1Search";
            this.btn1Search.Size = new System.Drawing.Size(75, 23);
            this.btn1Search.TabIndex = 1;
            this.btn1Search.Text = "Search";
            this.btn1Search.UseVisualStyleBackColor = true;
            this.btn1Search.Click += new System.EventHandler(this.btn1Search_Click);
            // 
            // txt4PIID_search
            // 
            this.txt4PIID_search.Location = new System.Drawing.Point(82, 199);
            this.txt4PIID_search.Name = "txt4PIID_search";
            this.txt4PIID_search.Size = new System.Drawing.Size(175, 21);
            this.txt4PIID_search.TabIndex = 0;
            this.txt4PIID_search.TextChanged += new System.EventHandler(this.txt4PIID_search_TextChanged_1);
            this.txt4PIID_search.Enter += new System.EventHandler(this.txt4PIID_search_TextChanged);
            // 
            // gb1mstr_PIMstr
            // 
            this.gb1mstr_PIMstr.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb1mstr_PIMstr.Controls.Add(this.label3);
            this.gb1mstr_PIMstr.Controls.Add(this.txtSQ3Desc);
            this.gb1mstr_PIMstr.Controls.Add(this.button1);
            this.gb1mstr_PIMstr.Controls.Add(this.lbl0Msg);
            this.gb1mstr_PIMstr.Controls.Add(this.btn0Add);
            this.gb1mstr_PIMstr.Controls.Add(this.label6);
            this.gb1mstr_PIMstr.Controls.Add(this.label1);
            this.gb1mstr_PIMstr.Controls.Add(this.txtSQ2Name);
            this.gb1mstr_PIMstr.Controls.Add(this.txt1SQID_PIMstr);
            this.gb1mstr_PIMstr.Location = new System.Drawing.Point(6, 7);
            this.gb1mstr_PIMstr.Name = "gb1mstr_PIMstr";
            this.gb1mstr_PIMstr.Size = new System.Drawing.Size(443, 181);
            this.gb1mstr_PIMstr.TabIndex = 20;
            this.gb1mstr_PIMstr.TabStop = false;
            this.gb1mstr_PIMstr.Text = "Add SQ RM for PI Pallet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(79, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "SQ DESC:";
            // 
            // txtSQ3Desc
            // 
            this.txtSQ3Desc.Location = new System.Drawing.Point(159, 80);
            this.txtSQ3Desc.Multiline = true;
            this.txtSQ3Desc.Name = "txtSQ3Desc";
            this.txtSQ3Desc.Size = new System.Drawing.Size(175, 41);
            this.txtSQ3Desc.TabIndex = 12;
            this.txtSQ3Desc.TextChanged += new System.EventHandler(this.txtSQ3Desc_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "&New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl0Msg
            // 
            this.lbl0Msg.AutoSize = true;
            this.lbl0Msg.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl0Msg.ForeColor = System.Drawing.Color.Red;
            this.lbl0Msg.Location = new System.Drawing.Point(17, 156);
            this.lbl0Msg.Name = "lbl0Msg";
            this.lbl0Msg.Size = new System.Drawing.Size(0, 14);
            this.lbl0Msg.TabIndex = 12;
            // 
            // btn0Add
            // 
            this.btn0Add.Location = new System.Drawing.Point(259, 131);
            this.btn0Add.Name = "btn0Add";
            this.btn0Add.Size = new System.Drawing.Size(75, 23);
            this.btn0Add.TabIndex = 13;
            this.btn0Add.Text = "&Add";
            this.btn0Add.UseVisualStyleBackColor = true;
            this.btn0Add.Click += new System.EventHandler(this.btn0Add_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(87, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "SQ ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(79, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "SQ Name:";
            // 
            // txtSQ2Name
            // 
            this.txtSQ2Name.Location = new System.Drawing.Point(159, 53);
            this.txtSQ2Name.Name = "txtSQ2Name";
            this.txtSQ2Name.Size = new System.Drawing.Size(175, 21);
            this.txtSQ2Name.TabIndex = 11;
            this.txtSQ2Name.Enter += new System.EventHandler(this.txt3CO_Value_Enter);
            // 
            // txt1SQID_PIMstr
            // 
            this.txt1SQID_PIMstr.Location = new System.Drawing.Point(159, 23);
            this.txt1SQID_PIMstr.Name = "txt1SQID_PIMstr";
            this.txt1SQID_PIMstr.Size = new System.Drawing.Size(175, 21);
            this.txt1SQID_PIMstr.TabIndex = 10;
            this.txt1SQID_PIMstr.Enter += new System.EventHandler(this.txt1Co_Name_PIMstr_Enter);
            // 
            // gb2det_PIdet
            // 
            this.gb2det_PIdet.Controls.Add(this.data1GV1_PIPalletList);
            this.gb2det_PIdet.Location = new System.Drawing.Point(6, 228);
            this.gb2det_PIdet.Name = "gb2det_PIdet";
            this.gb2det_PIdet.Size = new System.Drawing.Size(443, 209);
            this.gb2det_PIdet.TabIndex = 19;
            this.gb2det_PIdet.TabStop = false;
            this.gb2det_PIdet.Text = "SQ List";
            // 
            // data1GV1_PIPalletList
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data1GV1_PIPalletList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.data1GV1_PIPalletList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data1GV1_PIPalletList.DefaultCellStyle = dataGridViewCellStyle5;
            this.data1GV1_PIPalletList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data1GV1_PIPalletList.Location = new System.Drawing.Point(3, 17);
            this.data1GV1_PIPalletList.MultiSelect = false;
            this.data1GV1_PIPalletList.Name = "data1GV1_PIPalletList";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data1GV1_PIPalletList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.data1GV1_PIPalletList.RowTemplate.Height = 23;
            this.data1GV1_PIPalletList.Size = new System.Drawing.Size(437, 189);
            this.data1GV1_PIPalletList.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(5, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "SQ RM ID:";
            // 
            // frmPI5AddSQ_RMForPallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 443);
            this.Controls.Add(this.gb0PIAddCoForPallet);
            this.Name = "frmPI5AddSQ_RMForPallet";
            this.Text = "frmPI5AddSForPallet";
            this.gb0PIAddCoForPallet.ResumeLayout(false);
            this.gb0PIAddCoForPallet.PerformLayout();
            this.gb1mstr_PIMstr.ResumeLayout(false);
            this.gb1mstr_PIMstr.PerformLayout();
            this.gb2det_PIdet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data1GV1_PIPalletList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.GroupBox gb0PIAddCoForPallet;
        protected internal System.Windows.Forms.Button btn1Search;
        private System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.TextBox txt4PIID_search;
        private System.Windows.Forms.GroupBox gb1mstr_PIMstr;
        private System.Windows.Forms.Button button1;
        protected internal System.Windows.Forms.Button btn0Add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb2det_PIdet;
        protected internal System.Windows.Forms.DataGridView data1GV1_PIPalletList;
        private System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.Label lbl0Msg;
        protected internal System.Windows.Forms.TextBox txt1SQID_PIMstr;
        protected internal System.Windows.Forms.TextBox txtSQ2Name;
        protected internal System.Windows.Forms.TextBox txtSQ3Desc;
    }
}