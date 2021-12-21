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
    public partial class frmAccount_Edit : Form
    {
        private DTO.Account updatedAcc;

        private string errMsg = "";

        public frmAccount_Edit(string username)
        {
            InitializeComponent();

            updatedAcc = BUS.Account.Instance.Accounts.First(acc => acc.Username == username);

            this.Height = 305;

            ResetErrorMessage();
        }

        private void ResetErrorMessage()
        {
            pnlChangePassword.Visible = false;
            this.lblDisplayNameError.Text = "";
            this.lblOldPasswordError.Text = "";
            this.lblNewPasswordError.Text = "";
            this.lblConfirmPasswordError.Text = "";

            this.txtUsername.Text = updatedAcc.Username;
            this.txtDisplayName.Text = updatedAcc.DisplayName;
            cboPermission.Text = cboPermission.Items[updatedAcc.Permission].ToString();
            this.txtOldPassword.Text = "";
            this.txtNewPassword.Text = "";
            this.txtConfirmPassword.Text = "";

            this.errAccount_Edit.Clear();
            GC.Collect();
        }

        private void chkChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChangePassword.Checked)
            {
                this.Height = 510;

                pnlChangePassword.Visible = true;
                txtOldPassword.Enabled = true;
                txtNewPassword.Enabled = true;
                txtConfirmPassword.Enabled = true;
                chkHideShowPassword.Enabled = true;
            }
            else
            {
                this.Height = 305;

                pnlChangePassword.Visible = false;
                txtOldPassword.Enabled = false;
                txtNewPassword.Enabled = false;
                txtConfirmPassword.Enabled = false;
                chkHideShowPassword.Enabled = false;
            }
        }

        private void CancelValidatedEvent(Control control, Label error, CancelEventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
            e.Cancel = true;
            errAccount_Edit.SetError(control, errMsg);
            error.Text = errMsg;
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
            this.errAccount_Edit.SetError(txtDisplayName, "");
            this.lblDisplayNameError.Text = "";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

            if (!chkChangePassword.Checked)
            {
                //Ko thay đổi mật khẩu
                if (BUS.Account.Instance.UpdateAccount(
                    new DTO.Account(txtUsername.Text, txtDisplayName.Text.Trim(), 
                                    updatedAcc.Password, cboPermission.SelectedIndex)))
                {
                    MessageBox.Show("Sửa tài khoản thành công!");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Sửa tài khoản thất bại!");
                }
            }
            else
            {
                //Thay đổi mật khẩu
                if (BUS.Account.Instance.UpdateAccount(
                    new DTO.Account(txtUsername.Text, txtDisplayName.Text.Trim(), 
                                    txtNewPassword.Text, cboPermission.SelectedIndex)))
                {
                    MessageBox.Show("Sửa tài khoản thành công!");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Sửa tài khoản thất bại!");
                }
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
                txtOldPassword.PasswordChar = '\0';
                txtNewPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtOldPassword.PasswordChar = '●';
                txtNewPassword.PasswordChar = '●';
                txtConfirmPassword.PasswordChar = '●';
            }
        }

        private void txtOldPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtOldPassword.Text == "")
            {
                errMsg = "Hãy điền mật khẩu cũ";
                CancelValidatedEvent(txtOldPassword, lblOldPasswordError, e);
                return;
            }
            if (txtOldPassword.Text != updatedAcc.Password)
            {
                errMsg = "Mật khẩu cũ không đúng";
                CancelValidatedEvent(txtOldPassword, lblOldPasswordError, e);
                return;
            }
            if (!ValidateInput.ValidNoneSpecialChar(txtOldPassword.Text, out errMsg))
            {
                CancelValidatedEvent(txtOldPassword, lblOldPasswordError, e);
            }
        }

        private void txtOldPassword_Validated(object sender, EventArgs e)
        {
            this.errAccount_Edit.SetError(txtOldPassword, "");
            this.lblOldPasswordError.Text = "";
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtNewPassword.Text == "")
            {
                errMsg = "Hãy điền mật khẩu mới";
                CancelValidatedEvent(txtNewPassword, lblNewPasswordError, e);
                return;
            }
            if (!ValidateInput.ValidNoneSpecialChar(txtNewPassword.Text, out errMsg))
            {
                CancelValidatedEvent(txtNewPassword, lblNewPasswordError, e);
                return;
            }
            if (txtNewPassword.Text == txtOldPassword.Text)
            {
                errMsg = "Mật khẩu mới khác mật khẩu cũ";
                CancelValidatedEvent(txtNewPassword, lblNewPasswordError, e);
                return;
            }
        }

        private void txtNewPassword_Validated(object sender, EventArgs e)
        {
            this.errAccount_Edit.SetError(txtNewPassword, "");
            this.lblNewPasswordError.Text = "";
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
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                errMsg = "Mật khẩu xác nhận không trùng khớp";
                CancelValidatedEvent(txtConfirmPassword, lblConfirmPasswordError, e);
            }
        }

        private void txtConfirmPassword_Validated(object sender, EventArgs e)
        {
            this.errAccount_Edit.SetError(txtConfirmPassword, "");
            this.lblConfirmPasswordError.Text = "";
        }
    }
}
