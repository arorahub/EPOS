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
    public partial class Payroll : Form
    {
        public Payroll()
        {
            InitializeComponent();
        }
        String cs = "";//enter database data source;

        private void Payroll_Load(object sender, EventArgs e)
        {
            try
            {//Adds Menu Item Names to comboBox

                //create a new sql connection using the our CS string that is holding the data source
                SqlConnection myConnection = new SqlConnection(cs);
                //sets up new SqlCommand object as myCommand with sql query
                SqlDataAdapter sda = new SqlDataAdapter("SELECT distinct Firstname FROM tblLogin", myConnection);                //Open 
                myConnection.Open();
                

                DataTable dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {

                    cboName.Items.Add(row["Firstname"].ToString());
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                ;
                //create a new sql connection using the our CS string that is holding the data source
                SqlConnection myConnection = new SqlConnection(cs);

                //sql query 
                SqlCommand myCommand = new SqlCommand("SELECT * FROM tblLogin WHERE Firstname= '" + cboName.SelectedItem + "'", myConnection);
                //data reader set up 

                SqlDataReader reader;

                try
                {
                    myConnection.Open();
                    reader = myCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        
                        txtPayRate.Text = Convert.ToString(reader["PayRate"]);


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

        private void BtnCalculatePay_Click(object sender, EventArgs e)
        {

            try
            {
                char[] dollars = { '$' };//set dollars to $ so we can remove to calculate our change due
                double payRate = Convert.ToDouble(txtPayRate.Text.TrimStart(dollars));
                double hoursWorked = Convert.ToDouble(txtHoursWorked.Text);
                double pay;

                pay = payRate * hoursWorked;

                txtPay.Text = pay.ToString("c2");
            }

            catch (Exception)
            {
                MessageBox.Show("Please enter hours worked", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            this.Close();
            main.Show();
        }
    }
}
