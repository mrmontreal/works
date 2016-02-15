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

namespace HiTechDistribution.GUI.EmployeeGUI
{
    public partial class CheckEmpInformation : Form
    {
        private bool modifyItem=false;

        public CheckEmpInformation()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool check=employeeValidator.Valid;
            if (check)
            {
                Employee anEmployee = new Employee();
                string employeeId = "E" + employeeValidator.EmployeeId;
                string employeefn = employeeValidator.FirstName;
                string employeeln = employeeValidator.LastName;
                string jobTitle = employeeValidator.JobTitle;
                if (anEmployee.GetEmployeeInformation(employeeId)==null)
                {
                    anEmployee = new Employee(employeeId, employeefn,employeeln,jobTitle);
                    anEmployee.SaveInformation(anEmployee);
                    MessageBox.Show("Record has been saved.");
                }
                else
                {
                    MessageBox.Show("Employee id has existed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                employeeValidator.Valid = false;
            }
            else
            {
                MessageBox.Show("Please validate data first.");
            }
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            Employee anEmployee = new Employee();
            List<Employee> listOfEmployees = anEmployee.ReadInformation();
            listViewEmployee.Items.Clear();
            foreach (Employee item in listOfEmployees)
            {
                ListViewItem listView = new ListViewItem(item.EmpId);
                listView.SubItems.Add(item.FirstName);
                listView.SubItems.Add(item.LastName);
                listView.SubItems.Add(item.JobTitle);
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
                    //delete original txt
                    string employeeId = listViewEmployee.SelectedItems[0].SubItems[0].Text;
                    string employeefn = listViewEmployee.SelectedItems[0].SubItems[1].Text;
                    string employeeln = listViewEmployee.SelectedItems[0].SubItems[2].Text;
                    string jobTitle = listViewEmployee.SelectedItems[0].SubItems[3].Text;
                    Employee anEmployee = new Employee(employeeId, employeefn, employeeln, jobTitle);
                    
                    //create a user to search employee id, in order to get password of this employee
                    User searchUser = new User(employeeId,"",0);
                    anEmployee.AUser = searchUser.GetUserInformation(employeeId);

                    //delete employee and user information in file
                    if (anEmployee.AUser==null)       //user information has already deleted in userGUI
                    {
                        anEmployee.DeleteEmployeeInformation(anEmployee);
                    }
                    else
                    {
                        anEmployee.DeleteInformation(anEmployee);
                    }                  
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

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if ((listViewEmployee.SelectedItems.Count == 1)&&(modifyItem==true))
            {
                DialogResult result = MessageBox.Show("Do You Want To Modify?", "Modify", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    //create old employee
                    string employeeId = listViewEmployee.SelectedItems[0].SubItems[0].Text;
                    string employeefn = listViewEmployee.SelectedItems[0].SubItems[1].Text;
                    string employeeln = listViewEmployee.SelectedItems[0].SubItems[2].Text;
                    string jobTitle = listViewEmployee.SelectedItems[0].SubItems[3].Text;
                    Employee oldEmployee = new Employee(employeeId, employeefn, employeeln, jobTitle);

                    //create new employee
                    bool check = employeeValidator.Valid;
                    if (check)
                    {
                        Employee newEmployee = new Employee();
                        string newEmployeeId = "E" + employeeValidator.EmployeeId;
                        string newEmployeefn = employeeValidator.FirstName;
                        string newEmployeeln = employeeValidator.LastName;
                        string newJobTitle = employeeValidator.JobTitle;
                        if (newEmployeeId == employeeId)
                        {
                            newEmployee = new Employee(newEmployeeId, newEmployeefn, newEmployeeln, newJobTitle);
                            
                            //update
                            newEmployee.UpdateInformation(oldEmployee, newEmployee);
                            MessageBox.Show("Record has been saved.");
                            buttonAdd.Enabled = true;
                            buttonDelete.Enabled = true;
                            buttonList.Enabled = true;
                            buttonSearch.Enabled = true;
                            modifyItem = false;
                            listViewEmployee.Items.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Please enter same employee id to modify.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                           
                        }
                        employeeValidator.Valid = false;
                    }
                    else
                    {
                        MessageBox.Show("Please validate data first.");
                    }                   
                }
                else
                {
                    buttonAdd.Enabled = true;
                    buttonDelete.Enabled = true;
                    buttonList.Enabled = true;
                    buttonSearch.Enabled = true;
                    modifyItem = false;
                }

            }
            else
            {
                MessageBox.Show("Please double click one row to modify!");
            }
        }

        private void listViewEmployee_MouseDoubleClick(object sender, EventArgs e)
        {
            if (this.listViewEmployee.FocusedItem != null)  
            {
                if (listViewEmployee.SelectedItems != null)
                {
                    modifyItem = true;
                    buttonAdd.Enabled = false;
                    buttonDelete.Enabled = false;
                    buttonList.Enabled = false;
                    buttonSearch.Enabled = false;

                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //create search information
            Employee searchEmployee = null;
            if (comboBoxSearchEmployee.Text == "Employee ID")
            {
                searchEmployee = new Employee(textBoxSearchInfo.Text, "","", "");
            }
            else if (comboBoxSearchEmployee.Text == "First Name")
            {
                searchEmployee = new Employee("", textBoxSearchInfo.Text, "", "");
            }
            else if (comboBoxSearchEmployee.Text == "Last Name")
            {
                searchEmployee = new Employee("", "", textBoxSearchInfo.Text, "");
            }
            if (searchEmployee != null)
            {
                listViewEmployee.Items.Clear();
                List<Employee> listOfEmployees = searchEmployee.SearchInformation(searchEmployee);
                bool find = false;
                if (listOfEmployees != null)
                {
                    foreach (Employee oneEmployee in listOfEmployees)
                    {
                        ListViewItem listView = new ListViewItem(oneEmployee.EmpId);
                        listView.SubItems.Add(oneEmployee.FirstName);
                        listView.SubItems.Add(oneEmployee.LastName);
                        listView.SubItems.Add(oneEmployee.JobTitle);
                        listViewEmployee.Items.Add(listView);
                        find = true;
                    }
                }
                if (find == false)
                {
                    MessageBox.Show("There is no such an Employee.");
                }
            }
        }

    }
}
