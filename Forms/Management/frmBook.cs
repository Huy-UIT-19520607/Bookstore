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
    public partial class frmBook : Form
    {
        public frmBook()
        {
            InitializeComponent();
        }

        private void frmBook_Load(object sender, EventArgs e)
        {
            gunaDgvTitleBook.DataSource = BUS.Title.Instance.Titles;
            gunaDgvAuthor.DataSource = BUS.Author.Instance.Authors;
            gunaDgvBook.DataSource = BUS.Book.Instance.Books;

        }

        private void gunaDgvTitleBook_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                e.Value = BUS.Category.Instance.Categories.First(
                    cate => cate.Id == Convert.ToInt32(e.Value.ToString())).Name;
            }
        }

        #region TitleBook Search
        private void gunaTxtTitleBookSearch_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnTitleBookSearch;

            if (string.IsNullOrEmpty(gunaTxtTitleBookSearch.Text))
            {
                gunaDgvTitleBook.DataSource = BUS.Title.Instance.Titles;
                return;
            }
        }

        private void gunaTxtTitleBookSearch_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void btnTitleBookSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gunaTxtTitleBookSearch.Text))
            {
                gunaDgvTitleBook.DataSource = BUS.Title.Instance.Titles;
                return;
            }

            string searchText = gunaTxtTitleBookSearch.Text;

            searchText = MyConvert.ToAscii(searchText).ToLower();

            gunaDgvTitleBook.DataSource =
                BUS.Title.Instance.Titles.Where(title =>
                {
                    string bookName = MyConvert.ToAscii(title.Name).ToLower();

                    string categoryName = BUS.Category.Instance.Categories.First(
                                            cate => cate.Id == title.CategoryId).Name;
                    categoryName = MyConvert.ToAscii(categoryName).ToLower();

                    return bookName.Contains(searchText) || categoryName.Contains(searchText);
                }).ToList();
        }

        #endregion

        #region Author Search
        private void gunaTxtAuthorSearch_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnAuthorSearch;

            if (string.IsNullOrEmpty(gunaTxtAuthorSearch.Text))
            {
                gunaDgvAuthor.DataSource = BUS.Author.Instance.Authors;
                return;
            }
        }

        private void gunaTxtAuthorSearch_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void btnAuthorSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gunaTxtAuthorSearch.Text))
            {
                gunaDgvAuthor.DataSource = BUS.Author.Instance.Authors;
                return;
            }

            string searchText = gunaTxtAuthorSearch.Text;

            searchText = MyConvert.ToAscii(searchText).ToLower();

            gunaDgvAuthor.DataSource =
                BUS.Author.Instance.Authors.Where(author =>
                {
                    string authorName = MyConvert.ToAscii(author.Name).ToLower();

                    return authorName.Contains(searchText);
                }).ToList();
        }
        #endregion

        #region Book Seach
        private void gunaTxtBookSearch_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnBookSearch;

            if (string.IsNullOrEmpty(gunaTxtBookSearch.Text))
            {
                gunaDgvBook.DataSource = BUS.Book.Instance.Books;
                return;
            }
        }
        #endregion

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
                    string publisher = MyConvert.ToAscii(book.Publisher).ToLower();

                    string publishYearString = book.PublishYear.ToString();

                    return publisher.Contains(searchText) || publishYearString.Contains(searchText);
                }).ToList();
        }

        private void btnFilterAuthor_Click(object sender, EventArgs e)
        {
            if (gunaDgvTitleBook.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = gunaDgvTitleBook.SelectedRows[0];
                int titleId = Convert.ToInt32(row.Cells[0].Value.ToString());

                gunaDgvAuthor.DataSource =
                    BUS.Author.Instance.Authors.Where(author => author.TitleId == titleId).ToList();
            }
            else
            {
                MessageBox.Show("Hãy lựa chọn đầu sách cần lọc thông tin");
            }
            
        }

        private void btnFilterBook_Click(object sender, EventArgs e)
        {
            if (gunaDgvTitleBook.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = gunaDgvTitleBook.SelectedRows[0];
                int titleId = Convert.ToInt32(row.Cells[0].Value.ToString());

                gunaDgvBook.DataSource =
                    BUS.Book.Instance.Books.Where(book => book.TitleId == titleId).ToList();
            }
            else
            {
                MessageBox.Show("Hãy lựa chọn đầu sách cần lọc thông tin");
            }
        }

        private void btnAddTitleBook_Click(object sender, EventArgs e)
        {
            (new Forms.Management.frmBook_AddTitleBook()).ShowDialog();
        }

        private void btnEditTitleBook_Click(object sender, EventArgs e)
        {
            if (gunaDgvTitleBook.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = gunaDgvTitleBook.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells[0].Value.ToString());

                (new Forms.Management.frmBook_EditTitleBook(id)).ShowDialog();
            }
            else
            {
                MessageBox.Show("Hãy chọn đầu sách muốn sửa");
            }
        }

        private void btnDeleteTitleBook_Click(object sender, EventArgs e)
        {
            if (gunaDgvTitleBook.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = gunaDgvTitleBook.SelectedRows[0];
                int selectedId = Convert.ToInt32(row.Cells[0].Value.ToString());
                string selectedName = row.Cells[1].Value.ToString();
                if (MessageBox.Show(String.Format("Bạn muốn xoá đầu sách {0}?", selectedName), "Xoá", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    // Xóa
                    if (BUS.Book.Instance.Books.FirstOrDefault(book => book.TitleId == selectedId) != null)
                    {
                        MessageBox.Show("Đầu sách này đang có sách trong kho. Không thể xoá!");
                    }
                    else if (BUS.Title.Instance.DeleteTitle(selectedId))
                    {
                        gunaDgvTitleBook.Refresh();

                        while(BUS.Author.Instance.Authors.FirstOrDefault(author 
                                 => author.TitleId == selectedId) != null)
                        {
                            BUS.Author.Instance.Authors.Remove(
                                BUS.Author.Instance.Authors.First(author => author.TitleId == selectedId));
                        }

                        gunaDgvAuthor.Refresh();

                        MessageBox.Show("Xóa đầu sách thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa đầu sách thất bại!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn đầu sách muốn xóa!");
            }
        }

        private void btnDeleteAuthor_Click(object sender, EventArgs e)
        {
            if (gunaDgvAuthor.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = gunaDgvAuthor.SelectedRows[0];
                int selectedTitleId = Convert.ToInt32(row.Cells[0].Value.ToString());
                string selectedAuthor = row.Cells[1].Value.ToString();
                if (MessageBox.Show(String.Format("Bạn muốn xoá tác giả {0} của mã đầu sách \"{1}\"?", 
                    selectedAuthor, selectedTitleId), "Xoá", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {

                    int authorQuantityInTitle = BUS.Author.Instance.Authors.Where(title => 
                                                        title.TitleId == selectedTitleId).ToList().Count;

                    if (authorQuantityInTitle == 1)
                    {
                        MessageBox.Show("Đầu sách phải có ít nhất 1 tác giả! Không thể xoá");
                        return;
                    }
                    else
                    {
                        if (BUS.Author.Instance.DeleteAuthor(new DTO.Author(selectedTitleId, selectedAuthor)))
                        {
                            MessageBox.Show("Xóa tác giả thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Xóa tác giả thất bại!");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn tác giả muốn xóa!");
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (gunaDgvBook.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = gunaDgvBook.SelectedRows[0];
                int selectedBookId = Convert.ToInt32(row.Cells[0].Value.ToString());
                int selectedTitleId = Convert.ToInt32(row.Cells[1].Value.ToString());
                if (MessageBox.Show(String.Format("Bạn muốn xoá sách có mã {0} của mã đầu sách {1}?", 
                    selectedBookId,selectedTitleId), "Xoá", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    // Xóa
                    if (BUS.BillDetail.Instance.BillDetails.FirstOrDefault(billDetail => billDetail.BookId == selectedBookId) != null
                        || BUS.BookReceiptDetail.Instance.Details.FirstOrDefault(detail => detail.BookId == selectedBookId) != null)
                    {
                        MessageBox.Show("Sách này đã đang trong kho hoặc hoá đơn. Không thể xoá!");

                    }
                    else if (BUS.Book.Instance.DeleteBook(selectedBookId))
                    {
                        MessageBox.Show("Xóa sách thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa sách thất bại!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn sách muốn xóa!");
            }
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if (gunaDgvBook.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = gunaDgvBook.SelectedRows[0];
                int bookId = Convert.ToInt32(row.Cells[0].Value.ToString());
                int titleId = Convert.ToInt32(row.Cells[1].Value.ToString());

                (new Forms.Management.frmBook_EditBook(bookId, titleId)).ShowDialog();
            }
            else
            {
                MessageBox.Show("Hãy chọn sách muốn sửa");
            }
        }

        private void btnEditAuthor_Click(object sender, EventArgs e)
        {
            if (gunaDgvAuthor.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = gunaDgvAuthor.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                string author = row.Cells[1].Value.ToString();

                (new Forms.Management.frmBook_EditAuthor(id, author)).ShowDialog();
            }
            else
            {
                MessageBox.Show("Hãy chọn tác giả muốn sửa");
            }
        }
    }
}
