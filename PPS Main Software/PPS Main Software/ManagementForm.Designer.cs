
namespace PPS_Main_Software
{
    partial class ManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementForm));
            this.btnEmployeesManage = new System.Windows.Forms.Button();
            this.btnClientsManage = new System.Windows.Forms.Button();
            this.btnProjectsManage = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReports = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmployeesManage
            // 
            this.btnEmployeesManage.Location = new System.Drawing.Point(89, 164);
            this.btnEmployeesManage.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmployeesManage.Name = "btnEmployeesManage";
            this.btnEmployeesManage.Size = new System.Drawing.Size(193, 62);
            this.btnEmployeesManage.TabIndex = 1;
            this.btnEmployeesManage.Text = "Manage Employees";
            this.btnEmployeesManage.UseVisualStyleBackColor = true;
            this.btnEmployeesManage.Click += new System.EventHandler(this.btnEmployeesManage_Click);
            // 
            // btnClientsManage
            // 
            this.btnClientsManage.Location = new System.Drawing.Point(89, 254);
            this.btnClientsManage.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientsManage.Name = "btnClientsManage";
            this.btnClientsManage.Size = new System.Drawing.Size(193, 62);
            this.btnClientsManage.TabIndex = 2;
            this.btnClientsManage.Text = "Manage Clients";
            this.btnClientsManage.UseVisualStyleBackColor = true;
            this.btnClientsManage.Click += new System.EventHandler(this.btnClientsManage_Click);
            // 
            // btnProjectsManage
            // 
            this.btnProjectsManage.Location = new System.Drawing.Point(89, 348);
            this.btnProjectsManage.Margin = new System.Windows.Forms.Padding(4);
            this.btnProjectsManage.Name = "btnProjectsManage";
            this.btnProjectsManage.Size = new System.Drawing.Size(193, 62);
            this.btnProjectsManage.TabIndex = 4;
            this.btnProjectsManage.Text = "Manage Projects";
            this.btnProjectsManage.UseVisualStyleBackColor = true;
            this.btnProjectsManage.Click += new System.EventHandler(this.btnProjectsManage_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(89, 533);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(193, 37);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Cancel and Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "PPS Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 627);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "PPS v1.0";
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(89, 439);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(193, 62);
            this.btnReports.TabIndex = 13;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 653);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProjectsManage);
            this.Controls.Add(this.btnClientsManage);
            this.Controls.Add(this.btnEmployeesManage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManagementForm";
            this.Text = "ManagementForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEmployeesManage;
        private System.Windows.Forms.Button btnClientsManage;
        private System.Windows.Forms.Button btnProjectsManage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReports;
    }
}