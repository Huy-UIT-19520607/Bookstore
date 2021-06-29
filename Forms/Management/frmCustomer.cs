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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            gunaDgvCustomer.DataSource = BUS.Customer.Instance.Customers;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            (new Forms.Management.frmCustomer_Add()).ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gunaDgvCustomer.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = gunaDgvCustomer.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells[0].Value.ToString());

                (new Forms.Management.frmCustomer_Edit(id)).ShowDialog();
            }
            else
            {
                MessageBox.Show("Hãy chọn khách hàng muốn sửa");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gunaDgvCustomer.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = gunaDgvCustomer.SelectedRows[0];
                int selectedId = Convert.ToInt32(row.Cells[0].Value.ToString());
                string selectedName = row.Cells[1].Value.ToString();
                if (MessageBox.Show(String.Format("Bạn muốn xoá khách hàng {0}?", selectedName), "Xoá", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    // Xóa
                    if (BUS.Bill.Instance.Bills.FirstOrDefault(bill => bill.CustomerId == selectedId) != null ||
                        BUS.CashReceipt.Instance.Receipts.FirstOrDefault(receipt => receipt.CustomerId == selectedId) != null)
                    {
                        MessageBox.Show("Khách hàng đã đang sử adụng dịch vụ. Không thể xoá!");
                    }
                    else if (BUS.Customer.Instance.DeleteCustomer(selectedId))
                    {
                        MessageBox.Show("Xóa khách hàng thành công!");
                        gunaDgvCustomer.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Xóa khách hàng thất bại!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn khách hàng muốn xóa!");
            }
        }

        private void gunaTxtSearch_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnSearch;

            if (string.IsNullOrEmpty(gunaTxtSearch.Text))
            {
                gunaDgvCustomer.DataSource = BUS.Customer.Instance.Customers;
                return;
            }
        }

        private void gunaTxtSearch_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gunaTxtSearch.Text))
            {
                gunaDgvCustomer.DataSource = BUS.Customer.Instance.Customers;
                return;
            }

            string searchText = gunaTxtSearch.Text;

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
    }
}
