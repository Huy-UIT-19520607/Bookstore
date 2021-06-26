
namespace BookStore.Forms.Business
{
    partial class frmReceipt_Edit
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
            this.grpCustomerChoice = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nudDebtAmount = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cboPhone = new System.Windows.Forms.ComboBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerCode = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtReceiptCode = new System.Windows.Forms.TextBox();
            this.nudTotalAmount = new System.Windows.Forms.NumericUpDown();
            this.nudChangeAmount = new System.Windows.Forms.NumericUpDown();
            this.nudPaidAmount = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtmRecepitDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpCustomerChoice.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDebtAmount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChangeAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaidAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCustomerChoice
            // 
            this.grpCustomerChoice.Controls.Add(this.panel4);
            this.grpCustomerChoice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomerChoice.Location = new System.Drawing.Point(347, 58);
            this.grpCustomerChoice.Name = "grpCustomerChoice";
            this.grpCustomerChoice.Size = new System.Drawing.Size(451, 264);
            this.grpCustomerChoice.TabIndex = 48;
            this.grpCustomerChoice.TabStop = false;
            this.grpCustomerChoice.Text = "Chọn Khách hàng";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nudDebtAmount);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.cboPhone);
            this.panel4.Controls.Add(this.txtCustomerName);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtCustomerCode);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(3, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(445, 230);
            this.panel4.TabIndex = 0;
            // 
            // nudDebtAmount
            // 
            this.nudDebtAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDebtAmount.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDebtAmount.Location = new System.Drawing.Point(173, 171);
            this.nudDebtAmount.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudDebtAmount.Name = "nudDebtAmount";
            this.nudDebtAmount.ReadOnly = true;
            this.nudDebtAmount.Size = new System.Drawing.Size(134, 33);
            this.nudDebtAmount.TabIndex = 43;
            this.nudDebtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDebtAmount.ThousandsSeparator = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 50;
            this.label8.Text = "Số tiền nợ:";
            // 
            // cboPhone
            // 
            this.cboPhone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhone.FormattingEnabled = true;
            this.cboPhone.Location = new System.Drawing.Point(173, 15);
            this.cboPhone.Name = "cboPhone";
            this.cboPhone.Size = new System.Drawing.Size(142, 33);
            this.cboPhone.TabIndex = 49;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(173, 120);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(248, 33);
            this.txtCustomerName.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "Tên khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = "SĐT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "Mã khách hàng:";
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerCode.Location = new System.Drawing.Point(173, 68);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.ReadOnly = true;
            this.txtCustomerCode.Size = new System.Drawing.Size(142, 33);
            this.txtCustomerCode.TabIndex = 45;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(486, 340);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(137, 46);
            this.btnOk.TabIndex = 53;
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
            this.btnCancel.Location = new System.Drawing.Point(647, 340);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 46);
            this.btnCancel.TabIndex = 54;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 330);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Hoá đơn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtReceiptCode);
            this.panel1.Controls.Add(this.nudTotalAmount);
            this.panel1.Controls.Add(this.nudChangeAmount);
            this.panel1.Controls.Add(this.nudPaidAmount);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtmRecepitDate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 292);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 25);
            this.label9.TabIndex = 62;
            this.label9.Text = "Số HĐ:";
            // 
            // txtReceiptCode
            // 
            this.txtReceiptCode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiptCode.Location = new System.Drawing.Point(144, 21);
            this.txtReceiptCode.Name = "txtReceiptCode";
            this.txtReceiptCode.ReadOnly = true;
            this.txtReceiptCode.Size = new System.Drawing.Size(117, 33);
            this.txtReceiptCode.TabIndex = 60;
            // 
            // nudTotalAmount
            // 
            this.nudTotalAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTotalAmount.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTotalAmount.Location = new System.Drawing.Point(145, 127);
            this.nudTotalAmount.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudTotalAmount.Name = "nudTotalAmount";
            this.nudTotalAmount.ReadOnly = true;
            this.nudTotalAmount.Size = new System.Drawing.Size(134, 33);
            this.nudTotalAmount.TabIndex = 61;
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
            this.nudChangeAmount.Location = new System.Drawing.Point(145, 224);
            this.nudChangeAmount.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudChangeAmount.Name = "nudChangeAmount";
            this.nudChangeAmount.ReadOnly = true;
            this.nudChangeAmount.Size = new System.Drawing.Size(134, 33);
            this.nudChangeAmount.TabIndex = 59;
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
            this.nudPaidAmount.Location = new System.Drawing.Point(145, 173);
            this.nudPaidAmount.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudPaidAmount.Name = "nudPaidAmount";
            this.nudPaidAmount.ReadOnly = true;
            this.nudPaidAmount.Size = new System.Drawing.Size(134, 33);
            this.nudPaidAmount.TabIndex = 58;
            this.nudPaidAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPaidAmount.ThousandsSeparator = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 25);
            this.label7.TabIndex = 57;
            this.label7.Text = "Còn lại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 56;
            this.label6.Text = "Thanh toán:";
            // 
            // dtmRecepitDate
            // 
            this.dtmRecepitDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmRecepitDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmRecepitDate.Location = new System.Drawing.Point(145, 72);
            this.dtmRecepitDate.Name = "dtmRecepitDate";
            this.dtmRecepitDate.Size = new System.Drawing.Size(134, 33);
            this.dtmRecepitDate.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 54;
            this.label4.Text = "Tổng tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 53;
            this.label5.Text = "Ngày lập:";
            // 
            // frmReceipt_Edit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 398);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpCustomerChoice);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReceipt_Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Hoá đơn";
            this.grpCustomerChoice.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDebtAmount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChangeAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaidAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpCustomerChoice;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nudDebtAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboPhone;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerCode;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtReceiptCode;
        private System.Windows.Forms.NumericUpDown nudTotalAmount;
        private System.Windows.Forms.NumericUpDown nudChangeAmount;
        private System.Windows.Forms.NumericUpDown nudPaidAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtmRecepitDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}