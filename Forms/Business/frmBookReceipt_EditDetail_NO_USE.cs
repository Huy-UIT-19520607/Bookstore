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
    public partial class frmBookReceipt_EditDetail_NO_USE : Form
    {

        private int quantityMin = BUS.Parameter.Instance.SLNhapMin.Value;
        private int inStockMax = BUS.Parameter.Instance.SLTonMaxTruocNhap.Value;
        private int priceRate = BUS.Parameter.Instance.TiLeTinhDonGiaBan.Value;

        private DTO.BookReceipt receipt;

        private DTO.BookReceiptDetail detail;

        private DTO.Book book;

        private DTO.Title title;

        public frmBookReceipt_EditDetail_NO_USE(int bookReceiptId, int bookId)
        {
            InitializeComponent();

            receipt = BUS.BookReceipt.Instance.Receipts.First(re => re.Id == bookReceiptId);
            book = BUS.Book.Instance.Books.First(book => book.Id == bookId);

            detail = BUS.BookReceiptDetail.Instance.Details.First(de => 
                                        de.Id == bookReceiptId && de.BookId == bookId);
            
            title = BUS.Title.Instance.Titles.First(tit => tit.Id == book.TitleId);

            LoadBookReceiptDetailInfo();
        }

        private void LoadBookReceiptDetailInfo()
        {
            this.txtBookReceiptCode.Text = receipt.Id.ToString();
            this.dtmDate.Value = receipt.ReceiveDay;
            this.nudTotalAmount.Value = receipt.Total;

            this.txtBookCode.Text = book.Id.ToString();
            this.txtTitleBookName.Text = title.Name;
            this.txtCategory.Text
                = BUS.Category.Instance.Categories.First(cate => cate.Id == title.CategoryId).Name;
            this.txtPublisher.Text = book.Publisher;
            this.nudPublishingYear.Value = book.PublishYear;
            this.nudQuantity.Value = detail.Number;
            this.nudCostPrice.Value = detail.ReceivePrice;
            this.nudAmount.Value = detail.Total;

            nudPublishingYear.Maximum = DateTime.Now.Year;
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            nudAmount.Value = nudQuantity.Value * nudCostPrice.Value;
        }

        private void nudCostPrice_ValueChanged(object sender, EventArgs e)
        {
            nudAmount.Value = nudQuantity.Value * nudCostPrice.Value;
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

            if (nudQuantity.Value < quantityMin)
            {
                MessageBox.Show(String.Format("Số lượng sách nhập tối thiểu là {0}", quantityMin));
                return;
            }

            DTO.Book checkBook = BUS.Book.Instance.Books.FirstOrDefault(bk=> bk.TitleId == title.Id 
                    && bk.Publisher == book.Publisher && bk.PublishYear == book.PublishYear);
            if (checkBook != null)
            {
                nudCostPrice.Enabled = false;


                int costPrice = BUS.BookReceiptDetail.Instance.Details.First(
                        detail => detail.BookId == checkBook.Id).ReceivePrice;
                nudCostPrice.Value = costPrice;

                int quantity = (int)nudQuantity.Value;

                int amount = costPrice * quantity;

                var updatedStock = quantity + checkBook.InStock;

                BUS.Book.Instance.UpdateBook(new DTO.Book(checkBook.Id, book.TitleId,
                    book.Publisher, book.PublishYear, updatedStock, (int)(costPrice * priceRate / 100)));

            }
            else
            {
                //BUS.Book.Instance.AddBook(id, publisher, publishYear, quantity, (int)(costPrice * priceRate / 100));
                //DTO.Book newBook = BUS.Book.Instance.Books.FirstOrDefault(book
                //    => book.TitleId == id && book.Publisher == publisher && book.PublishYear == publishYear);
                //bookId = newBook.Id;
            }

            //BUS.BookReceiptDetail.Instance.UpdateDetail(bookReceiptId, bookId, quantity, costPrice, amount);




            //MessageBox.Show("Thêm phiếu nhập sách thành công");

            this.Dispose();

        }

        
    }
}