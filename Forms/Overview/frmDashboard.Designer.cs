
namespace BookStore.Forms.Overview
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.label5 = new System.Windows.Forms.Label();
            this.gunaCirProPayDebt = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPayDebtPercent = new System.Windows.Forms.Label();
            this.gunaCirProPayReceipt = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPayReceiptPercent = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblImportedBookQuantity = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblCustomerQuantity = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSoldBookQuantity = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gunaCirProPayDebt.SuspendLayout();
            this.gunaCirProPayReceipt.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(220, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(520, 37);
            this.label5.TabIndex = 26;
            this.label5.Text = "Thông tin số lượng sách và khách hàng ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gunaCirProPayDebt
            // 
            this.gunaCirProPayDebt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaCirProPayDebt.Controls.Add(this.label4);
            this.gunaCirProPayDebt.Controls.Add(this.lblPayDebtPercent);
            this.gunaCirProPayDebt.FillColor = System.Drawing.Color.Gainsboro;
            this.gunaCirProPayDebt.FillThickness = 20;
            this.gunaCirProPayDebt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gunaCirProPayDebt.ForeColor = System.Drawing.Color.White;
            this.gunaCirProPayDebt.InnerColor = System.Drawing.Color.White;
            this.gunaCirProPayDebt.Location = new System.Drawing.Point(559, 436);
            this.gunaCirProPayDebt.Minimum = 0;
            this.gunaCirProPayDebt.Name = "gunaCirProPayDebt";
            this.gunaCirProPayDebt.ProgressColor = System.Drawing.Color.Red;
            this.gunaCirProPayDebt.ProgressColor2 = System.Drawing.Color.Red;
            this.gunaCirProPayDebt.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.gunaCirProPayDebt.ShadowDecoration.Parent = this.gunaCirProPayDebt;
            this.gunaCirProPayDebt.Size = new System.Drawing.Size(176, 176);
            this.gunaCirProPayDebt.TabIndex = 25;
            this.gunaCirProPayDebt.Text = "guna2CircleProgressBar2";
            this.gunaCirProPayDebt.Value = 60;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(100, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "%";
            // 
            // lblPayDebtPercent
            // 
            this.lblPayDebtPercent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPayDebtPercent.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayDebtPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblPayDebtPercent.Location = new System.Drawing.Point(46, 55);
            this.lblPayDebtPercent.Name = "lblPayDebtPercent";
            this.lblPayDebtPercent.Size = new System.Drawing.Size(87, 50);
            this.lblPayDebtPercent.TabIndex = 18;
            this.lblPayDebtPercent.Text = "60";
            this.lblPayDebtPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaCirProPayReceipt
            // 
            this.gunaCirProPayReceipt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaCirProPayReceipt.Controls.Add(this.label2);
            this.gunaCirProPayReceipt.Controls.Add(this.lblPayReceiptPercent);
            this.gunaCirProPayReceipt.FillColor = System.Drawing.Color.Gainsboro;
            this.gunaCirProPayReceipt.FillThickness = 20;
            this.gunaCirProPayReceipt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gunaCirProPayReceipt.ForeColor = System.Drawing.Color.White;
            this.gunaCirProPayReceipt.InnerColor = System.Drawing.Color.White;
            this.gunaCirProPayReceipt.Location = new System.Drawing.Point(215, 436);
            this.gunaCirProPayReceipt.Minimum = 0;
            this.gunaCirProPayReceipt.Name = "gunaCirProPayReceipt";
            this.gunaCirProPayReceipt.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.gunaCirProPayReceipt.ShadowDecoration.Parent = this.gunaCirProPayReceipt;
            this.gunaCirProPayReceipt.Size = new System.Drawing.Size(176, 176);
            this.gunaCirProPayReceipt.TabIndex = 24;
            this.gunaCirProPayReceipt.Text = "guna2CircleProgressBar1";
            this.gunaCirProPayReceipt.Value = 80;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(100, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "%";
            // 
            // lblPayReceiptPercent
            // 
            this.lblPayReceiptPercent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPayReceiptPercent.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayReceiptPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblPayReceiptPercent.Location = new System.Drawing.Point(44, 55);
            this.lblPayReceiptPercent.Name = "lblPayReceiptPercent";
            this.lblPayReceiptPercent.Size = new System.Drawing.Size(92, 50);
            this.lblPayReceiptPercent.TabIndex = 16;
            this.lblPayReceiptPercent.Text = "80";
            this.lblPayReceiptPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(180)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(897, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(55, 45);
            this.btnRefresh.TabIndex = 23;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Controls.Add(this.lblImportedBookQuantity);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(349, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 123);
            this.panel2.TabIndex = 20;
            // 
            // lblImportedBookQuantity
            // 
            this.lblImportedBookQuantity.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportedBookQuantity.ForeColor = System.Drawing.Color.White;
            this.lblImportedBookQuantity.Location = new System.Drawing.Point(8, 43);
            this.lblImportedBookQuantity.Name = "lblImportedBookQuantity";
            this.lblImportedBookQuantity.Size = new System.Drawing.Size(154, 69);
            this.lblImportedBookQuantity.TabIndex = 3;
            this.lblImportedBookQuantity.Text = "1";
            this.lblImportedBookQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(168, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(15, 16);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(146, 30);
            this.label.TabIndex = 0;
            this.label.Text = "Sách đã nhập:";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.lblCustomerQuantity);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(674, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(252, 123);
            this.panel3.TabIndex = 21;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(168, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(71, 76);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // lblCustomerQuantity
            // 
            this.lblCustomerQuantity.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerQuantity.ForeColor = System.Drawing.Color.White;
            this.lblCustomerQuantity.Location = new System.Drawing.Point(8, 43);
            this.lblCustomerQuantity.Name = "lblCustomerQuantity";
            this.lblCustomerQuantity.Size = new System.Drawing.Size(154, 69);
            this.lblCustomerQuantity.TabIndex = 0;
            this.lblCustomerQuantity.Text = "12";
            this.lblCustomerQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "Khách hàng:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.lblSoldBookQuantity);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(24, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 123);
            this.panel1.TabIndex = 22;
            // 
            // lblSoldBookQuantity
            // 
            this.lblSoldBookQuantity.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoldBookQuantity.ForeColor = System.Drawing.Color.White;
            this.lblSoldBookQuantity.Location = new System.Drawing.Point(6, 43);
            this.lblSoldBookQuantity.Name = "lblSoldBookQuantity";
            this.lblSoldBookQuantity.Size = new System.Drawing.Size(154, 69);
            this.lblSoldBookQuantity.TabIndex = 3;
            this.lblSoldBookQuantity.Text = "1";
            this.lblSoldBookQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(166, 21);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(72, 76);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(17, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 30);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sách đã bán:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label11.Location = new System.Drawing.Point(609, 615);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 30);
            this.label11.TabIndex = 17;
            this.label11.Text = "Trả nợ";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label10.Location = new System.Drawing.Point(196, 615);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 30);
            this.label10.TabIndex = 18;
            this.label10.Text = "Thanh toán hoá đơn";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label12.Location = new System.Drawing.Point(130, 360);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(676, 37);
            this.label12.TabIndex = 19;
            this.label12.Text = "% Số tiền khách hàng thanh toán hoá đơn và trả nợ:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(959, 692);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gunaCirProPayDebt);
            this.Controls.Add(this.gunaCirProPayReceipt);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(959, 692);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TỔNG QUAN";
            this.gunaCirProPayDebt.ResumeLayout(false);
            this.gunaCirProPayDebt.PerformLayout();
            this.gunaCirProPayReceipt.ResumeLayout(false);
            this.gunaCirProPayReceipt.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2CircleProgressBar gunaCirProPayDebt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPayDebtPercent;
        private Guna.UI2.WinForms.Guna2CircleProgressBar gunaCirProPayReceipt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPayReceiptPercent;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblImportedBookQuantity;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblCustomerQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSoldBookQuantity;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
    }
}