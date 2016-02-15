using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Hitech.Business;
namespace Hitech.DataAccess
{
    public static class OrderDataMangement
    {
            //define file path 
            //finally,I did not use two fine to save data,I put everything in the OrderDetails.dat
            private static string path = Application.StartupPath + "//Orders.dat";
            private static string path2 = Application.StartupPath + "//OrderDetails.dat";
            //read file
            public static List<Order> ReadOrderDA()
            {
                List<Order> listOfOrder = new List<Order>();
                if (File.Exists(path))
                {
                    using (StreamReader sReader = new StreamReader(path))
                    {
                        String line = sReader.ReadLine();
                        while (line != null)
                        {
                            
                            string[] column = line.Split(',');
                            string orderId = column[0];
                            string clientId = column[1];
                            string clientName = column[2];
                            string productId = column[3];
                            string productName = column[4];
                            int totalQty = Int32.Parse(column[5]);
                            double price = Double.Parse(column[6]);
                            string requiredDate = column[7];
                            string shippingDate = column[8];
                            string address = column[9];
                            string phoneNumber = column[10];
                            string status = column[11];
                            //get the client and product information by id
                            Client cl = new Client();
                            cl.ClientId = clientId;
                            Client clInfo = cl.GetClientInformation(cl);
                            Product pr = new Product();
                            pr.ProductId = productId;
                            Product prInfo = pr.GetInformation(pr);
                            //MessageBox.Show(prInfo.ProductName);
                            Order order = new Order(orderId, clInfo, prInfo, totalQty, requiredDate, shippingDate, status);
                            listOfOrder.Add(order);
                            line = sReader.ReadLine();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("There is no Orders.dat file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return listOfOrder;
            }


            public static List<Order> ReadOrderDetailDA()
            {
                List<Order> listOfOrder = new List<Order>();
                if (File.Exists(path2))
                {
                    using (StreamReader sReader = new StreamReader(path2))
                    {
                        String line = sReader.ReadLine();
                        while (line != null)
                        {

                            string[] column = line.Split(',');
                            string orderId = column[0];
                            //MessageBox.Show();
                            string clientId = column[1];
                            string clientName = column[2];
                            string productId = column[3];
                            string productName = column[4];
                            double price = Double.Parse(column[5]);
                            int qty = Int32.Parse(column[6]);
                            string requiredDate = column[7];
                            string shippingDate = column[8];
                            //string address = column[9];
                            //string phoneNumber = column[10];
                            //string status = column[11];
                            //get the client and product information by id
                            Client cl = new Client();
                            cl.ClientId = clientId;
                            Client clInfo = cl.GetClientInformation(cl);
                            Product pr = new Product();
                            pr.ProductId = productId;
                            Product prInfo = pr.GetInformation(pr);
                           // MessageBox.Show(price.ToString());
                            Order order = new Order(orderId, clInfo, prInfo, price,qty, requiredDate, shippingDate, "");
                            listOfOrder.Add(order);
                            line = sReader.ReadLine();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("There is no Orders.dat file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return listOfOrder;
            }

            //write file
            //--OrderId,ClientId,ClientName,ProductId,ProductName,Price,Quantity,requiredDate,shippingDate
            public static void WriteOrderDetailDA(Order od)
            {
                StreamWriter sw = new StreamWriter(path2, true);

                sw.WriteLine(od.OrderId + "," + od.Client.ClientId + "," + od.Client.ClientName + "," + od.Product.ProductId + "," + od.Product.ProductName + "," + od.Product.UnitPrice + "," + od.Qty+ "," + od.RequiredDate+"," + od.ShippingDate);
                sw.Close();
            }

        //delete line
            public static void DeleteOrderLine(string orderId)
            {
                //string[] lines = File.ReadAllLines("filename.txt");
                //string[] newLines = RemoveUnnecessaryLine(lines);
                //File.WriteAllLines("filename.txt", newLines);


                if (File.Exists(path2))
                {
                    List<String> newColumn = new List<String>() ;
                    //read all line, compare,then copy to new string[]
                    using (StreamReader sReader = new StreamReader(path2))
                    {
                        String line = sReader.ReadLine();
                        while (line != null)
                        {
                            string[] column = line.Split(',');

                            if (orderId != column[0])
                            {
                                //MessageBox.Show(orderId);
                                //MessageBox.Show(column[0]);
                                //copy to new string[]
                                newColumn.Add(line); ;
                            }
                            line = sReader.ReadLine();
                        }
                    }
                    //delete file
                    DeleteOrderFile(path2);
                    //save new array to file
                    StreamWriter sw = new StreamWriter(path2);
                    newColumn.Sort();
                    foreach (var item in newColumn)
                    {
                        sw.WriteLine(item);
                    }

                    sw.Close();
                }
                else
                {
                    MessageBox.Show("There is no Orders.dat file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            
            }
            //delete file
            public static void DeleteOrderFile()
            {
                //delete original txt
                File.WriteAllBytes(path, new byte[0]);
            }
            public static void DeleteOrderFile(string inputPath)
            {
                //delete original txt
                File.WriteAllBytes(inputPath, new byte[0]);
            }

        }
}
