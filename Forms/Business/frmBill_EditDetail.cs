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
    public partial class frmBill_EditDetail : Form
    {
        private int inStockMin = BUS.Parameter.Instance.SLTonMinSauBan.Value;
        private int debtMax = BUS.Parameter.Instance.SoTienNoMax.Value;

        private DTO.Bill bill;

        private DTO.BillDetail detail;

        private DTO.Book book;

        private DTO.Title title;

        public frmBill_EditDetail(int billId, int bookId)
        {
            InitializeComponent();

            bill = BUS.Bill.Instance.Bills.First(re => re.Id == billId);
            book = BUS.Book.Instance.Books.First(book => book.Id == bookId);

            detail = BUS.BillDetail.Instance.BillDetails.First(de =>
                                        de.Id == billId && de.BookId == bookId);

            title = BUS.Title.Instance.Titles.First(tit => tit.Id == book.TitleId);

            LoadBillDetailInfo();
        }

        private void LoadBillDetailInfo()
        {
            this.txtBillCode.Text = bill.Id.ToString();
            this.dtmBillDate.Value = bill.CreateDate;
            this.nudTotalAmount.Value = bill.TotalPrice;
            this.nudPaidAmount.Value = bill.Payment;
            this.nudChangeAmount.Value = bill.Balance;

            this.txtBookCode.Text = book.Id.ToString();
            this.txtTitleBookName.Text = title.Name;
            this.txtCategory.Text
                = BUS.Category.Instance.Categories.First(cate => cate.Id == title.CategoryId).Name;
            this.txtPublisher.Text = book.Publisher;
            this.nudPublishingYear.Value = book.PublishYear;
            this.nudQuantity.Value = detail.Number;
            this.nudSoldPrice.Value = detail.Price;
            txtAmount.Text = detail.Total.ToString();

            nudQuantity.Maximum = book.InStock - inStockMin + detail.Number;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            GC.Collect();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(txtAmount.Text);

            BUS.BillDetail.Instance.UpdateDetail(
                new DTO.BillDetail(bill.Id, book.Id, (int)nudQuantity.Value, detail.Price, amount));
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            txtAmount.Text = (nudQuantity.Value * nudSoldPrice.Value).ToString();
        }
    }
}
