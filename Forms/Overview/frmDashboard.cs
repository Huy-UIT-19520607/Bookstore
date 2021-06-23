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
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            while (a <= 80 || b <= 1000)
            {
                Thread.Sleep(1);
                gunaCirProPayReceipt.Value = a;
                gunaCirProPayReceipt.Update();

                lblCustomerQuantity.Text = b.ToString();
                lblCustomerQuantity.Refresh();

                if (a <= 80) a++;
                b += 10;
            }
        }
    }
}
