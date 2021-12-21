
namespace BookStore.Forms
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.lblUsernameError = new System.Windows.Forms.Label();
            this.gunaTxtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaTxtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.errLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.gunaTxtNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pnlForgotPassword = new System.Windows.Forms.Panel();
            this.gunaTxtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaTxtUsernameFP = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblConfirmPasswordError = new System.Windows.Forms.Label();
            this.lblNewPasswordError = new System.Windows.Forms.Label();
            this.lblUsernameErrorFP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tmrForgotPassword = new System.Windows.Forms.Timer(this.components);
            this.tmrLogin = new System.Windows.Forms.Timer(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errLogin)).BeginInit();
            this.pnlForgotPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(38, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "QUẢN LÝ NHÀ SÁCH";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(33, 250);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(106, 46);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(161, 250);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 46);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(92, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Đăng nhập";
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.lblPasswordError);
            this.pnlLogin.Controls.Add(this.lblUsernameError);
            this.pnlLogin.Controls.Add(this.gunaTxtPassword);
            this.pnlLogin.Controls.Add(this.gunaTxtUsername);
            this.pnlLogin.Controls.Add(this.panel3);
            this.pnlLogin.Controls.Add(this.panel2);
            this.pnlLogin.Controls.Add(this.lblForgotPassword);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.btnExit);
            this.pnlLogin.Location = new System.Drawing.Point(11, 215);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(303, 306);
            this.pnlLogin.TabIndex = 15;
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.AutoSize = true;
            this.lblPasswordError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordError.Location = new System.Drawing.Point(36, 180);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(85, 15);
            this.lblPasswordError.TabIndex = 20;
            this.lblPasswordError.Text = "Password Error";
            // 
            // lblUsernameError
            // 
            this.lblUsernameError.AutoSize = true;
            this.lblUsernameError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameError.ForeColor = System.Drawing.Color.Red;
            this.lblUsernameError.Location = new System.Drawing.Point(36, 121);
            this.lblUsernameError.Name = "lblUsernameError";
            this.lblUsernameError.Size = new System.Drawing.Size(88, 15);
            this.lblUsernameError.TabIndex = 19;
            this.lblUsernameError.Text = "Username Error";
            // 
            // gunaTxtPassword
            // 
            this.gunaTxtPassword.BorderThickness = 0;
            this.gunaTxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTxtPassword.DefaultText = "";
            this.gunaTxtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gunaTxtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunaTxtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTxtPassword.DisabledState.Parent = this.gunaTxtPassword;
            this.gunaTxtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTxtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTxtPassword.FocusedState.Parent = this.gunaTxtPassword;
            this.gunaTxtPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gunaTxtPassword.ForeColor = System.Drawing.Color.Black;
            this.gunaTxtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTxtPassword.HoverState.Parent = this.gunaTxtPassword;
            this.gunaTxtPassword.Location = new System.Drawing.Point(33, 149);
            this.gunaTxtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gunaTxtPassword.Name = "gunaTxtPassword";
            this.gunaTxtPassword.PasswordChar = '\0';
            this.gunaTxtPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.gunaTxtPassword.PlaceholderText = "Mật khẩu";
            this.gunaTxtPassword.SelectedText = "";
            this.gunaTxtPassword.ShadowDecoration.Parent = this.gunaTxtPassword;
            this.gunaTxtPassword.Size = new System.Drawing.Size(234, 27);
            this.gunaTxtPassword.TabIndex = 1;
            this.gunaTxtPassword.UseSystemPasswordChar = true;
            this.gunaTxtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.gunaTxtPassword_Validating);
            this.gunaTxtPassword.Validated += new System.EventHandler(this.gunaTxtPassword_Validated);
            // 
            // gunaTxtUsername
            // 
            this.gunaTxtUsername.BorderThickness = 0;
            this.gunaTxtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTxtUsername.DefaultText = "";
            this.gunaTxtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gunaTxtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunaTxtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTxtUsername.DisabledState.Parent = this.gunaTxtUsername;
            this.gunaTxtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTxtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTxtUsername.FocusedState.Parent = this.gunaTxtUsername;
            this.gunaTxtUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gunaTxtUsername.ForeColor = System.Drawing.Color.Black;
            this.gunaTxtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTxtUsername.HoverState.Parent = this.gunaTxtUsername;
            this.gunaTxtUsername.Location = new System.Drawing.Point(33, 88);
            this.gunaTxtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gunaTxtUsername.Name = "gunaTxtUsername";
            this.gunaTxtUsername.PasswordChar = '\0';
            this.gunaTxtUsername.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.gunaTxtUsername.PlaceholderText = "Tên đăng nhập";
            this.gunaTxtUsername.SelectedText = "";
            this.gunaTxtUsername.ShadowDecoration.Parent = this.gunaTxtUsername;
            this.gunaTxtUsername.Size = new System.Drawing.Size(234, 29);
            this.gunaTxtUsername.TabIndex = 0;
            this.gunaTxtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.gunaTxtUsername_Validating);
            this.gunaTxtUsername.Validated += new System.EventHandler(this.gunaTxtUsername_Validated);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Location = new System.Drawing.Point(33, 177);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(234, 3);
            this.panel3.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Location = new System.Drawing.Point(33, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 3);
            this.panel2.TabIndex = 10;
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPassword.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblForgotPassword.Location = new System.Drawing.Point(96, 214);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(117, 21);
            this.lblForgotPassword.TabIndex = 2;
            this.lblForgotPassword.Text = "Quên mật khẩu";
            this.lblForgotPassword.Click += new System.EventHandler(this.lblForgotPassword_Click);
            // 
            // errLogin
            // 
            this.errLogin.BlinkRate = 0;
            this.errLogin.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errLogin.ContainerControl = this;
            // 
            // gunaTxtNewPassword
            // 
            this.gunaTxtNewPassword.BorderThickness = 0;
            this.gunaTxtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTxtNewPassword.DefaultText = "";
            this.gunaTxtNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gunaTxtNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunaTxtNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTxtNewPassword.DisabledState.Parent = this.gunaTxtNewPassword;
            this.gunaTxtNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTxtNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTxtNewPassword.FocusedState.Parent = this.gunaTxtNewPassword;
            this.gunaTxtNewPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gunaTxtNewPassword.ForeColor = System.Drawing.Color.Black;
            this.gunaTxtNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTxtNewPassword.HoverState.Parent = this.gunaTxtNewPassword;
            this.gunaTxtNewPassword.Location = new System.Drawing.Point(36, 134);
            this.gunaTxtNewPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gunaTxtNewPassword.Name = "gunaTxtNewPassword";
            this.gunaTxtNewPassword.PasswordChar = '\0';
            this.gunaTxtNewPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.gunaTxtNewPassword.PlaceholderText = "Mật khẩu mới";
            this.gunaTxtNewPassword.SelectedText = "";
            this.gunaTxtNewPassword.ShadowDecoration.Parent = this.gunaTxtNewPassword;
            this.gunaTxtNewPassword.Size = new System.Drawing.Size(234, 27);
            this.gunaTxtNewPassword.TabIndex = 5;
            this.gunaTxtNewPassword.UseSystemPasswordChar = true;
            this.gunaTxtNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.gunaTxtNewPassword_Validating);
            this.gunaTxtNewPassword.Validated += new System.EventHandler(this.gunaTxtNewPassword_Validated);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Navy;
            this.panel4.Location = new System.Drawing.Point(36, 162);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(234, 3);
            this.panel4.TabIndex = 20;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Navy;
            this.panel5.Location = new System.Drawing.Point(36, 103);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(234, 3);
            this.panel5.TabIndex = 19;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Navy;
            this.panel6.Location = new System.Drawing.Point(36, 221);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(234, 3);
            this.panel6.TabIndex = 23;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Navy;
            this.panel7.Location = new System.Drawing.Point(36, 162);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(234, 3);
            this.panel7.TabIndex = 20;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Navy;
            this.panel8.Location = new System.Drawing.Point(36, 103);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(234, 3);
            this.panel8.TabIndex = 19;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Navy;
            this.panel9.Location = new System.Drawing.Point(36, 221);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(234, 3);
            this.panel9.TabIndex = 23;
            // 
            // pnlForgotPassword
            // 
            this.pnlForgotPassword.Controls.Add(this.gunaTxtConfirmPassword);
            this.pnlForgotPassword.Controls.Add(this.gunaTxtUsernameFP);
            this.pnlForgotPassword.Controls.Add(this.lblConfirmPasswordError);
            this.pnlForgotPassword.Controls.Add(this.lblNewPasswordError);
            this.pnlForgotPassword.Controls.Add(this.lblUsernameErrorFP);
            this.pnlForgotPassword.Controls.Add(this.label3);
            this.pnlForgotPassword.Controls.Add(this.btnOk);
            this.pnlForgotPassword.Controls.Add(this.btnCancel);
            this.pnlForgotPassword.Controls.Add(this.panel9);
            this.pnlForgotPassword.Controls.Add(this.panel4);
            this.pnlForgotPassword.Controls.Add(this.panel6);
            this.pnlForgotPassword.Controls.Add(this.panel5);
            this.pnlForgotPassword.Controls.Add(this.panel7);
            this.pnlForgotPassword.Controls.Add(this.gunaTxtNewPassword);
            this.pnlForgotPassword.Controls.Add(this.panel8);
            this.pnlForgotPassword.Location = new System.Drawing.Point(343, 215);
            this.pnlForgotPassword.Name = "pnlForgotPassword";
            this.pnlForgotPassword.Size = new System.Drawing.Size(303, 306);
            this.pnlForgotPassword.TabIndex = 16;
            // 
            // gunaTxtConfirmPassword
            // 
            this.gunaTxtConfirmPassword.BorderThickness = 0;
            this.gunaTxtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTxtConfirmPassword.DefaultText = "";
            this.gunaTxtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gunaTxtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunaTxtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTxtConfirmPassword.DisabledState.Parent = this.gunaTxtConfirmPassword;
            this.gunaTxtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTxtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTxtConfirmPassword.FocusedState.Parent = this.gunaTxtConfirmPassword;
            this.gunaTxtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gunaTxtConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.gunaTxtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTxtConfirmPassword.HoverState.Parent = this.gunaTxtConfirmPassword;
            this.gunaTxtConfirmPassword.Location = new System.Drawing.Point(36, 193);
            this.gunaTxtConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gunaTxtConfirmPassword.Name = "gunaTxtConfirmPassword";
            this.gunaTxtConfirmPassword.PasswordChar = '\0';
            this.gunaTxtConfirmPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.gunaTxtConfirmPassword.PlaceholderText = "Xác nhận Mật khẩu";
            this.gunaTxtConfirmPassword.SelectedText = "";
            this.gunaTxtConfirmPassword.ShadowDecoration.Parent = this.gunaTxtConfirmPassword;
            this.gunaTxtConfirmPassword.Size = new System.Drawing.Size(234, 27);
            this.gunaTxtConfirmPassword.TabIndex = 6;
            this.gunaTxtConfirmPassword.UseSystemPasswordChar = true;
            this.gunaTxtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.gunaTxtConfirmPassword_Validating);
            this.gunaTxtConfirmPassword.Validated += new System.EventHandler(this.gunaTxtConfirmPassword_Validated);
            // 
            // gunaTxtUsernameFP
            // 
            this.gunaTxtUsernameFP.BorderThickness = 0;
            this.gunaTxtUsernameFP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTxtUsernameFP.DefaultText = "";
            this.gunaTxtUsernameFP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gunaTxtUsernameFP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunaTxtUsernameFP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTxtUsernameFP.DisabledState.Parent = this.gunaTxtUsernameFP;
            this.gunaTxtUsernameFP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTxtUsernameFP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTxtUsernameFP.FocusedState.Parent = this.gunaTxtUsernameFP;
            this.gunaTxtUsernameFP.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gunaTxtUsernameFP.ForeColor = System.Drawing.Color.Black;
            this.gunaTxtUsernameFP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTxtUsernameFP.HoverState.Parent = this.gunaTxtUsernameFP;
            this.gunaTxtUsernameFP.Location = new System.Drawing.Point(36, 75);
            this.gunaTxtUsernameFP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gunaTxtUsernameFP.Name = "gunaTxtUsernameFP";
            this.gunaTxtUsernameFP.PasswordChar = '\0';
            this.gunaTxtUsernameFP.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.gunaTxtUsernameFP.PlaceholderText = "Tên đăng nhập";
            this.gunaTxtUsernameFP.SelectedText = "";
            this.gunaTxtUsernameFP.ShadowDecoration.Parent = this.gunaTxtUsernameFP;
            this.gunaTxtUsernameFP.Size = new System.Drawing.Size(234, 27);
            this.gunaTxtUsernameFP.TabIndex = 4;
            this.gunaTxtUsernameFP.Validating += new System.ComponentModel.CancelEventHandler(this.gunaTxtUsernameFP_Validating);
            this.gunaTxtUsernameFP.Validated += new System.EventHandler(this.gunaTxtUsernameFP_Validated);
            // 
            // lblConfirmPasswordError
            // 
            this.lblConfirmPasswordError.AutoSize = true;
            this.lblConfirmPasswordError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblConfirmPasswordError.Location = new System.Drawing.Point(39, 224);
            this.lblConfirmPasswordError.Name = "lblConfirmPasswordError";
            this.lblConfirmPasswordError.Size = new System.Drawing.Size(132, 15);
            this.lblConfirmPasswordError.TabIndex = 25;
            this.lblConfirmPasswordError.Text = "Confirm Password Error";
            // 
            // lblNewPasswordError
            // 
            this.lblNewPasswordError.AutoSize = true;
            this.lblNewPasswordError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblNewPasswordError.Location = new System.Drawing.Point(39, 165);
            this.lblNewPasswordError.Name = "lblNewPasswordError";
            this.lblNewPasswordError.Size = new System.Drawing.Size(85, 15);
            this.lblNewPasswordError.TabIndex = 21;
            this.lblNewPasswordError.Text = "Password Error";
            // 
            // lblUsernameErrorFP
            // 
            this.lblUsernameErrorFP.AutoSize = true;
            this.lblUsernameErrorFP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameErrorFP.ForeColor = System.Drawing.Color.Red;
            this.lblUsernameErrorFP.Location = new System.Drawing.Point(39, 106);
            this.lblUsernameErrorFP.Name = "lblUsernameErrorFP";
            this.lblUsernameErrorFP.Size = new System.Drawing.Size(88, 15);
            this.lblUsernameErrorFP.TabIndex = 21;
            this.lblUsernameErrorFP.Text = "Username Error";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(86, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Đổi mật khẩu";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(36, 250);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(105, 46);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Chấp nhận";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(165, 250);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 46);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tmrForgotPassword
            // 
            this.tmrForgotPassword.Interval = 1;
            this.tmrForgotPassword.Tick += new System.EventHandler(this.tmrForgotPassword_Tick);
            // 
            // tmrLogin
            // 
            this.tmrLogin.Interval = 1;
            this.tmrLogin.Tick += new System.EventHandler(this.tmrLogin_Tick);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.CustomIconSize = 15F;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(301, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(25, 25);
            this.guna2ControlBox1.TabIndex = 17;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(326, 527);
            this.ControlBox = false;
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.pnlForgotPassword);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errLogin)).EndInit();
            this.pnlForgotPassword.ResumeLayout(false);
            this.pnlForgotPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.ErrorProvider errLogin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox gunaTxtUsername;
        private Guna.UI2.WinForms.Guna2TextBox gunaTxtPassword;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2TextBox gunaTxtNewPassword;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlForgotPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Timer tmrForgotPassword;
        private System.Windows.Forms.Label lblUsernameError;
        private System.Windows.Forms.Timer tmrLogin;
        private System.Windows.Forms.Label lblPasswordError;
        private System.Windows.Forms.Label lblConfirmPasswordError;
        private System.Windows.Forms.Label lblNewPasswordError;
        private System.Windows.Forms.Label lblUsernameErrorFP;
        private Guna.UI2.WinForms.Guna2TextBox gunaTxtConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox gunaTxtUsernameFP;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}