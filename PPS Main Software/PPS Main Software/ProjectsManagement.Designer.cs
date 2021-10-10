
namespace PPS_Main_Software
{
    partial class ProjectsManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectsManagement));
            this.btnLogOut = new System.Windows.Forms.Button();
            this.projectsTabControl = new System.Windows.Forms.TabControl();
            this.newProjectPage = new System.Windows.Forms.TabPage();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.projectPhaseTextBox = new System.Windows.Forms.TextBox();
            this.projectPriceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.projectIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.employeetextBox = new System.Windows.Forms.TextBox();
            this.clienttextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.companytextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxNewRoles = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.manageProjectsTabPage = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.projectsTabControl.SuspendLayout();
            this.newProjectPage.SuspendLayout();
            this.manageProjectsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(427, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 33);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // projectsTabControl
            // 
            this.projectsTabControl.Controls.Add(this.newProjectPage);
            this.projectsTabControl.Controls.Add(this.manageProjectsTabPage);
            this.projectsTabControl.Location = new System.Drawing.Point(36, 167);
            this.projectsTabControl.Name = "projectsTabControl";
            this.projectsTabControl.SelectedIndex = 0;
            this.projectsTabControl.Size = new System.Drawing.Size(429, 408);
            this.projectsTabControl.TabIndex = 5;
            // 
            // newProjectPage
            // 
            this.newProjectPage.Controls.Add(this.label11);
            this.newProjectPage.Controls.Add(this.companytextBox);
            this.newProjectPage.Controls.Add(this.label7);
            this.newProjectPage.Controls.Add(this.label5);
            this.newProjectPage.Controls.Add(this.clienttextBox);
            this.newProjectPage.Controls.Add(this.employeetextBox);
            this.newProjectPage.Controls.Add(this.dateTimePicker);
            this.newProjectPage.Controls.Add(this.ErrorMessage);
            this.newProjectPage.Controls.Add(this.btnClear);
            this.newProjectPage.Controls.Add(this.btnInsert);
            this.newProjectPage.Controls.Add(this.projectPhaseTextBox);
            this.newProjectPage.Controls.Add(this.projectPriceTextBox);
            this.newProjectPage.Controls.Add(this.label6);
            this.newProjectPage.Controls.Add(this.label4);
            this.newProjectPage.Controls.Add(this.label3);
            this.newProjectPage.Controls.Add(this.projectIDTextBox);
            this.newProjectPage.Controls.Add(this.label2);
            this.newProjectPage.Location = new System.Drawing.Point(4, 25);
            this.newProjectPage.Name = "newProjectPage";
            this.newProjectPage.Padding = new System.Windows.Forms.Padding(3);
            this.newProjectPage.Size = new System.Drawing.Size(421, 379);
            this.newProjectPage.TabIndex = 0;
            this.newProjectPage.Text = "Add New Project";
            this.newProjectPage.UseVisualStyleBackColor = true;
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.Location = new System.Drawing.Point(49, 306);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(0, 17);
            this.ErrorMessage.TabIndex = 13;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(248, 327);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 32);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(152, 327);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(80, 32);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // projectPhaseTextBox
            // 
            this.projectPhaseTextBox.Location = new System.Drawing.Point(152, 74);
            this.projectPhaseTextBox.Name = "projectPhaseTextBox";
            this.projectPhaseTextBox.Size = new System.Drawing.Size(176, 22);
            this.projectPhaseTextBox.TabIndex = 11;
            // 
            // projectPriceTextBox
            // 
            this.projectPriceTextBox.Location = new System.Drawing.Point(152, 158);
            this.projectPriceTextBox.Name = "projectPriceTextBox";
            this.projectPriceTextBox.Size = new System.Drawing.Size(176, 22);
            this.projectPriceTextBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Project Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Project Phase :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Project Date :";
            // 
            // projectIDTextBox
            // 
            this.projectIDTextBox.Location = new System.Drawing.Point(152, 31);
            this.projectIDTextBox.Name = "projectIDTextBox";
            this.projectIDTextBox.Size = new System.Drawing.Size(176, 22);
            this.projectIDTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Project ID :";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(374, 581);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 35);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(152, 118);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(176, 22);
            this.dateTimePicker.TabIndex = 14;
            // 
            // employeetextBox
            // 
            this.employeetextBox.Location = new System.Drawing.Point(152, 243);
            this.employeetextBox.Name = "employeetextBox";
            this.employeetextBox.Size = new System.Drawing.Size(176, 22);
            this.employeetextBox.TabIndex = 15;
            // 
            // clienttextBox
            // 
            this.clienttextBox.Location = new System.Drawing.Point(152, 203);
            this.clienttextBox.Name = "clienttextBox";
            this.clienttextBox.Size = new System.Drawing.Size(176, 22);
            this.clienttextBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Client ID :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Employee ID :";
            // 
            // companytextBox
            // 
            this.companytextBox.Location = new System.Drawing.Point(152, 288);
            this.companytextBox.Name = "companytextBox";
            this.companytextBox.Size = new System.Drawing.Size(176, 22);
            this.companytextBox.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(66, 291);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Company :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Update project phase :";
            // 
            // txtBoxNewRoles
            // 
            this.txtBoxNewRoles.Location = new System.Drawing.Point(188, 127);
            this.txtBoxNewRoles.Name = "txtBoxNewRoles";
            this.txtBoxNewRoles.Size = new System.Drawing.Size(179, 22);
            this.txtBoxNewRoles.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(156, 199);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 30);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // manageProjectsTabPage
            // 
            this.manageProjectsTabPage.Controls.Add(this.label12);
            this.manageProjectsTabPage.Controls.Add(this.textBox2);
            this.manageProjectsTabPage.Controls.Add(this.label9);
            this.manageProjectsTabPage.Controls.Add(this.btnUpdate);
            this.manageProjectsTabPage.Controls.Add(this.txtBoxNewRoles);
            this.manageProjectsTabPage.Controls.Add(this.label10);
            this.manageProjectsTabPage.Controls.Add(this.label8);
            this.manageProjectsTabPage.Location = new System.Drawing.Point(4, 25);
            this.manageProjectsTabPage.Name = "manageProjectsTabPage";
            this.manageProjectsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.manageProjectsTabPage.Size = new System.Drawing.Size(421, 379);
            this.manageProjectsTabPage.TabIndex = 1;
            this.manageProjectsTabPage.Text = "Manage Projects";
            this.manageProjectsTabPage.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = " :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(188, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 22);
            this.textBox2.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(105, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "Project ID :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(134, 96);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(331, 29);
            this.label13.TabIndex = 23;
            this.label13.Text = "PPS Projects Management ";
            // 
            // ProjectsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 645);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.projectsTabControl);
            this.Controls.Add(this.btnLogOut);
            this.Name = "ProjectsManagement";
            this.Text = "ProjectsManagement";
            this.projectsTabControl.ResumeLayout(false);
            this.newProjectPage.ResumeLayout(false);
            this.newProjectPage.PerformLayout();
            this.manageProjectsTabPage.ResumeLayout(false);
            this.manageProjectsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TabControl projectsTabControl;
        private System.Windows.Forms.TabPage newProjectPage;
        private System.Windows.Forms.Label ErrorMessage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox projectPhaseTextBox;
        private System.Windows.Forms.TextBox projectPriceTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox projectIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox clienttextBox;
        private System.Windows.Forms.TextBox employeetextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox companytextBox;
        private System.Windows.Forms.TabPage manageProjectsTabPage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtBoxNewRoles;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
    }
}