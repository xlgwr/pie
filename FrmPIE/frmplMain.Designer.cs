namespace FrmPIE
{
    partial class frmplMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmplMain));
            this.btnUpadeAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGenCartonNo2 = new System.Windows.Forms.Button();
            this.lbl_CartonGen = new System.Windows.Forms.Label();
            this.lblPoCheckResult = new System.Windows.Forms.Label();
            this.btnPoCheck = new System.Windows.Forms.Button();
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.btngo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPalletNo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtplr_suppliers_id = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCartonprifix = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dateTimeDeliDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimeRecDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCartonQty = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCartonIDFrom = new System.Windows.Forms.TextBox();
            this.txtCartonIDTo = new System.Windows.Forms.TextBox();
            this.txtCartonType = new System.Windows.Forms.TextBox();
            this.txtQTY = new System.Windows.Forms.TextBox();
            this.txtCartonID = new System.Windows.Forms.TextBox();
            this.txtLineID = new System.Windows.Forms.TextBox();
            this.txtPart = new System.Windows.Forms.TextBox();
            this.txtPO = new System.Windows.Forms.TextBox();
            this.txtInvoiceID = new System.Windows.Forms.TextBox();
            this.txtPackingListID = new System.Windows.Forms.TextBox();
            this.txtBatchID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStripMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpadeAdd
            // 
            this.btnUpadeAdd.Location = new System.Drawing.Point(284, 389);
            this.btnUpadeAdd.Name = "btnUpadeAdd";
            this.btnUpadeAdd.Size = new System.Drawing.Size(94, 28);
            this.btnUpadeAdd.TabIndex = 81;
            this.btnUpadeAdd.Text = "&Update";
            this.btnUpadeAdd.UseVisualStyleBackColor = true;
            this.btnUpadeAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(541, 389);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 28);
            this.btnExit.TabIndex = 84;
            this.btnExit.Text = "&Cancel";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGenCartonNo2
            // 
            this.btnGenCartonNo2.Location = new System.Drawing.Point(423, 389);
            this.btnGenCartonNo2.Name = "btnGenCartonNo2";
            this.btnGenCartonNo2.Size = new System.Drawing.Size(94, 28);
            this.btnGenCartonNo2.TabIndex = 82;
            this.btnGenCartonNo2.Text = "&GenCartonNo";
            this.btnGenCartonNo2.UseVisualStyleBackColor = true;
            this.btnGenCartonNo2.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_CartonGen
            // 
            this.lbl_CartonGen.AutoSize = true;
            this.lbl_CartonGen.Font = new System.Drawing.Font("宋体", 39F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_CartonGen.ForeColor = System.Drawing.Color.Red;
            this.lbl_CartonGen.Location = new System.Drawing.Point(614, 2);
            this.lbl_CartonGen.Name = "lbl_CartonGen";
            this.lbl_CartonGen.Size = new System.Drawing.Size(49, 52);
            this.lbl_CartonGen.TabIndex = 16;
            this.lbl_CartonGen.Text = "G";
            this.lbl_CartonGen.Visible = false;
            // 
            // lblPoCheckResult
            // 
            this.lblPoCheckResult.AutoSize = true;
            this.lblPoCheckResult.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPoCheckResult.ForeColor = System.Drawing.Color.Red;
            this.lblPoCheckResult.Location = new System.Drawing.Point(25, 19);
            this.lblPoCheckResult.Name = "lblPoCheckResult";
            this.lblPoCheckResult.Size = new System.Drawing.Size(0, 16);
            this.lblPoCheckResult.TabIndex = 17;
            // 
            // btnPoCheck
            // 
            this.btnPoCheck.Enabled = false;
            this.btnPoCheck.Location = new System.Drawing.Point(6, 389);
            this.btnPoCheck.Name = "btnPoCheck";
            this.btnPoCheck.Size = new System.Drawing.Size(94, 28);
            this.btnPoCheck.TabIndex = 85;
            this.btnPoCheck.Text = "&POCheck";
            this.btnPoCheck.UseVisualStyleBackColor = true;
            this.btnPoCheck.Visible = false;
            this.btnPoCheck.Click += new System.EventHandler(this.btnPoCheck_Click);
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.nextToolStripMenuItem});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(150, 48);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.nextToolStripMenuItem.Text = "Next &Record";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(108, 389);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 28);
            this.btnNew.TabIndex = 83;
            this.btnNew.Text = "&New BatchID";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(184, 8);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(38, 23);
            this.btnNext.TabIndex = 91;
            this.btnNext.Text = "N&ext";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(228, 8);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(38, 23);
            this.btnPre.TabIndex = 92;
            this.btnPre.Text = "P&re";
            this.btnPre.UseVisualStyleBackColor = true;
            // 
            // btngo
            // 
            this.btngo.Location = new System.Drawing.Point(320, 9);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(38, 23);
            this.btngo.TabIndex = 95;
            this.btngo.Text = "&Go";
            this.btngo.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(272, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 21);
            this.textBox1.TabIndex = 95;
            this.textBox1.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPalletNo);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtRemark);
            this.groupBox1.Controls.Add(this.txtplr_suppliers_id);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtCartonprifix);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.dateTimeDeliDate);
            this.groupBox1.Controls.Add(this.dateTimeRecDate);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtCartonQty);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtCartonIDFrom);
            this.groupBox1.Controls.Add(this.txtCartonIDTo);
            this.groupBox1.Controls.Add(this.txtCartonType);
            this.groupBox1.Controls.Add(this.txtQTY);
            this.groupBox1.Controls.Add(this.txtCartonID);
            this.groupBox1.Controls.Add(this.txtLineID);
            this.groupBox1.Controls.Add(this.txtPart);
            this.groupBox1.Controls.Add(this.txtPO);
            this.groupBox1.Controls.Add(this.txtInvoiceID);
            this.groupBox1.Controls.Add(this.txtPackingListID);
            this.groupBox1.Controls.Add(this.txtBatchID);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(50, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 356);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtPalletNo
            // 
            this.txtPalletNo.AcceptsTab = true;
            this.txtPalletNo.Location = new System.Drawing.Point(373, 17);
            this.txtPalletNo.Name = "txtPalletNo";
            this.txtPalletNo.Size = new System.Drawing.Size(152, 21);
            this.txtPalletNo.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(303, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 12);
            this.label18.TabIndex = 87;
            this.label18.Text = " Pallet No:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(61, 316);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 12);
            this.label15.TabIndex = 85;
            this.label15.Text = "ReMark:";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(114, 315);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(411, 35);
            this.txtRemark.TabIndex = 80;
            // 
            // txtplr_suppliers_id
            // 
            this.txtplr_suppliers_id.Enabled = false;
            this.txtplr_suppliers_id.Location = new System.Drawing.Point(373, 244);
            this.txtplr_suppliers_id.Name = "txtplr_suppliers_id";
            this.txtplr_suppliers_id.Size = new System.Drawing.Size(152, 21);
            this.txtplr_suppliers_id.TabIndex = 61;
            this.txtplr_suppliers_id.Text = "not";
            this.txtplr_suppliers_id.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Enabled = false;
            this.label14.Location = new System.Drawing.Point(284, 248);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 12);
            this.label14.TabIndex = 83;
            this.label14.Text = "Suppliers_id:";
            this.label14.Visible = false;
            // 
            // txtCartonprifix
            // 
            this.txtCartonprifix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCartonprifix.Location = new System.Drawing.Point(114, 244);
            this.txtCartonprifix.Name = "txtCartonprifix";
            this.txtCartonprifix.Size = new System.Drawing.Size(152, 21);
            this.txtCartonprifix.TabIndex = 60;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 248);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 12);
            this.label17.TabIndex = 81;
            this.label17.Text = "Carton prifix:";
            // 
            // dateTimeDeliDate
            // 
            this.dateTimeDeliDate.Location = new System.Drawing.Point(373, 206);
            this.dateTimeDeliDate.Name = "dateTimeDeliDate";
            this.dateTimeDeliDate.Size = new System.Drawing.Size(152, 21);
            this.dateTimeDeliDate.TabIndex = 51;
            // 
            // dateTimeRecDate
            // 
            this.dateTimeRecDate.Location = new System.Drawing.Point(114, 206);
            this.dateTimeRecDate.Name = "dateTimeRecDate";
            this.dateTimeRecDate.Size = new System.Drawing.Size(152, 21);
            this.dateTimeRecDate.TabIndex = 50;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 12);
            this.label13.TabIndex = 78;
            this.label13.Text = "Qty/Carton:";
            // 
            // txtCartonQty
            // 
            this.txtCartonQty.Location = new System.Drawing.Point(114, 130);
            this.txtCartonQty.Name = "txtCartonQty";
            this.txtCartonQty.Size = new System.Drawing.Size(152, 21);
            this.txtCartonQty.TabIndex = 30;
            this.txtCartonQty.Leave += new System.EventHandler(this.txtCartonQty_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(278, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 12);
            this.label12.TabIndex = 75;
            this.label12.Text = "Number Carton:";
            // 
            // txtCartonIDFrom
            // 
            this.txtCartonIDFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCartonIDFrom.Location = new System.Drawing.Point(114, 282);
            this.txtCartonIDFrom.Name = "txtCartonIDFrom";
            this.txtCartonIDFrom.Size = new System.Drawing.Size(152, 21);
            this.txtCartonIDFrom.TabIndex = 70;
            this.txtCartonIDFrom.Text = "0";
            // 
            // txtCartonIDTo
            // 
            this.txtCartonIDTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCartonIDTo.Location = new System.Drawing.Point(373, 282);
            this.txtCartonIDTo.Name = "txtCartonIDTo";
            this.txtCartonIDTo.Size = new System.Drawing.Size(152, 21);
            this.txtCartonIDTo.TabIndex = 71;
            this.txtCartonIDTo.Text = "0";
            // 
            // txtCartonType
            // 
            this.txtCartonType.Location = new System.Drawing.Point(373, 168);
            this.txtCartonType.Name = "txtCartonType";
            this.txtCartonType.Size = new System.Drawing.Size(152, 21);
            this.txtCartonType.TabIndex = 41;
            this.txtCartonType.Leave += new System.EventHandler(this.txtCartonType_Leave);
            // 
            // txtQTY
            // 
            this.txtQTY.Location = new System.Drawing.Point(373, 130);
            this.txtQTY.Name = "txtQTY";
            this.txtQTY.Size = new System.Drawing.Size(152, 21);
            this.txtQTY.TabIndex = 31;
            this.txtQTY.Leave += new System.EventHandler(this.txtQTY_Leave_1);
            // 
            // txtCartonID
            // 
            this.txtCartonID.Location = new System.Drawing.Point(114, 168);
            this.txtCartonID.Name = "txtCartonID";
            this.txtCartonID.Size = new System.Drawing.Size(152, 21);
            this.txtCartonID.TabIndex = 40;
            this.txtCartonID.Leave += new System.EventHandler(this.txtCartonID_Leave);
            // 
            // txtLineID
            // 
            this.txtLineID.Enabled = false;
            this.txtLineID.Location = new System.Drawing.Point(237, 16);
            this.txtLineID.Name = "txtLineID";
            this.txtLineID.Size = new System.Drawing.Size(29, 21);
            this.txtLineID.TabIndex = 3;
            // 
            // txtPart
            // 
            this.txtPart.Location = new System.Drawing.Point(373, 92);
            this.txtPart.Name = "txtPart";
            this.txtPart.Size = new System.Drawing.Size(152, 21);
            this.txtPart.TabIndex = 21;
            // 
            // txtPO
            // 
            this.txtPO.Location = new System.Drawing.Point(373, 54);
            this.txtPO.Name = "txtPO";
            this.txtPO.Size = new System.Drawing.Size(152, 21);
            this.txtPO.TabIndex = 11;
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.AcceptsTab = true;
            this.txtInvoiceID.Location = new System.Drawing.Point(114, 54);
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.Size = new System.Drawing.Size(152, 21);
            this.txtInvoiceID.TabIndex = 10;
            // 
            // txtPackingListID
            // 
            this.txtPackingListID.Location = new System.Drawing.Point(114, 92);
            this.txtPackingListID.Name = "txtPackingListID";
            this.txtPackingListID.Size = new System.Drawing.Size(152, 21);
            this.txtPackingListID.TabIndex = 20;
            // 
            // txtBatchID
            // 
            this.txtBatchID.Enabled = false;
            this.txtBatchID.Location = new System.Drawing.Point(114, 16);
            this.txtBatchID.Name = "txtBatchID";
            this.txtBatchID.Size = new System.Drawing.Size(117, 21);
            this.txtBatchID.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(344, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 12);
            this.label11.TabIndex = 71;
            this.label11.Text = "To:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 12);
            this.label9.TabIndex = 72;
            this.label9.Text = "Carton ID From:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(302, 210);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 70;
            this.label16.Text = "Deli_Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 69;
            this.label10.Text = "Rec_Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 67;
            this.label5.Text = "Total Qty:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 65;
            this.label6.Text = "Part:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 62;
            this.label7.Text = "Carton ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(338, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 60;
            this.label8.Text = "PO#:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 56;
            this.label3.Text = "Invoice ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 55;
            this.label2.Text = "Packing List ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 53;
            this.label1.Text = "Batch ID:";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(26, 2);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(47, 12);
            this.lblMsg.TabIndex = 96;
            this.lblMsg.Text = "Notice:";
            this.lblMsg.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNext);
            this.groupBox2.Controls.Add(this.btnPre);
            this.groupBox2.Controls.Add(this.btngo);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(57, 420);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(549, 35);
            this.groupBox2.TabIndex = 97;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 456);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(663, 22);
            this.statusStrip1.TabIndex = 98;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // frmplMain
            // 
            this.AcceptButton = this.btnUpadeAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(663, 478);
            this.ContextMenuStrip = this.contextMenuStripMain;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.lbl_CartonGen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnPoCheck);
            this.Controls.Add(this.lblPoCheckResult);
            this.Controls.Add(this.btnGenCartonNo2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpadeAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmplMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Packing list Maintenance";
            this.Load += new System.EventHandler(this.frmplMain_Load);
            this.contextMenuStripMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        protected internal System.Windows.Forms.Button btnUpadeAdd;
        protected internal System.Windows.Forms.Button btnGenCartonNo2;
        private System.Windows.Forms.Label lbl_CartonGen;
        private System.Windows.Forms.Label lblPoCheckResult;
        protected internal System.Windows.Forms.Button btnPoCheck;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        protected internal System.Windows.Forms.Button btnNew;
        protected internal System.Windows.Forms.Button btnNext;
        protected internal System.Windows.Forms.Button btnPre;
        protected internal System.Windows.Forms.Button btngo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCartonprifix;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dateTimeDeliDate;
        private System.Windows.Forms.DateTimePicker dateTimeRecDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCartonQty;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCartonIDFrom;
        private System.Windows.Forms.TextBox txtCartonIDTo;
        private System.Windows.Forms.TextBox txtCartonType;
        private System.Windows.Forms.TextBox txtQTY;
        private System.Windows.Forms.TextBox txtCartonID;
        private System.Windows.Forms.TextBox txtLineID;
        private System.Windows.Forms.TextBox txtPart;
        private System.Windows.Forms.TextBox txtPO;
        private System.Windows.Forms.TextBox txtInvoiceID;
        private System.Windows.Forms.TextBox txtPackingListID;
        private System.Windows.Forms.TextBox txtBatchID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtplr_suppliers_id;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        protected internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox txtPalletNo;
        private System.Windows.Forms.Label label18;
    }
}

