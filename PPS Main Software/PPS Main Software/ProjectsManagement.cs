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
    public partial class ProjectsManagement : Form
    {
        public SqlConnection connection;
        public SqlCommand command;
        public SqlDataReader reader;
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\New folder\PPS Main Software\PPS Main Software\PPS_Database.mdf;Integrated Security=True";

        public ManagementForm ManagementForm = new ManagementForm();
        public ProjectsManagement()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            ManagementForm.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
                 
            string getEmployeeID()
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                string Outcome = "";
                string employeeIDInDB = "";
                string userInput = employeetextBox.Text;
                string Query = $"SELECT * FROM EMPLOYEE WHERE Employee_ID LIKE '%{userInput}%'";
                command = new SqlCommand(Query, connection);
                reader = command.ExecuteReader();

                int count = 0;
                while (reader.Read())
                {

                    employeeIDInDB = reader["Employee_ID"].ToString();


                    char[] employeeInDBArr = employeeIDInDB.ToCharArray();
                    char[] userInputArr = userInput.ToCharArray();

                    if (employeeInDBArr[count] == userInputArr[count])
                    {
                        Outcome = employeeIDInDB;
                    }
                    else
                    {
                        Outcome = null;
                    }
                    ++count;
                }
                connection.Close();
                return Outcome;

            }
      
            string getClientID()
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                string Outcome = "";
                string employeeIDInDB = "";
                string userInput = clienttextBox.Text;
                string Query = $"SELECT * FROM CLIENT WHERE Client_ID LIKE '%{userInput}%'";
                command = new SqlCommand(Query, connection);
                reader = command.ExecuteReader();

                int count = 0;
                while (reader.Read())
                {

                    employeeIDInDB = reader["Client_ID"].ToString();


                    char[] employeeInDBArr = employeeIDInDB.ToCharArray();
                    char[] userInputArr = userInput.ToCharArray();

                    if (employeeInDBArr[count] == userInputArr[count])
                    {
                        Outcome = employeeIDInDB;
                    }
                    else
                    {
                        Outcome = null;
                    }
                    ++count;
                }
                connection.Close();
                return Outcome;              

            }
            


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
