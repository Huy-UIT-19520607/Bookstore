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
        private string username;
        private string password;
        private int role;

        public frmMain(string username, string password, int role)
        {
            InitializeComponent();
         
            this.username = username;
            this.password = password;
            this.role = role;

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            this.ResizeBegin += (s, ev) => { this.SuspendLayout(); };
            this.ResizeEnd += (s, ev) => { this.ResumeLayout(true); };

            onCustomizeDesign();

            onOpenChildForm(new Forms.Overview.frmDashboard());
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

        private void onCustomizeDesign()
        {
            pnlSubMenuManagement.Visible = false;
            pnlSubMenuBusiness.Visible = false;
            pnlSubMenuReport.Visible = false;
            pnlSubMenuSetting.Visible = false;
        }

        private void onHideSubMenu()
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

        private void onShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                onHideSubMenu();
                subMenu.Visible = true;
            }
        }

        private Form activeForm = null;
        private void onOpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.BackColor = Color.White;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            lblSubMenuName.Text = childForm.Text; 

            pnlChildForm.Controls.Clear();
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            onOpenChildForm(new Forms.Overview.frmDashboard());
        }

        #region Management SubMenu
        private void btnMenuManagement_Click(object sender, EventArgs e)
        {
            onShowSubMenu(pnlSubMenuManagement);
        }

        private void btnGenre_Click(object sender, EventArgs e)
        {
            onOpenChildForm(new Forms.Management.Form3());
            onHideSubMenu();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            onOpenChildForm(new Forms.Management.frmTitleBook());
            onHideSubMenu();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            onOpenChildForm(new Forms.Management.frmCustomer());
            onHideSubMenu();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            onOpenChildForm(new Forms.Management.frmAccount());
            onHideSubMenu();
        }
        #endregion

        #region Business SubMenu
        private void btnMenuBusiness_Click(object sender, EventArgs e)
        {
            onShowSubMenu(pnlSubMenuBusiness);
        }

        private void btnImportBook_Click(object sender, EventArgs e)
        {
            onOpenChildForm(new Forms.Business.frmImportBook());
            onHideSubMenu();
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            onOpenChildForm(new Forms.Business.frmReceipt());
            onHideSubMenu();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            onOpenChildForm(new Forms.Business.frmBill());
            onHideSubMenu();
        }
        #endregion

        #region Report SubMenu
        private void btnMenuReport_Click(object sender, EventArgs e)
        {
            onShowSubMenu(pnlSubMenuReport);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            onOpenChildForm(new Forms.Report.frmInventory());
            onHideSubMenu();
        }

        private void btnDept_Click(object sender, EventArgs e)
        {
            onOpenChildForm(new Forms.Report.frmDebt());
            onHideSubMenu();
        }
        #endregion

        #region Setting SubMenu
        private void btnMenuSetting_Click(object sender, EventArgs e)
        {
            onShowSubMenu(pnlSubMenuSetting);
        }

        private void btnRequirement_Click(object sender, EventArgs e)
        {
            onOpenChildForm(new Forms.Setting.frmRequirement());
            onHideSubMenu();
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
