using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPOS
{
    public partial class frmOrderScreen : Form
    {
        //sql connection
        String cs = "";//enter database data source;
        public frmOrderScreen()
        {
            InitializeComponent();
        }

        private void FrmOrderScreen_Load(object sender, EventArgs e)
        {
            try
            {//Adds Menu Item Names to comboBox

                //create a new sql connection using the our CS string that is holding the data source
                SqlConnection myConnection = new SqlConnection(cs);
                //sets up new SqlCommand object as myCommand with sql query
                SqlDataAdapter sda = new SqlDataAdapter("SELECT MenuItemName,MenuItemPrice FROM tblInventory", myConnection);                //Open 
                myConnection.Open();
                //display inventory tbl data in grid view

                DataTable dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    
                    cboMenuItems.Items.Add(row["MenuItemName"].ToString());
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {//Fills dataGrid

                //create a new sql connection using the our CS string that is holding the data source
                System.Data.SqlClient.SqlConnection myConnection = new SqlConnection(cs);
                //sets up new SqlCommand object as myCommand with sql query
                SqlCommand myCommand = new SqlCommand("SELECT  MenuItemName,MenuItemPrice FROM tblInventory", myConnection);
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
        private void CboMenuItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                ;
                //create a new sql connection using the our CS string that is holding the data source
                SqlConnection myConnection = new SqlConnection(cs);

                //sql query 
                SqlCommand myCommand = new SqlCommand("SELECT MenuItemName, MenuItemPrice FROM tblInventory WHERE MenuItemName= '" + cboMenuItems.SelectedItem + "'", myConnection);
                //data reader set up 

                SqlDataReader reader;

                try
                {
                    myConnection.Open();
                    reader = myCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        
                        txtItemPrice.Text = Convert.ToString(reader["MenuItemPrice"]);


                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddItem_Click(object sender, EventArgs e)
        {

            if (txtItemPrice.Text == "")
            {
                //checks if item price is entered
                MessageBox.Show("Please enter Item Price");

            }
            else
            {
                //Adds Item name and price to list view 
                ListViewItem item = new ListViewItem(cboMenuItems.Text);
                item.SubItems.Add(txtItemPrice.Text);
                lstvReceipt.Items.Add(item);
            }


        }

        private void BtnOrderCompleted_Click(object sender, EventArgs e)
        {//Adds total for Items.
            char[] dollars = { '$' };//set dollars to $ to clean up price
            double price = 0; //price before tax
            double tax = 0; //tax
            double total = 0; //price + tax
           

            foreach (ListViewItem item in lstvReceipt.Items)
            {
                //adds up all prices in listview 
                price += Convert.ToDouble(item.SubItems[1].Text.TrimStart(dollars));

            }

            
            tax = price * .075;
            total = price + tax;

            //"ToString("c") formats text in to currency 
            txtTotalBforTax.Text = price.ToString("c");
            txtOrderTax.Text = tax.ToString("c");
            txtOrderTotal.Text = total.ToString("c");



        }



        private void btnOrderCheckOut_Click(object sender, EventArgs e)
        {//This button generates the change ammount due and it also updates the sales DB
            if (txtOrderAmmountPaid.Text == "")
            {
                //checks if item price is entered
                MessageBox.Show("Please enter Amount Paid");


            }
            else
            {
                try
                {
                    char[] dollars = { '$' };//set dollars to $ so we can remove to calculate our change due
                    double amtPaid = Convert.ToDouble(txtOrderAmmountPaid.Text.TrimStart(dollars));
                    double changeDue = 0;
                    double total = Convert.ToDouble(txtOrderTotal.Text.TrimStart(dollars));

                    changeDue = amtPaid - total;

                    txtOrderChange.Text = changeDue.ToString("c2");
                }

                catch (Exception)
                {
                    MessageBox.Show("Please enter ammount paid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {


                    String path = @"C:\Users\Kan\source\repos\EPOS\Receipts\receipt.txt";


                    string[] lines = { "Date: " + dateTimePicker1.Value, "Order Total: " + txtOrderTotal.Text, "Amount Paid: " + txtOrderAmmountPaid.Text, "Change" + txtOrderChange.Text };
                    System.IO.File.WriteAllLines(path, lines);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {//Adds sale to DB

                    //create a new sql connection using the our CS string that is holding the data source
                    SqlConnection myConnection = new SqlConnection(cs);
                    //sets up new SqlCommand object as myCommand with sql query
                    SqlCommand myCommand = new SqlCommand("INSERT INTO tblSales (OrderDate,OrderTotal) VALUES(@OrderDate,@OrderTotal)", myConnection);

                    //set up sql parameters
                    SqlParameter orderDate = new SqlParameter("@OrderDate", SqlDbType.Date);
                    SqlParameter orderTotal = new SqlParameter("@OrderTotal", SqlDbType.NVarChar);


                    //grab info from textbox

                    orderDate.Value = dateTimePicker1.Value;
                    orderTotal.Value = txtOrderTotal.Text.Trim();

                    //takes sql command adds sql parameters and then adds to DB

                    myCommand.Parameters.Add(orderDate);
                    myCommand.Parameters.Add(orderTotal);

                    //open sql connection 
                    myCommand.Connection.Open();

                    //Execute sql query
                    myCommand.ExecuteNonQuery();

                    //new sale has been added to DB
                    MessageBox.Show("Thank you");

                    //close
                    myConnection.Close();

                    //clean up 
                    lstvReceipt.Items.Clear();
                    txtItemPrice.Clear();
                    txtTotalBforTax.Clear();
                    txtOrderAmmountPaid.Clear();
                    txtOrderTax.Clear();
                    txtOrderTotal.Clear();
                    txtOrderChange.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
        }

        private void BtnOrderRemoveItem_Click(object sender, EventArgs e)
        {
            //click on item in listbox to remove it
            foreach (ListViewItem eachItem in lstvReceipt.SelectedItems)
            {
                lstvReceipt.Items.Remove(eachItem);
            }
        }

        private void BtnOrderNewOrder_Click(object sender, EventArgs e)
        {
            //clears all text in textbox when clicked
            lstvReceipt.Items.Clear();
            txtItemPrice.Clear();
            txtTotalBforTax.Clear();
            txtOrderAmmountPaid.Clear();
            txtOrderTax.Clear();
            txtOrderTotal.Clear();
            txtOrderChange.Clear();


        }

        private void BtnOrderBackToMenu_Click(object sender, EventArgs e)
        {
            //back to main menu
            MainMenu mainMenu = new MainMenu();
            this.Close();
            mainMenu.Show();
        }

       
    }
}
    

