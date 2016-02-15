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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxPlatform.Enabled = false;
            comboBoxPlatform.Text = "";
            textBoxFn.Enabled = true;
            textBoxLn.Enabled = true;
            textBoxYear.Enabled = true;
            label4.Text = "B";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxFn.Enabled = false;
            textBoxLn.Enabled = false;
            textBoxYear.Enabled = false;
            textBoxFn.Text = "";
            textBoxLn.Text = "";
            textBoxYear.Text = "";
            comboBoxPlatform.Enabled = true;
            label4.Text = "S";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            CheckProductInformation.f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CheckProductBasic())
            {
                 Product aProduct= null;
                string productName = textBoxProName.Text;
                string isbn = textBoxISBN.Text;
                string category = comboBoxCategory.Text;
                double price = double.Parse(textBoxPrice.Text);
                string publisher = comboBoxPublisher.Text;
                if ((radioButton1.Checked) && CheckBookInfo())
                {
                    string productId = "B"+textBoxProId.Text;
                    string yearPublished = textBoxYear.Text;
                    string fn = textBoxFn.Text;
                    string ln = textBoxLn.Text;
                    aProduct = new Book(productId,productName, price, category, isbn, publisher, yearPublished, fn, ln);
                    if (aProduct.CheckProduct(productId))
                    {
                        MessageBox.Show("This product id has already existed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        aProduct.SaveInformation(aProduct);
                        this.Close();
                        CheckProductInformation.f.Show(); 
                    }

                }
                else if ((radioButton2.Checked) && CheckSoftwareInfo())
                {
                    string productId = "S"+textBoxProId.Text;
                    string platform= comboBoxPlatform.Text;
                    aProduct = new Software(productId,productName, price, category, isbn, publisher,platform);
                    if (aProduct.CheckProduct(productId))
                    {
                        MessageBox.Show("This product id has already existed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        aProduct.SaveInformation(aProduct);
                        this.Close();
                        CheckProductInformation.f.Show();
                    }
                }
              
            }

        }

        /// <summary>
        /// check product basic information
        /// </summary>
        /// <returns>true / false</returns>
        private bool CheckProductBasic()
        {
            Product aProduct = new Product();
            if ((Validator.IsValidNumber(textBoxProId, 4)) && (!Validator.CheckComma(textBoxProName)) && (Validator.IsPresent(textBoxProName))
                && (Validator.IsRightSize(textBoxISBN, 10)) && (Validator.IsNumeric(textBoxISBN)) && (Validator.IsPresent(comboBoxCategory)) 
                && (Validator.IsValidPrice(textBoxPrice)) && (Validator.IsPresent(comboBoxPublisher)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// check book informations
        /// </summary>
        /// <returns>true / false</returns>
        private bool CheckBookInfo()
        {
            if ((Validator.IsValidNumber(textBoxYear, 4)) && (Validator.IsValidYear(textBoxYear))&&(Validator.CheckName(textBoxFn))
                 && (!Validator.CheckComma(textBoxFn)) && (Validator.CheckName(textBoxLn)) && (!Validator.CheckComma(textBoxLn)))
            {
                return true;
            }
            else
            {
                return false;
            }       
        }

        /// <summary>
        /// check software informations
        /// </summary>
        /// <returns>true / false</returns>
        private bool CheckSoftwareInfo()
        {
            if (Validator.IsPresent(comboBoxPlatform))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
