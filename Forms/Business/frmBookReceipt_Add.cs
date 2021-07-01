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
    public partial class frmBookReceipt_Add : Form
    {
        private string errMsg = "";

        private int quantityMin = BUS.Parameter.Instance.SLNhapMin.Value;
        private int inStockMax = BUS.Parameter.Instance.SLTonMaxTruocNhap.Value;
        private int priceRate = BUS.Parameter.Instance.TiLeTinhDonGiaBan.Value;

        public frmBookReceipt_Add()
        {
            InitializeComponent();

            ResetErrorMessage();
        }

        private void frmBookReceipt_Add_Load(object sender, EventArgs e)
        {
            gunaDgvTitleBook.DataSource = BUS.Title.Instance.Titles;
            nudQuantity.Minimum = quantityMin;
        }

        private void gunaDgvTitleBook_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                e.Value = BUS.Category.Instance.Categories.First(
                    cate => cate.Id == Convert.ToInt32(e.Value.ToString())).Name;
            }
        }

        private void ResetErrorMessage()
        {
            this.lblPublisherError.Text = "";

            this.txtPublisher.Text = "";

            this.errBookReceipt_Add.Clear();
            GC.Collect();
        }
        private void CancelValidatedEvent(Control control, Label error, CancelEventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
            e.Cancel = true;
            errBookReceipt_Add.SetError(control, errMsg);
            error.Text = errMsg;
        }

        private void txtPublisher_Validating(object sender, CancelEventArgs e)
        {
            if (txtPublisher.Text.Trim() == "")
            {
                errMsg = "Hãy điền tên nhà sản xuất";
                CancelValidatedEvent(txtPublisher, lblPublisherError, e);
                return;
            }
            if (!ValidateInput.ValidOnlyLetterAndNumber(txtPublisher.Text, out errMsg))
            {
                CancelValidatedEvent(txtPublisher, lblPublisherError, e);
            }
        }

        private void txtPublisher_Validated(object sender, EventArgs e)
        {
            this.errBookReceipt_Add.SetError(txtPublisher, "");
            this.lblPublisherError.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();

            GC.Collect();
        }

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

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

            if (gunaDgvTitleBook.SelectedRows.Count > 0)
            {
                DataGridViewRow rowTitle = gunaDgvTitleBook.SelectedRows[0];
                int id = Convert.ToInt32(rowTitle.Cells[0].Value.ToString());
                string publisher = txtPublisher.Text.Trim();
                int publishYear = (int)nudPublishingYear.Value;
                int quantity = (int)nudQuantity.Value;
                int costPrice = (int)nudCostPrice.Value;
                int amount = quantity * costPrice;

                if (quantity < quantityMin)
                {
                    MessageBox.Show(String.Format("Số lượng sách nhập tối thiểu là {0}", quantityMin));
                    return;
                }

                DTO.Book checkBook = BUS.Book.Instance.Books.FirstOrDefault(book
                    => book.TitleId == id && book.Publisher == publisher && book.PublishYear == publishYear);
                
                if (checkBook != null)
                {
                    if (checkBook.InStock > inStockMax)
                    {
                        MessageBox.Show(String.Format("Chỉ nhập các sách có số lượng tồn ít hơn {0}", inStockMax));
                        return;
                    }
                    else
                    {
                        costPrice = BUS.BookReceiptDetail.Instance.Details.First(
                            detail => detail.BookId == checkBook.Id).ReceivePrice;
                        nudCostPrice.Value = costPrice;
                        amount = costPrice * quantity;
                        MessageBox.Show("Sách này đã tồn tại trong kho nên đơn giá nhập sẽ như nhau");
                    }
                }

                foreach (DataGridViewRow rowDetail in gunaDgvBookReceiptDetail.Rows)
                {
                    if (id == (int)rowDetail.Cells[0].Value 
                        && publisher == rowDetail.Cells[1].Value.ToString()
                        && publishYear == (int)rowDetail.Cells[2].Value)
                    {
                        MessageBox.Show("Sách này đã tồn tại trong chi tiết phiếu nhập.");
                        return;
                    } 
                }

                gunaDgvBookReceiptDetail.Rows.Add(id, publisher, publishYear, quantity, costPrice, amount);
            }
            
        }

        private void btnOkBook_Click(object sender, EventArgs e)
        {
            if (gunaDgvBookReceiptDetail.Rows.Count > 0)
            {
                grpTitleBook.Enabled = false;

                int total = 0;
                foreach(DataGridViewRow row in gunaDgvBookReceiptDetail.Rows)
                {
                    total += (int)row.Cells[5].Value;
                }
                nudTotalAmount.Value = total;
            }
            else
            {
                MessageBox.Show("Hãy thêm sách vào phiếu nhập!");
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.gunaDgvBookReceiptDetail.SelectedRows)
            {
                gunaDgvBookReceiptDetail.Rows.RemoveAt(item.Index);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (grpTitleBook.Enabled == true)
            {
                MessageBox.Show("Hãy chốt phiếu nhập sách!");
                return;
            }

            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

            int bookReceiptId = BUS.BookReceipt.Instance.AddReceipt(dtmDate.Value, (int)nudTotalAmount.Value);

            foreach (DataGridViewRow row in gunaDgvBookReceiptDetail.Rows)
            {
                int id = (int)row.Cells[0].Value;
                string publisher = row.Cells[1].Value.ToString();
                int publishYear = (int)row.Cells[2].Value;
                int quantity = (int)row.Cells[3].Value;
                int costPrice = (int)row.Cells[4].Value;
                int amount = (int)row.Cells[5].Value;
                int bookId = 0;

                DTO.Book checkBook = BUS.Book.Instance.Books.FirstOrDefault(book
                    => book.TitleId == id && book.Publisher == publisher && book.PublishYear == publishYear);
                if (checkBook != null)
                {
                    
                    bookId = checkBook.Id;
                    costPrice = BUS.BookReceiptDetail.Instance.Details.First(
                            detail => detail.BookId == checkBook.Id).ReceivePrice;
                    amount = costPrice * quantity;

                    var updatedStock = quantity + checkBook.InStock;

                    //MessageBox.Show(quantity + " - " + checkBook.InStock + " - " + updatedStock);

                    BUS.Book.Instance.UpdateBook(new DTO.Book(checkBook.Id, id, 
                        publisher, publishYear, updatedStock, (int)(costPrice * priceRate / 100)));

                }
                else
                {
                    BUS.Book.Instance.AddBook(id, publisher, publishYear, quantity, (int)(costPrice * priceRate / 100));
                    DTO.Book newBook = BUS.Book.Instance.Books.FirstOrDefault(book
                        => book.TitleId == id && book.Publisher == publisher && book.PublishYear == publishYear);
                    bookId = newBook.Id;
                }

                BUS.BookReceiptDetail.Instance.AddDetail(bookReceiptId, bookId, quantity, costPrice, amount);

                //var newReceipt = BUS.BookReceipt.Instance.Receipts.First(receipt => receipt.Id == bookReceiptId);


                //var listBookReceiptDetail = BUS.BookReceiptDetail.Instance.Details.Where(detail => detail.Id == bookId).ToList();
                //foreach (var item in listBookReceiptDetail)
                //{
                //    newReceipt.Total += item.Total;
                //}
            }

            MessageBox.Show("Thêm phiếu nhập sách thành công");

            this.Dispose();
        }
    }
}
