
namespace BookStore.Forms.Management
{
    partial class frmTitleBook_EditAuthor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTitleBook_EditAuthor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnOkAuthorList = new System.Windows.Forms.Button();
            this.btnDeleteList = new System.Windows.Forms.Button();
            this.txtTitlteBookCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddList = new System.Windows.Forms.Button();
            this.lblAuthorNameError = new System.Windows.Forms.Label();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaDgvAuthor = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTitleBookName = new System.Windows.Forms.TextBox();
            this.lblNewCategory = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MaDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDgvAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOkAuthorList
            // 
            this.btnOkAuthorList.BackColor = System.Drawing.Color.DarkGreen;
            this.btnOkAuthorList.FlatAppearance.BorderSize = 0;
            this.btnOkAuthorList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkAuthorList.ForeColor = System.Drawing.Color.White;
            this.btnOkAuthorList.Image = ((System.Drawing.Image)(resources.GetObject("btnOkAuthorList.Image")));
            this.btnOkAuthorList.Location = new System.Drawing.Point(445, 263);
            this.btnOkAuthorList.Name = "btnOkAuthorList";
            this.btnOkAuthorList.Size = new System.Drawing.Size(34, 34);
            this.btnOkAuthorList.TabIndex = 81;
            this.btnOkAuthorList.UseVisualStyleBackColor = false;
            // 
            // btnDeleteList
            // 
            this.btnDeleteList.BackColor = System.Drawing.Color.Brown;
            this.btnDeleteList.FlatAppearance.BorderSize = 0;
            this.btnDeleteList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteList.ForeColor = System.Drawing.Color.White;
            this.btnDeleteList.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteList.Image")));
            this.btnDeleteList.Location = new System.Drawing.Point(445, 223);
            this.btnDeleteList.Name = "btnDeleteList";
            this.btnDeleteList.Size = new System.Drawing.Size(34, 34);
            this.btnDeleteList.TabIndex = 80;
            this.btnDeleteList.UseVisualStyleBackColor = false;
            // 
            // txtTitlteBookCode
            // 
            this.txtTitlteBookCode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitlteBookCode.Location = new System.Drawing.Point(168, 15);
            this.txtTitlteBookCode.Name = "txtTitlteBookCode";
            this.txtTitlteBookCode.ReadOnly = true;
            this.txtTitlteBookCode.Size = new System.Drawing.Size(122, 33);
            this.txtTitlteBookCode.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 78;
            this.label3.Text = "Mã đầu sách:";
            // 
            // btnAddList
            // 
            this.btnAddList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAddList.FlatAppearance.BorderSize = 0;
            this.btnAddList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddList.ForeColor = System.Drawing.Color.White;
            this.btnAddList.Image = ((System.Drawing.Image)(resources.GetObject("btnAddList.Image")));
            this.btnAddList.Location = new System.Drawing.Point(445, 183);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(34, 34);
            this.btnAddList.TabIndex = 77;
            this.btnAddList.UseVisualStyleBackColor = false;
            // 
            // lblAuthorNameError
            // 
            this.lblAuthorNameError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorNameError.ForeColor = System.Drawing.Color.Red;
            this.lblAuthorNameError.Location = new System.Drawing.Point(168, 232);
            this.lblAuthorNameError.Name = "lblAuthorNameError";
            this.lblAuthorNameError.Size = new System.Drawing.Size(265, 17);
            this.lblAuthorNameError.TabIndex = 76;
            this.lblAuthorNameError.Text = "AuthorName Error";
            this.lblAuthorNameError.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorName.Location = new System.Drawing.Point(168, 199);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(265, 33);
            this.txtAuthorName.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 74;
            this.label2.Text = "Tên tác giả:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(497, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 179);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Tác giả";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaDgvAuthor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 147);
            this.panel1.TabIndex = 0;
            // 
            // gunaDgvAuthor
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gunaDgvAuthor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gunaDgvAuthor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDgvAuthor.BackgroundColor = System.Drawing.Color.White;
            this.gunaDgvAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDgvAuthor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDgvAuthor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDgvAuthor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gunaDgvAuthor.ColumnHeadersHeight = 28;
            this.gunaDgvAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gunaDgvAuthor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDauSach,
            this.TenTacGia});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDgvAuthor.DefaultCellStyle = dataGridViewCellStyle6;
            this.gunaDgvAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaDgvAuthor.EnableHeadersVisualStyles = false;
            this.gunaDgvAuthor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDgvAuthor.Location = new System.Drawing.Point(0, 0);
            this.gunaDgvAuthor.MultiSelect = false;
            this.gunaDgvAuthor.Name = "gunaDgvAuthor";
            this.gunaDgvAuthor.RowHeadersVisible = false;
            this.gunaDgvAuthor.RowTemplate.Height = 26;
            this.gunaDgvAuthor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDgvAuthor.Size = new System.Drawing.Size(238, 147);
            this.gunaDgvAuthor.TabIndex = 0;
            this.gunaDgvAuthor.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDgvAuthor.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDgvAuthor.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDgvAuthor.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDgvAuthor.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDgvAuthor.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDgvAuthor.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDgvAuthor.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDgvAuthor.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDgvAuthor.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDgvAuthor.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDgvAuthor.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gunaDgvAuthor.ThemeStyle.HeaderStyle.Height = 28;
            this.gunaDgvAuthor.ThemeStyle.ReadOnly = false;
            this.gunaDgvAuthor.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDgvAuthor.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDgvAuthor.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDgvAuthor.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDgvAuthor.ThemeStyle.RowsStyle.Height = 26;
            this.gunaDgvAuthor.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDgvAuthor.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 71;
            this.label7.Text = "Thể loại:";
            // 
            // txtTitleBookName
            // 
            this.txtTitleBookName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitleBookName.Location = new System.Drawing.Point(168, 69);
            this.txtTitleBookName.Name = "txtTitleBookName";
            this.txtTitleBookName.ReadOnly = true;
            this.txtTitleBookName.Size = new System.Drawing.Size(525, 33);
            this.txtTitleBookName.TabIndex = 69;
            // 
            // lblNewCategory
            // 
            this.lblNewCategory.AutoSize = true;
            this.lblNewCategory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewCategory.Location = new System.Drawing.Point(29, 72);
            this.lblNewCategory.Name = "lblNewCategory";
            this.lblNewCategory.Size = new System.Drawing.Size(125, 25);
            this.lblNewCategory.TabIndex = 68;
            this.lblNewCategory.Text = "Tên đầu sách:";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(377, 341);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(137, 46);
            this.btnOk.TabIndex = 82;
            this.btnOk.Text = "Sửa đổi";
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(538, 341);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 46);
            this.btnCancel.TabIndex = 83;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(168, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(311, 33);
            this.textBox1.TabIndex = 84;
            // 
            // MaDauSach
            // 
            this.MaDauSach.HeaderText = "Mã Đầu Sách";
            this.MaDauSach.Name = "MaDauSach";
            // 
            // TenTacGia
            // 
            this.TenTacGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenTacGia.HeaderText = "Tên Tác Giả";
            this.TenTacGia.Name = "TenTacGia";
            // 
            // frmTitleBook_EditAuthor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(781, 421);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOkAuthorList);
            this.Controls.Add(this.btnDeleteList);
            this.Controls.Add(this.txtTitlteBookCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddList);
            this.Controls.Add(this.lblAuthorNameError);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTitleBookName);
            this.Controls.Add(this.lblNewCategory);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTitleBook_EditAuthor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa tác giả của đầu sách";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDgvAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOkAuthorList;
        private System.Windows.Forms.Button btnDeleteList;
        private System.Windows.Forms.TextBox txtTitlteBookCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.Label lblAuthorNameError;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView gunaDgvAuthor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTitleBookName;
        private System.Windows.Forms.Label lblNewCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTacGia;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBox1;
    }
}