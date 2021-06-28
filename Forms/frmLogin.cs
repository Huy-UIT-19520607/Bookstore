using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Forms
{
    public partial class frmLogin : Form
    {
        private string username;
        private int role;
        private string errMsg = "";

        public frmLogin()
        {
            InitializeComponent();

            ResetLogin();
        }

        #region Reset
        private void ResetErrorMessage()
        {
            this.lblUsernameError.Text = "";
            this.lblPasswordError.Text = "";
            this.lblUsernameErrorFP.Text = "";
            this.lblNewPasswordError.Text = "";
            this.lblConfirmPasswordError.Text = "";

            this.gunaTxtConfirmPassword.Text = "";
            this.gunaTxtNewPassword.Text = "";
            this.gunaTxtUsernameFP.Text = "";

            this.gunaTxtUsername.Text = "";
            this.gunaTxtPassword.Text = "";

            this.errLogin.Clear();
            GC.Collect();
        }

        private void ResetLogin()
        {
            this.AcceptButton = this.btnLogin;

            this.gunaTxtConfirmPassword.Enabled = false;
            this.gunaTxtNewPassword.Enabled = false;
            this.gunaTxtUsernameFP.Enabled = false;
            
            this.gunaTxtUsername.Enabled = true;
            this.gunaTxtPassword.Enabled = true;
            
            ResetErrorMessage();

            this.gunaTxtUsername.Focus();
        }

        private void ResetForgotPassword()
        {
            this.AcceptButton = this.btnOk;

            this.gunaTxtConfirmPassword.Enabled = true;
            this.gunaTxtNewPassword.Enabled = true;
            this.gunaTxtUsernameFP.Enabled = true;

            this.gunaTxtUsername.Enabled = false;
            this.gunaTxtPassword.Enabled = false;

            ResetErrorMessage();

            this.gunaTxtUsernameFP.Focus();
        }
        #endregion

        #region Handle Login Area
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

            string username = gunaTxtUsername.Text;
            string password = gunaTxtPassword.Text;

            if (Login(username, password))
            {
                frmMain frmMain = new frmMain(username, role);
                frmMain.Owner = this;
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ResetLogin();

        }

        bool Login(string username, string password)
        {
            return BUS.Account.Instance.Login(username, password);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            tmrForgotPassword.Start();

            ResetForgotPassword();
        }

        private void tmrForgotPassword_Tick(object sender, EventArgs e)
        {
            this.pnlLogin.Left -= 10;
            this.pnlForgotPassword.Left -= 10;
            if (this.pnlForgotPassword.Left <= 20)
            {
                tmrForgotPassword.Stop();
            }
        }
        #endregion

        #region Handle ForgotPassword Area
        private void btnCancel_Click(object sender, EventArgs e)
        {
            tmrLogin.Start();

            ResetLogin();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

            tmrLogin.Start();

            ResetLogin();
        }

        private void tmrLogin_Tick(object sender, EventArgs e)
        {
            this.pnlLogin.Left += 10;
            this.pnlForgotPassword.Left += 10;
            if (this.pnlLogin.Left >= 10)
            {
                tmrLogin.Stop();
            }
        }
        #endregion

        private void CancelValidatedEvent(Control control, Label error, CancelEventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
            e.Cancel = true;
            errLogin.SetError(control, errMsg);
            error.Text = errMsg;
        }

        #region Validate Login
        private void gunaTxtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (gunaTxtUsername.Text == "")
            {
                errMsg = "Hãy điền tên đăng nhập";
                CancelValidatedEvent(gunaTxtUsername, lblUsernameError, e);
                return;
            }
            if (!ValidateInput.ValidNoneSpecialChar(gunaTxtUsername.Text, out errMsg))
            {
                CancelValidatedEvent(gunaTxtUsername, lblUsernameError, e);
            }
        }

        private void gunaTxtUsername_Validated(object sender, EventArgs e)
        {
            this.errLogin.SetError(gunaTxtUsername, "");
            this.lblUsernameError.Text = "";
        }

        private void gunaTxtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (gunaTxtPassword.Text == "")
            {
                errMsg = "Hãy điền mật khẩu";
                CancelValidatedEvent(gunaTxtPassword, lblPasswordError, e);
                return;
            }
            if (!ValidateInput.ValidNoneSpecialChar(gunaTxtPassword.Text, out errMsg))
            {
                CancelValidatedEvent(gunaTxtPassword, lblPasswordError, e);
            }
        }

        private void gunaTxtPassword_Validated(object sender, EventArgs e)
        {
            this.errLogin.SetError(gunaTxtPassword, "");
            this.lblPasswordError.Text = "";
        }
        #endregion

        #region Validate Forgot Password
        private void gunaTxtUsernameFP_Validating(object sender, CancelEventArgs e)
        {
            if (gunaTxtUsernameFP.Text == "")
            {
                errMsg = "Hãy điền tên đăng nhập";
                CancelValidatedEvent(gunaTxtUsernameFP, lblUsernameErrorFP, e);
            }
            if (!ValidateInput.ValidNoneSpecialChar(gunaTxtUsernameFP.Text, out errMsg))
            {
                CancelValidatedEvent(gunaTxtUsernameFP, lblUsernameErrorFP, e);
            }
        }

        private void gunaTxtUsernameFP_Validated(object sender, EventArgs e)
        {
            this.errLogin.SetError(gunaTxtUsernameFP, "");
            this.lblUsernameErrorFP.Text = "";
        }

        private void gunaTxtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (gunaTxtNewPassword.Text == "")
            {
                errMsg = "Hãy điền mật khẩu mới";
                CancelValidatedEvent(gunaTxtNewPassword, lblNewPasswordError, e);
            }
            if (!ValidateInput.ValidNoneSpecialChar(gunaTxtNewPassword.Text, out errMsg))
            {
                CancelValidatedEvent(gunaTxtNewPassword, lblNewPasswordError, e);
            }
        }

        private void gunaTxtNewPassword_Validated(object sender, EventArgs e)
        {
            this.errLogin.SetError(gunaTxtNewPassword, "");
            this.lblNewPasswordError.Text = "";
        }

        private void gunaTxtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (gunaTxtConfirmPassword.Text == "")
            {
                errMsg = "Hãy xác nhận mật khẩu";
                CancelValidatedEvent(gunaTxtConfirmPassword, lblConfirmPasswordError, e);
            }
            if (!ValidateInput.ValidNoneSpecialChar(gunaTxtConfirmPassword.Text, out errMsg))
            {
                CancelValidatedEvent(gunaTxtConfirmPassword, lblConfirmPasswordError, e);
            }
            if (gunaTxtNewPassword.Text != gunaTxtConfirmPassword.Text)
            {
                errMsg = "Mật khẩu xác nhận không trùng khớp";
                CancelValidatedEvent(gunaTxtConfirmPassword, lblConfirmPasswordError, e);
            }
        }

        private void gunaTxtConfirmPassword_Validated(object sender, EventArgs e)
        {
            this.errLogin.SetError(gunaTxtConfirmPassword, "");
            this.lblConfirmPasswordError.Text = "";
        }
        #endregion

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
