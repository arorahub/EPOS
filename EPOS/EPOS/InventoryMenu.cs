using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPOS
{
    public partial class InventoryMenu : Form
    {
        //captures the sql data source in a string
        String cs = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kan\source\repos\EPOS\DB\EPOS_DB.mdf;Integrated Security=True;Connect Timeout=30";
        public InventoryMenu()
        {
            InitializeComponent();


        }


        private void InventoryMenu_Load(object sender, EventArgs e)
        {
            //Both Panels are hiden when system starts 
            pnlViewInventory.Visible = false;
            pnlUpdateInventory.Visible = false;
        }

        private void BtnInventoryMenuView_Click(object sender, EventArgs e)
        {
            //Once the View Menu button is clicked, the Inventory view panel will be visible 
            pnlViewInventory.Visible = true;
            pnlUpdateInventory.Visible = false;

        }

        private void BtnInventoryUpdate_Click(object sender, EventArgs e)
        {
            //Once the Update Inventory button is clicked, the Update Inventory panel will be visible 
            //and the view inventory panel will be hidden
            pnlViewInventory.Visible = false;
            pnlUpdateInventory.Visible = true;
        }

        private void BtnInventoryMainmenu_Click(object sender, EventArgs e)
        {
            //Close this form and open main menu
            MainMenu mainMenu = new MainMenu();
            this.Close();
            mainMenu.Show();
        }

        private void btnUpdateInventoryAddNewItem_Click(object sender, EventArgs e)
        {
            //checks to see if text boxes are filled 
            if (txtUpdateInventoryName.Text == "")
            {
                MessageBox.Show("Please enter Item Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateInventoryName.Focus();
                return;


            }
            //checks to see if text boxes are filled 
            if (txtUpdateInventoryPriceToBiz.Text == "")
            {
                MessageBox.Show("Please enter Item Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateInventoryPriceToBiz.Focus();
                return;


            }
            //checks to see if text boxes are filled 
            if (txtUpdateInventoryPrice.Text == "")
            {
                MessageBox.Show("Please enter Item Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateInventoryPrice.Focus();
                return;


            }
            

            try
            {//Add new Item to Inventory 

                //create a new sql connection using the our CS string that is holding the data source
                SqlConnection myConnection = new SqlConnection(cs);
                //sets up new SqlCommand object as myCommand with sql query
                SqlCommand myCommand = new SqlCommand("INSERT INTO tblInventory (MenuItemName,MenuItemCostToBiz,MenuItemPrice) VALUES(@MenuItemName,@MenuItemCostToBiz,@MenuItemPrice)", myConnection);

                //set up sql parameters
                SqlParameter menuItemName = new SqlParameter("@MenuItemName", SqlDbType.VarChar);
                SqlParameter menuItemCostToBiz = new SqlParameter("@MenuItemCostToBiz", SqlDbType.NVarChar);
                SqlParameter menuItemPrice = new SqlParameter("@MenuItemPrice", SqlDbType.NVarChar);
                


                //grab info from textbox
                menuItemName.Value = txtUpdateInventoryName.Text.Trim();
                menuItemCostToBiz.Value = txtUpdateInventoryPriceToBiz.Text.Trim();
                menuItemPrice.Value = txtUpdateInventoryPrice.Text.Trim();
                
                //takes sql command adds sql parameters and then adds to DB
                myCommand.Parameters.Add(menuItemName);
                myCommand.Parameters.Add(menuItemCostToBiz);
                myCommand.Parameters.Add(menuItemPrice);
                
                //open sql connection 
                myCommand.Connection.Open();

                //Execute sql query
                myCommand.ExecuteNonQuery();

                //new item has been added to DB
                MessageBox.Show(" New Item has been added! ");
                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void BtnInventoryMenuViewReport_Click(object sender, EventArgs e)
        {
            try
            {
                
                //create a new sql connection using the our CS string that is holding the data source
                System.Data.SqlClient.SqlConnection myConnection = new SqlConnection(cs);
                //sets up new SqlCommand object as myCommand with sql query
                SqlCommand myCommand = new SqlCommand("SELECT * FROM tblInventory", myConnection);
                //Open 
                myConnection.Open();
                //display inventory tbl data in grid view
                SqlDataAdapter sqlData = new SqlDataAdapter();
                sqlData.SelectCommand = myCommand;
                DataTable dataTable = new DataTable();
                sqlData.Fill(dataTable);
                BindingSource bindingSource = new BindingSource();

                bindingSource.DataSource = dataTable;
                dgvInventoryMenuItemView.DataSource = bindingSource;
                sqlData.Update(dataTable);
             
            }




            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}
