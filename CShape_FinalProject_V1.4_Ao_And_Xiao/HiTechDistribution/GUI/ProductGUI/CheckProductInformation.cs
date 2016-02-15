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

namespace HiTechDistribution.GUI.ProductGUI
{
    public partial class CheckProductInformation : Form
    {
        public static Form f;

        ///pass this product to ModProduct form
        private Product modProduct=null;

        public CheckProductInformation()
        {
            InitializeComponent();
            f = this;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //change listview columns
            listViewInformation.Columns.Clear();
            listViewInformation.Columns.Add("Product Id").Width = 130;
            listViewInformation.Columns.Add("Product Name").Width = 130;
            listViewInformation.Columns.Add("Unit Price").Width = 130;
            listViewInformation.Columns.Add("Category").Width = 130;
            listViewInformation.Columns.Add("ISBN").Width = 130;
            listViewInformation.Columns.Add("Publisher").Width = 130;
            listViewInformation.Columns.Add("Year Published").Width = 130;
            //listView1.Columns.Add("Author ID").Width = 130;
            listViewInformation.Columns.Add("Author First Name").Width = 130;
            listViewInformation.Columns.Add("Author Last Name").Width = 130;
            //list books in file
            //ListBooks();
            listViewInformation.Items.Clear();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //change listview columns
            listViewInformation.Columns.Clear();
            listViewInformation.Columns.Add("Product Id").Width = 130;
            listViewInformation.Columns.Add("Product Name").Width = 130;
            listViewInformation.Columns.Add("Unit Price").Width = 130;
            listViewInformation.Columns.Add("Category").Width = 130;
            listViewInformation.Columns.Add("ISBN").Width = 130;
            listViewInformation.Columns.Add("Publisher").Width = 130;
            listViewInformation.Columns.Add("Platform").Width = 130;
            //list software in file
            //ListSoftwares();
            listViewInformation.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddProduct addPro = new AddProduct();
            addPro.Show();
            this.Visible = false;
            //this.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SearchProduct searchPro = new SearchProduct();
            searchPro.Show();
            this.Visible = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) 
            {
                ListBooks();
            }
            else if (radioButton2.Checked)
            {
                ListSoftwares();
            }          
        }

        //list all the books in file
        private void ListBooks()
        {
            Book aBook = new Book();
            List<Product> listOfBooks = aBook.ReadInformation();
            listViewInformation.Items.Clear();
            foreach (Book oneBook in listOfBooks)
            {
                ListViewItem listView = new ListViewItem(oneBook.ProductId);
                listView.SubItems.Add(oneBook.ProductName);
                listView.SubItems.Add(Convert.ToString(oneBook.UnitPrice));
                listView.SubItems.Add(oneBook.Category);
                listView.SubItems.Add(oneBook.Isbn);
                listView.SubItems.Add(oneBook.Publisher);
                listView.SubItems.Add(oneBook.YearPublished);
                listView.SubItems.Add(oneBook.Author.FirstName);
                listView.SubItems.Add(oneBook.Author.LastName);
                listViewInformation.Items.Add(listView);
            }       
        }

        //list all the softwares in file
        private void ListSoftwares()
        {
            Software aSoftware = new Software();
            List<Product> listOfSoftwares = aSoftware.ReadInformation();
            listViewInformation.Items.Clear();
            foreach (Software oneSoftware in listOfSoftwares)
            {
                ListViewItem listView = new ListViewItem(oneSoftware.ProductId);
                listView.SubItems.Add(oneSoftware.ProductName);
                listView.SubItems.Add(Convert.ToString(oneSoftware.UnitPrice));
                listView.SubItems.Add(oneSoftware.Category);
                listView.SubItems.Add(oneSoftware.Isbn);
                listView.SubItems.Add(oneSoftware.Publisher);
                listView.SubItems.Add(oneSoftware.Platform);
                listViewInformation.Items.Add(listView);
            }
        }

        //delete one product
        private void button2_Click(object sender, EventArgs e)
        {
            if (listViewInformation.SelectedItems.Count == 1)
            {
                //confirm
                DialogResult result = MessageBox.Show("Do You Want To Delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    //delete original txt
                    string productId = listViewInformation.SelectedItems[0].SubItems[0].Text;
                    string productName = listViewInformation.SelectedItems[0].SubItems[1].Text;
                    double price = double.Parse(listViewInformation.SelectedItems[0].SubItems[2].Text);
                    string category = listViewInformation.SelectedItems[0].SubItems[3].Text;
                    string isbn = listViewInformation.SelectedItems[0].SubItems[4].Text;
                    string publisher = listViewInformation.SelectedItems[0].SubItems[5].Text;
                    Product aProduct = new Product(productId, productName, price, category, isbn, publisher);
                    aProduct.DeleteInformation(aProduct);
                    //get the selected row,delete it in listview
                    listViewInformation.Items.Remove(listViewInformation.SelectedItems[0]);
                }
            }
            else
            {
                MessageBox.Show("Please select one row to delete!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listViewInformation.SelectedItems.Count == 1)
            {            
                string productId = listViewInformation.SelectedItems[0].SubItems[0].Text;
                string productName = listViewInformation.SelectedItems[0].SubItems[1].Text;
                double price = double.Parse(listViewInformation.SelectedItems[0].SubItems[2].Text);
                string category = listViewInformation.SelectedItems[0].SubItems[3].Text;
                string isbn = listViewInformation.SelectedItems[0].SubItems[4].Text;
                string publisher = listViewInformation.SelectedItems[0].SubItems[5].Text;
                if (radioButton1.Checked)
                {
                    //delete original txt
                    string yearPublished=listViewInformation.SelectedItems[0].SubItems[6].Text;
                    string fn=listViewInformation.SelectedItems[0].SubItems[7].Text;
                    string ln=listViewInformation.SelectedItems[0].SubItems[8].Text;
                    modProduct = new Book(productId, productName, price, category, isbn, publisher, yearPublished,fn,ln);
                }
                else if (radioButton2.Checked)
                {
                    //delete original txt
                    string platform = listViewInformation.SelectedItems[0].SubItems[6].Text;
                    modProduct = new Software(productId, productName, price, category, isbn, publisher, platform);                  
                }

                //pass parameter to modify form
                ModProduct modPro = new ModProduct(productId,modProduct);
                modPro.Show();
                this.Visible = false; 

            }
            else
            {
                MessageBox.Show("Please select one row to delete!");
            }
        }

    }
}
