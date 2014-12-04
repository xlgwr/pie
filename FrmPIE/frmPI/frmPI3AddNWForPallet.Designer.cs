namespace FrmPIE.frmPI
{
    partial class frmPI3AddNWForPallet
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
            this.gb0PIAddNWForPallet = new System.Windows.Forms.GroupBox();
            this.btn00More = new System.Windows.Forms.Button();
            this.btn1Search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt4PIID_search = new System.Windows.Forms.TextBox();
            this.gb1mstr_PIMstr = new System.Windows.Forms.GroupBox();
            this.lbl0Msg = new System.Windows.Forms.Label();
            this.btn0Add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt3NW = new System.Windows.Forms.TextBox();
            this.txt2_Plant_PIMstr = new System.Windows.Forms.TextBox();
            this.txt1PI_id_PIMstr = new System.Windows.Forms.TextBox();
            this.gb2det_PIdet = new System.Windows.Forms.GroupBox();
            this.data1GV1_PIPalletList = new System.Windows.Forms.DataGridView();
            this.gb0PIAddNWForPallet.SuspendLayout();
            this.gb1mstr_PIMstr.SuspendLayout();
            this.gb2det_PIdet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data1GV1_PIPalletList)).BeginInit();
            this.SuspendLayout();
            // 
            // gb0PIAddNWForPallet
            // 
            this.gb0PIAddNWForPallet.Controls.Add(this.btn00More);
            this.gb0PIAddNWForPallet.Controls.Add(this.btn1Search);
            this.gb0PIAddNWForPallet.Controls.Add(this.label2);
            this.gb0PIAddNWForPallet.Controls.Add(this.txt4PIID_search);
            this.gb0PIAddNWForPallet.Controls.Add(this.gb1mstr_PIMstr);
            this.gb0PIAddNWForPallet.Controls.Add(this.gb2det_PIdet);
            this.gb0PIAddNWForPallet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb0PIAddNWForPallet.Location = new System.Drawing.Point(0, 0);
            this.gb0PIAddNWForPallet.Name = "gb0PIAddNWForPallet";
            this.gb0PIAddNWForPallet.Size = new System.Drawing.Size(455, 443);
            this.gb0PIAddNWForPallet.TabIndex = 1;
            this.gb0PIAddNWForPallet.TabStop = false;
            // 
            // btn00More
            // 
            this.btn00More.BackgroundImage = global::FrmPIE.Properties.Resources._26;
            this.btn00More.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn00More.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn00More.FlatAppearance.BorderSize = 0;
            this.btn00More.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn00More.ForeColor = System.Drawing.SystemColors.Control;
            this.btn00More.Location = new System.Drawing.Point(253, 166);
            this.btn00More.Name = "btn00More";
            this.btn00More.Size = new System.Drawing.Size(23, 23);
            this.btn00More.TabIndex = 24;
            this.btn00More.UseVisualStyleBackColor = true;
            // 
            // btn1Search
            // 
            this.btn1Search.Location = new System.Drawing.Point(282, 166);
            this.btn1Search.Name = "btn1Search";
            this.btn1Search.Size = new System.Drawing.Size(75, 23);
            this.btn1Search.TabIndex = 23;
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
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "PI ID:";
            // 
            // txt4PIID_search
            // 
            this.txt4PIID_search.Location = new System.Drawing.Point(78, 167);
            this.txt4PIID_search.Name = "txt4PIID_search";
            this.txt4PIID_search.Size = new System.Drawing.Size(175, 21);
            this.txt4PIID_search.TabIndex = 21;
            this.txt4PIID_search.TextChanged += new System.EventHandler(this.txt4PIID_search_TextChanged);
            // 
            // gb1mstr_PIMstr
            // 
            this.gb1mstr_PIMstr.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb1mstr_PIMstr.Controls.Add(this.lbl0Msg);
            this.gb1mstr_PIMstr.Controls.Add(this.btn0Add);
            this.gb1mstr_PIMstr.Controls.Add(this.label6);
            this.gb1mstr_PIMstr.Controls.Add(this.label1);
            this.gb1mstr_PIMstr.Controls.Add(this.label8);
            this.gb1mstr_PIMstr.Controls.Add(this.txt3NW);
            this.gb1mstr_PIMstr.Controls.Add(this.txt2_Plant_PIMstr);
            this.gb1mstr_PIMstr.Controls.Add(this.txt1PI_id_PIMstr);
            this.gb1mstr_PIMstr.Location = new System.Drawing.Point(6, 7);
            this.gb1mstr_PIMstr.Name = "gb1mstr_PIMstr";
            this.gb1mstr_PIMstr.Size = new System.Drawing.Size(443, 155);
            this.gb1mstr_PIMstr.TabIndex = 20;
            this.gb1mstr_PIMstr.TabStop = false;
            this.gb1mstr_PIMstr.Text = "Add NW for PI Pallet:";
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
            // btn0Add
            // 
            this.btn0Add.Location = new System.Drawing.Point(187, 106);
            this.btn0Add.Name = "btn0Add";
            this.btn0Add.Size = new System.Drawing.Size(75, 23);
            this.btn0Add.TabIndex = 11;
            this.btn0Add.Text = "Add";
            this.btn0Add.UseVisualStyleBackColor = true;
            this.btn0Add.Click += new System.EventHandler(this.btn0Add_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(94, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "PI ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(118, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "GW:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(86, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Pallet:";
            // 
            // txt3NW
            // 
            this.txt3NW.Location = new System.Drawing.Point(150, 79);
            this.txt3NW.Name = "txt3NW";
            this.txt3NW.Size = new System.Drawing.Size(175, 21);
            this.txt3NW.TabIndex = 3;
            this.txt3NW.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt2_Plant_PIMstr
            // 
            this.txt2_Plant_PIMstr.Location = new System.Drawing.Point(150, 53);
            this.txt2_Plant_PIMstr.Name = "txt2_Plant_PIMstr";
            this.txt2_Plant_PIMstr.ReadOnly = true;
            this.txt2_Plant_PIMstr.Size = new System.Drawing.Size(175, 21);
            this.txt2_Plant_PIMstr.TabIndex = 3;
            // 
            // txt1PI_id_PIMstr
            // 
            this.txt1PI_id_PIMstr.Location = new System.Drawing.Point(150, 27);
            this.txt1PI_id_PIMstr.Name = "txt1PI_id_PIMstr";
            this.txt1PI_id_PIMstr.ReadOnly = true;
            this.txt1PI_id_PIMstr.Size = new System.Drawing.Size(175, 21);
            this.txt1PI_id_PIMstr.TabIndex = 1;
            // 
            // gb2det_PIdet
            // 
            this.gb2det_PIdet.Controls.Add(this.data1GV1_PIPalletList);
            this.gb2det_PIdet.Location = new System.Drawing.Point(6, 196);
            this.gb2det_PIdet.Name = "gb2det_PIdet";
            this.gb2det_PIdet.Size = new System.Drawing.Size(443, 241);
            this.gb2det_PIdet.TabIndex = 19;
            this.gb2det_PIdet.TabStop = false;
            this.gb2det_PIdet.Text = "PI of Pallet List";
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
            // frmPI3AddNWForPallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 443);
            this.Controls.Add(this.gb0PIAddNWForPallet);
            this.Name = "frmPI3AddNWForPallet";
            this.Text = "frmPI3AddNWForPallet";
            this.Load += new System.EventHandler(this.frmPI3AddNWForPallet_Load);
            this.gb0PIAddNWForPallet.ResumeLayout(false);
            this.gb0PIAddNWForPallet.PerformLayout();
            this.gb1mstr_PIMstr.ResumeLayout(false);
            this.gb1mstr_PIMstr.PerformLayout();
            this.gb2det_PIdet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data1GV1_PIPalletList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.GroupBox gb0PIAddNWForPallet;
        private System.Windows.Forms.GroupBox gb1mstr_PIMstr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt3NW;
        private System.Windows.Forms.TextBox txt2_Plant_PIMstr;
        private System.Windows.Forms.TextBox txt1PI_id_PIMstr;
        private System.Windows.Forms.GroupBox gb2det_PIdet;
        protected internal System.Windows.Forms.DataGridView data1GV1_PIPalletList;
        private System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.Button btn0Add;
        protected internal System.Windows.Forms.Button btn1Search;
        protected internal System.Windows.Forms.TextBox txt4PIID_search;
        private System.Windows.Forms.Label lbl0Msg;
        private System.Windows.Forms.Button btn00More;

    }
}