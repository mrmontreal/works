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
namespace HiTechDistribution.GUI.OrderGUI
{

    /// <summary>
    /// Author:Xiao Su
    /// Date:2015-11-20
    /// </summary>
    

    public partial class FormListOfOrder : Form
    {
        public FormListOfOrder()
        {
            InitializeComponent();
        }

        public static string orderIdSelected = null;

        private void displayListOfOrder()
        {

            listViewOrder.Items.Clear();
            //copy listview
            Order od = new Order();
            ListView listView = od.GetListViewOfOrder();
            foreach (ListViewItem item in listView.Items)
            {
                listViewOrder.Items.Add((ListViewItem)item.Clone());
            }


        }
        private void FormListOfOrder_Load(object sender, EventArgs e)
        {
            displayListOfOrder();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listViewOrder.Items.Clear();
            Order od = new Order();
            ListView listView = od.GetListViewOfOrder();
            foreach (ListViewItem item in listView.Items)
            {
                if (textBoxSearch.Text == item.SubItems[0].Text || textBoxSearch.Text == item.SubItems[1].Text || textBoxSearch.Text == item.SubItems[2].Text)
                {
                    listViewOrder.Items.Add((ListViewItem)item.Clone());
                }

            }

        }


        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewOrder.Items.Clear();
            Order od = new Order();
            ListView listView = od.GetListViewOfOrder();
            foreach (ListViewItem item in listView.Items)
            {
                if (comboBoxStatus.Text == item.SubItems[7].Text)
                {
                    listViewOrder.Items.Add((ListViewItem)item.Clone());
                }

            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewOrder.SelectedItems.Count > 0)
            {

                this.Hide();
                //get item seleted
                try
                {
                    orderIdSelected = listViewOrder.SelectedItems[0].SubItems[0].Text;
                }
                catch (Exception exception)
                {
                    Console.WriteLine("An error occurred: '{0}'", exception);
                }
                //show new form
                FormUpdateOrder formUpdateOrder = new FormUpdateOrder();
                formUpdateOrder.Show();
            }
            else
            {
                MessageBox.Show("Please select one row to update!");
            }
            
           
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
           
                this.Hide();
                FormAddOrder formAddOrder = new FormAddOrder();
                formAddOrder.Show();
          
            
           
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
                    //get item seleted
                    try
                    {
                        orderIdSelected = listViewOrder.SelectedItems[0].SubItems[0].Text;
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine("An error occurred: '{0}'", exception);
                    }
                    //confirm
                    DialogResult result = MessageBox.Show("Do You Want To Delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result.Equals(DialogResult.OK))
                    {
                        //delete by orderid
                        Order od = new Order();
                        if (orderIdSelected!=null)
	                    {
                            od.OrderId = orderIdSelected;
                            od.DeleteInformation(od);
                            //refurbish listview
                            displayListOfOrder();
	                    }
                       
                        else
                        {
                            MessageBox.Show("Please select one row to delete!");
                        }
                    }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            {
                DialogResult result = MessageBox.Show("Do you want to exit the application?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    this.Close();
                }
                else
                {
                    listViewOrder.Items.Clear();
                }
            }
        }

        private void comboBoxStatus_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            listViewOrder.Items.Clear();
            Order od = new Order();
            ListView listView = od.GetListViewOfOrder();
            foreach (ListViewItem item in listView.Items)
            {
                if (comboBoxStatus.Text == item.SubItems[7].Text)
                {
                    listViewOrder.Items.Add((ListViewItem)item.Clone());
                }

            }
        }

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            listViewOrder.Items.Clear();
            Order od = new Order();
            ListView listView = od.GetListViewOfOrder();
            if (listView!=null)
            {
                foreach (ListViewItem item in listView.Items)
                {
                    if (textBoxSearch.Text == item.SubItems[0].Text || textBoxSearch.Text == item.SubItems[1].Text || textBoxSearch.Text == item.SubItems[2].Text)
                    {
                        listViewOrder.Items.Add((ListViewItem)item.Clone());
                    }

                }
            }
            else
            {
                MessageBox.Show("Can not find, Please try again");
            }
           
        }

      

    }
}
