namespace IDR.Frm.frmPI
{
    partial class frmPI0PIInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.data1GV1_PIdet = new System.Windows.Forms.DataGridView();
            this.gb2det_PIdet = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt5_cre_date_PIMstr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt3Type_PIMstr = new System.Windows.Forms.TextBox();
            this.txt2_Plant_PIMstr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt1PI_id_PIMstr = new System.Windows.Forms.TextBox();
            this.gb1mstr_PIMstr = new System.Windows.Forms.GroupBox();
            this.gb00PIScanPIDataitemInquire = new System.Windows.Forms.GroupBox();
            this.tsm0menu_EnquireByPart = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi00enquireByPartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi01downLoad1ToExceltoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.data1GV1_PIdet)).BeginInit();
            this.gb2det_PIdet.SuspendLayout();
            this.gb1mstr_PIMstr.SuspendLayout();
            this.gb00PIScanPIDataitemInquire.SuspendLayout();
            this.tsm0menu_EnquireByPart.SuspendLayout();
            this.SuspendLayout();
            // 
            // data1GV1_PIdet
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data1GV1_PIdet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data1GV1_PIdet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data1GV1_PIdet.DefaultCellStyle = dataGridViewCellStyle2;
            this.data1GV1_PIdet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data1GV1_PIdet.Location = new System.Drawing.Point(3, 17);
            this.data1GV1_PIdet.MultiSelect = false;
            this.data1GV1_PIdet.Name = "data1GV1_PIdet";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data1GV1_PIdet.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.data1GV1_PIdet.RowTemplate.Height = 23;
            this.data1GV1_PIdet.Size = new System.Drawing.Size(708, 165);
            this.data1GV1_PIdet.TabIndex = 16;
            // 
            // gb2det_PIdet
            // 
            this.gb2det_PIdet.Controls.Add(this.data1GV1_PIdet);
            this.gb2det_PIdet.Location = new System.Drawing.Point(6, 68);
            this.gb2det_PIdet.Name = "gb2det_PIdet";
            this.gb2det_PIdet.Size = new System.Drawing.Size(714, 185);
            this.gb2det_PIdet.TabIndex = 19;
            this.gb2det_PIdet.TabStop = false;
            this.gb2det_PIdet.Text = "PI Det";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "PI ID:";
            // 
            // txt5_cre_date_PIMstr
            // 
            this.txt5_cre_date_PIMstr.Location = new System.Drawing.Point(542, 21);
            this.txt5_cre_date_PIMstr.Name = "txt5_cre_date_PIMstr";
            this.txt5_cre_date_PIMstr.Size = new System.Drawing.Size(158, 21);
            this.txt5_cre_date_PIMstr.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(156, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Plant:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "Create Date:";
            // 
            // txt3Type_PIMstr
            // 
            this.txt3Type_PIMstr.Location = new System.Drawing.Point(341, 21);
            this.txt3Type_PIMstr.Name = "txt3Type_PIMstr";
            this.txt3Type_PIMstr.Size = new System.Drawing.Size(124, 21);
            this.txt3Type_PIMstr.TabIndex = 5;
            // 
            // txt2_Plant_PIMstr
            // 
            this.txt2_Plant_PIMstr.Location = new System.Drawing.Point(212, 21);
            this.txt2_Plant_PIMstr.Name = "txt2_Plant_PIMstr";
            this.txt2_Plant_PIMstr.Size = new System.Drawing.Size(94, 21);
            this.txt2_Plant_PIMstr.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type:";
            // 
            // txt1PI_id_PIMstr
            // 
            this.txt1PI_id_PIMstr.Location = new System.Drawing.Point(62, 21);
            this.txt1PI_id_PIMstr.Name = "txt1PI_id_PIMstr";
            this.txt1PI_id_PIMstr.Size = new System.Drawing.Size(94, 21);
            this.txt1PI_id_PIMstr.TabIndex = 1;
            // 
            // gb1mstr_PIMstr
            // 
            this.gb1mstr_PIMstr.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb1mstr_PIMstr.Controls.Add(this.label6);
            this.gb1mstr_PIMstr.Controls.Add(this.txt5_cre_date_PIMstr);
            this.gb1mstr_PIMstr.Controls.Add(this.label8);
            this.gb1mstr_PIMstr.Controls.Add(this.label5);
            this.gb1mstr_PIMstr.Controls.Add(this.txt3Type_PIMstr);
            this.gb1mstr_PIMstr.Controls.Add(this.txt2_Plant_PIMstr);
            this.gb1mstr_PIMstr.Controls.Add(this.label2);
            this.gb1mstr_PIMstr.Controls.Add(this.txt1PI_id_PIMstr);
            this.gb1mstr_PIMstr.Location = new System.Drawing.Point(6, 7);
            this.gb1mstr_PIMstr.Name = "gb1mstr_PIMstr";
            this.gb1mstr_PIMstr.Size = new System.Drawing.Size(714, 55);
            this.gb1mstr_PIMstr.TabIndex = 20;
            this.gb1mstr_PIMstr.TabStop = false;
            this.gb1mstr_PIMstr.Text = "PI Mstr";
            // 
            // gb00PIScanPIDataitemInquire
            // 
            this.gb00PIScanPIDataitemInquire.Controls.Add(this.gb1mstr_PIMstr);
            this.gb00PIScanPIDataitemInquire.Controls.Add(this.gb2det_PIdet);
            this.gb00PIScanPIDataitemInquire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb00PIScanPIDataitemInquire.Location = new System.Drawing.Point(0, 0);
            this.gb00PIScanPIDataitemInquire.Name = "gb00PIScanPIDataitemInquire";
            this.gb00PIScanPIDataitemInquire.Size = new System.Drawing.Size(727, 257);
            this.gb00PIScanPIDataitemInquire.TabIndex = 1;
            this.gb00PIScanPIDataitemInquire.TabStop = false;
            // 
            // tsm0menu_EnquireByPart
            // 
            this.tsm0menu_EnquireByPart.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi00enquireByPartToolStripMenuItem,
            this.tsmi01downLoad1ToExceltoolStripMenuItem2});
            this.tsm0menu_EnquireByPart.Name = "ctmenu0EnquireByPart";
            this.tsm0menu_EnquireByPart.Size = new System.Drawing.Size(191, 70);
            // 
            // tsmi00enquireByPartToolStripMenuItem
            // 
            this.tsmi00enquireByPartToolStripMenuItem.Name = "tsmi00enquireByPartToolStripMenuItem";
            this.tsmi00enquireByPartToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.tsmi00enquireByPartToolStripMenuItem.Text = "Enquire by &Part";
            // 
            // tsmi01downLoad1ToExceltoolStripMenuItem2
            // 
            this.tsmi01downLoad1ToExceltoolStripMenuItem2.Name = "tsmi01downLoad1ToExceltoolStripMenuItem2";
            this.tsmi01downLoad1ToExceltoolStripMenuItem2.Size = new System.Drawing.Size(190, 22);
            this.tsmi01downLoad1ToExceltoolStripMenuItem2.Text = "&DownLoad To Excel";
            this.tsmi01downLoad1ToExceltoolStripMenuItem2.Click += new System.EventHandler(this.tsmi01downLoad1ToExceltoolStripMenuItem2_Click);
            // 
            // frmPI0PIInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 257);
            this.Controls.Add(this.gb00PIScanPIDataitemInquire);
            this.Name = "frmPI0PIInfo";
            this.Text = "frmPI0PIInfo";
            ((System.ComponentModel.ISupportInitialize)(this.data1GV1_PIdet)).EndInit();
            this.gb2det_PIdet.ResumeLayout(false);
            this.gb1mstr_PIMstr.ResumeLayout(false);
            this.gb1mstr_PIMstr.PerformLayout();
            this.gb00PIScanPIDataitemInquire.ResumeLayout(false);
            this.tsm0menu_EnquireByPart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.DataGridView data1GV1_PIdet;
        private System.Windows.Forms.GroupBox gb2det_PIdet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt5_cre_date_PIMstr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt3Type_PIMstr;
        private System.Windows.Forms.TextBox txt2_Plant_PIMstr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt1PI_id_PIMstr;
        private System.Windows.Forms.GroupBox gb1mstr_PIMstr;
        protected internal System.Windows.Forms.GroupBox gb00PIScanPIDataitemInquire;
        private System.Windows.Forms.ContextMenuStrip tsm0menu_EnquireByPart;
        private System.Windows.Forms.ToolStripMenuItem tsmi00enquireByPartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi01downLoad1ToExceltoolStripMenuItem2;
    }
}