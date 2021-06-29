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
    public partial class frmBook_EditBook : Form
    {
        private string errMsg = "";

        private DTO.Title title;

        private DTO.Book updatedBook;

        public frmBook_EditBook(int bookId, int titleId)
        {
            InitializeComponent();

            title = BUS.Title.Instance.Titles.First(tit => tit.Id == titleId);
            updatedBook = BUS.Book.Instance.Books.First(book => book.Id == bookId);

            nudPublishingYear.Maximum = DateTime.Now.Year;

            ResetErrorMessage();
        }

        private void ResetErrorMessage()
        {
            this.lblPublisherError.Text = "";

            this.txtTitlteBookCode.Text = updatedBook.Id.ToString();
            this.txtTitleBookName.Text = title.Name;
            this.txtCategory.Text = BUS.Category.Instance.Categories.First(cate => cate.Id == title.CategoryId).Name;
            this.txtBookCode.Text = updatedBook.Id.ToString();
            this.txtPublisher.Text = updatedBook.Publisher;
            this.nudPublishingYear.Value = updatedBook.PublishYear;

            this.errBook_EditBook.Clear();
            GC.Collect();
        }
        private void CancelValidatedEvent(Control control, Label error, CancelEventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
            e.Cancel = true;
            errBook_EditBook.SetError(control, errMsg);
            error.Text = errMsg;
        }

        private void txtPublisher_Validating(object sender, CancelEventArgs e)
        {
            if (txtPublisher.Text == "")
            {
                errMsg = "Hãy điền tên nhà sản xuất";
                CancelValidatedEvent(txtPublisher, lblPublisherError, e);
                return;
            }
            if (!ValidateInput.ValidOnlyLetter(txtPublisher.Text, out errMsg))
            {
                CancelValidatedEvent(txtPublisher, lblPublisherError, e);
            }
        }

        private void txtPublisher_Validated(object sender, EventArgs e)
        {
            this.errBook_EditBook.SetError(txtPublisher, "");
            this.lblPublisherError.Text = "";
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

            if (BUS.Book.Instance.Books.FirstOrDefault(book => 
                        book.TitleId == updatedBook.TitleId 
                        && book.Publisher == txtPublisher.Text.Trim()
                        && book.PublishYear == nudPublishingYear.Value) != null
                && (txtPublisher.Text.Trim() != updatedBook.Publisher
                || (int)nudPublishingYear.Value != updatedBook.PublishYear))
            {
                MessageBox.Show("Sách này đã tồn tại");
                return;
            }

            if (BUS.Book.Instance.UpdateBook(new DTO.Book(updatedBook.Id, updatedBook.TitleId, 
                        txtPublisher.Text.Trim(), (int)nudPublishingYear.Value, updatedBook.InStock, updatedBook.Price)))
            {
                MessageBox.Show("Sửa sách thành công!");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Sửa sách thất bại!");
            }
        }
    }
}
