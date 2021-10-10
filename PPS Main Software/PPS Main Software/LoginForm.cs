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

namespace PPS_Main_Software
{
    public partial class LoginForm : Form
    {

        public SqlConnection connection;
        public SqlCommand command;
        public SqlDataReader reader;
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\New folder\PPS Main Software\PPS Main Software\PPS_Database.mdf;Integrated Security=True";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                //Function checks if username exists in database. Returns TRUE if exists and FASLE if not.
                bool checkUsername()
                {
                    connection = new SqlConnection(connectionString);
                    connection.Open();

                    bool usernameOutcome = false;
                    string usernameInDB = "";
                    string userInput = usernameTextBox.Text;
                    string usernameQuery = $"SELECT * FROM EMPLOYEE WHERE Username LIKE '%{userInput}%'";
                    command = new SqlCommand(usernameQuery, connection);
                    reader = command.ExecuteReader();

                    int count = 0;
                    while (reader.Read())
                    {

                        usernameInDB = reader["Username"].ToString();


                        char[] usernameInDBArr = usernameInDB.ToCharArray();
                        char[] userInputArr = userInput.ToCharArray();

                        if (usernameInDBArr[count] == userInputArr[count])
                        {
                            usernameOutcome = true;
                        }
                        else
                        {
                            usernameOutcome = false;
                        }
                        ++count;
                    }
                    return usernameOutcome;
                }

                //Function checks if Password exists in database and matches the database. Returns TRUE if exists and FASLE if not.
                bool checkPassword()
                {
                    connection = new SqlConnection(connectionString);
                    connection.Open();

                    bool passwordOutcome = false;
                    string passwordInDB = "";
                    string passwordInput = passwordTextBox.Text;
                    string passwordQuery = $"SELECT * FROM EMPLOYEE WHERE Password LIKE '%{passwordInput}%'";
                    command = new SqlCommand(passwordQuery, connection);
                    reader = command.ExecuteReader();

                    int count = 0;
                    while (reader.Read())
                    {
                        passwordInDB = reader["Password"].ToString();

                        char[] passwordInDBArr = passwordInDB.ToCharArray();
                        char[] passwordInputArr = passwordInput.ToCharArray();

                        if (passwordInDBArr[count] == passwordInputArr[count])
                        {
                            passwordOutcome = true;
                        }
                        else
                        {
                            passwordOutcome = false;
                        }
                        ++count;
                    }
                    return passwordOutcome;
                }

                if (!(checkUsername()) || !(checkPassword()))
                {
                    MessageBox.Show("User Invalid! \n\nPlease Enter valid credentials");
                }
              
                else {
                    ManagementForm management = new ManagementForm();
                    management.Show();
                    usernameTextBox.Text = "";
                    passwordTextBox.Text = "";
                }
            }

            catch (SqlException error)
            {
                label4.Text = error.Message;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
