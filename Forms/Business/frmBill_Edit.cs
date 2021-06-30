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
    public partial class frmBill_Edit : Form
    {
        

        private DTO.Bill bill;

        private DTO.Customer customer;

        public frmBill_Edit(int billId, int cusId)
        {
            InitializeComponent();

            bill = BUS.Bill.Instance.Bills.First(bill => bill.Id == billId);
            customer = BUS.Customer.Instance.Customers.First(cus => cus.Id == cusId);

            LoadBillInfo();
        }

        private void LoadBillInfo()
        {
            this.txtBillCode.Text = bill.Id.ToString();
            this.dtmBillDate.Value = bill.CreateDate;
            this.nudTotalAmount.Value = bill.TotalPrice;
            this.nudPaidAmount.Value = bill.Payment;
            this.nudChangeAmount.Value = bill.Balance;

            this.txtCustomerCode.Text = customer.Id.ToString();
            this.txtCustomerName.Text = customer.Name;
            this.txtPhone.Text = customer.PhoneNumber;
            this.txtDebtAmount.Text = customer.Debt.ToString();

            this.nudPaidAmount.Maximum = this.nudTotalAmount.Value;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            GC.Collect();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int debtAmount = customer.Debt;

            int debtMax = BUS.Parameter.Instance.SoTienNoMax.Value;

            if (nudTotalAmount.Value - nudPaidAmount.Value < 0)
            {
                MessageBox.Show("Số tiền thanh toán không được vượt quá tổng tiền");
                return;
            }

            if ((bill.TotalPrice - nudPaidAmount.Value) + customer.Debt > debtMax)
            {
                MessageBox.Show(String.Format("Số tiền nợ mới của khách hàng đã vượt quá số tiền nợ tối đa {0}", debtMax));
                return;
            }

            if (BUS.Bill.Instance.UpdateBill(
                new DTO.Bill(bill.Id, customer.Id, dtmBillDate.Value, bill.TotalPrice, (int)nudPaidAmount.Value, (int)nudChangeAmount.Value)))
            {
                MessageBox.Show("Sửa phiếu thu tiền thành công");
            }

            this.Dispose();
        }

        private void nudPaidAmount_ValueChanged(object sender, EventArgs e)
        {
            if (nudTotalAmount.Value - nudPaidAmount.Value >= 0)
            {
                nudChangeAmount.Value = nudTotalAmount.Value - nudPaidAmount.Value;
            }
            else
            {
                MessageBox.Show("Số tiền thanh toán không được vượt quá tổng tiền");
            }
        }
    }
}
