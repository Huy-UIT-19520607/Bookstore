using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Forms.Management
{
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();

        }


        private void LoadAccountData()
        {
            //this.gunaDgvAccount.DataSource = BUS.Account.Instance.GetListAccount();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            //LoadAccountData();
            this.gunaDgvAccount.DataSource = BUS.Account.Instance.Accounts;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            (new Forms.Management.frmAccount_Add()).ShowDialog();
            //LoadAccountData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            (new Forms.Management.frmAccount_Edit()).ShowDialog();
            //LoadAccountData();
        }

        private void gunaDgvAccount_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (!chkHideShowPassword.Checked)
            {
                if (e.ColumnIndex == 2 && e.Value != null)
                {
                    e.Value = new String('●', e.Value.ToString().Length);
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

        private void chkHideShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            //LoadAccountData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gunaDgvAccount.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = gunaDgvAccount.SelectedRows[0];
                string username = row.Cells[0].Value.ToString();

                // Xóa
                if (BUS.Account.Instance.DeleteAccount(username))
                {
                    MessageBox.Show("Xóa tài khoản thành công");
                    //LoadAccountData();
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản thất bại");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn tài khoản muốn xóa");
            }
        }
    }
}
