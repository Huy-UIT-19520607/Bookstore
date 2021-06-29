using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Forms.Management
{
    public partial class frmAccount : Form
    {
        private string usernameLogin;

        public frmAccount(string username)
        {
            InitializeComponent();

            this.usernameLogin = username;
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            this.gunaDgvAccount.DataSource = BUS.Account.Instance.Accounts;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            (new Forms.Management.frmAccount_Add()).ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gunaDgvAccount.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = gunaDgvAccount.SelectedRows[0];
                string username = row.Cells[0].Value.ToString();
                
                var selectedUsername = BUS.Account.Instance.Accounts.First(acc => acc.Username == username).Username;

                (new Forms.Management.frmAccount_Edit(selectedUsername)).ShowDialog();
            }
            else
            {
                MessageBox.Show("Hãy chọn tài khoản muốn sửa");
            }
            
        }

        private string usernameCell { get; set; }

        private void gunaDgvAccount_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.Value != null)
            {
                usernameCell = e.Value.ToString();
            }

            if (e.ColumnIndex == 2 && e.Value != null)
            {
                if (!chkHideShowPassword.Checked)
                {
                    e.Value = new String('●', e.Value.ToString().Length);
                }
                else
                {
                    e.Value = BUS.Account.Instance.Accounts.First(acc => acc.Username == usernameCell).Password;
                }
            }
            
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                switch (e.Value)
                {
                    case 0:
                        e.Value = "Quản trị viên";
                        break;
                    case 1:
                        e.Value = "Nhân viên";
                        break;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gunaDgvAccount.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = gunaDgvAccount.SelectedRows[0];
                string selectedUsername = row.Cells[0].Value.ToString();

                if (MessageBox.Show(String.Format("Bạn muốn xoá tài khoản {0}?", selectedUsername), "Xoá", MessageBoxButtons.OKCancel, 
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    // Xóa
                    if (selectedUsername == usernameLogin)
                    {
                        MessageBox.Show("Tài khoản đang được sử dụng. Không thể xoá!");
                    }    
                    else if (BUS.Account.Instance.DeleteAccount(selectedUsername))
                    {
                        MessageBox.Show("Xóa tài khoản thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa tài khoản thất bại!");
                    }
                } 
            }
            else
            {
                MessageBox.Show("Hãy chọn tài khoản muốn xóa!");
            }
        }

        private void chkHideShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            gunaDgvAccount.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gunaTxtSearch.Text))
            {
                gunaDgvAccount.DataSource = BUS.Account.Instance.Accounts;
                return;
            }

            string searchText = gunaTxtSearch.Text;
            
            searchText = MyConvert.ToAscii(searchText).ToLower();

            gunaDgvAccount.DataSource = 
                BUS.Account.Instance.Accounts.Where(account =>
                {
                    string username = MyConvert.ToAscii(account.Username).ToLower();
                    string displayname = MyConvert.ToAscii(account.DisplayName).ToLower();

                    return username.Contains(searchText) || displayname.Contains(searchText);
                }).ToList();
        }

        private void gunaTxtSearch_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnSearch;

            if (string.IsNullOrEmpty(gunaTxtSearch.Text))
            {
                gunaDgvAccount.DataSource = BUS.Account.Instance.Accounts;
                return;
            }
        }

        private void gunaTxtSearch_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }
    }
}
