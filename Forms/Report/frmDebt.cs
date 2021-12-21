using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Forms.Report
{
    public partial class frmDebt : Form
    {
        public frmDebt()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            gunaDgvAccount.DataSource = BUS.DebtReport.Instance.Reports.Where(reprt =>
                reprt.Month == (int)nudMonth.Value &&
                reprt.Year == (int)nudPublishingYear.Value
            ).ToList();
        }

        private void frmDebt_Load(object sender, EventArgs e)
        {
            nudMonth.Maximum = DateTime.Now.Month != 1 ?
                DateTime.Now.Month : 12;
            nudPublishingYear.Maximum = nudMonth.Maximum == 12 ?
                DateTime.Now.Year - 1 : DateTime.Now.Year;

            nudMonth.Value = nudMonth.Maximum;

            gunaDgvCustomer.DataSource = BUS.Customer.Instance.Customers;
        }

        #region Search
        private void gunaTxtSearch_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnSearch;

            if (string.IsNullOrEmpty(gunaTxtSearch.Text))
            {
                gunaDgvCustomer.DataSource = BUS.Customer.Instance.Customers;
                return;
            }
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

        private void gunaTxtSearch_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }
        #endregion

        private void gunaDgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCancelFilter.Enabled = true;

            gunaDgvCustomer.DataSource = BUS.Customer.Instance.Customers.Where(customer =>
                customer.Id == (int)gunaDgvAccount.SelectedRows[0].Cells["MaKhachHang1"].Value
            ).ToList();
        }

        private void gunaDgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCancelFilter.Enabled = true;

            gunaDgvAccount.DataSource = BUS.DebtReport.Instance.Reports.Where(report =>
                report.CustomerId == (int)gunaDgvCustomer.SelectedRows[0].Cells["MaKhachHang"].Value
                && report.Month == (int)nudMonth.Value
                && report.Year == (int)nudPublishingYear.Value
            ).ToList();
        }

        private void btnCancelFilter_Click(object sender, EventArgs e)
        {
            btnCancelFilter.Enabled = false;

            gunaDgvCustomer.DataSource = BUS.Customer.Instance.Customers;
            gunaDgvAccount.DataSource = BUS.DebtReport.Instance.Reports.Where(reprt =>
                reprt.Month == (int)nudMonth.Value &&
                reprt.Year == (int)nudPublishingYear.Value
            ).ToList();
        }
    }
}
