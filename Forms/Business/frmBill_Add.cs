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
    public partial class frmBill_Add : Form
    {
        private int debtAmuont = 0;

        private int inStockMin = BUS.Parameter.Instance.SLTonMinSauBan.Value;
        private int debtMax = BUS.Parameter.Instance.SoTienNoMax.Value;

        public frmBill_Add()
        {
            InitializeComponent();

            gunaDgvBook.DataSource = BUS.Book.Instance.Books;
        }

        private void frmBill_Add_Load(object sender, EventArgs e)
        {
            cboPhone.ValueMember = "PhoneNumber";
            cboPhone.DisplayMember = "PhoneNumber";
            cboPhone.DataSource = BUS.Customer.Instance.Customers;
            gunaDgvBook.DataSource = BUS.Book.Instance.Books;

            lblInStockMin.Text = lblInStockMin.Text + " " + inStockMin.ToString();
            lblDebtMax.Text = lblDebtMax.Text + " " + debtMax.ToString();
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

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (gunaDgvBook.SelectedRows.Count > 0)
            {
                string cusPhone = cboPhone.Text;

                DataGridViewRow rowTitle = gunaDgvBook.SelectedRows[0];
                int bookId = Convert.ToInt32(rowTitle.Cells[0].Value.ToString());
                int inStock = Convert.ToInt32(rowTitle.Cells[4].Value.ToString());
                int soldPrice = Convert.ToInt32(rowTitle.Cells[5].Value.ToString());
                int quantity = (int)nudQuantity.Value;
                int amount = quantity * soldPrice;

                nudQuantity.Maximum = inStock - inStockMin;

                if (inStock - quantity < inStockMin)
                {
                    MessageBox.Show(String.Format("Số lượng sách tồn tối thiểu sau bán là {0}", inStockMin));
                    return;
                }

                foreach (DataGridViewRow rowDetail in gunaDgvBillDetail.Rows)
                {
                    if (bookId == (int)rowDetail.Cells[0].Value)
                    {
                        MessageBox.Show("Sách này đã tồn tại trong chi tiết hoá đơn.");
                        return;
                    }
                }

                gunaDgvBillDetail.Rows.Add(bookId, quantity, soldPrice, amount);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (grpBook.Enabled == true)
            {
                MessageBox.Show("Hãy chốt phiếu nhập sách!");
                return;
            }

            if (cboPhone.Text == "")
            {
                MessageBox.Show("Hãy lựa chọn khách hàng!");
                return;
            }

            if ((nudTotalAmount.Value - nudPaidAmount.Value) + debtAmuont > debtMax)
            {
                MessageBox.Show(String.Format("Số tiền nợ mới của khách hàng vượt quá số tiền nợ tối đa {0}", debtMax));
                return;
            }

            if (nudTotalAmount.Value - nudPaidAmount.Value < 0)
            {
                MessageBox.Show("Số tiền thanh toán không được vượt quá tổng tiền");
                return;
            }

            int cusId = Convert.ToInt32(txtCustomerCode.Text.ToString());

            int billId = BUS.Bill.Instance.AddBill(cusId, dtmBillDate.Value, 
                            (int)nudTotalAmount.Value, (int)nudPaidAmount.Value, (int)nudChangeAmount.Value);

            foreach (DataGridViewRow row in gunaDgvBillDetail.Rows)
            {
                int bookId = (int)row.Cells[0].Value;
                int quantity = (int)row.Cells[1].Value;
                int soldPrice = (int)row.Cells[2].Value;
                int amount = (int)row.Cells[3].Value;

                //BUS.InventoryReport.Instance.UpdateChange(oldBook.Id, dtmBillDate.Value, 0, quantity);

                BUS.BillDetail.Instance.AddDetail(new DTO.BillDetail(billId, bookId, quantity, soldPrice, amount));

                //BUS.Book.Instance.UpdateInStock(1, bookId, dtmBillDate.Value, quantity, 0);

            }

            //int debtFinal = (int)(debtAmuont + nudChangeAmount.Value);

            //BUS.Customer.Instance.UpdateDebt(3, cusId, dtmBillDate.Value, debtFinal);
            //BUS.DebtReport.Instance.UpdateChange(cusId, dtmBillDate.Value, debtFinal, 0);


            MessageBox.Show("Thêm hoá đơn thành công");

            this.Dispose();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.gunaDgvBillDetail.SelectedRows)
            {
                gunaDgvBillDetail.Rows.RemoveAt(item.Index);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();

            GC.Collect();
        }

        private void btnOkBook_Click(object sender, EventArgs e)
        {
            if (gunaDgvBillDetail.Rows.Count > 0)
            {
                grpBook.Enabled = false;

                int total = 0;
                foreach (DataGridViewRow row in gunaDgvBillDetail.Rows)
                {
                    total += (int)row.Cells[3].Value;
                }
                nudTotalAmount.Value = total;

                nudPaidAmount.Enabled = true;
                nudPaidAmount.Maximum = nudTotalAmount.Value;
                nudChangeAmount.Value = nudTotalAmount.Value - nudPaidAmount.Value;

                int debt = Convert.ToInt32(txtDebtAmount.Text.ToString());

                debt += (int)nudChangeAmount.Value;

                txtDebtAmount.Text = debt.ToString();
            }
            else
            {
                MessageBox.Show("Hãy thêm sách vào hoá đơn!");
            }
        }

        private void cboPhone_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDataCustomer();
        }

        void LoadDataCustomer()
        {
            if (cboPhone.Text != "")
            {
                DTO.Customer customer = BUS.Customer.Instance.Customers.First(cus => cus.PhoneNumber == cboPhone.Text);

                txtCustomerCode.Text = customer.Id.ToString();
                txtCustomerName.Text = customer.Name;

                txtDebtAmount.Text = customer.Debt.ToString();
                debtAmuont = customer.Debt;
            }
        }


        private void nudPaidAmount_ValueChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDebtAmount.Text))
            {
                if (nudTotalAmount.Value - nudPaidAmount.Value >= 0)
                {
                    int debt = Convert.ToInt32(txtDebtAmount.Text.ToString());

                    debt -= (int)nudChangeAmount.Value;

                    nudChangeAmount.Value = nudTotalAmount.Value - nudPaidAmount.Value;

                    debt += (int)nudChangeAmount.Value;

                    txtDebtAmount.Text = debt.ToString();
                }
                else
                {
                    MessageBox.Show("Số tiền thanh toán không được vượt quá tổng tiền");
                }
            }
        }


        private void gunaDgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gunaDgvBook.SelectedRows.Count > 0)
            {
                string cusPhone = cboPhone.Text;

                DataGridViewRow rowTitle = gunaDgvBook.SelectedRows[0];
                int inStock = Convert.ToInt32(rowTitle.Cells[4].Value.ToString());

                nudQuantity.Maximum = inStock - inStockMin;
            }
        }

    }
}
