
namespace BookStore.Forms.Business
{
    partial class frmReceipt_EditDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceipt_EditDetail));
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.nudTotalAmount = new System.Windows.Forms.NumericUpDown();
            this.nudChangeAmount = new System.Windows.Forms.NumericUpDown();
            this.nudPaidAmount = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtReceiptCode = new System.Windows.Forms.TextBox();
            this.dtmRecepitDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudPublishingYear = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTitleBookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.nudCostPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNewCategory = new System.Windows.Forms.Label();
            this.txtBookCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChangeAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaidAmount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPublishingYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(618, 481);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(137, 46);
            this.btnOk.TabIndex = 57;
            this.btnOk.Text = "Sửa đổi";
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(779, 481);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 46);
            this.btnCancel.TabIndex = 58;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bunifuPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 323);
            this.groupBox1.TabIndex = 135;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Hoá đơn";
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.nudTotalAmount);
            this.bunifuPanel1.Controls.Add(this.nudChangeAmount);
            this.bunifuPanel1.Controls.Add(this.nudPaidAmount);
            this.bunifuPanel1.Controls.Add(this.label10);
            this.bunifuPanel1.Controls.Add(this.label11);
            this.bunifuPanel1.Controls.Add(this.label12);
            this.bunifuPanel1.Controls.Add(this.label9);
            this.bunifuPanel1.Controls.Add(this.txtReceiptCode);
            this.bunifuPanel1.Controls.Add(this.dtmRecepitDate);
            this.bunifuPanel1.Controls.Add(this.label5);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuPanel1.Location = new System.Drawing.Point(3, 35);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(299, 285);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // nudTotalAmount
            // 
            this.nudTotalAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTotalAmount.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTotalAmount.Location = new System.Drawing.Point(138, 123);
            this.nudTotalAmount.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudTotalAmount.Name = "nudTotalAmount";
            this.nudTotalAmount.ReadOnly = true;
            this.nudTotalAmount.Size = new System.Drawing.Size(134, 33);
            this.nudTotalAmount.TabIndex = 144;
            this.nudTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTotalAmount.ThousandsSeparator = true;
            // 
            // nudChangeAmount
            // 
            this.nudChangeAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudChangeAmount.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudChangeAmount.Location = new System.Drawing.Point(138, 220);
            this.nudChangeAmount.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudChangeAmount.Name = "nudChangeAmount";
            this.nudChangeAmount.ReadOnly = true;
            this.nudChangeAmount.Size = new System.Drawing.Size(134, 33);
            this.nudChangeAmount.TabIndex = 143;
            this.nudChangeAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudChangeAmount.ThousandsSeparator = true;
            // 
            // nudPaidAmount
            // 
            this.nudPaidAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPaidAmount.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPaidAmount.Location = new System.Drawing.Point(138, 169);
            this.nudPaidAmount.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudPaidAmount.Name = "nudPaidAmount";
            this.nudPaidAmount.ReadOnly = true;
            this.nudPaidAmount.Size = new System.Drawing.Size(134, 33);
            this.nudPaidAmount.TabIndex = 142;
            this.nudPaidAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPaidAmount.ThousandsSeparator = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 25);
            this.label10.TabIndex = 141;
            this.label10.Text = "Còn lại:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 25);
            this.label11.TabIndex = 140;
            this.label11.Text = "Thanh toán:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 25);
            this.label12.TabIndex = 139;
            this.label12.Text = "Tổng tiền:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 25);
            this.label9.TabIndex = 138;
            this.label9.Text = "Số HĐ:";
            // 
            // txtReceiptCode
            // 
            this.txtReceiptCode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiptCode.Location = new System.Drawing.Point(138, 23);
            this.txtReceiptCode.Name = "txtReceiptCode";
            this.txtReceiptCode.ReadOnly = true;
            this.txtReceiptCode.Size = new System.Drawing.Size(117, 33);
            this.txtReceiptCode.TabIndex = 137;
            // 
            // dtmRecepitDate
            // 
            this.dtmRecepitDate.Enabled = false;
            this.dtmRecepitDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmRecepitDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmRecepitDate.Location = new System.Drawing.Point(138, 71);
            this.dtmRecepitDate.Name = "dtmRecepitDate";
            this.dtmRecepitDate.Size = new System.Drawing.Size(134, 33);
            this.dtmRecepitDate.TabIndex = 136;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 135;
            this.label5.Text = "Ngày lập:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(332, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(623, 467);
            this.groupBox2.TabIndex = 136;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Sách";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nudPublishingYear);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPublisher);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtCategory);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtTitleBookName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.nudQuantity);
            this.panel1.Controls.Add(this.nudCostPrice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblNewCategory);
            this.panel1.Controls.Add(this.txtBookCode);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 429);
            this.panel1.TabIndex = 137;
            // 
            // nudPublishingYear
            // 
            this.nudPublishingYear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPublishingYear.Location = new System.Drawing.Point(172, 219);
            this.nudPublishingYear.Maximum = new decimal(new int[] {
            9998,
            0,
            0,
            0});
            this.nudPublishingYear.Minimum = new decimal(new int[] {
            1753,
            0,
            0,
            0});
            this.nudPublishingYear.Name = "nudPublishingYear";
            this.nudPublishingYear.ReadOnly = true;
            this.nudPublishingYear.Size = new System.Drawing.Size(84, 33);
            this.nudPublishingYear.TabIndex = 160;
            this.nudPublishingYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPublishingYear.Value = new decimal(new int[] {
            1753,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 159;
            this.label4.Text = "Năm xuất bản:";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisher.Location = new System.Drawing.Point(172, 165);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.ReadOnly = true;
            this.txtPublisher.Size = new System.Drawing.Size(311, 33);
            this.txtPublisher.TabIndex = 158;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 25);
            this.label7.TabIndex = 157;
            this.label7.Text = "Nhà xuất bản:";
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(172, 117);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(211, 33);
            this.txtCategory.TabIndex = 156;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 25);
            this.label8.TabIndex = 155;
            this.label8.Text = "Thể loại:";
            // 
            // txtTitleBookName
            // 
            this.txtTitleBookName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitleBookName.Location = new System.Drawing.Point(172, 64);
            this.txtTitleBookName.Name = "txtTitleBookName";
            this.txtTitleBookName.ReadOnly = true;
            this.txtTitleBookName.Size = new System.Drawing.Size(425, 33);
            this.txtTitleBookName.TabIndex = 154;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 153;
            this.label1.Text = "Tên đầu sách:";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(172, 378);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(129, 33);
            this.txtAmount.TabIndex = 152;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 151;
            this.label6.Text = "Thành tiền:";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudQuantity.Location = new System.Drawing.Point(172, 274);
            this.nudQuantity.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(129, 35);
            this.nudQuantity.TabIndex = 150;
            this.nudQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudCostPrice
            // 
            this.nudCostPrice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCostPrice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCostPrice.Location = new System.Drawing.Point(172, 323);
            this.nudCostPrice.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudCostPrice.Name = "nudCostPrice";
            this.nudCostPrice.ReadOnly = true;
            this.nudCostPrice.Size = new System.Drawing.Size(129, 35);
            this.nudCostPrice.TabIndex = 149;
            this.nudCostPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 148;
            this.label3.Text = "Đơn giá:";
            // 
            // lblNewCategory
            // 
            this.lblNewCategory.AutoSize = true;
            this.lblNewCategory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewCategory.Location = new System.Drawing.Point(28, 280);
            this.lblNewCategory.Name = "lblNewCategory";
            this.lblNewCategory.Size = new System.Drawing.Size(91, 25);
            this.lblNewCategory.TabIndex = 147;
            this.lblNewCategory.Text = "Số lượng:";
            // 
            // txtBookCode
            // 
            this.txtBookCode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookCode.Location = new System.Drawing.Point(172, 11);
            this.txtBookCode.Name = "txtBookCode";
            this.txtBookCode.ReadOnly = true;
            this.txtBookCode.Size = new System.Drawing.Size(128, 33);
            this.txtBookCode.TabIndex = 146;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 145;
            this.label2.Text = "Mã sách:";
            // 
            // frmReceipt_EditDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(957, 539);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReceipt_EditDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Chi tiết hoá đơn";
            this.groupBox1.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChangeAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaidAmount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPublishingYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.NumericUpDown nudTotalAmount;
        private System.Windows.Forms.NumericUpDown nudChangeAmount;
        private System.Windows.Forms.NumericUpDown nudPaidAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtReceiptCode;
        private System.Windows.Forms.DateTimePicker dtmRecepitDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudPublishingYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTitleBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.NumericUpDown nudCostPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNewCategory;
        private System.Windows.Forms.TextBox txtBookCode;
        private System.Windows.Forms.Label label2;
    }
}