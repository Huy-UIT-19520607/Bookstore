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
    public partial class frmCategory_Edit : Form
    {
        private string errMsg = "";

        private DTO.Category updatedCate;

        public frmCategory_Edit(int id)
        {
            InitializeComponent();

            updatedCate = BUS.Category.Instance.Categories.First(cate => cate.Id == id);

            ResetErrorMessage();
        }

        private void ResetErrorMessage()
        {
            this.lblCategoryNameError.Text = "";

            txtCategoryCode.Text = updatedCate.Id.ToString();
            this.txtCategoryName.Text = updatedCate.Name;

            this.errCategory_Edit.Clear();
            GC.Collect();
        }
        private void CancelValidatedEvent(Control control, Label error, CancelEventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
            e.Cancel = true;
            errCategory_Edit.SetError(control, errMsg);
            error.Text = errMsg;
        }

        private void txtCategoryName_Validating(object sender, CancelEventArgs e)
        {
            if (txtCategoryName.Text == "")
            {
                errMsg = "Hãy điền tên thể loại";
                CancelValidatedEvent(txtCategoryName, lblCategoryNameError, e);
                return;
            }
            if (!ValidateInput.ValidOnlyLetter(txtCategoryName.Text, out errMsg))
            {
                CancelValidatedEvent(txtCategoryName, lblCategoryNameError, e);
            }
        }

        private void txtCategoryName_Validated(object sender, EventArgs e)
        {
            this.errCategory_Edit.SetError(txtCategoryName, "");
            this.lblCategoryNameError.Text = "";
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

            if (BUS.Category.Instance.Categories.
                    FirstOrDefault(cate => cate.Name == txtCategoryName.Text.Trim()) != null 
                && txtCategoryName.Text.Trim() != updatedCate.Name)
            {
                MessageBox.Show("Thể loại này đã tồn tại");
                return;
            }

            if (BUS.Category.Instance.UpdateCategory(updatedCate.Id, txtCategoryName.Text.Trim()))
            {
                MessageBox.Show("Sửa thể loại thành công!");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Sửa thể loại thất bại!");
            }
        }
    }
}
