
namespace BookStore.Forms.Management
{
    partial class frmBook_AddTitleBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBook_AddTitleBook));
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTitleBookNameError = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtTitleBookName = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaDgvAuthor = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TenTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAuthorNameError = new System.Windows.Forms.Label();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddList = new System.Windows.Forms.Button();
            this.btnDeleteList = new System.Windows.Forms.Button();
            this.errBook_AddTitleBook = new System.Windows.Forms.ErrorProvider(this.components);
            this.tipBook_AddTitleBook = new System.Windows.Forms.ToolTip(this.components);
            this.btnStopAddList = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDgvAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errBook_AddTitleBook)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(151, 88);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(305, 33);
            this.cboCategory.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 45;
            this.label7.Text = "Thể loại:";
            // 
            // lblTitleBookNameError
            // 
            this.lblTitleBookNameError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleBookNameError.ForeColor = System.Drawing.Color.Red;
            this.lblTitleBookNameError.Location = new System.Drawing.Point(302, 52);
            this.lblTitleBookNameError.Name = "lblTitleBookNameError";
            this.lblTitleBookNameError.Size = new System.Drawing.Size(374, 17);
            this.lblTitleBookNameError.TabIndex = 35;
            this.lblTitleBookNameError.Text = "TitleBookName Error";
            this.lblTitleBookNameError.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(346, 272);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(137, 46);
            this.btnOk.TabIndex = 33;
            this.btnOk.Text = "Tạo mới";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(507, 272);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 46);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtTitleBookName
            // 
            this.txtTitleBookName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitleBookName.Location = new System.Drawing.Point(151, 19);
            this.txtTitleBookName.Name = "txtTitleBookName";
            this.txtTitleBookName.Size = new System.Drawing.Size(525, 33);
            this.txtTitleBookName.TabIndex = 32;
            this.txtTitleBookName.Validating += new System.ComponentModel.CancelEventHandler(this.txtTitleBookName_Validating);
            this.txtTitleBookName.Validated += new System.EventHandler(this.txtTitleBookName_Validated);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(12, 22);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(125, 25);
            this.label.TabIndex = 31;
            this.label.Text = "Tên đầu sách:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(479, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 173);
            this.groupBox1.TabIndex = 47;
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
            this.panel1.Size = new System.Drawing.Size(238, 141);
            this.panel1.TabIndex = 0;
            // 
            // gunaDgvAuthor
            // 
            this.gunaDgvAuthor.AllowUserToAddRows = false;
            this.gunaDgvAuthor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaDgvAuthor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDgvAuthor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDgvAuthor.BackgroundColor = System.Drawing.Color.White;
            this.gunaDgvAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDgvAuthor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDgvAuthor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDgvAuthor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDgvAuthor.ColumnHeadersHeight = 28;
            this.gunaDgvAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gunaDgvAuthor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenTacGia});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDgvAuthor.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDgvAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaDgvAuthor.EnableHeadersVisualStyles = false;
            this.gunaDgvAuthor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDgvAuthor.Location = new System.Drawing.Point(0, 0);
            this.gunaDgvAuthor.Name = "gunaDgvAuthor";
            this.gunaDgvAuthor.ReadOnly = true;
            this.gunaDgvAuthor.RowHeadersVisible = false;
            this.gunaDgvAuthor.RowTemplate.Height = 26;
            this.gunaDgvAuthor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDgvAuthor.Size = new System.Drawing.Size(238, 141);
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
            this.gunaDgvAuthor.ThemeStyle.ReadOnly = true;
            this.gunaDgvAuthor.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDgvAuthor.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDgvAuthor.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDgvAuthor.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDgvAuthor.ThemeStyle.RowsStyle.Height = 26;
            this.gunaDgvAuthor.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDgvAuthor.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // TenTacGia
            // 
            this.TenTacGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenTacGia.HeaderText = "Tên Tác Giả";
            this.TenTacGia.Name = "TenTacGia";
            this.TenTacGia.ReadOnly = true;
            // 
            // lblAuthorNameError
            // 
            this.lblAuthorNameError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorNameError.ForeColor = System.Drawing.Color.Red;
            this.lblAuthorNameError.Location = new System.Drawing.Point(94, 193);
            this.lblAuthorNameError.Name = "lblAuthorNameError";
            this.lblAuthorNameError.Size = new System.Drawing.Size(322, 17);
            this.lblAuthorNameError.TabIndex = 50;
            this.lblAuthorNameError.Text = "AuthorName Error";
            this.lblAuthorNameError.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorName.Location = new System.Drawing.Point(151, 160);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(265, 33);
            this.txtAuthorName.TabIndex = 49;
            this.txtAuthorName.Validating += new System.ComponentModel.CancelEventHandler(this.txtAuthorName_Validating);
            this.txtAuthorName.Validated += new System.EventHandler(this.txtAuthorName_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "Tên tác giả:";
            // 
            // btnAddList
            // 
            this.btnAddList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAddList.FlatAppearance.BorderSize = 0;
            this.btnAddList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddList.ForeColor = System.Drawing.Color.White;
            this.btnAddList.Image = ((System.Drawing.Image)(resources.GetObject("btnAddList.Image")));
            this.btnAddList.Location = new System.Drawing.Point(436, 135);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(34, 34);
            this.btnAddList.TabIndex = 51;
            this.tipBook_AddTitleBook.SetToolTip(this.btnAddList, "Thêm tác giả vào danh sách");
            this.btnAddList.UseVisualStyleBackColor = false;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // btnDeleteList
            // 
            this.btnDeleteList.BackColor = System.Drawing.Color.Brown;
            this.btnDeleteList.FlatAppearance.BorderSize = 0;
            this.btnDeleteList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteList.ForeColor = System.Drawing.Color.White;
            this.btnDeleteList.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteList.Image")));
            this.btnDeleteList.Location = new System.Drawing.Point(436, 175);
            this.btnDeleteList.Name = "btnDeleteList";
            this.btnDeleteList.Size = new System.Drawing.Size(34, 34);
            this.btnDeleteList.TabIndex = 68;
            this.tipBook_AddTitleBook.SetToolTip(this.btnDeleteList, "Xoá tác giả được chọn khỏi danh sách");
            this.btnDeleteList.UseVisualStyleBackColor = false;
            this.btnDeleteList.Click += new System.EventHandler(this.btnDeleteList_Click);
            // 
            // errBook_AddTitleBook
            // 
            this.errBook_AddTitleBook.BlinkRate = 0;
            this.errBook_AddTitleBook.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errBook_AddTitleBook.ContainerControl = this;
            // 
            // btnStopAddList
            // 
            this.btnStopAddList.BackColor = System.Drawing.Color.DarkGreen;
            this.btnStopAddList.FlatAppearance.BorderSize = 0;
            this.btnStopAddList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopAddList.ForeColor = System.Drawing.Color.White;
            this.btnStopAddList.Image = ((System.Drawing.Image)(resources.GetObject("btnStopAddList.Image")));
            this.btnStopAddList.Location = new System.Drawing.Point(436, 215);
            this.btnStopAddList.Name = "btnStopAddList";
            this.btnStopAddList.Size = new System.Drawing.Size(34, 34);
            this.btnStopAddList.TabIndex = 69;
            this.tipBook_AddTitleBook.SetToolTip(this.btnStopAddList, "Kiểm tra và chốt danh sách tác giả");
            this.btnStopAddList.UseVisualStyleBackColor = false;
            this.btnStopAddList.Click += new System.EventHandler(this.btnStopAddList_Click);
            // 
            // frmBook_AddTitleBook
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(739, 335);
            this.Controls.Add(this.btnStopAddList);
            this.Controls.Add(this.btnDeleteList);
            this.Controls.Add(this.btnAddList);
            this.Controls.Add(this.lblAuthorNameError);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTitleBookNameError);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtTitleBookName);
            this.Controls.Add(this.label);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBook_AddTitleBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Đầu sách";
            this.Load += new System.EventHandler(this.frmBook_AddTitleBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDgvAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errBook_AddTitleBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTitleBookNameError;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtTitleBookName;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView gunaDgvAuthor;
        private System.Windows.Forms.Label lblAuthorNameError;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTacGia;
        private System.Windows.Forms.Button btnDeleteList;
        private System.Windows.Forms.ErrorProvider errBook_AddTitleBook;
        private System.Windows.Forms.ToolTip tipBook_AddTitleBook;
        private System.Windows.Forms.Button btnStopAddList;
    }
}