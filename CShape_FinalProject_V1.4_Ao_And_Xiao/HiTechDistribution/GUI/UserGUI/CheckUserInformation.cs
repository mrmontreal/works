using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hitech.Business;

namespace HiTechDistribution.GUI.UserGUI
{
    public partial class CheckUserInformation : Form
    {
        public CheckUserInformation()
        {
            InitializeComponent();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            User aUser = new User();
            List<User> listOfUsers = aUser.ReadInformation();
            listViewEmployee.Items.Clear();
            foreach (User item in listOfUsers)
            {
                ListViewItem listView = new ListViewItem(item.EmpId);
                listView.SubItems.Add(item.UserType.ToString());
                listViewEmployee.Items.Add(listView);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewEmployee.SelectedItems.Count == 1)
            {
                DialogResult result = MessageBox.Show("Do You Want To Delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    User searchUser = null;
                    //delete original txt
                    string employeeId = listViewEmployee.SelectedItems[0].SubItems[0].Text;
                    searchUser = new User(employeeId, "", 0);
                    List<User> listOfUsers = searchUser.SearchInformation(searchUser);
                    User aUser=null;
                    foreach (User oneUser in listOfUsers)
                    {
                        aUser = oneUser;
                    }
                    //delete employee and user information in file
                    aUser.DeleteInformation(aUser);
                    //get the selected row,delete it in listview
                    listViewEmployee.Items.Remove(listViewEmployee.SelectedItems[0]);
                }
            }
            else
            {
                MessageBox.Show("Please select one row to delete!");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listViewEmployee_DoubleClick(object sender, EventArgs e)
        {
            if (this.listViewEmployee.FocusedItem != null)
            {
                if (listViewEmployee.SelectedItems != null)
                {
                    string employeeId = listViewEmployee.SelectedItems[0].SubItems[0].Text;
                    string userType = listViewEmployee.SelectedItems[0].SubItems[1].Text;
                    textBoxUserName.Text = employeeId;
                    comboBoxUserType.Text = userType;
                    buttonDelete.Enabled = false;
                    buttonList.Enabled = false;
                    buttonSearch.Enabled = false;
                }
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (listViewEmployee.SelectedItems.Count == 1)
            {
                if (textBoxUserName.Text!="")
                {
                    DialogResult result = MessageBox.Show("Do You Want To Modify?", "Modify", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result.Equals(DialogResult.OK))
                    {
                        //create old user
                        User searchUser = null;
                        string employeeId = listViewEmployee.SelectedItems[0].SubItems[0].Text;
                        searchUser = new User(employeeId, "", 0);
                        User oldUser = searchUser.GetUserInformation(employeeId);

                        //create new user
                        string newUserId = textBoxUserName.Text;
                        string newPassword = textBoxPassword.Text;
                        int newUserType = Int32.Parse(comboBoxUserType.Text);
                        User newUser = new User(newUserId, newPassword, newUserType);

                        //update
                        newUser.UpdateInformation(oldUser, newUser);
                        buttonDelete.Enabled = true;
                        buttonList.Enabled = true;
                        buttonSearch.Enabled = true;
                        textBoxUserName.Text = "";
                        textBoxPassword.Text = "";
                        //comboBoxUserType.Text=" ";
                        listViewEmployee.Items.Clear();
                    }
                    else
                    {
                        buttonDelete.Enabled = true;
                        buttonList.Enabled = true;
                        buttonSearch.Enabled = true;
                        textBoxUserName.Text = "";
                        textBoxPassword.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Please double click one row to modify!");
                }
            }
            else
            {
                MessageBox.Show("Please double click one row to modify!");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //create search information
            User searchUser = null;
            if (comboBoxSearchUser.Text == "User Name")
            {
                searchUser = new User(textBoxSearchInfo.Text, "", 0);
            }
            else if (comboBoxSearchUser.Text == "User Type")
            {
                if (Validator.IsValidNumber(textBoxSearchInfo,1))
                {
                    searchUser = new User("", "", Int32.Parse(textBoxSearchInfo.Text));                    
                }
            }

            //display in listview
            if (searchUser != null)
            {
                listViewEmployee.Items.Clear();
                List<User> listOfUsers = searchUser.SearchInformation(searchUser);
                bool find = false;
                if (listOfUsers != null)
                {
                    foreach (User oneUser in listOfUsers)
                    {
                        ListViewItem listView = new ListViewItem(oneUser.EmpId);
                        listView.SubItems.Add(oneUser.UserType.ToString());
                        listViewEmployee.Items.Add(listView);
                        find = true;
                    }
                }
                if (find == false)
                {
                    MessageBox.Show("There is no such user.");
                }
            }
        }
    }
}
