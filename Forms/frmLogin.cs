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
        private string password;
        private int role;
        private string errMsg = "";

        public frmLogin()
        {
            InitializeComponent();

            this.Text = "";
            this.ControlBox = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.AcceptButton = this.btnLogin;

            this.gunaTxtConfirmPassword.Enabled = false;
            this.gunaTxtNewPassword.Enabled = false;
            this.gunaTxtUsernameFP.Enabled = false;

            ResetErrorMessage();
        }

        private void ResetErrorMessage()
        {
            lblUsernameError.Text = "";
            lblPasswordError.Text = "";
            lblUsernameErrorFP.Text = "";
            lblNewPasswordError.Text = "";
            lblConfirmPasswordError.Text = "";

            this.errLogin.Clear();
            GC.Collect();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CancelValidatedEvent(Control control, Label error, CancelEventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
            e.Cancel = true;
            errLogin.SetError(control, errMsg);
            error.Text = errMsg;
        }

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

        private void ResetLogin()
        {
            this.AcceptButton = this.btnLogin;

            gunaTxtUsername.Focus();

            this.gunaTxtConfirmPassword.Enabled = false;
            this.gunaTxtNewPassword.Enabled = false;
            this.gunaTxtUsernameFP.Enabled = false;

            this.gunaTxtUsername.Enabled = true;
            this.gunaTxtPassword.Enabled = true;

            ResetErrorMessage();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

            //frmMain frmMain = new frmMain(username, password, role);

            if (DAO.Account.Instance.Login(gunaTxtUsername.Text, gunaTxtPassword.Text))
            {
                frmMain frmMain = new frmMain(username, password, role);
                frmMain.Owner = this;
                frmMain.Show();
                this.Hide();
            }

            ResetLogin();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            tmrForgotPassword.Start();
            this.AcceptButton = this.btnOk;

            this.gunaTxtConfirmPassword.Enabled = true;
            this.gunaTxtNewPassword.Enabled = true;
            this.gunaTxtUsernameFP.Enabled = true;

            this.gunaTxtUsername.Enabled = false;
            this.gunaTxtPassword.Enabled = false;

            this.gunaTxtUsernameFP.Focus();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tmrLogin.Start();
            //this.AcceptButton = this.btnLogin;

            //this.gunaTxtConfirmPassword.Enabled = false;
            //this.gunaTxtNewPassword.Enabled = false;
            //this.gunaTxtUsernameFP.Enabled = false;

            //this.gunaTxtUsername.Enabled = true;
            //this.gunaTxtPassword.Enabled = true;

            //this.gunaTxtUsername.Focus();

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

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
