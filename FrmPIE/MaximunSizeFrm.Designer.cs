namespace FrmPIE
{
    partial class MaximunSizeFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaximunSizeFrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGVMax = new System.Windows.Forms.DataGridView();
            this.lblmessage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVMax)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGVMax);
            this.groupBox1.Location = new System.Drawing.Point(6, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 417);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dataGVMax
            // 
            this.dataGVMax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVMax.Location = new System.Drawing.Point(6, 14);
            this.dataGVMax.MultiSelect = false;
            this.dataGVMax.Name = "dataGVMax";
            this.dataGVMax.ReadOnly = true;
            this.dataGVMax.RowTemplate.Height = 23;
            this.dataGVMax.Size = new System.Drawing.Size(769, 397);
            this.dataGVMax.TabIndex = 0;
            this.dataGVMax.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVMax_CellClick);
            this.dataGVMax.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dataGVMax_CellContextMenuStripNeeded);
            this.dataGVMax.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVMax_CellDoubleClick);
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblmessage.Location = new System.Drawing.Point(12, 9);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(32, 16);
            this.lblmessage.TabIndex = 1;
            this.lblmessage.Text = "msg";
            // 
            // MaximunSizeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 446);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MaximunSizeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaximunSizeFrm";
            this.Activated += new System.EventHandler(this.MaximunSizeFrm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MaximunSizeFrm_FormClosing);
            this.Load += new System.EventHandler(this.MaximunSizeFrm_Load);
            this.Resize += new System.EventHandler(this.MaximunSizeFrm_Resize);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        protected internal System.Windows.Forms.DataGridView dataGVMax;
        private System.Windows.Forms.Label lblmessage;
    }
}