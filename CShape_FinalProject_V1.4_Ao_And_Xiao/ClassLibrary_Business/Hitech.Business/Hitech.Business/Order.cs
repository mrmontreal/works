using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hitech.DataAccess;
using System.Windows.Forms;
namespace Hitech.Business
{

    /// <summary>
    /// Author:Xiao Su
    /// Date:2015-11-20
    /// Description:1.implement the interface
    ///             2.set/get
    ///             
    /// </summary>
    public class Order : IOperation<Order>
    {

        //fields
        private string orderId;
        private Client client;
        private Product product;
        private int qty;
        private double totalPrice;
        private string requiredDate;
        private string shippingDate;
        private string status;

      
        //constructor
        public Order(){}
        public Order(string orderId,Client client, Product product,int qty, string requiredDate, string shippingDate,string status)
        {
            this.orderId = orderId;
            this.client = client;
            this.product = product;
            this.qty = qty;
            this.requiredDate = requiredDate;
            this.shippingDate = shippingDate;
            this.status = status;
        }

        public Order(string orderId, Client client, Product product, double totalPrice,int qty, string requiredDate, string shippingDate, string status)
        {
            this.orderId = orderId;
            this.client = client;
            this.product = product;
            this.totalPrice = totalPrice;
            this.qty = qty;
            this.requiredDate = requiredDate;
            this.shippingDate = shippingDate;
            this.status = status;
        }

        //properties
        public string OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        public string RequiredDate
        {
            get { return requiredDate; }
            set { requiredDate = value; }
        }

