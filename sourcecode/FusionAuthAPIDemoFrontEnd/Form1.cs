using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using FusionDemoAPI;

using static FusionDemoAPI.Helper;

namespace FusionDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnCreateUser_Click(object sender, EventArgs e)
        {
            //FusionAuthClient is a class that contains the logic to call the FusionAuth APIs
            var faClient = new FusionAuthClient();

            UserProperties userProperties = new UserProperties()
            {
                Email = txtEmail.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Password = txtPassword.Text
                //add additional properties here
            };

            User userToCreate = new User()
            {
                UserProperties = userProperties
            };

            //perform custom validation logic in the IsUserValid method
            if (IsUserValid(userToCreate))
            {
                ReturnValue userCreatedReturnValue = await faClient.CreateUser(userToCreate);
                if (userCreatedReturnValue.success == true)
                {
                    LogResults($"User created with ID: {userCreatedReturnValue.result}");
                }
                else
                {
                    LogResults($"User creation failed. {userCreatedReturnValue.result}");
                }
            }
            else
            {
                LogResults($"User data provided is invalid");
            }
        }


        private async void txtDeleteUser_Click(object sender, EventArgs e)
        {
            LogStatus("Deleting User");
            Stopwatch sw = new Stopwatch();
            sw.Start();

            
            var faClient = new FusionAuthClient();


            ReturnValue userCreatedReturnValue = await faClient.DeleteUser(txtUserToDelete.Text);
            LogResults($"User Deleted: {txtUserToDelete.Text}");


            sw.Stop();
            LogStatus("User Deletion Complete");
            LogStatus($"{sw.Elapsed} (hh:mm:ss:ms)");
        }

        private async void btnAddUserToGroup_Click(object sender, EventArgs e)
        {
            //FusionAuthClient is a class that contains the logic to call  the FusionAuth APIs
            var faClient = new FusionAuthClient();

            List<GroupUser> users = new List<GroupUser>()
            {
                new GroupUser() 
                {
                    UserID = txtUserIDToAddToGroup.Text
                }
            };

            Group group = new Group();

            group.ID = txtGroupIDToAddTo.Text;
            group.Users = users;

            List<Group> groups = new List<Group>();
            groups.Add(group);

            //perform custom validation logic here
            if (IsGroupValid(group))
            {
                ReturnValue addUserToGroupReturnValue = await faClient.AddUserToGroup(groups);
                if (addUserToGroupReturnValue.success == true)
                {
                    LogResults($"User has been added to the group: {addUserToGroupReturnValue.result}");
                }
                else
                {
                    LogResults($"Adding the user to the group has failed. {addUserToGroupReturnValue.result}");
                }
            }
            else
            {
                LogResults($"User and/or group data provided is invalid");
            }
        }

        private bool IsUserValid(User userToCreate)
        {
            //custom validation code to go here
            return true;
        }

        private bool IsGroupValid(Group groupToAdd)
        {
            //custom validation code to go here
            return true;
        }

        private void LogResults(string message)
        {
            rtbResults.Text = rtbResults.Text + message + Environment.NewLine;
            System.Windows.Forms.Application.DoEvents();
        }

        private void LogStatus(string message)
        {
            rtbStatus.Text = rtbStatus.Text + message + Environment.NewLine;
            System.Windows.Forms.Application.DoEvents();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbStatus.Text = "";
            rtbResults.Text = "";
        }
    }
}
