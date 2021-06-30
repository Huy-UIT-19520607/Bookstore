using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Forms.Setting
{
    public partial class frmRequirement : Form
    {
        private string message { get; set; }
        private bool isChange { get; set; }

        public frmRequirement()
        {
            InitializeComponent();

            message = "";
            isChange = false;
        }

        private void LoadData()
        {
            nudPercent.Value = BUS.Parameter.Instance.TiLeTinhDonGiaBan.Value;
            nudMinBookStoreNo.Value = BUS.Parameter.Instance.SLTonMinSauBan.Value;
            nudMaxBookStoreNo.Value = BUS.Parameter.Instance.SLTonMaxTruocNhap.Value;
            nudMinBookImportNo.Value = BUS.Parameter.Instance.SLNhapMin.Value;
            nudMaxDebt.Value = BUS.Parameter.Instance.SoTienNoMax.Value;
            gunaTsIsApply.Checked = BUS.Parameter.Instance.ApDungQD4.Value == 1 ? true : false;
        }

        private void frmRequirement_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        #region Change Data
        private void ChangePercent()
        {
            if (BUS.Parameter.Instance.TiLeTinhDonGiaBan.Value != nudPercent.Value)
            {
                if (BUS.Parameter.Instance.ChangeValue
                (
                    BUS.Parameter.Instance.TiLeTinhDonGiaBan.Name,
                    Convert.ToInt32(nudPercent.Value)
                ))
                {
                    message += "\n+ Tỉ lệ đơn giá bán";
                    isChange = true;
                }
            }
        }

        private void ChangeMinBookStoreNum()
        {
            if (BUS.Parameter.Instance.SLTonMinSauBan.Value != nudMinBookStoreNo.Value)
            {
                if (BUS.Parameter.Instance.ChangeValue
                (
                    BUS.Parameter.Instance.SLTonMinSauBan.Name,
                    Convert.ToInt32(nudMinBookStoreNo.Value)
                ))
                {
                    message += "\n+ Số lượng sách tồn tối thiểu sau bán";
                    isChange = true;
                }
            }
        }

        private void ChangeMaxBookStoreNum()
        {
            if (BUS.Parameter.Instance.SLTonMaxTruocNhap.Value != nudMaxBookStoreNo.Value)
            {
                if (BUS.Parameter.Instance.ChangeValue
                (
                    BUS.Parameter.Instance.SLTonMaxTruocNhap.Name, 
                    Convert.ToInt32(nudMaxBookStoreNo.Value)
                ))
                {
                    message += "\n+ Số lượng sách tồn tối đa trước nhập";
                    isChange = true;
                }
            }
        }

        private void ChangeMinBookImportNum()
        {
            if (BUS.Parameter.Instance.SLNhapMin.Value != nudMinBookImportNo.Value)
            {
                if (BUS.Parameter.Instance.ChangeValue(
                    BUS.Parameter.Instance.SLNhapMin.Name, 
                    Convert.ToInt32(nudMinBookImportNo.Value)
                ))
                {
                    message += "\n+ Số lượng sách nhập tối thiểu";
                    isChange = true;
                }            }
        }

        private void ChangeMaxDebt()
        {
            if (BUS.Parameter.Instance.SoTienNoMax.Value != nudMaxDebt.Value)
            {
                if (BUS.Parameter.Instance.ChangeValue
                (
                    BUS.Parameter.Instance.SoTienNoMax.Name,
                    Convert.ToInt32(nudMaxDebt.Value)
                ))
                {
                    message += "\n+ Số tiền nợ tối đa cho phép khách hàng được mua sách";
                    isChange = true;
                }
            }
        }

        private void ChangeIsApply()
        {
            int value = gunaTsIsApply.Checked ? 1 : 0;
            if (BUS.Parameter.Instance.ApDungQD4.Value != value)
            {
                if (BUS.Parameter.Instance.ChangeValue
                (
                    BUS.Parameter.Instance.ApDungQD4.Name,
                    value
                ))
                {
                    message += "\n+ Áp dụng số tiền thu không được quá số tiền khách hàng đang nợ";
                    isChange = true;
                }
            }
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            ChangePercent();
            ChangeMinBookStoreNum();
            ChangeMaxBookStoreNum();
            ChangeMinBookImportNum();
            ChangeMaxDebt();
            ChangeIsApply();

            if (isChange)
            {
                MessageBox.Show("Các quy định dưới đây đã được thay đổi:" + message, "Thông báo");
            }

            message = "";
            isChange = false;
        }
    }
}
