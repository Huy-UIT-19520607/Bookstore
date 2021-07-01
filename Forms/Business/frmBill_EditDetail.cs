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

        private DTO.Customer customer;

        private DTO.BillDetail detail;

        private DTO.Book book;

        private DTO.Title title;

        public frmBill_EditDetail(int billId, int bookId)
        {
            InitializeComponent();

            bill = BUS.Bill.Instance.Bills.First(re => re.Id == billId);

            customer = BUS.Customer.Instance.Customers.First(cus => cus.Id == bill.CustomerId);

            book = BUS.Book.Instance.Books.First(book => book.Id == bookId);

            detail = BUS.BillDetail.Instance.BillDetails.First(de =>
                                        de.Id == billId && de.BookId == bookId);

            title = BUS.Title.Instance.Titles.First(tit => tit.Id == book.TitleId);

            
        }
        private void frmBill_EditDetail_Load(object sender, EventArgs e)
        {
            //lblInStockMin.Text = lblInStockMin.Text + " " + inStockMin.ToString();
            //lblDebtMax.Text = lblDebtMax.Text + " " + debtMax.ToString();

            LoadBillDetailInfo();
        }
        private void LoadBillDetailInfo()
        {
            this.txtBillCode.Text = bill.Id.ToString();
            this.dtmBillDate.Value = bill.CreateDate;
            this.nudTotalAmount.Value = bill.TotalPrice;
            this.nudPaidAmount.Value = bill.Payment;
            this.nudChangeAmount.Value = bill.Balance;


            //this.txtCustomerCode.Text = customer.Id.ToString();
            //this.txtCustomerName.Text = customer.Name;
            //this.txtPhone.Text = customer.PhoneNumber;
            //this.txtDebtAmount.Text = customer.Debt.ToString();


            this.txtBookCode.Text = book.Id.ToString();
            this.txtTitleBookName.Text = title.Name;
            this.txtCategory.Text
                = BUS.Category.Instance.Categories.First(cate => cate.Id == title.CategoryId).Name;
            this.txtPublisher.Text = book.Publisher;
            this.nudPublishingYear.Value = book.PublishYear;
            //this.nudInStock.Value = book.InStock;

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


            if (nudTotalAmount.Value - nudPaidAmount.Value < 0)
            {
                MessageBox.Show("Số tiền thanh toán không được vượt quá tổng tiền");
                return;
            }

            //if (Convert.ToInt32(txtDebtAmount.Text) > debtMax)
            //{
            //    MessageBox.Show(String.Format("Số tiền nợ mới của khách hàng đã vượt quá số tiền nợ tối đa {0}", debtMax));
            //}

            if ((bill.TotalPrice - nudPaidAmount.Value) +
                (customer.Debt - bill.Balance) > debtMax)
            {
                MessageBox.Show(String.Format("Số tiền nợ mới của khách hàng đã vượt quá số tiền nợ tối đa {0}", debtMax));
                return;
            }

            if (BUS.Bill.Instance.UpdateBill(
                new DTO.Bill(bill.Id, customer.Id, dtmBillDate.Value, bill.TotalPrice, (int)nudPaidAmount.Value, (int)nudChangeAmount.Value)))
            {
                MessageBox.Show("Sửa phiếu thu tiền thành công");
            }



            BUS.BillDetail.Instance.UpdateDetail(
                new DTO.BillDetail(bill.Id, book.Id, (int)nudQuantity.Value, detail.Price, amount));

            this.Dispose();
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            //if (!String.IsNullOrEmpty(txtDebtAmount.Text) && !String.IsNullOrEmpty(txtAmount.Text))
            //{
                
            //        nudInStock.Value = book.InStock + detail.Number;

            //        int amount = Convert.ToInt32(txtAmount.Text);

            //        nudTotalAmount.Value -= amount;

            //        amount = (int)(nudQuantity.Value * nudSoldPrice.Value);

            //        txtAmount.Text = amount.ToString();

            //        nudTotalAmount.Value += amount;

            //    if (nudTotalAmount.Value - nudPaidAmount.Value >= 0)
            //    {
            //        int debt = Convert.ToInt32(txtDebtAmount.Text.ToString());

            //        debt -= (int)nudChangeAmount.Value;


            //        nudChangeAmount.Value = nudTotalAmount.Value - nudPaidAmount.Value;

            //        debt += (int)nudChangeAmount.Value;

            //        if (debt > 0)
            //        {
            //            if (debt > debtMax)
            //            {
            //                MessageBox.Show(String.Format("Số tiền nợ mới của khách hàng đã vượt quá số tiền nợ tối đa {0}", debtMax));

            //                return;
            //            }

            //            txtDebtAmount.Text = debt.ToString();

            //            nudInStock.Value -= nudQuantity.Value;

            //        } 
            //        else
            //        {
            //            MessageBox.Show("Số tiền nợ không được âm");
            //        }
            //    }
            //    else
            //    {
            //        nudQuantity.Minimum = amount / nudSoldPrice.Value;
            //        MessageBox.Show("Số tiền thanh toán không được vượt quá tổng tiền");
            //    }
            //}
        }

        private void txtDebtAmount_TextChanged(object sender, EventArgs e)
        {
            //nudInStock.Value -= nudQuantity.Value;

            //nudInStock.Value -= nudQuantity.Value;
        }

    }
}
