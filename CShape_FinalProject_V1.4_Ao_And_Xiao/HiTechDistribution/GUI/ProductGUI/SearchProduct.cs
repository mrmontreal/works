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
    public partial class SearchProduct : Form
    {
        public SearchProduct()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listViewSearch.Columns.Clear();
            listViewSearch.Columns.Add("Product Id").Width = 130;
            listViewSearch.Columns.Add("Product Name").Width = 130;
            listViewSearch.Columns.Add("Unit Price").Width = 130;
            listViewSearch.Columns.Add("Category").Width = 130;
            listViewSearch.Columns.Add("ISBN").Width = 130;
            listViewSearch.Columns.Add("Publisher").Width = 130;
            listViewSearch.Columns.Add("Year Published").Width = 130;
            //listViewSearch.Columns.Add("Author ID").Width = 130;
            listViewSearch.Columns.Add("Author First Name").Width = 130;
            listViewSearch.Columns.Add("Author Last Name").Width = 130;
            listViewSearch.Items.Clear();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //change listview columns
            listViewSearch.Columns.Clear();
            listViewSearch.Columns.Add("Product Id").Width = 130;
            listViewSearch.Columns.Add("Product Name").Width = 130;
            listViewSearch.Columns.Add("Unit Price").Width = 130;
            listViewSearch.Columns.Add("Category").Width = 130;
            listViewSearch.Columns.Add("ISBN").Width = 130;
            listViewSearch.Columns.Add("Publisher").Width = 130;
            listViewSearch.Columns.Add("Platform").Width = 130;
            listViewSearch.Items.Clear();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            CheckProductInformation.f.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //create search information
            Product searchProduct = null; 
            if (comboBoxSearchType.Text=="Product Id")
	        {
		        searchProduct=new Product(textBoxInfo.Text,"",0,"","","");
	        }
            else if (comboBoxSearchType.Text=="Product Name")
	        {
		        searchProduct=new Product("",textBoxInfo.Text,0,"","","");
	        }
            if (searchProduct!=null)
            {
                listViewSearch.Items.Clear();
                List<Product> listOfProducts = searchProduct.SearchInformation(searchProduct);
                bool find = false;
                if (listOfProducts!=null)
                {
                    foreach (Product oneProduct in listOfProducts)
                    {
                        ListViewItem listView = new ListViewItem(oneProduct.ProductId);
                        listView.SubItems.Add(oneProduct.ProductName);
                        listView.SubItems.Add(Convert.ToString(oneProduct.UnitPrice));
                        listView.SubItems.Add(oneProduct.Category);
                        listView.SubItems.Add(oneProduct.Isbn);
                        listView.SubItems.Add(oneProduct.Publisher);
                        if (radioButtonBook.Checked && oneProduct.ProductId.Substring(0,1)=="B")
                        {
                            Book oneBook = (Book)oneProduct;
                            listView.SubItems.Add(oneBook.YearPublished);
                            //listView.SubItems.Add(oneBook.Author.AuthorId);
                            listView.SubItems.Add(oneBook.Author.FirstName);
                            listView.SubItems.Add(oneBook.Author.LastName);
                            listViewSearch.Items.Add(listView);
                            find = true;
                        }
                        else if (radioButtonSoftware.Checked && oneProduct.ProductId.Substring(0, 1) == "S")
                        {
                            Software oneSoftware = (Software)oneProduct;
                            listView.SubItems.Add(oneSoftware.Platform);
                            listViewSearch.Items.Add(listView);
                            find = true;
                        }
                    }
                }
                if (find==false)
                {
                     MessageBox.Show("no such product.");
                }                
            }

            //search

        }

    }
}
