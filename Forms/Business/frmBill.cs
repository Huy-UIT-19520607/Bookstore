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
    public partial class frmBill : Form
    {
        public frmBill()
        {
            InitializeComponent();

        }

        private void frmBill_Load(object sender, EventArgs e)
        {
            gunaDgvBill.DataSource = BUS.Bill.Instance.Bills;
            gunaDgvBillDetail.DataSource = BUS.BillDetail.Instance.BillDetails;
        }

        private void gunaDgvBillDetail_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.Value != null)
            {
                e.Value = BUS.Book.Instance.Books.First(
                    book => book.Id == Convert.ToInt32(e.Value.ToString())).Publisher;
            }
            if (e.ColumnIndex == 7 && e.Value != null)
            {
                e.Value = BUS.Book.Instance.Books.First(
                    book => book.Id == Convert.ToInt32(e.Value.ToString())).PublishYear;
            }
            if (e.ColumnIndex == 5 && e.Value != null)
            {
                int titleId = BUS.Book.Instance.Books.First(
                    book => book.Id == Convert.ToInt32(e.Value.ToString())).TitleId;

                e.Value = BUS.Title.Instance.Titles.First(title => title.Id == titleId).Name;
            }
        }
        private void gunaBillDetailSearch_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnBillDetailSearch;

            if (string.IsNullOrEmpty(gunaTxtBillDetailSearch.Text))
            {
                gunaDgvBill.DataSource = BUS.Book.Instance.Books;
                return;
            }
        }

        private void gunaTxtBillDetailSearch_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void btnBillDetailSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gunaTxtBillDetailSearch.Text))
            {
                gunaDgvBillDetail.DataSource = BUS.Book.Instance.Books;
                return;
            }

            string searchText = gunaTxtBillDetailSearch.Text;

            searchText = MyConvert.ToAscii(searchText).ToLower();

            gunaDgvBillDetail.DataSource =
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

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            (new Forms.Business.frmBill_Add()).ShowDialog();
        }

        private void btnFilterBillDetail_Click(object sender, EventArgs e)
        {
            if (gunaDgvBill.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = gunaDgvBill.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells[0].Value.ToString());

                gunaDgvBillDetail.DataSource =
                    BUS.BillDetail.Instance.BillDetails.Where(detail => detail.Id == id).ToList();
            }
            else
            {
                MessageBox.Show("Hãy lựa chọn hoá đơn cần lọc thông tin");
            }
        }
        
        void LoadDataCustomer()
        {
            if (gunaDgvBill.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = gunaDgvBill.SelectedRows[0];
                int customerId = Convert.ToInt32(row.Cells[1].Value.ToString());

                var customer = BUS.Customer.Instance.Customers.First(cus => cus.Id == customerId);
                txtDebtAmount.DataBindings.Clear();
                txtDebtAmount.DataBindings.Add("Text", customer, "Debt");

                txtCustomerCode.Text = customer.Id.ToString();

                txtCustomerName.DataBindings.Clear();
                txtCustomerName.DataBindings.Add("Text", customer, "Name");

                txtPhone.DataBindings.Clear();
                txtPhone.DataBindings.Add("Text", customer, "PhoneNumber");

                //DTO.Customer customer = BUS.Customer.Instance.Customers.First(cus => cus.Id == customerId);

                //txtCustomerCode.Text = customer.Id.ToString();
                //txtCustomerName.Text = customer.Name;
                //txtPhone.Text = customer.PhoneNumber;

                //txtDebtAmount.Text = customer.Debt.ToString();

                GC.Collect();
            }
        }

        private void btnEditBill_Click(object sender, EventArgs e)
        {
            if (gunaDgvBill.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = gunaDgvBill.SelectedRows[0];
                int billId = Convert.ToInt32(row.Cells[0].Value.ToString());
                int cusId = Convert.ToInt32(row.Cells[1].Value.ToString());

                (new Forms.Business.frmBill_Edit(billId, cusId)).ShowDialog();
            }
            else
            {
                MessageBox.Show("Hãy phiếu thu tiền muốn sửa");
            }
        }

        private void gunaDgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataCustomer();
        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            if (gunaDgvBill.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = gunaDgvBill.SelectedRows[0];
                int billId = Convert.ToInt32(row.Cells[0].Value.ToString());
                int cusId = Convert.ToInt32(row.Cells[1].Value.ToString());

                BUS.Bill.Instance.DeleteBill(billId);
            }
            else
            {
                MessageBox.Show("Hãy chọn hoá đơn muốn xoá");
            }
        }

        private void btnEditBillDetail_Click(object sender, EventArgs e)
        {
            if (gunaDgvBillDetail.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = gunaDgvBillDetail.SelectedRows[0];
                int billId = Convert.ToInt32(row.Cells[0].Value.ToString());
                int bookId = Convert.ToInt32(row.Cells[1].Value.ToString());

                (new Forms.Business.frmBill_EditDetail(billId, bookId)).ShowDialog();
            }
            else
            {
                MessageBox.Show("Hãy chọn chi tiết hoá đơn muốn sửa");
            }
        }

        private void btnDeleteBillDetail_Click(object sender, EventArgs e)
        {
            if (gunaDgvBillDetail.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = gunaDgvBillDetail.SelectedRows[0];
                int billId = Convert.ToInt32(row.Cells[0].Value.ToString());
                int bookId = Convert.ToInt32(row.Cells[1].Value.ToString());

                if (gunaDgvBillDetail.Rows.Count == 1)
                {
                    MessageBox.Show("")
                }    
                    BUS.BillDetail.Instance.DeleteDetail(billId, bookId);

            }
            else
            {
                MessageBox.Show("Hãy chi tiết hoá đơn muốn xoá");
            }
        }
    }
}
