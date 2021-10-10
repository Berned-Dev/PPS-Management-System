
namespace PPS_Main_Software
{
    partial class EmployeesManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesManagementForm));
            this.employeesTabControl = new System.Windows.Forms.TabControl();
            this.newEmployeetabPage = new System.Windows.Forms.TabPage();
            this.rolesTabPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeIDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextName = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxEmployeeID = new System.Windows.Forms.TextBox();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.listBoxRoles = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxNewRoles = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnEnterRole = new System.Windows.Forms.Button();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteTabPage = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.employeeSearchTextBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.employeeListBox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.employeesTabControl.SuspendLayout();
            this.newEmployeetabPage.SuspendLayout();
            this.rolesTabPage.SuspendLayout();
            this.deleteTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // employeesTabControl
            // 
            this.employeesTabControl.Controls.Add(this.newEmployeetabPage);
            this.employeesTabControl.Controls.Add(this.deleteTabPage);
            this.employeesTabControl.Controls.Add(this.rolesTabPage);
            this.employeesTabControl.Location = new System.Drawing.Point(42, 164);
            this.employeesTabControl.Name = "employeesTabControl";
            this.employeesTabControl.SelectedIndex = 0;
            this.employeesTabControl.Size = new System.Drawing.Size(416, 400);
            this.employeesTabControl.TabIndex = 2;
            // 
            // newEmployeetabPage
            // 
            this.newEmployeetabPage.Controls.Add(this.ErrorMessage);
            this.newEmployeetabPage.Controls.Add(this.btnClear);
            this.newEmployeetabPage.Controls.Add(this.btnInsert);
            this.newEmployeetabPage.Controls.Add(this.firstNameTextBox);
            this.newEmployeetabPage.Controls.Add(this.LastNameTextBox);
            this.newEmployeetabPage.Controls.Add(this.usernameTextName);
            this.newEmployeetabPage.Controls.Add(this.passwordTextBox);
            this.newEmployeetabPage.Controls.Add(this.label7);
            this.newEmployeetabPage.Controls.Add(this.label6);
            this.newEmployeetabPage.Controls.Add(this.label4);
            this.newEmployeetabPage.Controls.Add(this.label3);
            this.newEmployeetabPage.Controls.Add(this.employeeIDTextBox);
            this.newEmployeetabPage.Controls.Add(this.label2);
            this.newEmployeetabPage.Location = new System.Drawing.Point(4, 25);
            this.newEmployeetabPage.Name = "newEmployeetabPage";
            this.newEmployeetabPage.Padding = new System.Windows.Forms.Padding(3);
            this.newEmployeetabPage.Size = new System.Drawing.Size(408, 371);
            this.newEmployeetabPage.TabIndex = 0;
            this.newEmployeetabPage.Text = "Add New Employee";
            this.newEmployeetabPage.UseVisualStyleBackColor = true;
            // 
            // rolesTabPage
            // 
            this.rolesTabPage.Controls.Add(this.btnEnterRole);
            this.rolesTabPage.Controls.Add(this.btnUpdate);
            this.rolesTabPage.Controls.Add(this.txtBoxNewRoles);
            this.rolesTabPage.Controls.Add(this.label10);
            this.rolesTabPage.Controls.Add(this.listBoxRoles);
            this.rolesTabPage.Controls.Add(this.btnSearchEmployee);
            this.rolesTabPage.Controls.Add(this.textBoxEmployeeID);
            this.rolesTabPage.Controls.Add(this.label9);
            this.rolesTabPage.Controls.Add(this.label8);
            this.rolesTabPage.Location = new System.Drawing.Point(4, 25);
            this.rolesTabPage.Name = "rolesTabPage";
            this.rolesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.rolesTabPage.Size = new System.Drawing.Size(408, 371);
            this.rolesTabPage.TabIndex = 1;
            this.rolesTabPage.Text = "Manage Roles";
            this.rolesTabPage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee ID :";
            // 
            // employeeIDTextBox
            // 
            this.employeeIDTextBox.Location = new System.Drawing.Point(132, 31);
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.Size = new System.Drawing.Size(176, 22);
            this.employeeIDTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "First Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Username :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Password :";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(132, 201);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(176, 22);
            this.passwordTextBox.TabIndex = 7;
            // 
            // usernameTextName
            // 
            this.usernameTextName.Location = new System.Drawing.Point(132, 158);
            this.usernameTextName.Name = "usernameTextName";
            this.usernameTextName.Size = new System.Drawing.Size(176, 22);
            this.usernameTextName.TabIndex = 8;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(132, 113);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(176, 22);
            this.LastNameTextBox.TabIndex = 10;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(132, 72);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(176, 22);
            this.firstNameTextBox.TabIndex = 11;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(142, 240);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(80, 32);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(228, 240);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 32);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(426, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 33);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(367, 579);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 35);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Employee ID :";
            // 
            // textBoxEmployeeID
            // 
            this.textBoxEmployeeID.Location = new System.Drawing.Point(135, 33);
            this.textBoxEmployeeID.Name = "textBoxEmployeeID";
            this.textBoxEmployeeID.Size = new System.Drawing.Size(153, 22);
            this.textBoxEmployeeID.TabIndex = 2;
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.Location = new System.Drawing.Point(304, 26);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(67, 29);
            this.btnSearchEmployee.TabIndex = 3;
            this.btnSearchEmployee.Text = "Search";
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            // 
            // listBoxRoles
            // 
            this.listBoxRoles.FormattingEnabled = true;
            this.listBoxRoles.ItemHeight = 16;
            this.listBoxRoles.Location = new System.Drawing.Point(37, 81);
            this.listBoxRoles.Name = "listBoxRoles";
            this.listBoxRoles.Size = new System.Drawing.Size(334, 180);
            this.listBoxRoles.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Enter new role :";
            // 
            // txtBoxNewRoles
            // 
            this.txtBoxNewRoles.Location = new System.Drawing.Point(147, 277);
            this.txtBoxNewRoles.Name = "txtBoxNewRoles";
            this.txtBoxNewRoles.Size = new System.Drawing.Size(151, 22);
            this.txtBoxNewRoles.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(147, 320);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 30);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnEnterRole
            // 
            this.btnEnterRole.Location = new System.Drawing.Point(304, 274);
            this.btnEnterRole.Name = "btnEnterRole";
            this.btnEnterRole.Size = new System.Drawing.Size(67, 29);
            this.btnEnterRole.TabIndex = 8;
            this.btnEnterRole.Text = "Enter";
            this.btnEnterRole.UseVisualStyleBackColor = true;
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.Location = new System.Drawing.Point(49, 306);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(0, 17);
            this.ErrorMessage.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 492);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 5;
            // 
            // deleteTabPage
            // 
            this.deleteTabPage.Controls.Add(this.button2);
            this.deleteTabPage.Controls.Add(this.employeeListBox);
            this.deleteTabPage.Controls.Add(this.btnSearch);
            this.deleteTabPage.Controls.Add(this.employeeSearchTextBox);
            this.deleteTabPage.Controls.Add(this.label11);
            this.deleteTabPage.Location = new System.Drawing.Point(4, 25);
            this.deleteTabPage.Name = "deleteTabPage";
            this.deleteTabPage.Size = new System.Drawing.Size(408, 371);
            this.deleteTabPage.TabIndex = 2;
            this.deleteTabPage.Text = "Delete Emloyee";
            this.deleteTabPage.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Employee ID :";
            // 
            // employeeSearchTextBox
            // 
            this.employeeSearchTextBox.Location = new System.Drawing.Point(131, 66);
            this.employeeSearchTextBox.Name = "employeeSearchTextBox";
            this.employeeSearchTextBox.Size = new System.Drawing.Size(153, 22);
            this.employeeSearchTextBox.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(300, 59);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 29);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // employeeListBox
            // 
            this.employeeListBox.FormattingEnabled = true;
            this.employeeListBox.ItemHeight = 16;
            this.employeeListBox.Location = new System.Drawing.Point(15, 127);
            this.employeeListBox.Name = "employeeListBox";
            this.employeeListBox.Size = new System.Drawing.Size(377, 100);
            this.employeeListBox.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "Delete Selected";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(118, 95);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(365, 29);
            this.label12.TabIndex = 10;
            this.label12.Text = "PPS Employees Management ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 622);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "PPS v1.0";
            // 
            // EmployeesManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 648);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.employeesTabControl);
            this.Name = "EmployeesManagementForm";
            this.Text = "EmployeesManagementForm";
            this.Load += new System.EventHandler(this.EmployeesManagementForm_Load);
            this.employeesTabControl.ResumeLayout(false);
            this.newEmployeetabPage.ResumeLayout(false);
            this.newEmployeetabPage.PerformLayout();
            this.rolesTabPage.ResumeLayout(false);
            this.rolesTabPage.PerformLayout();
            this.deleteTabPage.ResumeLayout(false);
            this.deleteTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl employeesTabControl;
        private System.Windows.Forms.TabPage newEmployeetabPage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox usernameTextName;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox employeeIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage rolesTabPage;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEnterRole;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtBoxNewRoles;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBoxRoles;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.TextBox textBoxEmployeeID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ErrorMessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage deleteTabPage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox employeeListBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox employeeSearchTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
    }
}