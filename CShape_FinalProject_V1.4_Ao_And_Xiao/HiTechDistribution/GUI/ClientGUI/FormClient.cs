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
using Hitech.DataAccess;


namespace HiTechDistribution.GUI.ClientGUI
{

    /// <summary>
    /// Author:Xiao Su
    /// Date:2015-11-15
    /// </summary>
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //put the selected items to textboxes
                textBoxClientId.Text = listViewClient.SelectedItems[0].SubItems[0].Text;
                textBoxClientName.Text = listViewClient.SelectedItems[0].SubItems[1].Text;
                comboBoxClientType.Text = listViewClient.SelectedItems[0].SubItems[2].Text;
                textBoxCreaditLimit.Text = listViewClient.SelectedItems[0].SubItems[3].Text;
                textBoxStreet.Text = listViewClient.SelectedItems[0].SubItems[4].Text;
                textBoxCity.Text = listViewClient.SelectedItems[0].SubItems[5].Text;
                textBoxProvince.Text = listViewClient.SelectedItems[0].SubItems[6].Text;
                textBoxPostalCode.Text = listViewClient.SelectedItems[0].SubItems[7].Text;
                textBoxPhoneNumber.Text = listViewClient.SelectedItems[0].SubItems[8].Text;
                textBoxFax.Text = listViewClient.SelectedItems[0].SubItems[9].Text;
                textBoxEmail.Text = listViewClient.SelectedItems[0].SubItems[10].Text;
            }
            catch (Exception exception)
            {
                Console.WriteLine("An error occurred: '{0}'", exception);
            }
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            displayListOfClient();
        }
        //display list of client
        private void displayListOfClient()
        {
            listViewClient.Items.Clear();
            Client clientList = new Client();
            List<Client> listOfClient = new List<Client>();
            //get the List<Client> from the business layer
            listOfClient = clientList.ReadInformation();
            foreach (Client cl in listOfClient)
            {
                ListViewItem lvi = new ListViewItem(cl.ClientId);
                lvi.SubItems.Add(cl.ClientName);
                lvi.SubItems.Add(cl.ClientType);
                lvi.SubItems.Add(cl.CreaditLimit.ToString());
                lvi.SubItems.Add(cl.Street);
                lvi.SubItems.Add(cl.City);
                lvi.SubItems.Add(cl.Province);
                lvi.SubItems.Add(cl.PostalCode);
                lvi.SubItems.Add(cl.PhoneNumber);
                lvi.SubItems.Add(cl.Fax);
                lvi.SubItems.Add(cl.Email);
                listViewClient.Items.Add(lvi);
            }
        }
        //overloading  displayListOfClient
        private void displayListOfClient(List<Client> listOfClient)
        {

            if (listOfClient != null)
            {
                listViewClient.Items.Clear();
                foreach (Hitech.Business.Client cl in listOfClient)
                {
                    ListViewItem lvi = new ListViewItem(cl.ClientId);
                    lvi.SubItems.Add(cl.ClientName);
                    lvi.SubItems.Add(cl.ClientType);
                    lvi.SubItems.Add(cl.CreaditLimit.ToString());
                    lvi.SubItems.Add(cl.Street);
                    lvi.SubItems.Add(cl.City);
                    lvi.SubItems.Add(cl.Province);
                    lvi.SubItems.Add(cl.PostalCode);
                    lvi.SubItems.Add(cl.PhoneNumber);
                    lvi.SubItems.Add(cl.Fax);
                    lvi.SubItems.Add(cl.Email);
                    listViewClient.Items.Add(lvi);
                }
            }
        }
        //reset the form
        private void restForm()
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Clear();
                }
                if (ctrl is ComboBox)
                {
                    (ctrl as ComboBox).ResetText();
                }
            }
        }
        //save one item
        private void buttonSave_Click(object sender, EventArgs e)
        {
            //add new information to listview
            //confirm, then save to txt,successful or not
            DialogResult result = MessageBox.Show("Do You Want To Save?", "Save", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                //TO-DO:validate
                if (Validator.IsValidEmpty(textBoxClientId))
                {
                    String clientId;
                    if (textBoxClientId.Text.Substring(0, 1) == "C")
                    {
                        clientId = textBoxClientId.Text;
                    }
                    else
                    {
                        clientId = "C" + textBoxClientId.Text;
                    }

                    Client clientSave = new Client(clientId, textBoxClientName.Text, comboBoxClientType.Text, textBoxStreet.Text, textBoxCity.Text, textBoxProvince.Text, textBoxPostalCode.Text, textBoxPhoneNumber.Text, textBoxFax.Text, Convert.ToDouble(textBoxCreaditLimit.Text), textBoxEmail.Text);
                    //save
                    clientSave.SaveInformation(clientSave);
                    //reset
                    restForm();
                    //reload  txt file to listview
                    displayListOfClient();
                }
            }
                else
                {
                    listViewClient.Items.Clear();
                }
                
              
        }
        //update one item
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count > 0)
            {
                 //confirm
                DialogResult result = MessageBox.Show("Do You Want To Update?", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result.Equals(DialogResult.OK))
                    {
                        ////TO-DO:validate

                        if (result.Equals(DialogResult.OK))
                        {

                            try
                            {
                                //get old information which need to update
                                Client newCli = new Client();
                                newCli.ClientId = textBoxClientId.Text;
                                newCli.ClientName = textBoxClientName.Text;
                                newCli.ClientType = comboBoxClientType.Text;
                                newCli.CreaditLimit = Double.Parse(textBoxCreaditLimit.Text);
                                newCli.Street = textBoxStreet.Text;
                                newCli.City = textBoxCity.Text;
                                newCli.Province = textBoxProvince.Text;
                                newCli.PostalCode = textBoxPostalCode.Text;
                                newCli.PhoneNumber = textBoxPhoneNumber.Text;
                                newCli.Fax = textBoxFax.Text;
                                newCli.Email = textBoxEmail.Text;

                                Client oldCli = new Client();
                                oldCli.ClientId = listViewClient.SelectedItems[0].SubItems[0].Text;
                                oldCli.ClientName = listViewClient.SelectedItems[0].SubItems[1].Text;
                                oldCli.ClientType = listViewClient.SelectedItems[0].SubItems[2].Text;
                                oldCli.CreaditLimit = Double.Parse(listViewClient.SelectedItems[0].SubItems[3].Text);
                                oldCli.Street = listViewClient.SelectedItems[0].SubItems[4].Text;
                                oldCli.City = listViewClient.SelectedItems[0].SubItems[5].Text;
                                oldCli.Province = listViewClient.SelectedItems[0].SubItems[6].Text;
                                oldCli.PostalCode = listViewClient.SelectedItems[0].SubItems[7].Text;
                                oldCli.PhoneNumber = listViewClient.SelectedItems[0].SubItems[8].Text;
                                oldCli.Fax = listViewClient.SelectedItems[0].SubItems[9].Text;
                                oldCli.Email = listViewClient.SelectedItems[0].SubItems[10].Text;
                                //get the object which we need to update,then call the function
                                newCli.UpdateInformation(oldCli, newCli);
                                //update listview
                                displayListOfClient();
                                MessageBox.Show("Update Successful!");
                            }
                            catch (Exception exception)
                            {
                                Console.WriteLine("An error occurred: '{0}'", exception);
                            }
                        }
                    }
            }
            else
            {
                MessageBox.Show("Please select an item before updating a value.");
            }
           
        }
        //delete one item
        private void buttonDelete_Click(object sender, EventArgs e)
        {

                if (listViewClient.SelectedItems.Count > 0)
                {
                    //confirm
                    DialogResult result = MessageBox.Show("Do You Want To Delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result.Equals(DialogResult.OK))
                    {
                   
                    //get the object which we need to delete,then call the function
                    try
                     {
                        Client clientDelete = new Client();
                        clientDelete.ClientId = listViewClient.SelectedItems[0].SubItems[0].Text;
                        clientDelete.ClientName = listViewClient.SelectedItems[0].SubItems[1].Text;
                        clientDelete.ClientType = listViewClient.SelectedItems[0].SubItems[2].Text;
                        clientDelete.CreaditLimit = Double.Parse(listViewClient.SelectedItems[0].SubItems[3].Text);
                        clientDelete.Street = listViewClient.SelectedItems[0].SubItems[4].Text;
                        clientDelete.City = listViewClient.SelectedItems[0].SubItems[5].Text;
                        clientDelete.Province = listViewClient.SelectedItems[0].SubItems[6].Text;
                        clientDelete.PostalCode = listViewClient.SelectedItems[0].SubItems[7].Text;
                        clientDelete.PhoneNumber = listViewClient.SelectedItems[0].SubItems[8].Text;
                        clientDelete.Fax = listViewClient.SelectedItems[0].SubItems[9].Text;
                        clientDelete.Email = listViewClient.SelectedItems[0].SubItems[10].Text;
                        clientDelete.DeleteInformation(clientDelete);
                       //get the selected row,delete it in listview
                        listViewClient.Items.Remove(listViewClient.SelectedItems[0]);
                        MessageBox.Show("Delete Successful!");
                     }
                    catch (Exception exception)
                    {
                        Console.WriteLine("An error occurred: '{0}'", exception);
                    }
                   }
                }
                else
                {
                    MessageBox.Show("Please select one row to delete!");
                }
              
         
        }
        //search one item
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //TO-DO:validate
            //get searching key from the form by name,type,phoneNumber
            comboBoxClientType.Text = "";
            Client clientSearch = new Client();
            
            if (!String.IsNullOrEmpty(textBoxSearch.Text))
            {   //by name
                clientSearch.ClientName = textBoxSearch.Text;
            }
            else if (!String.IsNullOrEmpty(comboBoxSearch.Text))
            {
                //by type
                clientSearch.ClientType = comboBoxSearch.Text;
            }
            else if (!String.IsNullOrEmpty(textBoxSearch.Text))
            {
                //by phoneNumber
                clientSearch.PhoneNumber = textBoxSearch.Text;
            }
            else if (!String.IsNullOrEmpty(textBoxSearch.Text))
            {
                //by email
                clientSearch.PhoneNumber = textBoxSearch.Text;
            }
            else
            {
                MessageBox.Show("Please enter the client's name or client's type or client's phonenumber to search.");
            }
            List<Client> listOfFound = clientSearch.SearchInformation(clientSearch);

            if (listOfFound != null)
            {
                //show the result
                displayListOfClient(listOfFound);
            }
            else
            {
                MessageBox.Show("Can not Find, Please try again.");
            }
            


        }
        //list items
        private void buttonList_Click(object sender, EventArgs e)
        {
            displayListOfClient();
        }
        //reset
        private void buttonReset_Click(object sender, EventArgs e)
        {
            restForm();
        }
        //exit
        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit the application?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                this.Close();
            }
            else
            {
                textBoxClientId.Focus();
            }
        }
    }
}
