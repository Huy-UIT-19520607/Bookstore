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
    public partial class frmCustomer_Add : Form
    {
        private string errMsg = "";
        public frmCustomer_Add()
        {
            InitializeComponent();

            ResetErrorMessage();
        }

        private void ResetErrorMessage()
        {
            this.lblCustomerNameError.Text = "";
            this.lblAddressError.Text = "";
            this.lblPhoneError.Text = "";
            this.lblEmailError.Text = "";

            this.txtCustomerName.Text = "";
            this.txtAddress.Text = "";
            this.txtPhone.Text = "";
            this.txtEmail.Text = "";

            this.errCustomer_Add.Clear();
            GC.Collect();
        }
        private void CancelValidatedEvent(Control control, Label error, CancelEventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
            e.Cancel = true;
            errCustomer_Add.SetError(control, errMsg);
            error.Text = errMsg;
        }

        private void txtCustomerName_Validating(object sender, CancelEventArgs e)
        {
            if (txtCustomerName.Text == "")
            {
                errMsg = "Hãy điền tên khách hàng";
                CancelValidatedEvent(txtCustomerName, lblCustomerNameError, e);
                return;
            }
            if (!ValidateInput.ValidOnlyLetter(txtCustomerName.Text, out errMsg))
            {
                CancelValidatedEvent(txtCustomerName, lblCustomerNameError, e);
            }
        }

        private void txtCustomerName_Validated(object sender, EventArgs e)
        {
            this.errCustomer_Add.SetError(txtCustomerName, "");
            this.lblCustomerNameError.Text = "";
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (txtAddress.Text == "")
            {
                errMsg = "Hãy điền địa chỉ khách hàng";
                CancelValidatedEvent(txtAddress, lblAddressError, e);
                return;
            }
        }

        private void txtAddress_Validated(object sender, EventArgs e)
        {
            this.errCustomer_Add.SetError(txtAddress, "");
            this.lblAddressError.Text = "";
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (txtPhone.Text == "")
            {
                errMsg = "Hãy điền SĐT khách hàng";
                CancelValidatedEvent(txtPhone, lblPhoneError, e);
                return;
            }
            if (!ValidateInput.ValidVietnamesePhone(txtPhone.Text, out errMsg))
            {
                CancelValidatedEvent(txtPhone, lblPhoneError, e);
            }
        }

        private void txtPhone_Validated(object sender, EventArgs e)
        {
            this.errCustomer_Add.SetError(txtPhone, "");
            this.lblPhoneError.Text = "";
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text == "")
            {
                errMsg = "Hãy điền email khách hàng";
                CancelValidatedEvent(txtEmail, lblEmailError, e);
                return;
            }
            if (!ValidateInput.ValidEmail(txtEmail.Text, out errMsg))
            {
                CancelValidatedEvent(txtEmail, lblEmailError, e);
            }
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            this.errCustomer_Add.SetError(txtEmail, "");
            this.lblEmailError.Text = "";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

            if (BUS.Customer.Instance.Customers.
                FirstOrDefault(cus => cus.PhoneNumber == txtPhone.Text.Trim()) != null)
            {
                MessageBox.Show("SĐT này đã tồn tại");
                return;
            }

            if (BUS.Customer.Instance.Customers.
                FirstOrDefault(cus => cus.Email == txtEmail.Text.Trim()) != null)
            {
                MessageBox.Show("Email này đã tồn tại");
                return;
            }

            if (BUS.Customer.Instance.AddCustomer(
                txtCustomerName.Text.Trim(), txtAddress.Text.Trim(), txtPhone.Text.Trim(), txtEmail.Text.Trim(), 0))
            {
                MessageBox.Show("Thêm khách hàng mới thành công");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thêm khách hàng mới thất bại");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();

            GC.Collect();
        }

        
    }
}