        public string ShippingDate
        {
            get { return shippingDate; }
            set { shippingDate = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public Client Client
        {
            get { return client; }
            set { client = value; }
        }

        public Product Product
        {
            get { return product; }
            set { product = value; }
        }

        public double TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }
        
        //implemtment the interface
        /// <summary>
        /// save order to txt file
        /// </summary>
        /// <param name="ord"></param>
        public  void SaveInformation(Order ord)
        {
            OrderDataMangement.WriteOrderDetailDA(ord);
        }

        /// <summary>
        /// modify the order
        /// </summary>
        /// <param name="oldOrd"></param>
        /// <param name="newOrd"></param>
        public void UpdateInformation(Order oldOrd,Order newOrd)
        {
            MessageBox.Show(newOrd.OrderId.ToString());
            OrderDataMangement.DeleteOrderLine(newOrd.OrderId);
        }

        /// <summary>
        /// delete an order
        /// </summary>
        /// <param name="ord"></param>
        public void DeleteInformation(Order ord)
        {
            OrderDataMangement.DeleteOrderLine(ord.OrderId);
        }

        /// <summary>
        /// search orders
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public List<Order> SearchInformation(Order order)
        {
            
            DataAccess.OrderDataMangement.ReadOrderDetailDA();
            return null;
        }

        /// <summary>
        /// read the whole orders by txt file
        /// </summary>
        /// <returns></returns>
        public List<Order> ReadInformation()
        {
            List<Order> listOfOrder = DataAccess.OrderDataMangement.ReadOrderDA();
            return listOfOrder;
            throw new NotImplementedException();
        }
        public List<Order> ReadOrderTotal()
        {
            int totalQty = 0;
            double totalPrice = 0.00;
            string preOrderId = null;
            List<Order> listOfOrderTotal = null;
            List<Order> listOfOrderDetail= DataAccess.OrderDataMangement.ReadOrderDetailDA();
            foreach (Order item in listOfOrderDetail)
            {
                if (item.OrderId != preOrderId || preOrderId==null)
                {
                    totalQty = totalQty + item.Qty;
                    totalPrice = totalPrice + item.Product.UnitPrice;
                    preOrderId = item.OrderId;
                }
                else
                {

                }
            }


            return listOfOrderTotal;
        }
        /// <summary>
        /// read the  orders detail by txt file
        /// </summary>
        /// <returns></returns>
        /// 
        public List<Order> ReadOrderDetail()
        {
            List<Order> listOfOrder = DataAccess.OrderDataMangement.ReadOrderDetailDA();
            return listOfOrder;
        }

        public List<Order> ReadNewOrderDetail(string inputOrderId)
        {
            List<Order> listOfOrderDetail = DataAccess.OrderDataMangement.ReadOrderDetailDA();
            List<Order> listOfOrderNewDetail = new List<Order>();
            foreach (Order item in listOfOrderDetail)
            {
                if (item.OrderId == inputOrderId && item != null)
                {
                    listOfOrderNewDetail.Add(item);
                }
            }
            return listOfOrderNewDetail;
        }
        
        /// <summary>
        /// get the listview of order
        /// </summary>
        /// <returns></returns>
        public ListView GetListViewOfOrder()
        {
            ListView listViewOfOrder = new ListView();
            string lvOrderId, lvClientId, lvClientName, lvRequireDate, lvShippingDate, lvStatus;
            int totalQty = 0;
            double totalPrice = 0.00;
            Order preOrder = null;
            List<Order> listOfOrderDetail = DataAccess.OrderDataMangement.ReadOrderDetailDA();
            if (listOfOrderDetail != null)
            {
                foreach (Order od in listOfOrderDetail)
                {
                    //the first item
                    if (preOrder == null)
                    {
                        preOrder = od;
                        totalQty = od.Qty;
                        totalPrice =  od.totalPrice;
                    }
                    else
                    {
                        if (od.OrderId==preOrder.OrderId)
                        {

                            totalQty = totalQty + od.Qty;
                             totalPrice = totalPrice + od.totalPrice;

                        }
                        if (od.OrderId != preOrder.OrderId)
                        {
                            //MessageBox.Show("here");
                            lvOrderId = preOrder.OrderId;
                            lvClientId = preOrder.Client.ClientId;
                            lvClientName = preOrder.Client.ClientName;
                            lvRequireDate = preOrder.RequiredDate;
                            lvShippingDate = preOrder.ShippingDate;
                            lvStatus = preOrder.GetOrderStatus();

                            //add to listview
                            ListViewItem lvi = new ListViewItem(lvOrderId);
                            lvi.SubItems.Add(lvClientId);
                            lvi.SubItems.Add(lvClientName);
                            lvi.SubItems.Add(totalQty.ToString());
                            lvi.SubItems.Add(totalPrice.ToString());
                            lvi.SubItems.Add(lvRequireDate);
                            lvi.SubItems.Add(lvShippingDate);
                            lvi.SubItems.Add(lvStatus);
                            listViewOfOrder.Items.Add(lvi);
   
                            //reset totalQty totalPrice
                            totalQty = od.Qty;
                            totalPrice = od.totalPrice;
                            preOrder = od;
                        }
                    }                                     
                }
                //add the list item to listview
                lvOrderId = preOrder.OrderId;
                lvClientId = preOrder.Client.ClientId;
                lvClientName = preOrder.Client.ClientName;
                lvRequireDate = preOrder.RequiredDate;
                lvShippingDate = preOrder.ShippingDate;
                lvStatus = preOrder.GetOrderStatus();

                //add to listview
                ListViewItem lvi2 = new ListViewItem(lvOrderId);
                lvi2.SubItems.Add(lvClientId);
                lvi2.SubItems.Add(lvClientName);
                lvi2.SubItems.Add(totalQty.ToString());
                lvi2.SubItems.Add(totalPrice.ToString());
                lvi2.SubItems.Add(lvRequireDate);
                lvi2.SubItems.Add(lvShippingDate);
                lvi2.SubItems.Add(lvStatus);
                listViewOfOrder.Items.Add(lvi2);

            }

            return listViewOfOrder;
        }
        /// <summary>
        /// check the order status
        /// </summary>
        /// <returns></returns>
        public string GetOrderStatus()
        {
            string systime=DateTime.Now.ToString("MM/dd/yy");
            string status = "" ;
            //ShippingDate<systime
            if (ShippingDate.CompareTo(systime) == -1 )
            {
                status = "Shipping";
            }
            //ShippingDate>systime
            else if (ShippingDate.CompareTo(systime)==1)
            {
                status = "Processing";
            }
            return status;
        }
    }
}
