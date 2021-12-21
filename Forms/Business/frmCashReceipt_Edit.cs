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
    public partial class frmCashReceipt_Edit : Form
    {
        private DTO.CashReceipt cashReceipt;

        private DTO.Customer customer;

        public frmCashReceipt_Edit(int cashReceiptId, int cusId)
        {
            InitializeComponent();

            cashReceipt = BUS.CashReceipt.Instance.Receipts.First(receipt => receipt.Id == cashReceiptId);
            customer = BUS.Customer.Instance.Customers.First(cus => cus.Id == cusId);

            LoadCashReceiptInfo();
        }

        private void LoadCashReceiptInfo()
        {
            this.txtCashReceiptCode.Text = cashReceipt.Id.ToString();
            this.dtmDate.Value = cashReceipt.CreateDate;
            this.nudCollectedAmount.Value = cashReceipt.Payment;

            this.txtCustomerCode.Text = customer.Id.ToString();
            this.txtCustomerName.Text = customer.Name;
            this.txtPhone.Text = customer.PhoneNumber;
            this.txtDebtAmountBefore.Text = (customer.Debt + cashReceipt.Payment).ToString();
            this.txtDebtAmountAfter.Text = customer.Debt.ToString();

            nudCollectedAmount.Maximum = customer.Debt + cashReceipt.Payment;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            GC.Collect();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int oldDebt = cashReceipt.Payment + customer.Debt;
            int collectedAmount = (int)nudCollectedAmount.Value;

            bool requirement4 = BUS.Parameter.Instance.ApDungQD4.Value == 1 ? true : false;

            if (requirement4)
            {
                if (collectedAmount > oldDebt)
                {
                    MessageBox.Show("Số tiền thu không vượt quá số tiền nợ của khách hàng");
                    return;
                }
            }

            if (BUS.CashReceipt.Instance.UpdateReceipt(
                new DTO.CashReceipt(cashReceipt.Id, customer.Id, dtmDate.Value, collectedAmount)))
            {
                MessageBox.Show("Sửa phiếu thu tiền thành công");
            }

            this.Dispose();
        }

        private void nudCollectedAmount_ValueChanged(object sender, EventArgs e)
        {
            txtDebtAmountAfter.Text 
                = (customer.Debt + cashReceipt.Payment - (int)nudCollectedAmount.Value).ToString();
        }
    }
}
