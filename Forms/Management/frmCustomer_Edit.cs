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
    public partial class frmCustomer_Edit : Form
    {
        private string errMsg = "";

        private DTO.Customer updatedCus;

        public frmCustomer_Edit(int id)
        {
            InitializeComponent();

            updatedCus = BUS.Customer.Instance.Customers.First(cus => cus.Id == id);

            ResetErrorMessage();
        }

        private void ResetErrorMessage()
        {
            this.lblCustomerNameError.Text = "";
            this.lblAddressError.Text = "";
            this.lblPhoneError.Text = "";
            this.lblEmailError.Text = "";

            this.txtCustomerCode.Text = updatedCus.Id.ToString();
            this.txtCustomerName.Text = updatedCus.Name;
            this.txtAddress.Text = updatedCus.Address;
            this.txtPhone.Text = updatedCus.PhoneNumber;
            this.txtEmail.Text = updatedCus.Email;
            this.nudDebtAmount.Value = updatedCus.Debt;

            this.errCustomer_Edit.Clear();
            GC.Collect();
        }

        private void CancelValidatedEvent(Control control, Label error, CancelEventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
            e.Cancel = true;
            errCustomer_Edit.SetError(control, errMsg);
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
            this.errCustomer_Edit.SetError(txtCustomerName, "");
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
            this.errCustomer_Edit.SetError(txtAddress, "");
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
            this.errCustomer_Edit.SetError(txtPhone, "");
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
            this.errCustomer_Edit.SetError(txtEmail, "");
            this.lblEmailError.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();

            GC.Collect();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

            if (BUS.Customer.Instance.Customers.
                    FirstOrDefault(cus => cus.PhoneNumber == txtPhone.Text.Trim()) != null
                && updatedCus.PhoneNumber != txtPhone.Text.Trim())
            {
                MessageBox.Show("SĐT này đã tồn tại");
                return;
            }

            if (BUS.Customer.Instance.Customers.
                    FirstOrDefault(cus => cus.Email == txtEmail.Text.Trim()) != null
                && updatedCus.Email != txtEmail.Text.Trim())
            {
                MessageBox.Show("Email này đã tồn tại");
                return;
            }

            if (BUS.Customer.Instance.UpdateCustomer(new DTO.Customer(updatedCus.Id, txtCustomerName.Text.Trim(),
                    txtAddress.Text.Trim(), txtPhone.Text.Trim(), txtEmail.Text.Trim(), updatedCus.Debt)))
            {
                MessageBox.Show("Sửa khách hàng thành công!");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Sửa khách hàng thất bại!");
            }
        }
    }
}
