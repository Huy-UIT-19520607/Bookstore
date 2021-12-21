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
    public partial class frmBook_EditAuthor : Form
    {
        private string errMsg = "";

        private DTO.Title title;

        private DTO.Author updatedAuthor;

        public frmBook_EditAuthor(int titleId, string authorName)
        {
            InitializeComponent();

            title = BUS.Title.Instance.Titles.First(tit => tit.Id == titleId);
            updatedAuthor = BUS.Author.Instance.Authors.First(author => 
                                    author.Name == authorName && author.TitleId == titleId);

            ResetErrorMessage();
        }

        private void ResetErrorMessage()
        {
            this.lblAuthorNameError.Text = "";

            this.txtTitlteBookCode.Text = title.Id.ToString();
            this.txtTitleBookName.Text = title.Name;
            this.txtCategory.Text = BUS.Category.Instance.Categories.First(cate => cate.Id == title.CategoryId).Name;
            this.txtAuthorName.Text = updatedAuthor.Name;

            this.errBook_EditAuthor.Clear();
            GC.Collect();
        }
        private void CancelValidatedEvent(Control control, Label error, CancelEventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
            e.Cancel = true;
            errBook_EditAuthor.SetError(control, errMsg);
            error.Text = errMsg;
        }

        private void txtAuthorName_Validating(object sender, CancelEventArgs e)
        {
            if (txtAuthorName.Text == "")
            {
                errMsg = "Hãy điền tên tác giả";
                CancelValidatedEvent(txtAuthorName, lblAuthorNameError, e);
                return;
            }
            if (!ValidateInput.ValidOnlyLetter(txtAuthorName.Text, out errMsg))
            {
                CancelValidatedEvent(txtAuthorName, lblAuthorNameError, e);
            }
        }

        private void txtAuthorName_Validated(object sender, EventArgs e)
        {
            this.errBook_EditAuthor.SetError(txtAuthorName, "");
            this.lblAuthorNameError.Text = "";
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

            if (BUS.Author.Instance.Authors.
                    FirstOrDefault(author => author.Name == txtAuthorName.Text.Trim()) != null
                && txtAuthorName.Text.Trim() != updatedAuthor.Name)
            {
                MessageBox.Show("Đầu sách đã có tác giả này");
                return;
            }

            if (BUS.Author.Instance.UpdateAuthor(
                new DTO.Author(updatedAuthor.TitleId, txtAuthorName.Text.Trim()), updatedAuthor.Name))
            {
                MessageBox.Show("Sửa tác giả thành công!");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Sửa tác giả thất bại!");
            }
        }
    }
}
