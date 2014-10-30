namespace FrmPIE
{
    partial class AdminManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManage));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUserMsg = new System.Windows.Forms.Label();
            this.lblRoleMsg = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cmbcomp0 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.btn3ChangePassWD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(96, 58);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(121, 21);
            this.txtUserName.TabIndex = 1;
            // 
            // cmbUsers
            // 
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(96, 93);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(121, 20);
            this.cmbUsers.TabIndex = 2;
            this.cmbUsers.SelectedValueChanged += new System.EventHandler(this.cmbUsers_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "用户名：";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(419, 56);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "&Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // cmbRoles
            // 
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(292, 92);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(121, 20);
            this.cmbRoles.TabIndex = 7;
            this.cmbRoles.SelectedValueChanged += new System.EventHandler(this.cmbRoles_SelectedValueChanged);
            // 
            // btnAddRole
            // 
            this.btnAddRole.Location = new System.Drawing.Point(419, 91);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(75, 23);
            this.btnAddRole.TabIndex = 8;
            this.btnAddRole.Text = "A&dd Role";
            this.btnAddRole.UseVisualStyleBackColor = true;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "角色名：";
            // 
            // lblUserMsg
            // 
            this.lblUserMsg.AutoSize = true;
            this.lblUserMsg.ForeColor = System.Drawing.Color.Red;
            this.lblUserMsg.Location = new System.Drawing.Point(47, 165);
            this.lblUserMsg.Name = "lblUserMsg";
            this.lblUserMsg.Size = new System.Drawing.Size(0, 12);
            this.lblUserMsg.TabIndex = 9;
            // 
            // lblRoleMsg
            // 
            this.lblRoleMsg.AutoSize = true;
            this.lblRoleMsg.ForeColor = System.Drawing.Color.Green;
            this.lblRoleMsg.Location = new System.Drawing.Point(47, 231);
            this.lblRoleMsg.Name = "lblRoleMsg";
            this.lblRoleMsg.Size = new System.Drawing.Size(0, 12);
            this.lblRoleMsg.TabIndex = 10;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(419, 119);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "&Remove Role";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // cmbcomp0
            // 
            this.cmbcomp0.FormattingEnabled = true;
            this.cmbcomp0.Items.AddRange(new object[] {
            "WWTS",
            "WTSZ",
            "WEC"});
            this.cmbcomp0.Location = new System.Drawing.Point(96, 24);
            this.cmbcomp0.Name = "cmbcomp0";
            this.cmbcomp0.Size = new System.Drawing.Size(121, 20);
            this.cmbcomp0.TabIndex = 12;
            this.cmbcomp0.Text = "WWTS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "公司：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "Passwd：";
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(292, 58);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(121, 21);
            this.txtpwd.TabIndex = 1;
            // 
            // btn3ChangePassWD
            // 
            this.btn3ChangePassWD.Location = new System.Drawing.Point(292, 24);
            this.btn3ChangePassWD.Name = "btn3ChangePassWD";
            this.btn3ChangePassWD.Size = new System.Drawing.Size(106, 23);
            this.btn3ChangePassWD.TabIndex = 14;
            this.btn3ChangePassWD.Text = "&ChangePassword";
            this.btn3ChangePassWD.UseVisualStyleBackColor = true;
            this.btn3ChangePassWD.Click += new System.EventHandler(this.btn3ChangePassWD_Click);
            // 
            // AdminManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(595, 294);
            this.Controls.Add(this.btn3ChangePassWD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbcomp0);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblRoleMsg);
            this.Controls.Add(this.lblUserMsg);
            this.Controls.Add(this.btnAddRole);
            this.Controls.Add(this.cmbRoles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.cmbUsers);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminManage";
            this.Load += new System.EventHandler(this.AdminManage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUserMsg;
        private System.Windows.Forms.Label lblRoleMsg;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox cmbcomp0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.Button btn3ChangePassWD;
    }
}