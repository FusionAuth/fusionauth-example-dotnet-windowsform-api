using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using FusionDemoAPI;
using FusionDemoAPI.Helper;

namespace FusionDemo
{
    public partial class frmMain : Form
    {
        public enum PopulateType
        {
            Users = 0,
            Groups = 1
        }

        public frmMain()
        {
            InitializeComponent();
        }

        //tag::btnCreateUser[]
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
        //end::btnCreateUser[]

        private async void txtDeleteUser_Click(object sender, EventArgs e)
        {
            LogStatus("Deleting User");
            if (cmbUsersToDelete.SelectedIndex >= 0)
            {
                string userIdToDelete = (string)cmbUsersToDelete.SelectedValue;
                Stopwatch sw = new Stopwatch();
                sw.Start();
                var faClient = new FusionAuthClient();
                ReturnValue userCreatedReturnValue = await faClient.DeleteUser(userIdToDelete);
                LogResults($"User Deleted: {userIdToDelete}");
                sw.Stop();
                LogStatus("User Deletion Complete");
                LogStatus($"{sw.Elapsed} (hh:mm:ss:ms)");
                PopulateComboBox(cmbUsersToAddToGroup, PopulateType.Users);
                PopulateComboBox(cmbUsersToDelete, PopulateType.Users);
            }
            else
            {
                LogStatus("Must select a user to delete.");
            }
           
        }

        //tag::btnAddUserToGroup[]
        private async void btnAddUserToGroup_Click(object sender, EventArgs e)
        {
            //FusionAuthClient is a class that contains the logic to call  the FusionAuth APIs
            var faClient = new FusionAuthClient();
            var userIdToAdd = (string)cmbUsersToAddToGroup.SelectedValue;
            var groupIdToAdd = (string)cmbGroups.SelectedValue;

            if (userIdToAdd != null && groupIdToAdd != null)
            {
                List<GroupUser> users = new List<GroupUser>()
                {
                    new GroupUser()
                    {
                        UserID = userIdToAdd
                    }
                };

                Group group = new Group();

                group.ID = groupIdToAdd;
                group.Users = users;

                List<Group> groups = new List<Group>();
                groups.Add(group);

                //perform custom validation logic here
                if (IsGroupValid(group))
                {
                    ReturnValue addUserToGroupReturnValue = await faClient.AddUserToGroup(groups);
                    if (addUserToGroupReturnValue.success == true)
                    {
                        LogResults($"User {(string)cmbUsersToAddToGroup.Text} has been added to the group: {(string)cmbGroups.Text}");
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
            else
            {
                LogResults($"No group or user selected.  Populate Users and Groups.");
            }
        }
        //end::btnAddUserToGroup[]
        
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

        private void btnGetUsers_Click(object sender, EventArgs e)
        {
            PopulateComboBox(cmbUsersToDelete, PopulateType.Users);
        }

        private async void PopulateComboBox(ComboBox comboBoxToPopulate, PopulateType populateType)
        {
            var faClient = new FusionAuthClient();
            Dictionary<string,string> collection = new Dictionary<string,string>();
            if (populateType == PopulateType.Users)
            {
                collection = await faClient.GetDictionaryOfUsers();
            }
            else if (populateType == PopulateType.Groups)
            {
                collection = await faClient.GetDictionaryOfGroups();
            }
            
            if (collection.Count > 0)
            {
                comboBoxToPopulate.DataSource = new BindingSource(collection, null);
                comboBoxToPopulate.DisplayMember = "Value";
                comboBoxToPopulate.ValueMember = "Key";
                comboBoxToPopulate.SelectedItem = comboBoxToPopulate.Items[0];
            }
        }

        private void btnPopulateUsersAndGroups_Click(object sender, EventArgs e)
        {
            PopulateComboBox(cmbUsersToAddToGroup, PopulateType.Users);
            PopulateComboBox(cmbGroups, PopulateType.Groups);
        }
    }
}
