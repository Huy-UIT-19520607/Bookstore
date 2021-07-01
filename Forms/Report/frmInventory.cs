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
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }

        #region Search
        private void gunaDgvBook_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = null;
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
                    string publisher = MyConvert.ToAscii(book.Publisher).ToLower();

                    string publishYearString = book.PublishYear.ToString();

                    return publisher.Contains(searchText) 
                    || publishYearString.Contains(searchText);
                }).ToList();
        }

        private void gunaDgvBook_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.Value != null)
            {
                e.Value = BUS.Title.Instance.Titles.First(
                    title => title.Id == Convert.ToInt32(e.Value)).Name;
            }
        }
        #endregion

        private void frmInventory_Load(object sender, EventArgs e)
        {
            //nudMonth.Maximum = DateTime.Now.Month != 1 ? 
            //    DateTime.Now.Month - 1 : 12;
            //nudPublishingYear.Maximum = nudMonth.Maximum == 12 ? 
            //    DateTime.Now.Year - 1 : DateTime.Now.Year;

            //nudMonth.Value = nudMonth.Maximum;
            
            gunaDgvBook.DataSource = BUS.Book.Instance.Books;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            gunaDgvAccount.DataSource = BUS.InventoryReport.Instance.Reports.Where(reprt =>
                reprt.Month == (int)nudMonth.Value &&
                reprt.Year == (int)nudPublishingYear.Value
            ).ToList();
        }

        private void gunaDgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCancelFilter.Enabled = true;

            gunaDgvAccount.DataSource = BUS.InventoryReport.Instance.Reports.Where(report =>
                report.BookId == (int)gunaDgvBook.SelectedRows[0].Cells[0].Value &&
                report.Month == (int)nudMonth.Value &&
                report.Year == (int)nudPublishingYear.Value
            ).ToList();
        }

        private void gunaDgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCancelFilter.Enabled = true;

            gunaDgvBook.DataSource = BUS.Book.Instance.Books.Where(book =>
                book.Id == (int)gunaDgvAccount.SelectedRows[0].Cells["MaSach1"].Value
            ).ToList();
        }

        private void btnCancelFilter_Click(object sender, EventArgs e)
        {
            btnCancelFilter.Enabled = false;

            gunaDgvBook.DataSource = BUS.Book.Instance.Books;
            gunaDgvAccount.DataSource = BUS.InventoryReport.Instance.Reports.Where(reprt =>
                reprt.Month == (int)nudMonth.Value &&
                reprt.Year == (int)nudPublishingYear.Value
            ).ToList();
        }
    }
}
