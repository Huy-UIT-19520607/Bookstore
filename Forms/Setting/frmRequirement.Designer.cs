
namespace BookStore.Forms.Setting
{
    partial class frmRequirement
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gunaTsIsApply = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.nudMaxDebt = new System.Windows.Forms.NumericUpDown();
            this.nudMinBookStoreNo = new System.Windows.Forms.NumericUpDown();
            this.nudMaxBookStoreNo = new System.Windows.Forms.NumericUpDown();
            this.nudMinBookImportNo = new System.Windows.Forms.NumericUpDown();
            this.nudPercent = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxDebt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinBookStoreNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxBookStoreNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinBookImportNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPercent)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(328, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 37);
            this.label5.TabIndex = 27;
            this.label5.Text = "Các yêu cầu nhà sách";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 30);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tỉ lệ tính đơn giá bán (%):";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 30);
            this.label2.TabIndex = 29;
            this.label2.Text = "Số lượng sách nhập tối thiểu:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(386, 30);
            this.label3.TabIndex = 30;
            this.label3.Text = "Số lượng sách tồn tối đa trước khi nhập:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(135, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(381, 30);
            this.label4.TabIndex = 31;
            this.label4.Text = "Số lượng sách tồn tối thiểu sau khi bán:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(135, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(527, 30);
            this.label6.TabIndex = 32;
            this.label6.Text = "Số tiền nợ tối đa cho phép khách hàng được mua sách:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(135, 471);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(538, 30);
            this.label7.TabIndex = 33;
            this.label7.Text = "Số tiền thu không vượt quá số tiền khách hàng đang nợ:";
            // 
            // gunaTsIsApply
            // 
            this.gunaTsIsApply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaTsIsApply.Animated = true;
            this.gunaTsIsApply.BackColor = System.Drawing.Color.Transparent;
            this.gunaTsIsApply.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTsIsApply.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTsIsApply.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.gunaTsIsApply.CheckedState.InnerColor = System.Drawing.Color.White;
            this.gunaTsIsApply.CheckedState.Parent = this.gunaTsIsApply;
            this.gunaTsIsApply.Location = new System.Drawing.Point(700, 471);
            this.gunaTsIsApply.Name = "gunaTsIsApply";
            this.gunaTsIsApply.ShadowDecoration.Parent = this.gunaTsIsApply;
            this.gunaTsIsApply.Size = new System.Drawing.Size(67, 30);
            this.gunaTsIsApply.TabIndex = 34;
            this.gunaTsIsApply.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gunaTsIsApply.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gunaTsIsApply.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.gunaTsIsApply.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.gunaTsIsApply.UncheckedState.Parent = this.gunaTsIsApply;
            //
            // nudMaxDebt
            // 
            this.nudMaxDebt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudMaxDebt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMaxDebt.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMaxDebt.Location = new System.Drawing.Point(672, 394);
            this.nudMaxDebt.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudMaxDebt.Name = "nudMaxDebt";
            this.nudMaxDebt.Size = new System.Drawing.Size(120, 35);
            this.nudMaxDebt.TabIndex = 35;
            this.nudMaxDebt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudMinBookStoreNo
            // 
            this.nudMinBookStoreNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudMinBookStoreNo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinBookStoreNo.Location = new System.Drawing.Point(672, 324);
            this.nudMinBookStoreNo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMinBookStoreNo.Name = "nudMinBookStoreNo";
            this.nudMinBookStoreNo.Size = new System.Drawing.Size(120, 35);
            this.nudMinBookStoreNo.TabIndex = 36;
            this.nudMinBookStoreNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudMaxBookStoreNo
            // 
            this.nudMaxBookStoreNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudMaxBookStoreNo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMaxBookStoreNo.Location = new System.Drawing.Point(672, 249);
            this.nudMaxBookStoreNo.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudMaxBookStoreNo.Name = "nudMaxBookStoreNo";
            this.nudMaxBookStoreNo.Size = new System.Drawing.Size(120, 35);
            this.nudMaxBookStoreNo.TabIndex = 37;
            this.nudMaxBookStoreNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudMinBookImportNo
            // 
            this.nudMinBookImportNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudMinBookImportNo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinBookImportNo.Location = new System.Drawing.Point(672, 176);
            this.nudMinBookImportNo.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudMinBookImportNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinBookImportNo.Name = "nudMinBookImportNo";
            this.nudMinBookImportNo.Size = new System.Drawing.Size(120, 35);
            this.nudMinBookImportNo.TabIndex = 38;
            this.nudMinBookImportNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMinBookImportNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudPercent
            // 
            this.nudPercent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudPercent.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPercent.Location = new System.Drawing.Point(672, 116);
            this.nudPercent.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nudPercent.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudPercent.Name = "nudPercent";
            this.nudPercent.Size = new System.Drawing.Size(120, 35);
            this.nudPercent.TabIndex = 39;
            this.nudPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPercent.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(754, 578);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 46);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(613, 578);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 46);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmRequirement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(943, 653);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nudPercent);
            this.Controls.Add(this.nudMinBookImportNo);
            this.Controls.Add(this.nudMaxBookStoreNo);
            this.Controls.Add(this.nudMinBookStoreNo);
            this.Controls.Add(this.nudMaxDebt);
            this.Controls.Add(this.gunaTsIsApply);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(959, 692);
            this.Name = "frmRequirement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUY ĐỊNH";
            this.Load += new System.EventHandler(this.frmRequirement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxDebt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinBookStoreNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxBookStoreNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinBookImportNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPercent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ToggleSwitch gunaTsIsApply;
        private System.Windows.Forms.NumericUpDown nudMaxDebt;
        private System.Windows.Forms.NumericUpDown nudMinBookStoreNo;
        private System.Windows.Forms.NumericUpDown nudMaxBookStoreNo;
        private System.Windows.Forms.NumericUpDown nudMinBookImportNo;
        private System.Windows.Forms.NumericUpDown nudPercent;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}