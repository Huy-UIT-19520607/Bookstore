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
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            gunaDgvCategory.DataSource = BUS.Category.Instance.Categories;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            (new Forms.Management.frmCategory_Add()).ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gunaDgvCategory.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = gunaDgvCategory.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells[0].Value.ToString());

                (new Forms.Management.frmCategory_Edit(id)).ShowDialog();
            }
            else
            {
                MessageBox.Show("Hãy chọn thể loại muốn sửa");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gunaDgvCategory.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = gunaDgvCategory.SelectedRows[0];
                int selectedId = Convert.ToInt32(row.Cells[0].Value.ToString());
                string selectedName = row.Cells[1].Value.ToString();
                if (MessageBox.Show(String.Format("Bạn muốn xoá thể loại {0}?", selectedName), "Xoá", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    // Xóa
                    if (BUS.Title.Instance.Titles.FirstOrDefault(title => title.CategoryId == selectedId) != null)
                    {
                        MessageBox.Show("Thể loại đang được sử dụng. Không thể xoá!");
                    }
                    else if (BUS.Category.Instance.DeleteCategory(selectedId))
                    {
                        MessageBox.Show("Xóa thể loại thành công!");
                        gunaDgvCategory.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thể loại thất bại!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thể loại muốn xóa!");
            }
        }

        private void gunaTxtSearch_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnSearch;

            if (string.IsNullOrEmpty(gunaTxtSearch.Text))
            {
                gunaDgvCategory.DataSource = BUS.Category.Instance.Categories;
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
                gunaDgvCategory.DataSource = BUS.Category.Instance.Categories;
                return;
            }

            string searchText = gunaTxtSearch.Text;

            searchText = MyConvert.ToAscii(searchText).ToLower();

            gunaDgvCategory.DataSource = 
                BUS.Category.Instance.Categories.Where(cate =>
                {
                    string categoryName = MyConvert.ToAscii(cate.Name).ToLower();

                    return categoryName.Contains(searchText); 
                }).ToList();
        }
    }
}
