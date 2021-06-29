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
    public partial class frmBook_EditTitleBook : Form
    {
        private string errMsg = "";

        private DTO.Title updatedTitle;

        public frmBook_EditTitleBook(int titleId)
        {
            InitializeComponent();

            updatedTitle = BUS.Title.Instance.Titles.First(title => title.Id == titleId);

            ResetErrorMessage();
        }

        private void frmBook_EditTitleBook_Load(object sender, EventArgs e)
        {
            cboCategory.ValueMember = "Id";
            cboCategory.DisplayMember = "Name";
            cboCategory.DataSource = BUS.Category.Instance.Categories;
        }

        private void ResetErrorMessage()
        {
            this.lblTitleBookNameError.Text = "";

            this.txtTitlteBookCode.Text = updatedTitle.Id.ToString();
            this.txtTitleBookName.Text = updatedTitle.Name;
            this.cboCategory.Text = BUS.Category.Instance.Categories.First(cate 
                                                 => cate.Id == updatedTitle.CategoryId).Name;

            this.errBook_EditTitleBook.Clear();
            GC.Collect();
        }
        private void CancelValidatedEvent(Control control, Label error, CancelEventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
            e.Cancel = true;
            errBook_EditTitleBook.SetError(control, errMsg);
            error.Text = errMsg;
        }

        private void txtTitleBookName_Validating(object sender, CancelEventArgs e)
        {
            if (txtTitleBookName.Text == "")
            {
                errMsg = "Hãy điền tên đầu sách";
                CancelValidatedEvent(txtTitleBookName, lblTitleBookNameError, e);
                return;
            }
            if (!ValidateInput.ValidOnlyLetterAndNumber(txtTitleBookName.Text, out errMsg))
            {
                CancelValidatedEvent(txtTitleBookName, lblTitleBookNameError, e);
            }
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

            int categoryId = BUS.Category.Instance.Categories.
                    First(cate => cate.Name == cboCategory.Text.Trim()).Id;

            if (BUS.Title.Instance.Titles.FirstOrDefault(title => 
                        (title.Name == txtTitleBookName.Text.Trim() && title.CategoryId == categoryId)) != null
                && (txtTitleBookName.Text.Trim() != updatedTitle.Name || categoryId != updatedTitle.CategoryId))
            {
                MessageBox.Show("Đầu sách này đã tồn tại");
                return;
            }

            if (BUS.Title.Instance.UpdateTitle(
                    new DTO.Title(updatedTitle.Id, txtTitleBookName.Text.Trim(), categoryId)))
            {
                MessageBox.Show("Sửa đầu sách thành công!");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Sửa đầu sách thất bại!");
            }
        }
    }
}
