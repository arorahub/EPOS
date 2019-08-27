using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPOS
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void BtnMainMenuLogout_Click(object sender, EventArgs e)
        {
            //Go back to login screen
            frmMainLogin frm = new frmMainLogin();
            this.Close();
            frm.Show();
        }

     

        private void BtnMainMenuInventory_Click(object sender, EventArgs e)
        {
            //Opens up Inventory Menu
            InventoryMenu inventoryMenu = new InventoryMenu();
            this.Close();
            inventoryMenu.Show();
            
        }

        private void BtnMainMenuTakeOrder_Click(object sender, EventArgs e)
        {
            //Opens New Order Menu
            frmOrderScreen frmOrder = new frmOrderScreen();
            this.Close();
            frmOrder.Show();
        }

        private void btnMailMenuEmail_Click(object sender, EventArgs e)
        {
            //Open Email tool
            Email email = new Email();
            this.Close();
            email.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Payroll payroll = new Payroll();
            this.Close();
            payroll.Show();
        }
    }
}
