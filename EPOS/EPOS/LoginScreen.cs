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
using Microsoft.VisualBasic;

namespace EPOS
{
    public partial class frmMainLogin : Form
    {

        //captures the sql data source in a string
        String cs = "";//enter database data source;
        public frmMainLogin()
        {
            InitializeComponent();
        }
        private void BtnLoginUser_Click(object sender, EventArgs e)
        {

            //checks to see if text boxes are filled 
            if (txtLoginIDUser.Text == "")
            {
                MessageBox.Show("Please enter User ID Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLoginIDUser.Focus();
                return;


            }
            if (txtLoginPassUser.Text == "")
            {

                MessageBox.Show("Please enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLoginPassUser.Focus();
                return;

            }

            try
            {
                //creates new sql connection 
                SqlConnection myConnection = new SqlConnection(cs);


                //sql command to get sql user data from table
                SqlCommand myCommand = new SqlCommand("SELECT Userid,Password FROM tblLogin WHERE Userid = @Userid AND Password = @Password", myConnection);

                //sql data from table is set up as uName, and uPassword
                SqlParameter userID = new SqlParameter("@Userid", SqlDbType.VarChar);
                SqlParameter userPassword = new SqlParameter("@Password", SqlDbType.VarChar);

                //grab user info from text box 
                userID.Value = txtLoginIDUser.Text.Trim();
                userPassword.Value = txtLoginPassUser.Text.Trim();

                //takes sql command adds sql parameters and then adds to DB
                myCommand.Parameters.Add(userID);
                myCommand.Parameters.Add(userPassword);

                //open sql connection 
                myCommand.Connection.Open();

                //set up new sql data reader
                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                //if the user is in the DB they will be redirected to the choose game page
                if (myReader.Read() == true)
                {
                    MainMenu mainMenu = new MainMenu();
                    this.Hide();
                    mainMenu.Show();

                }

                //login failed error pops up for any entries are worng
                else
                {
                    MessageBox.Show("Login Failed...Try again !", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtLoginIDUser.Clear();
                    txtLoginPassUser.Clear();


                }
                //closed sql connection 
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Dispose();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNewUser_Click(object sender, EventArgs e)
        {
            // input box pop 
            string input = Interaction.InputBox("Enter Admin Psssword to access", "Password needed", "Enter Password", -1, -1);
            
            //security for new user set up 
            if (input == "password")
            {

                frmNewUser frmNewUser = new frmNewUser();
                this.Hide();
                frmNewUser.Show();
            }
            else
            {
                MessageBox.Show("Bad Admin Password");

            }


        }

      
        //Clears both textboxes when user clicks
        private void TxtLoginPassUser_MouseClick(object sender, MouseEventArgs e)
        {
            txtLoginPassUser.Text = String.Empty;
        }


        private void TxtLoginIDUser_MouseClick(object sender, MouseEventArgs e)
        {
                txtLoginIDUser.Text = String.Empty;
            }

        

       
    }
    }

