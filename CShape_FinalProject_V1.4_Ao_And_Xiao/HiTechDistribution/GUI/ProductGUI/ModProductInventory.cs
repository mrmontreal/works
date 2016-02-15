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
    public partial class ModProductInventory : Form
    {
        private int total=0;

        public ModProductInventory()
        {
            InitializeComponent();
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Product> listOfProducts = null;
            comboBoxName.Items.Clear();
            if (comboBoxType.Text == "Book")
            {
                Book aBook = new Book();
                listOfProducts = aBook.ReadInformation();
                foreach (Book oneBook in listOfProducts)
                {
                    comboBoxName.Items.Add(oneBook.ProductName);
                }
            }
            else if (comboBoxType.Text == "Software")
            {
                Software aSoftware = new Software();
                listOfProducts = aSoftware.ReadInformation();
                foreach (Software oneSoftware in listOfProducts)
                {
                    comboBoxName.Items.Add(oneSoftware.ProductName);
                }
            }
        }

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //read qoh from a product
            textBoxQoh.Text = "";
            List<Product> listOfProduct=null;
            if (comboBoxType.Text == "Book")
            {
                Product searchProduct = new Product("", comboBoxName.Text, 0, "", "", "");
                listOfProduct = searchProduct.SearchInformation(searchProduct);
                foreach (var item in listOfProduct)
                {
                    if (item.ProductId.Substring(0, 1) == "B")
                    {
                        textBoxQoh.Text = item.Qoh.ToString();
                    }
                }
            }
            else if (comboBoxType.Text == "Software")
            {
                Product searchProduct = new Product("", comboBoxName.Text, 0, "", "", "");
                listOfProduct = searchProduct.SearchInformation(searchProduct);
                foreach (var item in listOfProduct)
                {
                    if (item.ProductId.Substring(0, 1) == "S")
                    {
                        textBoxQoh.Text = item.Qoh.ToString();
                    }                   
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valid = false;
            if (Validator.IsNumeric(textBoxCheck))
            {
                //calulate total quantity
                if (radioButtonCheckin.Checked)
                {
                    total = Int32.Parse(textBoxCheck.Text) + Int32.Parse(textBoxQoh.Text);
                    valid = true;
                }
                else if (radioButtonCheckout.Checked)
                {
                    int qoh=Int32.Parse(textBoxQoh.Text);
                    int checkout=Int32.Parse(textBoxCheck.Text);
                    if (qoh>=checkout)
                    {
                        total = qoh - checkout;
                        valid = true;
                    }
                    else
                    {
                        MessageBox.Show("Quantity On Hand is not enough to checkout.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                if (valid)
                {
                     //update product quantity
                    List<Product> listOfProduct = null;
                    if (comboBoxType.Text == "Book")
                    {
                        Product searchProduct = new Product("", comboBoxName.Text, 0, "", "", "");
                        listOfProduct = searchProduct.SearchInformation(searchProduct);
                        foreach (var item in listOfProduct)
                        {
                            if (item.ProductId.Substring(0, 1) == "B")
                            {
                                Product newItem = item;
                                newItem.Qoh = total;
                                newItem.UpdateInformation(item,newItem);
                                textBoxQoh.Text = total.ToString();
                                textBoxCheck.Text = "";
                            }
                        }
                    }
                    else if (comboBoxType.Text == "Software")
                    {
                        Product searchProduct = new Product("", comboBoxName.Text, 0, "", "", "");
                        listOfProduct = searchProduct.SearchInformation(searchProduct);
                        foreach (var item in listOfProduct)
                        {
                            if (item.ProductId.Substring(0, 1) == "S")
                            {
                                Product newItem = item;
                                newItem.Qoh = total;
                                newItem.UpdateInformation(item, newItem);
                                textBoxQoh.Text = total.ToString();
                                textBoxCheck.Text = "";
                            }
                        }
                    }                   
                }
                
            }

        }

        private void radioButtonCheckin_CheckedChanged(object sender, EventArgs e)
        {
            labelInfor.Text = "Checkin :";
        }

        private void radioButtonCheckout_CheckedChanged(object sender, EventArgs e)
        {
            labelInfor.Text = "Checkout :";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
