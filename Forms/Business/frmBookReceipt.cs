using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Forms.Business
{
    public partial class frmBookReceipt : Form
    {
        public frmBookReceipt()
        {
            InitializeComponent();
        }

        private void frmBookReceipt_Load(object sender, EventArgs e)
        {
            gunaDgvBookReceipt.DataSource = BUS.BookReceipt.Instance.Receipts;
            gunaDgvBookReceiptDetail.DataSource = BUS.BookReceiptDetail.Instance.Details;
            gunaDgvBook.DataSource = BUS.Book.Instance.Books;
        }

        private void gunaDgvBook_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.Value != null)
            {
                string bookName = BUS.Title.Instance.Titles.First(
                    title => title.Id == Convert.ToInt32(e.Value.ToString())).Name;

                e.Value = bookName;
            }
        }

        private void gunaTxtBookSearch_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnBookSearch;

            if (string.IsNullOrEmpty(gunaTxtBookSearch.Text))
            {
                gunaDgvBook.DataSource = BUS.Book.Instance.Books;
                return;
            }
        }

        private void gunaTxtBookSearch_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gunaTxtBookSearch.Text))
            {
                gunaDgvBook.DataSource = BUS.Book.Instance.Books;
                return;
            }

            string searchText = gunaTxtBookSearch.Text;

            searchText = MyConvert.ToAscii(searchText).ToLower();

            gunaDgvBook.DataSource =
                BUS.Book.Instance.Books.Where(book =>
                {

                    string bookName = BUS.Title.Instance.Titles.First(title => title.Id == book.TitleId).Name;
                    bookName = MyConvert.ToAscii(bookName).ToLower();

                    string publisher = MyConvert.ToAscii(book.Publisher).ToLower();

                    string publishYearString = MyConvert.ToAscii(book.PublishYear.ToString()).ToLower();

                    return bookName.Contains(searchText) || publisher.Contains(searchText)
                            || publishYearString.Contains(searchText);
                }).ToList();
        }

        private void btnFilterDetail_Click(object sender, EventArgs e)
        {
            if (gunaDgvBookReceipt.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = gunaDgvBookReceipt.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells[0].Value.ToString());

                gunaDgvBookReceiptDetail.DataSource =
                    BUS.BookReceiptDetail.Instance.Details.Where(detail => detail.Id == id).ToList();
            }
            else
            {
                MessageBox.Show("Hãy lựa chọn phiếu nhập sách cần lọc thông tin");
            }
        }

        private void btnFilterBook_Click(object sender, EventArgs e)
        {
            if (gunaDgvBookReceiptDetail.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = gunaDgvBookReceiptDetail.SelectedRows[0];
                int bookId = Convert.ToInt32(row.Cells[1].Value.ToString());

                gunaDgvBook.DataSource =
                    BUS.Book.Instance.Books.Where(book => book.Id == bookId).ToList();
            }
            else
            {
                MessageBox.Show("Hãy lựa chọn mã sách ở chi tiết phiếu nhập cần lọc thông tin");
            }
        }

        private void btnAddBookReceipt_Click(object sender, EventArgs e)
        {
            (new Forms.Business.frmBookReceipt_Add()).ShowDialog();
        }

        private void btnEditBookReceipt_Click(object sender, EventArgs e)
        {
            if (gunaDgvBookReceipt.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = gunaDgvBookReceipt.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells[0].Value.ToString());

                (new Forms.Business.frmBookReceipt_Edit_NO_USE()).ShowDialog();
            }
            else
            {
                MessageBox.Show("Hãy chọn phiếu nhập sách muốn sửa");
            }
        }

        private void btnDeleteBookReceipt_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteBookReceiptDetail_Click(object sender, EventArgs e)
        {

        }

        private void btnEditBookReceiptDetail_Click(object sender, EventArgs e)
        {
            if (gunaDgvBookReceiptDetail.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = gunaDgvBookReceiptDetail.SelectedRows[0];
                int receiptId = Convert.ToInt32(row.Cells[0].Value.ToString());
                int bookId = Convert.ToInt32(row.Cells[1].Value.ToString());

                (new Forms.Business.frmBookReceipt_EditDetail_NO_USE(receiptId, bookId)).ShowDialog();
            }
            else
            {
                MessageBox.Show("Hãy chọn chi tiết phiếu nhập sách muốn sửa");
            }
        }
    }
}
