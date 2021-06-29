using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Forms
{
    public partial class frmMain : Form
    {

        private DTO.Account loginAcc;

        private Button currentButton;

        private Forms.Overview.frmDashboard dashboardForm;

        private Forms.Management.frmCategory categoryForm;
        private Forms.Management.frmBook bookForm;
        private Forms.Management.frmCustomer customerForm;
        private Forms.Management.frmAccount accountForm;

        private Forms.Business.frmBookReceipt bookReceiptForm;
        private Forms.Business.frmBill billForm;
        private Forms.Business.frmCashReceipt cashReceiptForm;

        private Forms.Report.frmInventory inventoryForm;
        private Forms.Report.frmDebt debtForm;

        private Forms.Setting.frmRequirement requirementForm;


        public frmMain(string username)
        {
            InitializeComponent();

            loginAcc = BUS.Account.Instance.Accounts.First(acc => acc.Username == username);

            dashboardForm = new Overview.frmDashboard();

            categoryForm = new Management.frmCategory();
            bookForm = new Management.frmBook();
            customerForm = new Management.frmCustomer();
            accountForm = new Management.frmAccount(loginAcc.Username);

            bookReceiptForm = new Business.frmBookReceipt();
            billForm = new Business.frmBill();
            cashReceiptForm = new Business.frmCashReceipt();

            inventoryForm = new Report.frmInventory();
            debtForm = new Report.frmDebt();

            requirementForm = new Setting.frmRequirement();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            this.ResizeBegin += (s, ev) => { this.SuspendLayout(); };
            this.ResizeEnd += (s, ev) => { this.ResumeLayout(true); };

            CustomizeDesign();

            OpenChildForm(dashboardForm, sender);
            pnlTopBar.BackColor = Color.Black;
        }

        #region Drag Control
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

            GC.Collect();
        }
        #endregion

        private void CustomizeDesign()
        {
            pnlSubMenuManagement.Visible = false;
            pnlSubMenuBusiness.Visible = false;
            pnlSubMenuReport.Visible = false;
            pnlSubMenuSetting.Visible = false;

            lblDisplayName.Text = loginAcc.DisplayName;
            lblPermission.Text = (loginAcc.Permission == 0 ? "Quản trị viên" : "Nhân viên"); 
        }

        private void HideSubMenu()
        {
            if (pnlSubMenuManagement.Visible == true)
                pnlSubMenuManagement.Visible = false;
            if (pnlSubMenuBusiness.Visible == true)
                pnlSubMenuBusiness.Visible = false;
            if (pnlSubMenuReport.Visible == true)
                pnlSubMenuReport.Visible = false;
            if (pnlSubMenuSetting.Visible == true)
                pnlSubMenuSetting.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
        }

        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.OrangeRed;
                }
            }
        } 

        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(0, 71, 180);
            }

            GC.Collect();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            pnlChildForm.Controls.Clear();

            if (btnSender.GetType() == typeof(Button))
            {
                ActiveButton(btnSender);
            }

            childForm.BackColor = Color.White;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            lblSubMenuName.Text = childForm.Text;
            pnlTopBar.BackColor = Color.Firebrick;
            
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            OpenChildForm(dashboardForm, sender);
            pnlTopBar.BackColor = Color.Black;
            DisableButton();
            HideSubMenu();
        }

        #region Management SubMenu
        private void btnMenuManagement_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenuManagement);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(categoryForm, sender);
            ShowSubMenu(pnlSubMenuManagement);
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            OpenChildForm(bookForm, sender);
            ShowSubMenu(pnlSubMenuManagement);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(customerForm, sender);
            ShowSubMenu(pnlSubMenuManagement);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            OpenChildForm(accountForm, sender);
            ShowSubMenu(pnlSubMenuManagement);
        }
        #endregion

        #region Business SubMenu
        private void btnMenuBusiness_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenuBusiness);
        }

        private void btnBookReceipt_Click(object sender, EventArgs e)
        {
            OpenChildForm(bookReceiptForm, sender);
            ShowSubMenu(pnlSubMenuBusiness);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            OpenChildForm(billForm, sender);
            ShowSubMenu(pnlSubMenuBusiness);
        }

        private void btnCashReceipt_Click(object sender, EventArgs e)
        {
            OpenChildForm(cashReceiptForm, sender);
            ShowSubMenu(pnlSubMenuBusiness);
        }
        
        #endregion

        #region Report SubMenu
        private void btnMenuReport_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenuReport);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            OpenChildForm(inventoryForm, sender);
            ShowSubMenu(pnlSubMenuReport);
        }

        private void btnDebt_Click(object sender, EventArgs e)
        {
            OpenChildForm(debtForm, sender);
            ShowSubMenu(pnlSubMenuReport);
        }
        
        #endregion

        #region Setting SubMenu
        private void btnMenuSetting_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenuSetting);
        }

        private void btnRequirement_Click(object sender, EventArgs e)
        {
            OpenChildForm(requirementForm, sender);
            ShowSubMenu(pnlSubMenuSetting);
        }
        #endregion

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tmrCurrentTime_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

    }
}
