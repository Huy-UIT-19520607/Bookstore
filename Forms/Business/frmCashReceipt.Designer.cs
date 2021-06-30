
namespace BookStore.Forms.Business
{
    partial class frmCashReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCashReceipt));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFilterCustomer = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.gunaDgvCustomer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnCustomerSearch = new System.Windows.Forms.Button();
            this.gunaTxtCustomerSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grpCashReceipt = new System.Windows.Forms.GroupBox();
            this.pnlImportBook = new System.Windows.Forms.Panel();
            this.gunaDgvCashReceipt = new Guna.UI2.WinForms.Guna2DataGridView();
            this.SoPNS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnAddCashReceipt = new System.Windows.Forms.Button();
            this.btnDeleteCashReceipt = new System.Windows.Forms.Button();
            this.btnEditCashReceipt = new System.Windows.Forms.Button();
            this.btnAddTitleBook = new System.Windows.Forms.Button();
            this.btnDeleteTitleBook = new System.Windows.Forms.Button();
            this.btnEditTitleBook = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pnlCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDgvCustomer)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grpCashReceipt.SuspendLayout();
            this.pnlImportBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDgvCashReceipt)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFilterCustomer
            // 
            this.btnFilterCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFilterCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnFilterCustomer.FlatAppearance.BorderSize = 0;
            this.btnFilterCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterCustomer.ForeColor = System.Drawing.Color.White;
            this.btnFilterCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnFilterCustomer.Image")));
            this.btnFilterCustomer.Location = new System.Drawing.Point(366, 0);
            this.btnFilterCustomer.Name = "btnFilterCustomer";
            this.btnFilterCustomer.Size = new System.Drawing.Size(34, 35);
            this.btnFilterCustomer.TabIndex = 10;
            this.btnFilterCustomer.UseVisualStyleBackColor = false;
            this.btnFilterCustomer.Click += new System.EventHandler(this.btnFilterCustomer_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.44564F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.55436F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(943, 653);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(937, 298);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Khách hàng";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pnlCategory);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 42);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(931, 253);
            this.panel7.TabIndex = 3;
            // 
            // pnlCategory
            // 
            this.pnlCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCategory.Controls.Add(this.gunaDgvCustomer);
            this.pnlCategory.Controls.Add(this.pnlSearch);
            this.pnlCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCategory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCategory.Location = new System.Drawing.Point(0, 0);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(931, 253);
            this.pnlCategory.TabIndex = 0;
            // 
            // gunaDgvCustomer
            // 
            this.gunaDgvCustomer.AllowUserToAddRows = false;
            this.gunaDgvCustomer.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaDgvCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDgvCustomer.BackgroundColor = System.Drawing.Color.White;
            this.gunaDgvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDgvCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDgvCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDgvCustomer.ColumnHeadersHeight = 30;
            this.gunaDgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.TenKhachHang,
            this.DiaChi,
            this.SDT,
            this.Email,
            this.SoTienNo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDgvCustomer.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaDgvCustomer.EnableHeadersVisualStyles = false;
            this.gunaDgvCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDgvCustomer.Location = new System.Drawing.Point(0, 64);
            this.gunaDgvCustomer.MultiSelect = false;
            this.gunaDgvCustomer.Name = "gunaDgvCustomer";
            this.gunaDgvCustomer.ReadOnly = true;
            this.gunaDgvCustomer.RowHeadersVisible = false;
            this.gunaDgvCustomer.RowTemplate.Height = 28;
            this.gunaDgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDgvCustomer.Size = new System.Drawing.Size(929, 187);
            this.gunaDgvCustomer.TabIndex = 3;
            this.gunaDgvCustomer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDgvCustomer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDgvCustomer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDgvCustomer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDgvCustomer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDgvCustomer.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDgvCustomer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDgvCustomer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDgvCustomer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDgvCustomer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDgvCustomer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDgvCustomer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDgvCustomer.ThemeStyle.HeaderStyle.Height = 30;
            this.gunaDgvCustomer.ThemeStyle.ReadOnly = true;
            this.gunaDgvCustomer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDgvCustomer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDgvCustomer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDgvCustomer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDgvCustomer.ThemeStyle.RowsStyle.Height = 28;
            this.gunaDgvCustomer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDgvCustomer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Khách Hàng";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 169;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKhachHang.DataPropertyName = "Name";
            this.TenKhachHang.HeaderText = "Tên Khách Hàng";
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "Address";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SDT.DataPropertyName = "PhoneNumber";
            this.SDT.HeaderText = "SĐT";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 68;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // SoTienNo
            // 
            this.SoTienNo.DataPropertyName = "Debt";
            this.SoTienNo.HeaderText = "Số Tiền Nợ";
            this.SoTienNo.Name = "SoTienNo";
            this.SoTienNo.ReadOnly = true;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.btnCustomerSearch);
            this.pnlSearch.Controls.Add(this.gunaTxtCustomerSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(929, 64);
            this.pnlSearch.TabIndex = 4;
            // 
            // btnCustomerSearch
            // 
            this.btnCustomerSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(106)))));
            this.btnCustomerSearch.FlatAppearance.BorderSize = 0;
            this.btnCustomerSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerSearch.ForeColor = System.Drawing.Color.White;
            this.btnCustomerSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerSearch.Image")));
            this.btnCustomerSearch.Location = new System.Drawing.Point(483, 7);
            this.btnCustomerSearch.Name = "btnCustomerSearch";
            this.btnCustomerSearch.Size = new System.Drawing.Size(34, 35);
            this.btnCustomerSearch.TabIndex = 1;
            this.btnCustomerSearch.UseVisualStyleBackColor = false;
            this.btnCustomerSearch.Click += new System.EventHandler(this.btnCustomerSearch_Click);
            // 
            // gunaTxtCustomerSearch
            // 
            this.gunaTxtCustomerSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTxtCustomerSearch.DefaultText = "";
            this.gunaTxtCustomerSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gunaTxtCustomerSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunaTxtCustomerSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTxtCustomerSearch.DisabledState.Parent = this.gunaTxtCustomerSearch;
            this.gunaTxtCustomerSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTxtCustomerSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTxtCustomerSearch.FocusedState.Parent = this.gunaTxtCustomerSearch;
            this.gunaTxtCustomerSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaTxtCustomerSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTxtCustomerSearch.HoverState.Parent = this.gunaTxtCustomerSearch;
            this.gunaTxtCustomerSearch.Location = new System.Drawing.Point(65, 7);
            this.gunaTxtCustomerSearch.Margin = new System.Windows.Forms.Padding(5);
            this.gunaTxtCustomerSearch.Name = "gunaTxtCustomerSearch";
            this.gunaTxtCustomerSearch.PasswordChar = '\0';
            this.gunaTxtCustomerSearch.PlaceholderText = "Tìm kiếm";
            this.gunaTxtCustomerSearch.SelectedText = "";
            this.gunaTxtCustomerSearch.ShadowDecoration.Parent = this.gunaTxtCustomerSearch;
            this.gunaTxtCustomerSearch.Size = new System.Drawing.Size(410, 35);
            this.gunaTxtCustomerSearch.TabIndex = 0;
            this.gunaTxtCustomerSearch.TextChanged += new System.EventHandler(this.gunaTxtCustomerSearch_TextChanged);
            this.gunaTxtCustomerSearch.Leave += new System.EventHandler(this.gunaTxtCustomerSearch_Leave);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.43757F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(937, 343);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.grpCashReceipt);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(931, 337);
            this.panel2.TabIndex = 17;
            // 
            // grpCashReceipt
            // 
            this.grpCashReceipt.Controls.Add(this.pnlImportBook);
            this.grpCashReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCashReceipt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCashReceipt.Location = new System.Drawing.Point(0, 0);
            this.grpCashReceipt.Name = "grpCashReceipt";
            this.grpCashReceipt.Size = new System.Drawing.Size(931, 289);
            this.grpCashReceipt.TabIndex = 39;
            this.grpCashReceipt.TabStop = false;
            this.grpCashReceipt.Text = "Phiếu Thu tiền";
            // 
            // pnlImportBook
            // 
            this.pnlImportBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlImportBook.Controls.Add(this.gunaDgvCashReceipt);
            this.pnlImportBook.Controls.Add(this.panel10);
            this.pnlImportBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImportBook.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlImportBook.Location = new System.Drawing.Point(3, 35);
            this.pnlImportBook.Name = "pnlImportBook";
            this.pnlImportBook.Size = new System.Drawing.Size(925, 251);
            this.pnlImportBook.TabIndex = 0;
            // 
            // gunaDgvCashReceipt
            // 
            this.gunaDgvCashReceipt.AllowUserToAddRows = false;
            this.gunaDgvCashReceipt.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gunaDgvCashReceipt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gunaDgvCashReceipt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDgvCashReceipt.BackgroundColor = System.Drawing.Color.White;
            this.gunaDgvCashReceipt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDgvCashReceipt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDgvCashReceipt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDgvCashReceipt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gunaDgvCashReceipt.ColumnHeadersHeight = 30;
            this.gunaDgvCashReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPNS,
            this.MaKhachHang,
            this.NgayLap,
            this.SoTienThu});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDgvCashReceipt.DefaultCellStyle = dataGridViewCellStyle6;
            this.gunaDgvCashReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaDgvCashReceipt.EnableHeadersVisualStyles = false;
            this.gunaDgvCashReceipt.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDgvCashReceipt.Location = new System.Drawing.Point(0, 0);
            this.gunaDgvCashReceipt.MultiSelect = false;
            this.gunaDgvCashReceipt.Name = "gunaDgvCashReceipt";
            this.gunaDgvCashReceipt.ReadOnly = true;
            this.gunaDgvCashReceipt.RowHeadersVisible = false;
            this.gunaDgvCashReceipt.RowTemplate.Height = 28;
            this.gunaDgvCashReceipt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDgvCashReceipt.Size = new System.Drawing.Size(923, 187);
            this.gunaDgvCashReceipt.TabIndex = 28;
            this.gunaDgvCashReceipt.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDgvCashReceipt.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDgvCashReceipt.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDgvCashReceipt.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDgvCashReceipt.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDgvCashReceipt.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDgvCashReceipt.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDgvCashReceipt.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDgvCashReceipt.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDgvCashReceipt.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDgvCashReceipt.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDgvCashReceipt.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDgvCashReceipt.ThemeStyle.HeaderStyle.Height = 30;
            this.gunaDgvCashReceipt.ThemeStyle.ReadOnly = true;
            this.gunaDgvCashReceipt.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDgvCashReceipt.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDgvCashReceipt.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDgvCashReceipt.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDgvCashReceipt.ThemeStyle.RowsStyle.Height = 28;
            this.gunaDgvCashReceipt.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDgvCashReceipt.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // SoPNS
            // 
            this.SoPNS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SoPNS.DataPropertyName = "Id";
            this.SoPNS.HeaderText = "Số Phiếu Thu";
            this.SoPNS.Name = "SoPNS";
            this.SoPNS.ReadOnly = true;
            this.SoPNS.Width = 146;
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MaKhachHang.DataPropertyName = "CustomerId";
            this.MaKhachHang.HeaderText = "Mã Khách Hàng";
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.ReadOnly = true;
            this.MaKhachHang.Width = 169;
            // 
            // NgayLap
            // 
            this.NgayLap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayLap.DataPropertyName = "CreateDate";
            this.NgayLap.HeaderText = "Ngày Lập";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            // 
            // SoTienThu
            // 
            this.SoTienThu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoTienThu.DataPropertyName = "Payment";
            this.SoTienThu.HeaderText = "Số Tiền Thu";
            this.SoTienThu.Name = "SoTienThu";
            this.SoTienThu.ReadOnly = true;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel9);
            this.panel10.Controls.Add(this.btnAddTitleBook);
            this.panel10.Controls.Add(this.btnDeleteTitleBook);
            this.panel10.Controls.Add(this.btnEditTitleBook);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 187);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(923, 62);
            this.panel10.TabIndex = 27;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnAddCashReceipt);
            this.panel9.Controls.Add(this.btnDeleteCashReceipt);
            this.panel9.Controls.Add(this.btnEditCashReceipt);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(923, 62);
            this.panel9.TabIndex = 28;
            // 
            // btnAddCashReceipt
            // 
            this.btnAddCashReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCashReceipt.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddCashReceipt.FlatAppearance.BorderSize = 0;
            this.btnAddCashReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCashReceipt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCashReceipt.ForeColor = System.Drawing.Color.White;
            this.btnAddCashReceipt.Location = new System.Drawing.Point(646, 10);
            this.btnAddCashReceipt.Name = "btnAddCashReceipt";
            this.btnAddCashReceipt.Size = new System.Drawing.Size(76, 46);
            this.btnAddCashReceipt.TabIndex = 2;
            this.btnAddCashReceipt.Text = "Thêm";
            this.btnAddCashReceipt.UseVisualStyleBackColor = false;
            this.btnAddCashReceipt.Click += new System.EventHandler(this.btnAddCashReceipt_Click);
            // 
            // btnDeleteCashReceipt
            // 
            this.btnDeleteCashReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCashReceipt.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteCashReceipt.FlatAppearance.BorderSize = 0;
            this.btnDeleteCashReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCashReceipt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCashReceipt.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCashReceipt.Location = new System.Drawing.Point(844, 10);
            this.btnDeleteCashReceipt.Name = "btnDeleteCashReceipt";
            this.btnDeleteCashReceipt.Size = new System.Drawing.Size(76, 46);
            this.btnDeleteCashReceipt.TabIndex = 5;
            this.btnDeleteCashReceipt.Text = "Xoá";
            this.btnDeleteCashReceipt.UseVisualStyleBackColor = false;
            this.btnDeleteCashReceipt.Click += new System.EventHandler(this.btnDeleteCashReceipt_Click);
            // 
            // btnEditCashReceipt
            // 
            this.btnEditCashReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditCashReceipt.BackColor = System.Drawing.Color.Goldenrod;
            this.btnEditCashReceipt.FlatAppearance.BorderSize = 0;
            this.btnEditCashReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCashReceipt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCashReceipt.ForeColor = System.Drawing.Color.White;
            this.btnEditCashReceipt.Location = new System.Drawing.Point(745, 10);
            this.btnEditCashReceipt.Name = "btnEditCashReceipt";
            this.btnEditCashReceipt.Size = new System.Drawing.Size(76, 46);
            this.btnEditCashReceipt.TabIndex = 4;
            this.btnEditCashReceipt.Text = "Sửa";
            this.btnEditCashReceipt.UseVisualStyleBackColor = false;
            this.btnEditCashReceipt.Click += new System.EventHandler(this.btnEditCashReceipt_Click);
            // 
            // btnAddTitleBook
            // 
            this.btnAddTitleBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTitleBook.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddTitleBook.FlatAppearance.BorderSize = 0;
            this.btnAddTitleBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTitleBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTitleBook.ForeColor = System.Drawing.Color.White;
            this.btnAddTitleBook.Location = new System.Drawing.Point(719, 10);
            this.btnAddTitleBook.Name = "btnAddTitleBook";
            this.btnAddTitleBook.Size = new System.Drawing.Size(63, 46);
            this.btnAddTitleBook.TabIndex = 2;
            this.btnAddTitleBook.Text = "Thêm";
            this.btnAddTitleBook.UseVisualStyleBackColor = false;
            // 
            // btnDeleteTitleBook
            // 
            this.btnDeleteTitleBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteTitleBook.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteTitleBook.FlatAppearance.BorderSize = 0;
            this.btnDeleteTitleBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTitleBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTitleBook.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTitleBook.Location = new System.Drawing.Point(857, 10);
            this.btnDeleteTitleBook.Name = "btnDeleteTitleBook";
            this.btnDeleteTitleBook.Size = new System.Drawing.Size(63, 46);
            this.btnDeleteTitleBook.TabIndex = 5;
            this.btnDeleteTitleBook.Text = "Xoá";
            this.btnDeleteTitleBook.UseVisualStyleBackColor = false;
            // 
            // btnEditTitleBook
            // 
            this.btnEditTitleBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditTitleBook.BackColor = System.Drawing.Color.Goldenrod;
            this.btnEditTitleBook.FlatAppearance.BorderSize = 0;
            this.btnEditTitleBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTitleBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTitleBook.ForeColor = System.Drawing.Color.White;
            this.btnEditTitleBook.Location = new System.Drawing.Point(788, 10);
            this.btnEditTitleBook.Name = "btnEditTitleBook";
            this.btnEditTitleBook.Size = new System.Drawing.Size(63, 46);
            this.btnEditTitleBook.TabIndex = 4;
            this.btnEditTitleBook.Text = "Sửa";
            this.btnEditTitleBook.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnFilterCustomer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 289);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(931, 48);
            this.panel3.TabIndex = 27;
            // 
            // frmCashReceipt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(943, 653);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(959, 692);
            this.Name = "frmCashReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THU TIỀN";
            this.Load += new System.EventHandler(this.frmCashReceipt_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.pnlCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDgvCustomer)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.grpCashReceipt.ResumeLayout(false);
            this.pnlImportBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDgvCashReceipt)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFilterCustomer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grpCashReceipt;
        private System.Windows.Forms.Panel pnlImportBook;
        private Guna.UI2.WinForms.Guna2DataGridView gunaDgvCashReceipt;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnAddCashReceipt;
        private System.Windows.Forms.Button btnDeleteCashReceipt;
        private System.Windows.Forms.Button btnEditCashReceipt;
        private System.Windows.Forms.Button btnAddTitleBook;
        private System.Windows.Forms.Button btnDeleteTitleBook;
        private System.Windows.Forms.Button btnEditTitleBook;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel pnlCategory;
        private Guna.UI2.WinForms.Guna2DataGridView gunaDgvCustomer;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnCustomerSearch;
        private Guna.UI2.WinForms.Guna2TextBox gunaTxtCustomerSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPNS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienThu;
    }
}