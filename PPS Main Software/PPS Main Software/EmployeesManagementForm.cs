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
    public partial class EmployeesManagementForm : Form
    {

        public SqlConnection connection;
        public SqlCommand command;
        public SqlDataReader reader;
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\New folder\PPS Main Software\PPS Main Software\PPS_Database.mdf;Integrated Security=True";

        public ManagementForm ManagementForm = new ManagementForm();
        public LoginForm LoginForm = new LoginForm();


        public EmployeesManagementForm()
        {
            InitializeComponent();
        }

        private void EmployeesManagementForm_Load(object sender, EventArgs e)
        {
            employeeListBox.Items.Add("Employee ID   |   First Name   |   Last Name   |   Username");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //Connecting to database and inserting New employee details
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                string sqlQuery = "INSERT INTO EMPLOYEE(Employee_ID, FirstName, LastName, Username, Password) VALUES(@employee_ID, @firstName, @lastName, @username, @password)";

                command = new SqlCommand(sqlQuery, connection);

                if (employeeIDTextBox.Text == "" || firstNameTextBox.Text == "" || LastNameTextBox.Text == ""
                    || usernameTextName.Text == "" || passwordTextBox.Text == "")
                {
                    MessageBox.Show("Missing fields!\n\nPlease enter all fields");
                    
                }
                else
                {
                    command.Parameters.AddWithValue("@employee_ID", employeeIDTextBox.Text);
                    command.Parameters.AddWithValue("@firstName", firstNameTextBox.Text);
                    command.Parameters.AddWithValue("@lastName", LastNameTextBox.Text);
                    command.Parameters.AddWithValue("@username", usernameTextName.Text);
                    command.Parameters.AddWithValue("@password", passwordTextBox.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Employee succesfully added");
                }

                connection.Close();

                
            }
            catch (SqlException errorMessage)
            {
               label5.Text = "Problem enctountered " + errorMessage.Message;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            employeeIDTextBox.Text = "";
            firstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            usernameTextName.Text = "";
            passwordTextBox.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            ManagementForm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                //Function checks if username exists in database. Returns TRUE if exists and FASLE if not.
             
                    connection = new SqlConnection(connectionString);
                    connection.Open();

                    bool outcome = false;                   
                    string userInput = employeeSearchTextBox.Text;
                    string employeeQuery = $"SELECT * FROM EMPLOYEE WHERE Employee_ID LIKE '%{userInput}%'";
                    command = new SqlCommand(employeeQuery, connection);
                    reader = command.ExecuteReader();

                    string employeeIDInDB = "";
                    string firstName = "";
                    string lastName = "";
                    string username = "";

                    int count = 0;
                    while (reader.Read())
                    {

                        employeeIDInDB = reader["Employee_ID"].ToString();
                        firstName = reader["FirstName"].ToString();
                        lastName = reader["LastName"].ToString();
                        username = reader["Username"].ToString();


                        char[] employeeInDBArr = employeeIDInDB.ToCharArray();
                        char[] userInputArr = userInput.ToCharArray();

                        if (employeeInDBArr[count] == userInputArr[count])
                        {
                            employeeListBox.Items.Add("    "+employeeIDInDB+"                   "+firstName+"                    "+lastName+"                         "+username);
                           
                    }
                        else
                        {
                            outcome = false;
                        }
                        ++count;
                    }

                connection.Close();

            }

            catch (SqlException error)
            {
                label4.Text = error.Message;
            }
        }    

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            ManagementForm.Close();          
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();

            string userInput = employeeSearchTextBox.Text;
            string employeeQuery = $"DELETE * FROM EMPLOYEE WHERE Employee_ID LIKE '%{userInput}%'";

            MessageBox.Show("Deletion succesfull!");

        }
    }
}
