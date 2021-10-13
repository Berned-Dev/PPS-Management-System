using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPS_Main_Software
{
    public partial class ManagementForm : Form
    {
        public ManagementForm()
        {
            InitializeComponent();
        }

        private void btnEmployeesManage_Click(object sender, EventArgs e)
        {
            this.Close();
            EmployeesManagementForm employeesManagement = new EmployeesManagementForm();
            employeesManagement.Show();
        }

        private void btnProjectsManage_Click(object sender, EventArgs e)
        {
            this.Close();
            ProjectsManagement projectsManagement = new ProjectsManagement();
            projectsManagement.Show();
        }

        private void btnClientsManage_Click(object sender, EventArgs e)
        {
            this.Close();
            ClientsManagement clients = new ClientsManagement();
            clients.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            this.Close();
            ReportsForm reports = new ReportsForm();
            reports.Show();
        }
    }
}
