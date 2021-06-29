
namespace BookStore.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlSlideMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlSubMenuSetting = new System.Windows.Forms.Panel();
            this.btnRequirement = new System.Windows.Forms.Button();
            this.btnMenuSetting = new System.Windows.Forms.Button();
            this.pnlSubMenuReport = new System.Windows.Forms.Panel();
            this.btnDebt = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnMenuReport = new System.Windows.Forms.Button();
            this.pnlSubMenuBusiness = new System.Windows.Forms.Panel();
            this.btnCashReceipt = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnBookReceipt = new System.Windows.Forms.Button();
            this.btnMenuBusiness = new System.Windows.Forms.Button();
            this.pnlSubMenuManagement = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnMenuManagement = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblLogoName = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblPermission = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSubMenuName = new System.Windows.Forms.Label();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.tmrCurrentTime = new System.Windows.Forms.Timer(this.components);
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.pnlSlideMenu.SuspendLayout();
            this.pnlSubMenuSetting.SuspendLayout();
            this.pnlSubMenuReport.SuspendLayout();
            this.pnlSubMenuBusiness.SuspendLayout();
            this.pnlSubMenuManagement.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSlideMenu
            // 
            this.pnlSlideMenu.AutoScroll = true;
            this.pnlSlideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(106)))));
            this.pnlSlideMenu.Controls.Add(this.btnLogout);
            this.pnlSlideMenu.Controls.Add(this.pnlSubMenuSetting);
            this.pnlSlideMenu.Controls.Add(this.btnMenuSetting);
            this.pnlSlideMenu.Controls.Add(this.pnlSubMenuReport);
            this.pnlSlideMenu.Controls.Add(this.btnMenuReport);
            this.pnlSlideMenu.Controls.Add(this.pnlSubMenuBusiness);
            this.pnlSlideMenu.Controls.Add(this.btnMenuBusiness);
            this.pnlSlideMenu.Controls.Add(this.pnlSubMenuManagement);
            this.pnlSlideMenu.Controls.Add(this.btnMenuManagement);
            this.pnlSlideMenu.Controls.Add(this.pnlLogo);
            this.pnlSlideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSlideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSlideMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSlideMenu.Name = "pnlSlideMenu";
            this.pnlSlideMenu.Size = new System.Drawing.Size(260, 785);
            this.pnlSlideMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 856);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(20, 0, 25, 0);
            this.btnLogout.Size = new System.Drawing.Size(243, 60);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "  Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlSubMenuSetting
            // 
            this.pnlSubMenuSetting.Controls.Add(this.btnRequirement);
            this.pnlSubMenuSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuSetting.Location = new System.Drawing.Point(0, 801);
            this.pnlSubMenuSetting.Name = "pnlSubMenuSetting";
            this.pnlSubMenuSetting.Size = new System.Drawing.Size(243, 55);
            this.pnlSubMenuSetting.TabIndex = 10;
            // 
            // btnRequirement
            // 
            this.btnRequirement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(180)))));
            this.btnRequirement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRequirement.FlatAppearance.BorderSize = 0;
            this.btnRequirement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequirement.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequirement.ForeColor = System.Drawing.Color.White;
            this.btnRequirement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRequirement.Location = new System.Drawing.Point(0, 0);
            this.btnRequirement.Name = "btnRequirement";
            this.btnRequirement.Padding = new System.Windows.Forms.Padding(63, 0, 25, 0);
            this.btnRequirement.Size = new System.Drawing.Size(243, 50);
            this.btnRequirement.TabIndex = 4;
            this.btnRequirement.Text = "Các quy định";
            this.btnRequirement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRequirement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRequirement.UseVisualStyleBackColor = false;
            this.btnRequirement.Click += new System.EventHandler(this.btnRequirement_Click);
            // 
            // btnMenuSetting
            // 
            this.btnMenuSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(106)))));
            this.btnMenuSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuSetting.FlatAppearance.BorderSize = 0;
            this.btnMenuSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSetting.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuSetting.ForeColor = System.Drawing.Color.White;
            this.btnMenuSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuSetting.Image")));
            this.btnMenuSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSetting.Location = new System.Drawing.Point(0, 741);
            this.btnMenuSetting.Name = "btnMenuSetting";
            this.btnMenuSetting.Padding = new System.Windows.Forms.Padding(20, 0, 25, 0);
            this.btnMenuSetting.Size = new System.Drawing.Size(243, 60);
            this.btnMenuSetting.TabIndex = 9;
            this.btnMenuSetting.Text = "  Tuỳ chỉnh";
            this.btnMenuSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuSetting.UseVisualStyleBackColor = false;
            this.btnMenuSetting.Click += new System.EventHandler(this.btnMenuSetting_Click);
            // 
            // pnlSubMenuReport
            // 
            this.pnlSubMenuReport.Controls.Add(this.btnDebt);
            this.pnlSubMenuReport.Controls.Add(this.btnInventory);
            this.pnlSubMenuReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuReport.Location = new System.Drawing.Point(0, 635);
            this.pnlSubMenuReport.Name = "pnlSubMenuReport";
            this.pnlSubMenuReport.Size = new System.Drawing.Size(243, 106);
            this.pnlSubMenuReport.TabIndex = 8;
            // 
            // btnDebt
            // 
            this.btnDebt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(180)))));
            this.btnDebt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDebt.FlatAppearance.BorderSize = 0;
            this.btnDebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebt.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebt.ForeColor = System.Drawing.Color.White;
            this.btnDebt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDebt.Location = new System.Drawing.Point(0, 50);
            this.btnDebt.Name = "btnDebt";
            this.btnDebt.Padding = new System.Windows.Forms.Padding(63, 0, 25, 0);
            this.btnDebt.Size = new System.Drawing.Size(243, 50);
            this.btnDebt.TabIndex = 4;
            this.btnDebt.Text = "Công nợ";
            this.btnDebt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDebt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDebt.UseVisualStyleBackColor = false;
            this.btnDebt.Click += new System.EventHandler(this.btnDebt_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(180)))));
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(0, 0);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Padding = new System.Windows.Forms.Padding(63, 0, 25, 0);
            this.btnInventory.Size = new System.Drawing.Size(243, 50);
            this.btnInventory.TabIndex = 3;
            this.btnInventory.Text = "Tồn kho";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnMenuReport
            // 
            this.btnMenuReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(106)))));
            this.btnMenuReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuReport.FlatAppearance.BorderSize = 0;
            this.btnMenuReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuReport.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuReport.ForeColor = System.Drawing.Color.White;
            this.btnMenuReport.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuReport.Image")));
            this.btnMenuReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuReport.Location = new System.Drawing.Point(0, 575);
            this.btnMenuReport.Name = "btnMenuReport";
            this.btnMenuReport.Padding = new System.Windows.Forms.Padding(20, 0, 25, 0);
            this.btnMenuReport.Size = new System.Drawing.Size(243, 60);
            this.btnMenuReport.TabIndex = 7;
            this.btnMenuReport.Text = "  Báo cáo";
            this.btnMenuReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuReport.UseVisualStyleBackColor = false;
            this.btnMenuReport.Click += new System.EventHandler(this.btnMenuReport_Click);
            // 
            // pnlSubMenuBusiness
            // 
            this.pnlSubMenuBusiness.Controls.Add(this.btnCashReceipt);
            this.pnlSubMenuBusiness.Controls.Add(this.btnBill);
            this.pnlSubMenuBusiness.Controls.Add(this.btnBookReceipt);
            this.pnlSubMenuBusiness.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuBusiness.Location = new System.Drawing.Point(0, 420);
            this.pnlSubMenuBusiness.Name = "pnlSubMenuBusiness";
            this.pnlSubMenuBusiness.Size = new System.Drawing.Size(243, 155);
            this.pnlSubMenuBusiness.TabIndex = 4;
            // 
            // btnCashReceipt
            // 
            this.btnCashReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(180)))));
            this.btnCashReceipt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCashReceipt.FlatAppearance.BorderSize = 0;
            this.btnCashReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashReceipt.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashReceipt.ForeColor = System.Drawing.Color.White;
            this.btnCashReceipt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCashReceipt.Location = new System.Drawing.Point(0, 100);
            this.btnCashReceipt.Name = "btnCashReceipt";
            this.btnCashReceipt.Padding = new System.Windows.Forms.Padding(63, 0, 25, 0);
            this.btnCashReceipt.Size = new System.Drawing.Size(243, 50);
            this.btnCashReceipt.TabIndex = 3;
            this.btnCashReceipt.Text = "Thu tiền";
            this.btnCashReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCashReceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCashReceipt.UseVisualStyleBackColor = false;
            this.btnCashReceipt.Click += new System.EventHandler(this.btnCashReceipt_Click);
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(180)))));
            this.btnBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBill.FlatAppearance.BorderSize = 0;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.Location = new System.Drawing.Point(0, 50);
            this.btnBill.Name = "btnBill";
            this.btnBill.Padding = new System.Windows.Forms.Padding(63, 0, 25, 0);
            this.btnBill.Size = new System.Drawing.Size(243, 50);
            this.btnBill.TabIndex = 2;
            this.btnBill.Text = "Hoá đơn";
            this.btnBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBill.UseVisualStyleBackColor = false;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnBookReceipt
            // 
            this.btnBookReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(180)))));
            this.btnBookReceipt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookReceipt.FlatAppearance.BorderSize = 0;
            this.btnBookReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookReceipt.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookReceipt.ForeColor = System.Drawing.Color.White;
            this.btnBookReceipt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookReceipt.Location = new System.Drawing.Point(0, 0);
            this.btnBookReceipt.Name = "btnBookReceipt";
            this.btnBookReceipt.Padding = new System.Windows.Forms.Padding(63, 0, 25, 0);
            this.btnBookReceipt.Size = new System.Drawing.Size(243, 50);
            this.btnBookReceipt.TabIndex = 1;
            this.btnBookReceipt.Text = "Nhập sách";
            this.btnBookReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookReceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBookReceipt.UseVisualStyleBackColor = false;
            this.btnBookReceipt.Click += new System.EventHandler(this.btnBookReceipt_Click);
            // 
            // btnMenuBusiness
            // 
            this.btnMenuBusiness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(106)))));
            this.btnMenuBusiness.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuBusiness.FlatAppearance.BorderSize = 0;
            this.btnMenuBusiness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuBusiness.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuBusiness.ForeColor = System.Drawing.Color.White;
            this.btnMenuBusiness.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuBusiness.Image")));
            this.btnMenuBusiness.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuBusiness.Location = new System.Drawing.Point(0, 360);
            this.btnMenuBusiness.Name = "btnMenuBusiness";
            this.btnMenuBusiness.Padding = new System.Windows.Forms.Padding(20, 0, 25, 0);
            this.btnMenuBusiness.Size = new System.Drawing.Size(243, 60);
            this.btnMenuBusiness.TabIndex = 3;
            this.btnMenuBusiness.Text = "  Kinh doanh";
            this.btnMenuBusiness.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuBusiness.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuBusiness.UseVisualStyleBackColor = false;
            this.btnMenuBusiness.Click += new System.EventHandler(this.btnMenuBusiness_Click);
            // 
            // pnlSubMenuManagement
            // 
            this.pnlSubMenuManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(106)))));
            this.pnlSubMenuManagement.Controls.Add(this.btnAccount);
            this.pnlSubMenuManagement.Controls.Add(this.btnCustomer);
            this.pnlSubMenuManagement.Controls.Add(this.btnBook);
            this.pnlSubMenuManagement.Controls.Add(this.btnCategory);
            this.pnlSubMenuManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuManagement.Location = new System.Drawing.Point(0, 153);
            this.pnlSubMenuManagement.Name = "pnlSubMenuManagement";
            this.pnlSubMenuManagement.Size = new System.Drawing.Size(243, 207);
            this.pnlSubMenuManagement.TabIndex = 2;
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(180)))));
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(0, 150);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Padding = new System.Windows.Forms.Padding(63, 0, 0, 0);
            this.btnAccount.Size = new System.Drawing.Size(243, 50);
            this.btnAccount.TabIndex = 6;
            this.btnAccount.Text = "Tài khoản";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(180)))));
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(0, 100);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(63, 0, 0, 0);
            this.btnCustomer.Size = new System.Drawing.Size(243, 50);
            this.btnCustomer.TabIndex = 5;
            this.btnCustomer.Text = "Khách hàng";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(180)))));
            this.btnBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.Color.White;
            this.btnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBook.Location = new System.Drawing.Point(0, 50);
            this.btnBook.Name = "btnBook";
            this.btnBook.Padding = new System.Windows.Forms.Padding(63, 0, 0, 0);
            this.btnBook.Size = new System.Drawing.Size(243, 50);
            this.btnBook.TabIndex = 1;
            this.btnBook.Text = "Sách";
            this.btnBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(180)))));
            this.btnCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(0, 0);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Padding = new System.Windows.Forms.Padding(63, 0, 0, 0);
            this.btnCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCategory.Size = new System.Drawing.Size(243, 50);
            this.btnCategory.TabIndex = 0;
            this.btnCategory.Text = "Thể loại";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnMenuManagement
            // 
            this.btnMenuManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(106)))));
            this.btnMenuManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuManagement.FlatAppearance.BorderSize = 0;
            this.btnMenuManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuManagement.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuManagement.ForeColor = System.Drawing.Color.White;
            this.btnMenuManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuManagement.Image")));
            this.btnMenuManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuManagement.Location = new System.Drawing.Point(0, 93);
            this.btnMenuManagement.Name = "btnMenuManagement";
            this.btnMenuManagement.Padding = new System.Windows.Forms.Padding(20, 0, 25, 0);
            this.btnMenuManagement.Size = new System.Drawing.Size(243, 60);
            this.btnMenuManagement.TabIndex = 1;
            this.btnMenuManagement.Text = "  Quản lý";
            this.btnMenuManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuManagement.UseVisualStyleBackColor = false;
            this.btnMenuManagement.Click += new System.EventHandler(this.btnMenuManagement_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(180)))));
            this.pnlLogo.Controls.Add(this.lblLogoName);
            this.pnlLogo.Controls.Add(this.picLogo);
            this.pnlLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(243, 93);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblLogoName
            // 
            this.lblLogoName.AutoSize = true;
            this.lblLogoName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoName.ForeColor = System.Drawing.Color.White;
            this.lblLogoName.Location = new System.Drawing.Point(61, 61);
            this.lblLogoName.Name = "lblLogoName";
            this.lblLogoName.Size = new System.Drawing.Size(138, 25);
            this.lblLogoName.TabIndex = 3;
            this.lblLogoName.Text = "SE Book Store";
            // 
            // picLogo
            // 
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(97, 7);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(60, 58);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.Firebrick;
            this.pnlTopBar.Controls.Add(this.lblPermission);
            this.pnlTopBar.Controls.Add(this.label3);
            this.pnlTopBar.Controls.Add(this.lblDisplayName);
            this.pnlTopBar.Controls.Add(this.label);
            this.pnlTopBar.Controls.Add(this.lblCurrentTime);
            this.pnlTopBar.Controls.Add(this.btnMinimize);
            this.pnlTopBar.Controls.Add(this.btnMaximize);
            this.pnlTopBar.Controls.Add(this.btnExit);
            this.pnlTopBar.Controls.Add(this.lblSubMenuName);
            this.pnlTopBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(260, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(959, 93);
            this.pnlTopBar.TabIndex = 1;
            this.pnlTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseDown);
            // 
            // lblPermission
            // 
            this.lblPermission.AutoSize = true;
            this.lblPermission.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermission.ForeColor = System.Drawing.Color.White;
            this.lblPermission.Location = new System.Drawing.Point(105, 45);
            this.lblPermission.Name = "lblPermission";
            this.lblPermission.Size = new System.Drawing.Size(126, 25);
            this.lblPermission.TabIndex = 9;
            this.lblPermission.Text = "Chủ nhà sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Chức vụ:";
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayName.ForeColor = System.Drawing.Color.White;
            this.lblDisplayName.Location = new System.Drawing.Point(105, 19);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(66, 25);
            this.lblDisplayName.TabIndex = 7;
            this.lblDisplayName.Text = "admin";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(21, 19);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(91, 25);
            this.label.TabIndex = 6;
            this.label.Text = "Xin chào:";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.ForeColor = System.Drawing.Color.White;
            this.lblCurrentTime.Location = new System.Drawing.Point(837, 49);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(88, 25);
            this.lblCurrentTime.TabIndex = 5;
            this.lblCurrentTime.Text = "00:00:00";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(881, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(27, 23);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Text = "___";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(908, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(27, 23);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(932, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSubMenuName
            // 
            this.lblSubMenuName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubMenuName.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubMenuName.ForeColor = System.Drawing.Color.White;
            this.lblSubMenuName.Location = new System.Drawing.Point(390, 25);
            this.lblSubMenuName.Name = "lblSubMenuName";
            this.lblSubMenuName.Size = new System.Drawing.Size(242, 40);
            this.lblSubMenuName.TabIndex = 2;
            this.lblSubMenuName.Text = "TỔNG QUAN";
            this.lblSubMenuName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlChildForm.Location = new System.Drawing.Point(260, 93);
            this.pnlChildForm.MinimumSize = new System.Drawing.Size(959, 692);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(959, 692);
            this.pnlChildForm.TabIndex = 2;
            // 
            // tmrCurrentTime
            // 
            this.tmrCurrentTime.Enabled = true;
            this.tmrCurrentTime.Interval = 1000;
            this.tmrCurrentTime.Tick += new System.EventHandler(this.tmrCurrentTime_Tick);
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Enabled = true;
            this.tmrRefresh.Interval = 5000;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1219, 785);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlSlideMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1235, 824);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Nhà sách";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlSlideMenu.ResumeLayout(false);
            this.pnlSubMenuSetting.ResumeLayout(false);
            this.pnlSubMenuReport.ResumeLayout(false);
            this.pnlSubMenuBusiness.ResumeLayout(false);
            this.pnlSubMenuManagement.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSlideMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlSubMenuManagement;
        private System.Windows.Forms.Button btnMenuManagement;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Panel pnlSubMenuSetting;
        private System.Windows.Forms.Button btnRequirement;
        private System.Windows.Forms.Button btnMenuSetting;
        private System.Windows.Forms.Panel pnlSubMenuReport;
        private System.Windows.Forms.Button btnDebt;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnMenuReport;
        private System.Windows.Forms.Panel pnlSubMenuBusiness;
        private System.Windows.Forms.Button btnCashReceipt;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnBookReceipt;
        private System.Windows.Forms.Button btnMenuBusiness;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblSubMenuName;
        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblLogoName;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Timer tmrCurrentTime;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblPermission;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer tmrRefresh;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnCustomer;
    }
}