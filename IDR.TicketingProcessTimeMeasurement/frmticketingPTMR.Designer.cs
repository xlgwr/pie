namespace IDR.TicketingProcessTimeMeasurement
{
    partial class frmticketingPTMR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmticketingPTMR));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn1In = new System.Windows.Forms.Button();
            this.btn2Back = new System.Windows.Forms.Button();
            this.btn3Rece = new System.Windows.Forms.Button();
            this.btn4Leave = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn1In);
            this.flowLayoutPanel1.Controls.Add(this.btn2Back);
            this.flowLayoutPanel1.Controls.Add(this.btn3Rece);
            this.flowLayoutPanel1.Controls.Add(this.btn4Leave);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(302, 278);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btn1In
            // 
            this.btn1In.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn1In.Location = new System.Drawing.Point(3, 3);
            this.btn1In.Name = "btn1In";
            this.btn1In.Size = new System.Drawing.Size(143, 130);
            this.btn1In.TabIndex = 0;
            this.btn1In.Text = "入单";
            this.btn1In.UseVisualStyleBackColor = true;
            this.btn1In.Click += new System.EventHandler(this.btn1In_Click);
            // 
            // btn2Back
            // 
            this.btn2Back.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn2Back.Location = new System.Drawing.Point(152, 3);
            this.btn2Back.Name = "btn2Back";
            this.btn2Back.Size = new System.Drawing.Size(143, 130);
            this.btn2Back.TabIndex = 1;
            this.btn2Back.Text = "返回时间";
            this.btn2Back.UseVisualStyleBackColor = true;
            this.btn2Back.Click += new System.EventHandler(this.btn2Back_Click);
            // 
            // btn3Rece
            // 
            this.btn3Rece.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn3Rece.Location = new System.Drawing.Point(3, 139);
            this.btn3Rece.Name = "btn3Rece";
            this.btn3Rece.Size = new System.Drawing.Size(143, 130);
            this.btn3Rece.TabIndex = 2;
            this.btn3Rece.Text = "收货";
            this.btn3Rece.UseVisualStyleBackColor = true;
            this.btn3Rece.Click += new System.EventHandler(this.btn3Rece_Click);
            // 
            // btn4Leave
            // 
            this.btn4Leave.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn4Leave.Location = new System.Drawing.Point(152, 139);
            this.btn4Leave.Name = "btn4Leave";
            this.btn4Leave.Size = new System.Drawing.Size(143, 130);
            this.btn4Leave.TabIndex = 3;
            this.btn4Leave.Text = "离开时间";
            this.btn4Leave.UseVisualStyleBackColor = true;
            this.btn4Leave.Click += new System.EventHandler(this.btn4Leave_Click);
            // 
            // frmticketingPTMR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(302, 278);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmticketingPTMR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticketing System For Process Time Measurement";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn1In;
        private System.Windows.Forms.Button btn2Back;
        private System.Windows.Forms.Button btn3Rece;
        private System.Windows.Forms.Button btn4Leave;
    }
}

