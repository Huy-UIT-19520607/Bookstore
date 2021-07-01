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
        private int debtMax = BUS.Parameter.Instance.SoTienNoMax.Value;

        private DTO.Bill bill;

        private DTO.Customer customer;

        public frmBill_Edit(int billId, int cusId)
        {
            InitializeComponent();

            bill = BUS.Bill.Instance.Bills.First(bill => bill.Id == billId);
            customer = BUS.Customer.Instance.Customers.First(cus => cus.Id == cusId);


        }
        private void frmBill_Edit_Load(object sender, EventArgs e)
        {
            lblDebtMax.Text = lblDebtMax.Text + " " + debtMax.ToString();

            LoadBillInfo();
        }
        private void LoadBillInfo()
        {
            this.txtBillCode.Text = bill.Id.ToString();
            this.dtmBillDate.Value = bill.CreateDate;
            this.nudTotalAmount.Value = bill.TotalPrice;
            this.nudPaidAmount.Value = bill.Payment;
            this.txtChangeAmount.Text = bill.Balance.ToString();

            this.txtCustomerCode.Text = customer.Id.ToString();
            this.txtCustomerName.Text = customer.Name;
            this.txtPhone.Text = customer.PhoneNumber;
            this.txtDebtAmount.Text = customer.Debt.ToString();

            //this.nudPaidAmount.Maximum = this.nudTotalAmount.Value;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            GC.Collect();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //int debtAmount = customer.Debt;

            if (nudTotalAmount.Value - nudPaidAmount.Value < 0)
            {
                MessageBox.Show("Số tiền thanh toán không được vượt quá tổng tiền");
                return;
            }

            if ((bill.TotalPrice - nudPaidAmount.Value) +
                (customer.Debt - bill.Balance) > debtMax)
            {
                MessageBox.Show(String.Format("Số tiền nợ mới của khách hàng đã vượt quá số tiền nợ tối đa {0}", debtMax));
                return;
            }

            if (BUS.Bill.Instance.UpdateBill(
                new DTO.Bill(bill.Id, customer.Id, dtmBillDate.Value, bill.TotalPrice, (int)nudPaidAmount.Value, Convert.ToInt32(txtChangeAmount.Text))))
            {
                MessageBox.Show("Sửa phiếu thu tiền thành công");

            }
            this.Dispose();
        }

        private void nudPaidAmount_ValueChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDebtAmount.Text))
            {
                if (nudTotalAmount.Value - nudPaidAmount.Value >= 0)
                {
                    int debt = Convert.ToInt32(txtDebtAmount.Text.ToString());

                    debt -= Convert.ToInt32(txtChangeAmount.Text);

                    txtChangeAmount.Text = (nudTotalAmount.Value - nudPaidAmount.Value).ToString();

                    debt += Convert.ToInt32(txtChangeAmount.Text);

                    txtDebtAmount.Text = debt.ToString();
                }
                else
                {
                    MessageBox.Show("Số tiền thanh toán không được vượt quá tổng tiền");
                }
            }   
        }

        
    }
}
