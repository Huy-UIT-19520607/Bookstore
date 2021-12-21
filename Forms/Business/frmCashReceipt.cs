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
    public partial class frmCashReceipt : Form
    {
        public frmCashReceipt()
        {
            InitializeComponent();
        }

        private void frmCashReceipt_Load(object sender, EventArgs e)
        {
            gunaDgvCashReceipt.DataSource = BUS.CashReceipt.Instance.Receipts;
            gunaDgvCustomer.DataSource = BUS.Customer.Instance.Customers;
        }

        private void btnFilterCustomer_Click(object sender, EventArgs e)
        {
            if (gunaDgvCashReceipt.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = gunaDgvCashReceipt.SelectedRows[0];
                int cusId = Convert.ToInt32(row.Cells[1].Value.ToString());

                gunaDgvCustomer.DataSource =
                    BUS.Customer.Instance.Customers.Where(cus => cus.Id == cusId).ToList();
            }
            else
            {
                MessageBox.Show("Hãy lựa chọn phiếu thu tiền cần lọc thông tin");
            }
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
            this.AcceptButton = null;
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

        private void btnAddCashReceipt_Click(object sender, EventArgs e)
        {
            (new Forms.Business.frmCashReceipt_Add()).ShowDialog();
        }

        private void btnEditCashReceipt_Click(object sender, EventArgs e)
        {
            if (gunaDgvCashReceipt.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = gunaDgvCashReceipt.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                int cusId = Convert.ToInt32(row.Cells[1].Value.ToString());

                (new Forms.Business.frmCashReceipt_Edit(id, cusId)).ShowDialog();
            }
            else
            {
                MessageBox.Show("Hãy phiếu thu tiền muốn sửa");
            }
        }

        private void btnDeleteCashReceipt_Click(object sender, EventArgs e)
        {
            if (gunaDgvCashReceipt.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = gunaDgvCashReceipt.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                int cusId = Convert.ToInt32(row.Cells[1].Value.ToString());

                if (BUS.CashReceipt.Instance.DeleteReceipt(id))
                {
                    MessageBox.Show("Xoá phiếu thu tiền thành công!");
                }
                else
                {
                    MessageBox.Show("Xoá phiếu thu tiền thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Hãy phiếu thu tiền muốn xoá");
            }
        }
    }
}
