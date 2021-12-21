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
    public partial class frmBook_AddTitleBook : Form
    {
        private string errMsg = "";

        public frmBook_AddTitleBook()
        {
            InitializeComponent();

            ResetErrorMessage();
        }

        private void frmBook_AddTitleBook_Load(object sender, EventArgs e)
        {
            cboCategory.ValueMember = "Id";
            cboCategory.DisplayMember = "Name";
            cboCategory.DataSource = BUS.Category.Instance.Categories;
        }

        private void ResetErrorMessage()
        {
            this.lblTitleBookNameError.Text = "";
            this.lblAuthorNameError.Text = "";

            this.txtTitleBookName.Text = "";
            this.txtAuthorName.Text = "";

            this.errBook_AddTitleBook.Clear();
            GC.Collect();
        }
        private void CancelValidatedEvent(Control control, Label error, CancelEventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
            e.Cancel = true;
            errBook_AddTitleBook.SetError(control, errMsg);
            error.Text = errMsg;
        }

        private void txtTitleBookName_Validating(object sender, CancelEventArgs e)
        {
            if (txtTitleBookName.Text == "")
            {
                errMsg = "Hãy điền tên đầu sách";
                CancelValidatedEvent(txtTitleBookName, lblTitleBookNameError, e);
                return;
            }
            if (!ValidateInput.ValidOnlyLetterAndNumber(txtTitleBookName.Text, out errMsg))
            {
                CancelValidatedEvent(txtTitleBookName, lblTitleBookNameError, e);
            }
        }

        private void txtTitleBookName_Validated(object sender, EventArgs e)
        {
            this.errBook_AddTitleBook.SetError(txtTitleBookName, "");
            this.lblTitleBookNameError.Text = "";
        }

        private void txtAuthorName_Validating(object sender, CancelEventArgs e)
        {
            if (txtAuthorName.Text == "")
            {
                errMsg = "Hãy điền tên tác giả";
                CancelValidatedEvent(txtAuthorName, lblAuthorNameError, e);
                return;
            }
            if (!ValidateInput.ValidOnlyLetter(txtAuthorName.Text, out errMsg))
            {
                CancelValidatedEvent(txtAuthorName, lblAuthorNameError, e);
            }
        }

        private void txtAuthorName_Validated(object sender, EventArgs e)
        {
            this.errBook_AddTitleBook.SetError(txtAuthorName, "");
            this.lblAuthorNameError.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();

            GC.Collect();
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            if (lblAuthorNameError.Text.Length == 0)
            {
                foreach (DataGridViewRow item in this.gunaDgvAuthor.Rows)
                {
                    if (item.Cells[0].Value.ToString() == txtAuthorName.Text.Trim())
                        return;
                }
                gunaDgvAuthor.Rows.Add(txtAuthorName.Text.Trim());
            }
        }

        private void btnDeleteList_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.gunaDgvAuthor.SelectedRows)
            {
                gunaDgvAuthor.Rows.RemoveAt(item.Index);
            }
        }

        private void btnStopAddList_Click(object sender, EventArgs e)
        {
            if (gunaDgvAuthor.Rows.Count > 0)
            {
                txtAuthorName.Enabled = false;
            }
            else
            {
                MessageBox.Show("Hãy thêm tác giả!");
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtAuthorName.Enabled == true)
            {
                MessageBox.Show("Hãy chốt danh sách tác giả!");
                return;
            }

            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

            int categoryId = BUS.Category.Instance.Categories.First(cate => cate.Name == cboCategory.Text).Id;

            if (BUS.Title.Instance.Titles.FirstOrDefault(title => 
                title.Name == txtTitleBookName.Text.Trim() && title.CategoryId == categoryId) != null)
            {
                MessageBox.Show("Đầu sách này đã tồn tại!");
                return;
            }

            if (BUS.Title.Instance.AddTitle(txtTitleBookName.Text.Trim(), categoryId))
            {
                int newTitleId = BUS.Title.Instance.Titles.First(title =>
                            title.Name == txtTitleBookName.Text.Trim() && title.CategoryId == categoryId).Id;

                foreach (DataGridViewRow item in this.gunaDgvAuthor.Rows)
                {
                    if (!BUS.Author.Instance.AddAuthor(newTitleId, item.Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("Thêm tác giả gặp gián đoạn.");
                    }
                }

                MessageBox.Show("Thêm đầu sách mới thành công");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thêm đầu sách mới thất bại");
            }
        }

        
    }
}
