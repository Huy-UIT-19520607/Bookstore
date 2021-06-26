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

            LoadAccountList();
        }

        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.Value != null)
            {
                if (chkHideShowPassword.Checked == false)
                    e.Value = new String('●', e.Value.ToString().Length);
                else
                    e.Value = e.Value;
                
            }
        }

        void LoadAccountList()
        {
            string connectionSTR = @"Data Source=DESKTOP-O9Q211T;Initial Catalog=QuanLyNhaSach;Persist Security Info=True;User ID=sa;Password=Huy123456";
            SqlConnection connection = new SqlConnection(connectionSTR);

            string query = @"SELECT * from TAIKHOAN";

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);

            connection.Close();

            gunaDgvAccount.DataSource = data;
        }
    }
}
