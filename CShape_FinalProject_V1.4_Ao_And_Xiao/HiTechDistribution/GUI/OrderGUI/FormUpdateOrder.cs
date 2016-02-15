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
    public partial class FormUpdateOrder : Form
    {
        public static int totalQuantity = 0;
        public static double totalPrice = 0.00;
        //get the orderId from FormListOfOrder
        string orderIdSelected = OrderGUI.FormListOfOrder.orderIdSelected;
        public FormUpdateOrder()
        {
            InitializeComponent();
        }

        //set textbox readonly
        private void itemReadOnly()
        {
            textBoxPrice.ReadOnly = true;
            textBoxIsbn.ReadOnly = true;
            textBoxPublisher.ReadOnly = true;
            textBoxYear.ReadOnly = true;
            textBoxAuthor.ReadOnly = true;
            textBoxPublisher.ReadOnly = true;
            textBoxPlatform.ReadOnly = true;
            textBoxTotalPrice.ReadOnly = true;
            textBoxCategory.ReadOnly = true;
            textBoxClientName.ReadOnly = true;
            textBoxPhone.ReadOnly = true;
            textBoxEmail.ReadOnly = true;
            textBoxAddress.ReadOnly = true;
        }

        private void displayListOfNewOrder()
        {
            listViewNewOrder.Items.Clear();
            Order od = new Order();
            List<Order> listOfOrder = new List<Order>();
            listOfOrder = od.ReadNewOrderDetail(labelOrderId.Text);
            if (listOfOrder != null)
            {
                foreach (Order item in listOfOrder)
                {
                    ListViewItem lvi = new ListViewItem(item.Client.ClientId);
                    lvi.SubItems.Add(item.Client.ClientName);
                    lvi.SubItems.Add(item.Product.ProductId);
                    lvi.SubItems.Add(item.Product.ProductName);
                    lvi.SubItems.Add(item.Product.UnitPrice.ToString());
                    lvi.SubItems.Add(item.Qty.ToString());
                    listViewNewOrder.Items.Add(lvi);
                }
            }

        }

        private void FormUpdateOrder_Load(object sender, EventArgs e)
        {
            //listViewNewOrder.Items.Clear();
         
            //load from text to listview
            if (orderIdSelected != "" && orderIdSelected != null)
            {
                //MessageBox.Show(OrderGUI.FormListOfOrder.orderIdSelected);
                labelOrderId.Text = orderIdSelected;
                Order od = new Order();
                List<Order> listOfOrder = new List<Order>();
                listOfOrder = od.ReadNewOrderDetail(orderIdSelected);
                if (listOfOrder != null)
                {
                    foreach (Order item in listOfOrder)
                    {
                        ListViewItem lvi = new ListViewItem(item.Client.ClientId);
                        lvi.SubItems.Add(item.Client.ClientName);
                        lvi.SubItems.Add(item.Product.ProductId);
                        lvi.SubItems.Add(item.Product.ProductName);
                        lvi.SubItems.Add(item.Product.UnitPrice.ToString());
                        totalPrice = totalPrice + item.Product.UnitPrice;
                        lvi.SubItems.Add(item.Qty.ToString());
                        totalQuantity = totalQuantity + item.Qty;
                        listViewNewOrder.Items.Add(lvi);
                    }
                }
                //show the total label
                labelTotalPrice.Text = totalPrice.ToString();
                labelTotalQty.Text = totalQuantity.ToString();
                //readonly
                itemReadOnly();
                //get client
                Client cl = new Client();
                List<Client> listOfClient = cl.ReadInformation();
                foreach (Client aClient in listOfClient)
                {
                    comboBoxClient.Items.Add(aClient.ClientId + "-" + aClient.ClientName);
                }
                //get product
                List<Product> listOfProducts = null;
                Book aBook = new Book();
                listOfProducts = aBook.ReadInformation();
                foreach (Book oneBook in listOfProducts)
                {
                    comboBoxProduct.Items.Add(oneBook.ProductId + "-" + oneBook.ProductName);
                }
                Software aSoftware = new Software();
                listOfProducts = aSoftware.ReadInformation();
                foreach (Software oneSoftware in listOfProducts)
                {
                    comboBoxProduct.Items.Add(oneSoftware.ProductId + "-" + oneSoftware.ProductName);
                }
            }
           

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //refresh total price and qty
            try
            {
                double price = double.Parse(listViewNewOrder.SelectedItems[0].SubItems[4].Text);
                int quantity = Int32.Parse(listViewNewOrder.SelectedItems[0].SubItems[5].Text);
                //reduce the  totalQuantity and totalPrice
                totalQuantity = totalQuantity - quantity;
                totalPrice = totalPrice - price;

                labelTotalPrice.Text = totalPrice.ToString();
                labelTotalQty.Text = totalQuantity.ToString();
            }
            catch (Exception exception)
            {
                Console.WriteLine("An error occurred: '{0}'", exception);
            }
            listViewNewOrder.Items.Remove(listViewNewOrder.SelectedItems[0]);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //TODO: validate
            if (textBoxQty.Text != "" && textBoxQty.Text != "0")
            {
                //to listview
                string orderId, clientId, clientName, productId, productName, requiredDate, shippingDate;
                int subQuantity = 0;
                double subTotal = 0.00;
                orderId = labelOrderId.Text;
                clientId = labelClientId.Text;
                productId = labelProductId.Text;
                clientName = textBoxClientName.Text;
                productName = labelProductName.Text;
                requiredDate = dateTimePickerReqDate.Text;
                shippingDate = dateTimePickerSpDate.Text;
                subQuantity = Int32.Parse(textBoxQty.Text);
                subTotal = double.Parse(textBoxTotalPrice.Text);

                ListViewItem lvi = new ListViewItem(clientId);
                lvi.SubItems.Add(clientName);
                lvi.SubItems.Add(productId);
                lvi.SubItems.Add(productName);
                lvi.SubItems.Add(subTotal.ToString());
                lvi.SubItems.Add(subQuantity.ToString());
                listViewNewOrder.Items.Add(lvi);
                //add to totalQuantity and totalPrice
                totalQuantity = totalQuantity + subQuantity;
                totalPrice = totalPrice + subTotal;
                labelTotalPrice.Text = totalPrice.ToString();
                labelTotalQty.Text = totalQuantity.ToString();

            }
            else
            {
                MessageBox.Show("Please input the quantity!");
            }

        }

        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get productid
            string[] column = comboBoxProduct.Text.Split('-');
            string productId = column[0];
            labelProductId.Text = productId;
            //get productInfo
            Product pd = new Product();
            Book bkInfo = null;
            Software sfInfo = null;
            if (productId != "" && productId.Substring(0, 1) == "B")
            {
                pd.ProductId = productId;
                bkInfo = (Book)pd.GetInformation(pd);
                textBoxPrice.Text = bkInfo.UnitPrice.ToString();
                textBoxIsbn.Text = bkInfo.Isbn;
                textBoxPublisher.Text = bkInfo.Publisher;
                textBoxYear.Text = bkInfo.YearPublished;
                textBoxAuthor.Text = bkInfo.Author.LastName + "," + bkInfo.Author.FirstName;
                labelProductName.Text = bkInfo.ProductName;
            }

            if (productId != "" && productId.Substring(0, 1) == "S")
            {
                pd.ProductId = productId;
                sfInfo = (Software)pd.GetInformation(pd);
                textBoxPrice.Text = sfInfo.UnitPrice.ToString();
                textBoxIsbn.Text = sfInfo.Isbn;
                textBoxPublisher.Text = sfInfo.Publisher;
                textBoxPlatform.Text = sfInfo.Platform;
                labelProductName.Text = sfInfo.ProductName;
            }

            //set qty =0
            textBoxQty.Text = "0";
        }

        private void comboBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get cleint id
            string[] column = comboBoxClient.Text.Split('-');
            string clientId = column[0];
            labelClientId.Text = clientId;
            //get clientInfo
            Client cl = new Client();
            Client clInfo = null;

            if (clientId != "")
            {
                cl.ClientId = clientId;
                clInfo = cl.GetClientInformation(cl);
                textBoxClientName.Text = clInfo.ClientName;
                textBoxEmail.Text = clInfo.Email;
                textBoxAddress.Text = clInfo.Street + "," + clInfo.City + "," + clInfo.Province + "," + clInfo.PostalCode;
                textBoxPhone.Text = clInfo.PhoneNumber;

            }
        }

        private void textBoxQty_TextChanged(object sender, EventArgs e)
        {
            if (Validator.IsValidEmpty(textBoxQty) || Validator.IsValidEmpty(textBoxPrice))
            {
                textBoxTotalPrice.Text = (Double.Parse(textBoxPrice.Text) * Int32.Parse(textBoxQty.Text)).ToString();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit the application?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                this.Hide();
                FormListOfOrder formListOfOrder = new FormListOfOrder();
                formListOfOrder.Show();
            }
            else
            {
                listViewNewOrder.Items.Clear();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want To Save?", "Save", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
               //delete old info
                Order delOrder = new Order();
                delOrder.OrderId = orderIdSelected;
                delOrder.UpdateInformation(null, delOrder);
               //save new info           
                int totalQuantity = 0;
                double totalPrice = 0.00;
                for (int i = 0; i < listViewNewOrder.Items.Count; i++)
                {
                    string orderId, clientId, clientName, productId, productName, requiredDate, shippingDate;
                    int quantity;
                    double price;
                    clientId = listViewNewOrder.Items[i].SubItems[0].Text;
                    clientName = listViewNewOrder.Items[i].SubItems[1].Text;
                    productId = listViewNewOrder.Items[i].SubItems[2].Text;
                    productName = listViewNewOrder.Items[i].SubItems[3].Text;
                    price = double.Parse(listViewNewOrder.Items[i].SubItems[4].Text);
                    quantity = Int32.Parse(listViewNewOrder.Items[i].SubItems[5].Text);
                    requiredDate = dateTimePickerReqDate.Text;
                    shippingDate = dateTimePickerSpDate.Text;
                    orderId = labelOrderId.Text;

                    Client clInfo = new Client();
                    clInfo.ClientId = clientId;
                    clInfo.ClientName = clientName;
                    Product pdInfo = new Product();
                    pdInfo.ProductId = productId;
                    pdInfo.ProductName = productName;
                    pdInfo.UnitPrice = price;
                    Order addOrder = new Order(orderId, clInfo, pdInfo, quantity, requiredDate, shippingDate, "");
                    //save to orderdetail file
                    addOrder.SaveInformation(addOrder);
                    totalQuantity = totalQuantity + quantity;
                    totalPrice = totalPrice + price;

                }

                //display listview
                displayListOfNewOrder();
                //successful
                MessageBox.Show("Save Orders Successful!");
                //clear listview
                listViewNewOrder.Items.Clear();
            }
        }
    }
}
