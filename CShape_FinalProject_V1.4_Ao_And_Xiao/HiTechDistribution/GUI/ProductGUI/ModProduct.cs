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
    public partial class ModProduct : Form
    {
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private Product newProduct;

        public Product NewProduct
        {
            get { return newProduct; }
            set { newProduct = value; }
        }

        //ProductGUI.CheckProductInformation form1 = new ProductGUI.CheckProductInformation();
        public ModProduct()
        {
            InitializeComponent();
        }
        
        //new constructor
        public ModProduct(string id,Product newProduct)
        {
            InitializeComponent();
            this.id = id;
            this.newProduct = newProduct;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            CheckProductInformation.f.Show();
        }

        private void ModProduct_Load(object sender, EventArgs e)
        {
            //receive id and newProduct from constructor
            string productId = id;
            labelProductId.Text = productId;
            Product modProduct = newProduct;
            //fill all the textbox
            textBoxProName.Text = modProduct.ProductName;
            textBoxISBN.Text = modProduct.Isbn;
            comboBoxCategory.Text = modProduct.Category;
            textBoxPrice.Text = modProduct.UnitPrice.ToString();
            comboBoxPublisher.Text = modProduct.Publisher;
            if (productId.Substring(0,1)=="B")
            {
                Book modBook=(Book)modProduct;
                textBoxYear.Text = modBook.YearPublished;
                textBoxFn.Text = modBook.Author.FirstName;
                textBoxLn.Text = modBook.Author.LastName;
                comboBoxPlatform.Enabled = false;
            }
            else if (productId.Substring(0, 1) == "S")
            {
                Software modSoftware = (Software)modProduct;
                comboBoxPlatform.Text = modSoftware.Platform;
                textBoxYear.Enabled=false;
                textBoxFn.Enabled = false;
                textBoxLn.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CheckProductBasic())
            {
                Product modProduct = null;
                string productName = textBoxProName.Text;
                string isbn = textBoxISBN.Text;
                string category = comboBoxCategory.Text;
                double price = double.Parse(textBoxPrice.Text);
                string publisher = comboBoxPublisher.Text;
                if (id.Substring(0, 1) == "B")
                {
                    string productId = id;
                    string yearPublished = textBoxYear.Text;
                    string fn = textBoxFn.Text;
                    string ln = textBoxLn.Text;
                    modProduct = new Book(productId, productName, price, category, isbn, publisher, yearPublished, fn, ln);
                    modProduct.UpdateInformation(newProduct, modProduct);
                }
                else if (id.Substring(0, 1) == "S")
                {
                    string productId = id;
                    string platform = comboBoxPlatform.Text;
                    modProduct = new Software(productId, productName, price, category, isbn, publisher, platform);
                    modProduct.UpdateInformation(newProduct, modProduct);
                }
                this.Close();
                CheckProductInformation.f.Show();
            }
        }

        /// <summary>
        /// check product basic information
        /// </summary>
        /// <returns>true / false</returns>
        private bool CheckProductBasic()
        {
            Product aProduct = new Product();
            if ((Validator.IsPresent(textBoxProName)) && (!Validator.CheckComma(textBoxProName)) && (Validator.IsRightSize(textBoxISBN, 10))
                && (Validator.IsNumeric(textBoxISBN)) && (Validator.IsPresent(comboBoxCategory))
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
            if ((Validator.IsValidNumber(textBoxYear, 4)) && (Validator.IsValidYear(textBoxYear)) && (Validator.CheckName(textBoxFn))
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
