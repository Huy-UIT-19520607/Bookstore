using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Forms.Management
{
    public partial class frmAccount_Add : Form
    {
        private string errMsg = "";

        public frmAccount_Add()
        {
            InitializeComponent();

            ResetErrorMessage();
        }

        private void ResetErrorMessage()
        {
            this.lblUsernameError.Text = "";
            this.lblDisplayNameError.Text = "";
            this.lblPasswordError.Text = "";
            this.lblConfirmPasswordError.Text = "";

            this.txtUsername.Text = "";
            this.txtDisplayName.Text = "";
            this.txtPassword.Text = "";
            this.txtConfirmPassword.Text = "";

            this.errAccount_Add.Clear();
            GC.Collect();
        }

        private void CancelValidatedEvent(Control control, Label error, CancelEventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
            e.Cancel = true;
            errAccount_Add.SetError(control, errMsg);
            error.Text = errMsg;
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (txtUsername.Text == "")
            {
                errMsg = "Hãy điền tên đăng nhập";
                CancelValidatedEvent(txtUsername, lblUsernameError, e);
                return;
            }
            if (!ValidateInput.ValidNoneSpecialChar(txtUsername.Text, out errMsg))
            {
                CancelValidatedEvent(txtUsername, lblUsernameError, e);
            }
        }

        private void txtUsername_Validated(object sender, EventArgs e)
        {
            this.errAccount_Add.SetError(txtUsername, "");
            this.lblUsernameError.Text = "";
        }

        private void txtDisplayName_Validating(object sender, CancelEventArgs e)
        {
            if (txtDisplayName.Text == "")
            {
                errMsg = "Hãy điền tên hiển thị";
                CancelValidatedEvent(txtDisplayName, lblDisplayNameError, e);
                return;
            }
            if (!ValidateInput.ValidOnlyLetter(txtDisplayName.Text, out errMsg))
            {
                CancelValidatedEvent(txtDisplayName, lblDisplayNameError, e);
            }
        }

        private void txtDisplayName_Validated(object sender, EventArgs e)
        {
            this.errAccount_Add.SetError(txtDisplayName, "");
            this.lblDisplayNameError.Text = "";
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text == "")
            {
                errMsg = "Hãy điền mật khẩu";
                CancelValidatedEvent(txtPassword, lblPasswordError, e);
                return;
            }
            if (!ValidateInput.ValidNoneSpecialChar(txtPassword.Text, out errMsg))
            {
                CancelValidatedEvent(txtPassword, lblPasswordError, e);
            }
        }

        private void txtPassword_Validated(object sender, EventArgs e)
        {
            this.errAccount_Add.SetError(txtPassword, "");
            this.lblPasswordError.Text = "";
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text == "")
            {
                errMsg = "Hãy xác nhận mật khẩu";
                CancelValidatedEvent(txtConfirmPassword, lblConfirmPasswordError, e);
                return;
            }
            if (!ValidateInput.ValidNoneSpecialChar(txtConfirmPassword.Text, out errMsg))
            {
                CancelValidatedEvent(txtConfirmPassword, lblConfirmPasswordError, e);
                return;
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                errMsg = "Mật khẩu xác nhận không trùng khớp";
                CancelValidatedEvent(txtConfirmPassword, lblConfirmPasswordError, e);
            }
        }

        private void txtConfirmPassword_Validated(object sender, EventArgs e)
        {
            this.errAccount_Add.SetError(txtConfirmPassword, "");
            this.lblConfirmPasswordError.Text = "";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

            if (BUS.Account.Instance.Accounts.
                FirstOrDefault(account => account.Username.Equals(txtUsername.Text.Trim())) != null)
            {
                MessageBox.Show("Tài khoản này đã tồn tại");
                return;
            }

            if (BUS.Account.Instance.AddAccount(
                new DTO.Account(txtUsername.Text.Trim(), txtDisplayName.Text.Trim(), 
                                txtPassword.Text.Trim(), cboPermission.SelectedIndex)))
            {
                MessageBox.Show("Thêm tài khoản mới thành công");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thêm tài khoản mới thất bại");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();

            GC.Collect();
        }

        private void chkHideShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHideShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '●';
                txtConfirmPassword.PasswordChar = '●';
            }    
        }
    }
}
