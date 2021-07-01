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
    public partial class frmCategory_Add : Form
    {
        private string errMsg = "";
        public frmCategory_Add()
        {
            InitializeComponent();

            ResetErrorMessage();
        }
        private void ResetErrorMessage()
        {
            this.lblCategoryNameError.Text = "";

            this.txtNewCategory.Text = "";

            this.errCategory_Add.Clear();
            GC.Collect();
        }
        private void CancelValidatedEvent(Control control, Label error, CancelEventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
            e.Cancel = true;
            errCategory_Add.SetError(control, errMsg);
            error.Text = errMsg;
        }

        private void txtNewCategory_Validating(object sender, CancelEventArgs e)
        {
            if (txtNewCategory.Text == "")
            {
                errMsg = "Hãy điền tên thể loại";
                CancelValidatedEvent(txtNewCategory, lblCategoryNameError, e);
                return;
            }
            if (!ValidateInput.ValidOnlyLetter(txtNewCategory.Text, out errMsg))
            {
                CancelValidatedEvent(txtNewCategory, lblCategoryNameError, e);
            }
        }

        private void txtNewCategory_Validated(object sender, EventArgs e)
        {
            this.errCategory_Add.SetError(txtNewCategory, "");
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
                FirstOrDefault(cate => cate.Name == txtNewCategory.Text.Trim()) != null)
            {
                MessageBox.Show("Thể loại này đã tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (BUS.Category.Instance.AddCategory(txtNewCategory.Text.Trim()))
            {
                MessageBox.Show("Thêm thể loại mới thành công");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thêm thể loại mới thất bại");
            }
        }
    }
}
