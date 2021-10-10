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
    public partial class ClientsManagement : Form
    {

        public SqlConnection connection;
        public SqlCommand command;
        public SqlDataReader reader;
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\New folder\PPS Main Software\PPS Main Software\PPS_Database.mdf;Integrated Security=True";

        public ManagementForm ManagementForm = new ManagementForm();
        public ClientsManagement()
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
            //Connecting to database and inserting New employee details
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                string sqlQuery = "INSERT INTO CLIENT(Client_ID, FirstName, LastName, Telephone_Number) VALUES(@client_ID, @firstName, @lastName, @telephone)";

                command = new SqlCommand(sqlQuery, connection);

                if (clientIDTextBox.Text == "" || firstNameTextBox.Text == "" || LastNameTextBox.Text == ""
                    || telephoneTextBox.Text == "")
                {
                    MessageBox.Show("Missing fields!\n\nPlease enter all fields");

                }
                else
                {
                    command.Parameters.AddWithValue("@client_ID", clientIDTextBox.Text);
                    command.Parameters.AddWithValue("@firstName", firstNameTextBox.Text);
                    command.Parameters.AddWithValue("@lastName", LastNameTextBox.Text);
                    command.Parameters.AddWithValue("@telephone", telephoneTextBox.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Client succesfully added");
                }

                connection.Close();
            }
            catch (SqlException errorMessage)
            {
                
                MessageBox.Show(errorMessage.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clientIDTextBox.Text = "";
            firstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            telephoneTextBox.Text = "";
        }
    }
}
