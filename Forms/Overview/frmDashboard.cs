using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Forms.Overview
{
    public partial class frmDashboard : Form
    {
        private int soldBookQuantity = 0;
        private int importedBookQuantity = 0;
        private int customerQuantity = 0;
        private int paidReceiptAmountPercent = 0;
        private int paidDebtAmountPercent = 0;

        public frmDashboard()
        {
            InitializeComponent();
        }

        private void ReloadFormDashboard()
        {
            soldBookQuantity = 1000;
            importedBookQuantity = 1000;
            customerQuantity = 200;
            paidReceiptAmountPercent = 80;
            paidDebtAmountPercent = 60;

            int countSoldBook = soldBookQuantity % 10;
            int countImportedBook = importedBookQuantity % 10;
            int countCustomer = customerQuantity % 10;
            int countReceiptAmountPercent = paidReceiptAmountPercent % 2;
            int countDebtAmountPercent = paidReceiptAmountPercent % 2;

            while (countSoldBook <= soldBookQuantity 
                || countImportedBook <= importedBookQuantity
                || countCustomer <= customerQuantity
                || countReceiptAmountPercent <= paidReceiptAmountPercent
                || countDebtAmountPercent <= paidDebtAmountPercent)
            {
                Thread.Sleep(1);

                if (countSoldBook <= soldBookQuantity)
                {
                    this.lblSoldBookQuantity.Text = countCustomer.ToString();
                    this.lblSoldBookQuantity.Refresh();
                }
                if (countImportedBook <= importedBookQuantity)
                {
                    this.lblImportedBookQuantity.Text = countImportedBook.ToString();
                    this.lblImportedBookQuantity.Refresh();
                }
                if (countCustomer <= customerQuantity)
                {
                    this.lblCustomerQuantity.Text = countCustomer.ToString();
                    this.lblCustomerQuantity.Refresh();
                }
                if (countCustomer <= customerQuantity)
                {
                    this.gunaCirProPayReceipt.Value = countReceiptAmountPercent;
                    this.gunaCirProPayReceipt.Update();
                }
                if (countCustomer <= customerQuantity)
                {
                    this.gunaCirProPayDebt.Value = countDebtAmountPercent;
                    this.gunaCirProPayDebt.Update();
                }

                countSoldBook += 10;
                countImportedBook += 10;
                countCustomer += 10;
                countReceiptAmountPercent += 2;
                countDebtAmountPercent += 2;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ReloadFormDashboard();
        }
    }
}
