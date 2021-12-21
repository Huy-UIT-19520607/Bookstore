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
    public partial class frmCashReceipt_Add : Form
    {
        public frmCashReceipt_Add()
        {
            InitializeComponent();
        }

        private void frmCashReceipt_Add_Load(object sender, EventArgs e)
        {
            gunaDgvCustomer.DataSource = BUS.Customer.Instance.Customers;
        }

        private void gunaTxtCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnCustomerSearch;

            if (string.IsNullOrEmpty(gunaTxtCustomerSearch.Text))
            {
                gunaDgvCustomer.DataSource = BUS.Customer.Instance.Customers;
                return;
            }
        }

        private void gunaTxtCustomerSearch_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = btnOk;
        }

        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gunaTxtCustomerSearch.Text))
            {
                gunaDgvCustomer.DataSource = BUS.Customer.Instance.Customers;
                return;
            }

            string searchText = gunaTxtCustomerSearch.Text;

            searchText = MyConvert.ToAscii(searchText).ToLower();

            gunaDgvCustomer.DataSource =
                BUS.Customer.Instance.Customers.Where(cus =>
                {
                    string customerName = MyConvert.ToAscii(cus.Name).ToLower();
                    string address = MyConvert.ToAscii(cus.Address).ToLower();
                    string phone = MyConvert.ToAscii(cus.PhoneNumber).ToLower();
                    string email = MyConvert.ToAscii(cus.Email).ToLower();

                    return customerName.Contains(searchText) || address.Contains(searchText)
                        || phone.Contains(searchText) || email.Contains(searchText);
                }).ToList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();

            GC.Collect();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (gunaDgvCustomer.SelectedRows.Count > 0)
            {
                DataGridViewRow row = gunaDgvCustomer.SelectedRows[0];
                int cusId = Convert.ToInt32(row.Cells[0].Value.ToString());
                int debtAmount = Convert.ToInt32(row.Cells[5].Value.ToString());


                int collectedAmount = (int)nudCollectedAmount.Value;

                bool requirement4 = BUS.Parameter.Instance.ApDungQD4.Value == 1 ? true : false;

                if (requirement4)
                {
                    if (collectedAmount > debtAmount)
                    {
                        MessageBox.Show("Số tiền thu không vượt quá nợ của khách hàng");
                        return;
                    }
                }

                if (BUS.CashReceipt.Instance.AddReceipt(cusId, dtmBillDate.Value, collectedAmount))
                {
                    MessageBox.Show("Thêm phiếu thu tiền thành công");
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn khách hàng nộp tiền");
            }

            this.Dispose();
        }

        private void gunaDgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gunaDgvCustomer.SelectedRows.Count > 0)
            {
                DataGridViewRow row = gunaDgvCustomer.SelectedRows[0];
                int debtAmount = Convert.ToInt32(row.Cells[5].Value.ToString());

                nudCollectedAmount.Maximum = debtAmount;
            }
        }
    }
}
