
namespace BookStore.Forms.Business
{
    partial class frmBookReceipt_Add
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookReceipt_Add));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpTitleBook = new System.Windows.Forms.GroupBox();
            this.pnlBook = new System.Windows.Forms.Panel();
            this.gunaDgvTitleBook = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearchTitleBook = new System.Windows.Forms.Panel();
            this.btnTitleBookSearch = new System.Windows.Forms.Button();
            this.gunaTxtTitleBookSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nudPublishingYear = new System.Windows.Forms.NumericUpDown();
            this.lblPublisherError = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.nudCostPrice = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNewCategory = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grpImportBookDetail = new System.Windows.Forms.GroupBox();
            this.pnlTitleBook = new System.Windows.Forms.Panel();
            this.pnlAccount = new System.Windows.Forms.Panel();
            this.gunaDgvBookReceiptDetail = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaDauSach2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnOkBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpImportBookInfo = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nudTotalAmount = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtmDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errBookReceipt_Add = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.grpTitleBook.SuspendLayout();
            this.pnlBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDgvTitleBook)).BeginInit();
            this.pnlSearchTitleBook.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPublishingYear)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostPrice)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.grpImportBookDetail.SuspendLayout();
            this.pnlTitleBook.SuspendLayout();
            this.pnlAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDgvBookReceiptDetail)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpImportBookInfo.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errBookReceipt_Add)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grpTitleBook, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.67628F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.32372F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1206, 804);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // grpTitleBook
            // 
            this.grpTitleBook.Controls.Add(this.pnlBook);
            this.grpTitleBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTitleBook.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTitleBook.Location = new System.Drawing.Point(3, 398);
            this.grpTitleBook.Name = "grpTitleBook";
            this.grpTitleBook.Size = new System.Drawing.Size(1200, 403);
            this.grpTitleBook.TabIndex = 18;
            this.grpTitleBook.TabStop = false;
            this.grpTitleBook.Text = "Danh sách Đầu sách";
            // 
            // pnlBook
            // 
            this.pnlBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBook.Controls.Add(this.gunaDgvTitleBook);
            this.pnlBook.Controls.Add(this.pnlSearchTitleBook);
            this.pnlBook.Controls.Add(this.panel2);
            this.pnlBook.Controls.Add(this.panel5);
            this.pnlBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBook.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBook.Location = new System.Drawing.Point(3, 35);
            this.pnlBook.Name = "pnlBook";
            this.pnlBook.Size = new System.Drawing.Size(1194, 365);
            this.pnlBook.TabIndex = 0;
            // 
            // gunaDgvTitleBook
            // 
            this.gunaDgvTitleBook.AllowUserToAddRows = false;
            this.gunaDgvTitleBook.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.gunaDgvTitleBook.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gunaDgvTitleBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDgvTitleBook.BackgroundColor = System.Drawing.Color.White;
            this.gunaDgvTitleBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDgvTitleBook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDgvTitleBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDgvTitleBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gunaDgvTitleBook.ColumnHeadersHeight = 30;
            this.gunaDgvTitleBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gunaDgvTitleBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDauSach,
            this.TenDauSach,
            this.TenTheLoai});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDgvTitleBook.DefaultCellStyle = dataGridViewCellStyle9;
            this.gunaDgvTitleBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaDgvTitleBook.EnableHeadersVisualStyles = false;
            this.gunaDgvTitleBook.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDgvTitleBook.Location = new System.Drawing.Point(0, 46);
            this.gunaDgvTitleBook.MultiSelect = false;
            this.gunaDgvTitleBook.Name = "gunaDgvTitleBook";
            this.gunaDgvTitleBook.ReadOnly = true;
            this.gunaDgvTitleBook.RowHeadersVisible = false;
            this.gunaDgvTitleBook.RowTemplate.Height = 28;
            this.gunaDgvTitleBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDgvTitleBook.Size = new System.Drawing.Size(954, 263);
            this.gunaDgvTitleBook.TabIndex = 15;
            this.gunaDgvTitleBook.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDgvTitleBook.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDgvTitleBook.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDgvTitleBook.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDgvTitleBook.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDgvTitleBook.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDgvTitleBook.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDgvTitleBook.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDgvTitleBook.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDgvTitleBook.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDgvTitleBook.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDgvTitleBook.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gunaDgvTitleBook.ThemeStyle.HeaderStyle.Height = 30;
            this.gunaDgvTitleBook.ThemeStyle.ReadOnly = true;
            this.gunaDgvTitleBook.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDgvTitleBook.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDgvTitleBook.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDgvTitleBook.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDgvTitleBook.ThemeStyle.RowsStyle.Height = 28;
            this.gunaDgvTitleBook.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDgvTitleBook.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDgvTitleBook.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gunaDgvTitleBook_CellFormatting);
            // 
            // MaDauSach
            // 
            this.MaDauSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MaDauSach.DataPropertyName = "Id";
            this.MaDauSach.HeaderText = "Mã Đầu Sách";
            this.MaDauSach.Name = "MaDauSach";
            this.MaDauSach.ReadOnly = true;
            this.MaDauSach.Width = 146;
            // 
            // TenDauSach
            // 
            this.TenDauSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenDauSach.DataPropertyName = "Name";
            this.TenDauSach.HeaderText = "Tên Đầu Sách";
            this.TenDauSach.Name = "TenDauSach";
            this.TenDauSach.ReadOnly = true;
            // 
            // TenTheLoai
            // 
            this.TenTheLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenTheLoai.DataPropertyName = "CategoryId";
            this.TenTheLoai.HeaderText = "Thể Loại";
            this.TenTheLoai.Name = "TenTheLoai";
            this.TenTheLoai.ReadOnly = true;
            // 
            // pnlSearchTitleBook
            // 
            this.pnlSearchTitleBook.Controls.Add(this.btnTitleBookSearch);
            this.pnlSearchTitleBook.Controls.Add(this.gunaTxtTitleBookSearch);
            this.pnlSearchTitleBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchTitleBook.Location = new System.Drawing.Point(0, 0);
            this.pnlSearchTitleBook.Name = "pnlSearchTitleBook";
            this.pnlSearchTitleBook.Size = new System.Drawing.Size(954, 46);
            this.pnlSearchTitleBook.TabIndex = 16;
            // 
            // btnTitleBookSearch
            // 
            this.btnTitleBookSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(106)))));
            this.btnTitleBookSearch.FlatAppearance.BorderSize = 0;
            this.btnTitleBookSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitleBookSearch.ForeColor = System.Drawing.Color.White;
            this.btnTitleBookSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnTitleBookSearch.Image")));
            this.btnTitleBookSearch.Location = new System.Drawing.Point(432, 2);
            this.btnTitleBookSearch.Name = "btnTitleBookSearch";
            this.btnTitleBookSearch.Size = new System.Drawing.Size(34, 35);
            this.btnTitleBookSearch.TabIndex = 1;
            this.btnTitleBookSearch.UseVisualStyleBackColor = false;
            this.btnTitleBookSearch.Click += new System.EventHandler(this.btnTitleBookSearch_Click);
            // 
            // gunaTxtTitleBookSearch
            // 
            this.gunaTxtTitleBookSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTxtTitleBookSearch.DefaultText = "";
            this.gunaTxtTitleBookSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gunaTxtTitleBookSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunaTxtTitleBookSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTxtTitleBookSearch.DisabledState.Parent = this.gunaTxtTitleBookSearch;
            this.gunaTxtTitleBookSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTxtTitleBookSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTxtTitleBookSearch.FocusedState.Parent = this.gunaTxtTitleBookSearch;
            this.gunaTxtTitleBookSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaTxtTitleBookSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTxtTitleBookSearch.HoverState.Parent = this.gunaTxtTitleBookSearch;
            this.gunaTxtTitleBookSearch.Location = new System.Drawing.Point(40, 2);
            this.gunaTxtTitleBookSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaTxtTitleBookSearch.Name = "gunaTxtTitleBookSearch";
            this.gunaTxtTitleBookSearch.PasswordChar = '\0';
            this.gunaTxtTitleBookSearch.PlaceholderText = "Tìm kiếm";
            this.gunaTxtTitleBookSearch.SelectedText = "";
            this.gunaTxtTitleBookSearch.ShadowDecoration.Parent = this.gunaTxtTitleBookSearch;
            this.gunaTxtTitleBookSearch.Size = new System.Drawing.Size(385, 35);
            this.gunaTxtTitleBookSearch.TabIndex = 0;
            this.gunaTxtTitleBookSearch.TextChanged += new System.EventHandler(this.gunaTxtTitleBookSearch_TextChanged);
            this.gunaTxtTitleBookSearch.Leave += new System.EventHandler(this.gunaTxtTitleBookSearch_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.nudPublishingYear);
            this.panel2.Controls.Add(this.lblPublisherError);
            this.panel2.Controls.Add(this.txtPublisher);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 309);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 54);
            this.panel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(670, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Năm xuất bản:";
            // 
            // nudPublishingYear
            // 
            this.nudPublishingYear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPublishingYear.Location = new System.Drawing.Point(786, 3);
            this.nudPublishingYear.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.nudPublishingYear.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.nudPublishingYear.Name = "nudPublishingYear";
            this.nudPublishingYear.Size = new System.Drawing.Size(86, 33);
            this.nudPublishingYear.TabIndex = 28;
            this.nudPublishingYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPublishingYear.Value = new decimal(new int[] {
            1999,
            0,
            0,
            0});
            // 
            // lblPublisherError
            // 
            this.lblPublisherError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisherError.ForeColor = System.Drawing.Color.Red;
            this.lblPublisherError.Location = new System.Drawing.Point(289, 34);
            this.lblPublisherError.Name = "lblPublisherError";
            this.lblPublisherError.Size = new System.Drawing.Size(319, 17);
            this.lblPublisherError.TabIndex = 24;
            this.lblPublisherError.Text = "Publisher Error";
            this.lblPublisherError.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisher.Location = new System.Drawing.Point(289, 5);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(319, 29);
            this.txtPublisher.TabIndex = 23;
            this.txtPublisher.Validating += new System.ComponentModel.CancelEventHandler(this.txtPublisher_Validating);
            this.txtPublisher.Validated += new System.EventHandler(this.txtPublisher_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nhà xuất bản:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.nudQuantity);
            this.panel5.Controls.Add(this.nudCostPrice);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.lblNewCategory);
            this.panel5.Controls.Add(this.btnAddBook);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(954, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(238, 363);
            this.panel5.TabIndex = 17;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(132, 88);
            this.nudQuantity.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(100, 33);
            this.nudQuantity.TabIndex = 30;
            this.nudQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudQuantity.ThousandsSeparator = true;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudCostPrice
            // 
            this.nudCostPrice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCostPrice.Location = new System.Drawing.Point(132, 138);
            this.nudCostPrice.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudCostPrice.Name = "nudCostPrice";
            this.nudCostPrice.Size = new System.Drawing.Size(100, 33);
            this.nudCostPrice.TabIndex = 29;
            this.nudCostPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudCostPrice.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "Đơn giá nhập:";
            // 
            // lblNewCategory
            // 
            this.lblNewCategory.AutoSize = true;
            this.lblNewCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewCategory.Location = new System.Drawing.Point(15, 93);
            this.lblNewCategory.Name = "lblNewCategory";
            this.lblNewCategory.Size = new System.Drawing.Size(115, 21);
            this.lblNewCategory.TabIndex = 22;
            this.lblNewCategory.Text = "Số lượng nhập:";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBook.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAddBook.FlatAppearance.BorderSize = 0;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.ForeColor = System.Drawing.Color.White;
            this.btnAddBook.Location = new System.Drawing.Point(29, 212);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(194, 46);
            this.btnAddBook.TabIndex = 11;
            this.btnAddBook.Text = "Thêm sách vào phiếu";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.25F));
            this.tableLayoutPanel2.Controls.Add(this.grpImportBookDetail, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1200, 365);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // grpImportBookDetail
            // 
            this.grpImportBookDetail.Controls.Add(this.pnlTitleBook);
            this.grpImportBookDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpImportBookDetail.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpImportBookDetail.Location = new System.Drawing.Point(300, 3);
            this.grpImportBookDetail.Name = "grpImportBookDetail";
            this.grpImportBookDetail.Size = new System.Drawing.Size(897, 359);
            this.grpImportBookDetail.TabIndex = 17;
            this.grpImportBookDetail.TabStop = false;
            this.grpImportBookDetail.Text = "Chi tiết Phiếu nhập";
            // 
            // pnlTitleBook
            // 
            this.pnlTitleBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitleBook.Controls.Add(this.pnlAccount);
            this.pnlTitleBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTitleBook.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTitleBook.Location = new System.Drawing.Point(3, 35);
            this.pnlTitleBook.Name = "pnlTitleBook";
            this.pnlTitleBook.Size = new System.Drawing.Size(891, 321);
            this.pnlTitleBook.TabIndex = 0;
            // 
            // pnlAccount
            // 
            this.pnlAccount.Controls.Add(this.gunaDgvBookReceiptDetail);
            this.pnlAccount.Controls.Add(this.panel4);
            this.pnlAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAccount.Location = new System.Drawing.Point(0, 0);
            this.pnlAccount.Name = "pnlAccount";
            this.pnlAccount.Size = new System.Drawing.Size(889, 319);
            this.pnlAccount.TabIndex = 3;
            // 
            // gunaDgvBookReceiptDetail
            // 
            this.gunaDgvBookReceiptDetail.AllowUserToAddRows = false;
            this.gunaDgvBookReceiptDetail.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.gunaDgvBookReceiptDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gunaDgvBookReceiptDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDgvBookReceiptDetail.BackgroundColor = System.Drawing.Color.White;
            this.gunaDgvBookReceiptDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDgvBookReceiptDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDgvBookReceiptDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDgvBookReceiptDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.gunaDgvBookReceiptDetail.ColumnHeadersHeight = 30;
            this.gunaDgvBookReceiptDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDauSach2,
            this.NhaXuatBan,
            this.NamXuatBan,
            this.SoLuongNhap,
            this.DonGiaNhap,
            this.ThanhTien});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDgvBookReceiptDetail.DefaultCellStyle = dataGridViewCellStyle12;
            this.gunaDgvBookReceiptDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaDgvBookReceiptDetail.EnableHeadersVisualStyles = false;
            this.gunaDgvBookReceiptDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDgvBookReceiptDetail.Location = new System.Drawing.Point(0, 0);
            this.gunaDgvBookReceiptDetail.MultiSelect = false;
            this.gunaDgvBookReceiptDetail.Name = "gunaDgvBookReceiptDetail";
            this.gunaDgvBookReceiptDetail.ReadOnly = true;
            this.gunaDgvBookReceiptDetail.RowHeadersVisible = false;
            this.gunaDgvBookReceiptDetail.RowTemplate.Height = 28;
            this.gunaDgvBookReceiptDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDgvBookReceiptDetail.Size = new System.Drawing.Size(889, 255);
            this.gunaDgvBookReceiptDetail.TabIndex = 21;
            this.gunaDgvBookReceiptDetail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDgvBookReceiptDetail.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDgvBookReceiptDetail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDgvBookReceiptDetail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDgvBookReceiptDetail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDgvBookReceiptDetail.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDgvBookReceiptDetail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDgvBookReceiptDetail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDgvBookReceiptDetail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDgvBookReceiptDetail.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDgvBookReceiptDetail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDgvBookReceiptDetail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDgvBookReceiptDetail.ThemeStyle.HeaderStyle.Height = 30;
            this.gunaDgvBookReceiptDetail.ThemeStyle.ReadOnly = true;
            this.gunaDgvBookReceiptDetail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDgvBookReceiptDetail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDgvBookReceiptDetail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDgvBookReceiptDetail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDgvBookReceiptDetail.ThemeStyle.RowsStyle.Height = 28;
            this.gunaDgvBookReceiptDetail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDgvBookReceiptDetail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MaDauSach2
            // 
            this.MaDauSach2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MaDauSach2.HeaderText = "Mã Đầu Sách";
            this.MaDauSach2.Name = "MaDauSach2";
            this.MaDauSach2.ReadOnly = true;
            this.MaDauSach2.Width = 146;
            // 
            // NhaXuatBan
            // 
            this.NhaXuatBan.HeaderText = "Nhà Xuất Bản";
            this.NhaXuatBan.Name = "NhaXuatBan";
            this.NhaXuatBan.ReadOnly = true;
            // 
            // NamXuatBan
            // 
            this.NamXuatBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.NamXuatBan.HeaderText = "Năm XB";
            this.NamXuatBan.Name = "NamXuatBan";
            this.NamXuatBan.ReadOnly = true;
            this.NamXuatBan.Width = 102;
            // 
            // SoLuongNhap
            // 
            this.SoLuongNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SoLuongNhap.HeaderText = "Số Lượng";
            this.SoLuongNhap.Name = "SoLuongNhap";
            this.SoLuongNhap.ReadOnly = true;
            this.SoLuongNhap.Width = 114;
            // 
            // DonGiaNhap
            // 
            this.DonGiaNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DonGiaNhap.HeaderText = "Đơn Giá";
            this.DonGiaNhap.Name = "DonGiaNhap";
            this.DonGiaNhap.ReadOnly = true;
            this.DonGiaNhap.Width = 103;
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            this.ThanhTien.Width = 129;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnOkBook);
            this.panel4.Controls.Add(this.btnDeleteBook);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 255);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(889, 64);
            this.panel4.TabIndex = 19;
            // 
            // btnOkBook
            // 
            this.btnOkBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOkBook.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnOkBook.FlatAppearance.BorderSize = 0;
            this.btnOkBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkBook.ForeColor = System.Drawing.Color.White;
            this.btnOkBook.Location = new System.Drawing.Point(643, 15);
            this.btnOkBook.Name = "btnOkBook";
            this.btnOkBook.Size = new System.Drawing.Size(97, 46);
            this.btnOkBook.TabIndex = 33;
            this.btnOkBook.Text = "Chốt phiếu";
            this.btnOkBook.UseVisualStyleBackColor = false;
            this.btnOkBook.Click += new System.EventHandler(this.btnOkBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteBook.BackColor = System.Drawing.Color.Brown;
            this.btnDeleteBook.FlatAppearance.BorderSize = 0;
            this.btnDeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBook.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBook.Location = new System.Drawing.Point(780, 15);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(97, 46);
            this.btnDeleteBook.TabIndex = 32;
            this.btnDeleteBook.Text = "Xoá sách";
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpImportBookInfo);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 345);
            this.panel1.TabIndex = 18;
            // 
            // grpImportBookInfo
            // 
            this.grpImportBookInfo.Controls.Add(this.panel3);
            this.grpImportBookInfo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpImportBookInfo.Location = new System.Drawing.Point(16, 24);
            this.grpImportBookInfo.Name = "grpImportBookInfo";
            this.grpImportBookInfo.Size = new System.Drawing.Size(251, 295);
            this.grpImportBookInfo.TabIndex = 26;
            this.grpImportBookInfo.TabStop = false;
            this.grpImportBookInfo.Text = "Phiếu nhập sách";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.nudTotalAmount);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.dtmDate);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(3, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 257);
            this.panel3.TabIndex = 0;
            // 
            // nudTotalAmount
            // 
            this.nudTotalAmount.Enabled = false;
            this.nudTotalAmount.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTotalAmount.Location = new System.Drawing.Point(103, 110);
            this.nudTotalAmount.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudTotalAmount.Name = "nudTotalAmount";
            this.nudTotalAmount.ReadOnly = true;
            this.nudTotalAmount.Size = new System.Drawing.Size(126, 33);
            this.nudTotalAmount.TabIndex = 31;
            this.nudTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTotalAmount.ThousandsSeparator = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(142, 184);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 46);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(31, 184);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 46);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtmDate
            // 
            this.dtmDate.Enabled = false;
            this.dtmDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmDate.Location = new System.Drawing.Point(112, 57);
            this.dtmDate.Name = "dtmDate";
            this.dtmDate.Size = new System.Drawing.Size(117, 33);
            this.dtmDate.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tổng tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Ngày lập:";
            // 
            // errBookReceipt_Add
            // 
            this.errBookReceipt_Add.BlinkRate = 0;
            this.errBookReceipt_Add.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errBookReceipt_Add.ContainerControl = this;
            // 
            // frmBookReceipt_Add
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1206, 804);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBookReceipt_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Phiếu nhập sách";
            this.Load += new System.EventHandler(this.frmBookReceipt_Add_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpTitleBook.ResumeLayout(false);
            this.pnlBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDgvTitleBook)).EndInit();
            this.pnlSearchTitleBook.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPublishingYear)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostPrice)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.grpImportBookDetail.ResumeLayout(false);
            this.pnlTitleBook.ResumeLayout(false);
            this.pnlAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDgvBookReceiptDetail)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.grpImportBookInfo.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errBookReceipt_Add)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox grpTitleBook;
        private System.Windows.Forms.Panel pnlBook;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpImportBookInfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtmDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpImportBookDetail;
        private System.Windows.Forms.Panel pnlTitleBook;
        private System.Windows.Forms.Panel pnlAccount;
        private Guna.UI2.WinForms.Guna2DataGridView gunaDgvTitleBook;
        private System.Windows.Forms.Panel pnlSearchTitleBook;
        private System.Windows.Forms.Button btnTitleBookSearch;
        private Guna.UI2.WinForms.Guna2TextBox gunaTxtTitleBookSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPublishingYear;
        private System.Windows.Forms.Label lblPublisherError;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.NumericUpDown nudCostPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNewCategory;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.NumericUpDown nudTotalAmount;
        private System.Windows.Forms.ErrorProvider errBookReceipt_Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTheLoai;
        private Guna.UI2.WinForms.Guna2DataGridView gunaDgvBookReceiptDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDauSach2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Button btnOkBook;
    }
}