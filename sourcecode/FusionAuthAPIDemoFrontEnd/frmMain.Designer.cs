﻿
namespace FusionDemo
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbUsersToAddToGroup = new System.Windows.Forms.ComboBox();
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            this.btnPopulateUsersAndGroups = new System.Windows.Forms.Button();
            this.btnGetUsers = new System.Windows.Forms.Button();
            this.cmbUsersToDelete = new System.Windows.Forms.ComboBox();
            this.btnAddUserToGroup = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.rtbStatus = new System.Windows.Forms.RichTextBox();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbUsersToAddToGroup);
            this.panel1.Controls.Add(this.cmbGroups);
            this.panel1.Controls.Add(this.btnPopulateUsersAndGroups);
            this.panel1.Controls.Add(this.btnGetUsers);
            this.panel1.Controls.Add(this.cmbUsersToDelete);
            this.panel1.Controls.Add(this.btnAddUserToGroup);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnDeleteUser);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnCreateUser);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 201);
            this.panel1.TabIndex = 0;
            // 
            // cmbUsersToAddToGroup
            // 
            this.cmbUsersToAddToGroup.FormattingEnabled = true;
            this.cmbUsersToAddToGroup.Location = new System.Drawing.Point(631, 77);
            this.cmbUsersToAddToGroup.Name = "cmbUsersToAddToGroup";
            this.cmbUsersToAddToGroup.Size = new System.Drawing.Size(292, 21);
            this.cmbUsersToAddToGroup.TabIndex = 23;
            // 
            // cmbGroups
            // 
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.Location = new System.Drawing.Point(631, 45);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(292, 21);
            this.cmbGroups.TabIndex = 22;
            // 
            // btnPopulateUsersAndGroups
            // 
            this.btnPopulateUsersAndGroups.Location = new System.Drawing.Point(631, 104);
            this.btnPopulateUsersAndGroups.Name = "btnPopulateUsersAndGroups";
            this.btnPopulateUsersAndGroups.Size = new System.Drawing.Size(166, 23);
            this.btnPopulateUsersAndGroups.TabIndex = 21;
            this.btnPopulateUsersAndGroups.Text = "Populate Users and Groups";
            this.btnPopulateUsersAndGroups.UseVisualStyleBackColor = true;
            this.btnPopulateUsersAndGroups.Click += new System.EventHandler(this.btnPopulateUsersAndGroups_Click);
            // 
            // btnGetUsers
            // 
            this.btnGetUsers.Location = new System.Drawing.Point(335, 80);
            this.btnGetUsers.Name = "btnGetUsers";
            this.btnGetUsers.Size = new System.Drawing.Size(104, 23);
            this.btnGetUsers.TabIndex = 20;
            this.btnGetUsers.Text = "Populate Users";
            this.btnGetUsers.UseVisualStyleBackColor = true;
            this.btnGetUsers.Click += new System.EventHandler(this.btnGetUsers_Click);
            // 
            // cmbUsersToDelete
            // 
            this.cmbUsersToDelete.FormattingEnabled = true;
            this.cmbUsersToDelete.Location = new System.Drawing.Point(335, 49);
            this.cmbUsersToDelete.Name = "cmbUsersToDelete";
            this.cmbUsersToDelete.Size = new System.Drawing.Size(222, 21);
            this.cmbUsersToDelete.TabIndex = 19;
            // 
            // btnAddUserToGroup
            // 
            this.btnAddUserToGroup.Location = new System.Drawing.Point(803, 104);
            this.btnAddUserToGroup.Name = "btnAddUserToGroup";
            this.btnAddUserToGroup.Size = new System.Drawing.Size(120, 23);
            this.btnAddUserToGroup.TabIndex = 4;
            this.btnAddUserToGroup.Text = "Add User To Group";
            this.btnAddUserToGroup.UseVisualStyleBackColor = true;
            this.btnAddUserToGroup.Click += new System.EventHandler(this.btnAddUserToGroup_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(577, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Add User to Group";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(453, 80);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(104, 23);
            this.btnDeleteUser.TabIndex = 2;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.txtDeleteUser_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(285, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Delete User";
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(22, 156);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(94, 23);
            this.btnCreateUser.TabIndex = 1;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Create User";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(578, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "GroupID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(578, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "User ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "User ID";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(83, 130);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(188, 20);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.Text = "password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(83, 101);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(188, 20);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Text = "joe.limitedaccess@customburger.com";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(83, 73);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(188, 20);
            this.txtLastName.TabIndex = 6;
            this.txtLastName.Text = "Limited-Access";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(83, 45);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(188, 20);
            this.txtFirstName.TabIndex = 5;
            this.txtFirstName.Text = "Joe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(12, 16);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear Log and Status";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 201);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(948, 3);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(156, 349);
            this.panel2.TabIndex = 2;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(156, 204);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 349);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // rtbStatus
            // 
            this.rtbStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbStatus.Location = new System.Drawing.Point(159, 204);
            this.rtbStatus.Name = "rtbStatus";
            this.rtbStatus.Size = new System.Drawing.Size(789, 96);
            this.rtbStatus.TabIndex = 4;
            this.rtbStatus.Text = "";
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter3.Location = new System.Drawing.Point(159, 300);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(789, 3);
            this.splitter3.TabIndex = 5;
            this.splitter3.TabStop = false;
            // 
            // rtbResults
            // 
            this.rtbResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbResults.Location = new System.Drawing.Point(159, 303);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.Size = new System.Drawing.Size(789, 250);
            this.rtbResults.TabIndex = 6;
            this.rtbResults.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 553);
            this.Controls.Add(this.rtbResults);
            this.Controls.Add(this.splitter3);
            this.Controls.Add(this.rtbStatus);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "FusionAuth User API Demo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.RichTextBox rtbStatus;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.RichTextBox rtbResults;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddUserToGroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbUsersToDelete;
        private System.Windows.Forms.Button btnGetUsers;
        private System.Windows.Forms.ComboBox cmbUsersToAddToGroup;
        private System.Windows.Forms.ComboBox cmbGroups;
        private System.Windows.Forms.Button btnPopulateUsersAndGroups;
    }
}

