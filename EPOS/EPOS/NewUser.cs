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


    public partial class frmNewUser : Form
    {

        //captures the sql data source in a string
        String cs = "";//enter database data source;
        public frmNewUser()
        {
            InitializeComponent();
        }



        private void FrmNewUser_Load(object sender, EventArgs e)
        {

        }

        private void BtnNewUser_Click(object sender, EventArgs e)
        {
            //checks to see if text boxes are filled 
            if (txtNewFirstName.Text == "")
            {
                MessageBox.Show("Please enter First Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewFirstName.Focus();
                return;


            }
            if (txtNewLastName.Text == "")
            {
                MessageBox.Show("Please enter Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewLastName.Focus();
                return;


            }
            if (txtNewPass.Text == "")
            {
                MessageBox.Show("Please enter User Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewPass.Focus();
                return;


            }
            if (txtPayRate.Text == "")
            {
                MessageBox.Show("Please enter Payrate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPayRate.Focus();
                return;


            }
            if (txtRole.Text == "")
            {
                MessageBox.Show("Please enter User Role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRole.Focus();
                return;


            }

            if (txtNewUserid.Text == "")
            {
                MessageBox.Show("Please enter User ID number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewUserid.Focus();
                return;


            }

            try
            {
                //create a new sql connection using the our CS string that is holding the data source
                SqlConnection myConnection = new SqlConnection(cs);
                //sets up new SqlCommand object as myCommand with sql query
                SqlCommand myCommand = new SqlCommand("INSERT INTO tblLogin (Userid,Firstname,Lastname,Password,Role,Payrate) VALUES(@Userid,@Firstname,@Lastname,@Password,@Role,@Payrate)", myConnection);

                //set up sql parameters
                SqlParameter userId = new SqlParameter("@Userid", SqlDbType.VarChar);
                SqlParameter userFirstname = new SqlParameter("@Firstname", SqlDbType.VarChar);
                SqlParameter userLastname = new SqlParameter("@Lastname", SqlDbType.VarChar);
                SqlParameter userPassword = new SqlParameter("@Password", SqlDbType.VarChar);
                SqlParameter userRole = new SqlParameter("@Role", SqlDbType.VarChar);
                SqlParameter userPayrate = new SqlParameter("@Payrate", SqlDbType.VarChar);

                //grab new user info from textbox
                userId.Value = txtNewUserid.Text.Trim();
                userFirstname.Value = txtNewFirstName.Text.Trim();
                userLastname.Value = txtNewLastName.Text.Trim();
                userPassword.Value = txtNewPass.Text.Trim();
                userRole.Value = txtRole.Text.Trim();
                userPayrate.Value = txtPayRate.Text.Trim();

                //takes sql command adds sql parameters and then adds to DB
                myCommand.Parameters.Add(userId);
                myCommand.Parameters.Add(userFirstname);
                myCommand.Parameters.Add(userLastname);
                myCommand.Parameters.Add(userPassword);
                myCommand.Parameters.Add(userRole);
                myCommand.Parameters.Add(userPayrate);
                
                //open sql connection 
                myCommand.Connection.Open();

                //Execute sql query
                myCommand.ExecuteNonQuery();

                //new user has been added to DB
                MessageBox.Show(" New Account Setup! ");
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtNewFirstName_MouseClick(object sender, MouseEventArgs e)
        {//click newuser firstname textbox to clear out prefill text
            txtNewFirstName.Text = "";
            txtNewPass.Text = "";
            txtNewUserid.Text = "";
            txtNewLastName.Text = "";
            txtPayRate.Text = "";
            txtRole.Text = "";


        }

        private void BtnNewUserMainMenu_Click(object sender, EventArgs e)
        {
            //Go back to Main Menu
            this.Hide();
            frmMainLogin frmMainLogin = new frmMainLogin();
            frmMainLogin.Show();

        }
    }
}

