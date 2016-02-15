using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Hitech.Business;
using System.Windows.Forms;

namespace Hitech.DataAccess
{
    public static class ProductDataMangement
    {
        //user.dat file location
        private static string pathProduct = Application.StartupPath + "//Products.dat";

        /// <summary>
        /// read book product information from Products.dat file
        /// </summary>
        /// <returns>list of books</returns>
        public static List<Product> ReadBookDA()
        {
            List<Product> listOfBooks = new List<Product>();
            if (File.Exists(pathProduct))
            {
                using (StreamReader sReader = new StreamReader(pathProduct))
                {
                    String line = sReader.ReadLine();
                    while (line != null)
                    {
                        string[] column = line.Split(',');
                        string id = column[0];
                        if (id.Substring(0, 1) == "B")
                        {
                            string name = column[1];
                            double price = double.Parse(column[2]);
                            string category = column[3];
                            string isbn=column[4];
                            string publisher=column[5];
                            string yearPub = column[6];
                            //string authorId = column[7];
                            string authorFirstName = column[7];
                            string authorLastName = column[8];
                            int quantity = Int32.Parse(column[9]);
                            Book aBook = new Book(id, name, price, category, isbn, publisher, yearPub, authorFirstName, authorLastName,quantity);
                            listOfBooks.Add(aBook);                                                
                        }
                        line = sReader.ReadLine();  

                    }
                }
            }
            else
            {
                MessageBox.Show("There is no Products.dat file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listOfBooks;
        }


        /// <summary>
        /// read products informations from Products.dat file only except this product
        /// </summary>
        /// <returns>list of books</returns>
        public static List<Product> ReadProductDA(Product pro)
        {
            List<Product> listOfProducts = new List<Product>();
            if (File.Exists(pathProduct))
            {
                using (StreamReader sReader = new StreamReader(pathProduct))
                {
                    String line = sReader.ReadLine();
                    while (line != null)
                    {
                        string[] column = line.Split(',');
                        string id = column[0];
                        if (id.Substring(0, 1) == "B")
                        {
                            string name = column[1];
                            double price = double.Parse(column[2]);
                            string category = column[3];
                            string isbn = column[4];
                            string publisher = column[5];
                            string yearPub = column[6];
                            string authorFirstName = column[7];
                            string authorLastName = column[8];
                            int quantity = Int32.Parse(column[9]);
                            //Author anAuthor = new Author(authorFirstName,authorLastName);
                            Book aBook = new Book(id, name, price, category, isbn, publisher, yearPub, authorFirstName, authorLastName,quantity);
                            if (pro.Equals(aBook)==false)
                            {
                                listOfProducts.Add(aBook); 
                            }                            
                        }
                        else if (id.Substring(0, 1) == "S")
                        {
                            string name = column[1];
                            double price = double.Parse(column[2]);
                            string category = column[3];
                            string isbn = column[4];
                            string publisher = column[5];
                            string platform = column[6];
                            int quantity = Int32.Parse(column[7]);
                            Software aSoftware = new Software(id, name, price, category, isbn, publisher, platform,quantity);
                            if (pro.Equals(aSoftware) == false)
                            {
                                listOfProducts.Add(aSoftware);
                            }  
                        }
                        line = sReader.ReadLine();

                    }
                }
            }
            else
            {
                MessageBox.Show("There is no Products.dat file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listOfProducts;
        }

        /// <summary>
        /// read software product information from Products.dat file
        /// </summary>
        /// <returns>list of softwares</returns>
        public static List<Product> ReadSoftwareDA()
        {
            List<Product> listOfSoftwares = new List<Product>();
            if (File.Exists(pathProduct))
            {
                using (StreamReader sReader = new StreamReader(pathProduct))
                {
                    String line = sReader.ReadLine();
                    while (line != null)
                    {
                        string[] column = line.Split(',');
                        string id = column[0];
                        if (id.Substring(0, 1) == "S")
                        {
                            string name = column[1];
                            double price = double.Parse(column[2]);
                            string category = column[3];
                            string isbn = column[4];
                            string publisher=column[5];
                            string platform = column[6];
                            int quantity = Int32.Parse(column[7]);
                            Software aSoftware = new Software(id, name, price, category, isbn, publisher,platform,quantity);
                            listOfSoftwares.Add(aSoftware);
                        }
                        line = sReader.ReadLine();

                    }
                }
            }
            else
            {
                MessageBox.Show("There is no Products.dat file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listOfSoftwares;
        }

        /// <summary>
        /// write a book information to file
        /// </summary>
        /// <param name="aBook"></param>
        public static void WriteBookDA(Product pro)
        {
            Book aBook = (Book)pro;
            StreamWriter sWriter = new StreamWriter(pathProduct, true);
            sWriter.WriteLine(aBook.ProductId + "," + aBook.ProductName + "," + aBook.UnitPrice+","+aBook.Category+","+
                              aBook.Isbn+","+aBook.Publisher+","+aBook.YearPublished+","+aBook.Author.FirstName+","
                              +aBook.Author.LastName+","+aBook.Qoh);
            sWriter.Close();
        }

        /// <summary>
        /// write a software information to file
        /// </summary>
        /// <param name="pro"></param>
        public static void WriteSoftwareDA(Product pro)
        {
            Software aSoftware=(Software)pro;
            StreamWriter sWriter = new StreamWriter(pathProduct, true);
            sWriter.WriteLine(aSoftware.ProductId + "," + aSoftware.ProductName + "," + aSoftware.UnitPrice + "," + aSoftware.Category + "," +
                              aSoftware.Isbn + "," + aSoftware.Publisher + "," + aSoftware.Platform + "," + aSoftware.Qoh);
            sWriter.Close();
        }


        /// <summary>
        /// write list of products into product.dat file
        /// </summary>
        /// <param name="listOfUsers"></param>
        public static void WriteProductDA(List<Product> listOfProducts)
        {
            if (File.Exists(pathProduct))
            {
                File.Delete(pathProduct);
            }
            foreach (Product aProduct in listOfProducts)
            {
                if (aProduct.ProductId.Substring(0, 1) == "B")
                {
                    WriteBookDA(aProduct);
                }
                else if (aProduct.ProductId.Substring(0, 1) == "S")
	            {
                    WriteSoftwareDA(aProduct);
	            }
            }
        }

        /// <summary>
        /// delete a product in product.dat file
        /// </summary>
        /// <param name="aUser"></param>
        public static void DeleteProductDA(Product pro)
        {
            List<Product> listOfProducts = ReadProductDA(pro);
            WriteProductDA(listOfProducts);
        }

        /// <summary>
        /// search product information by product Id
        /// </summary>
        /// <param name="searchId"></param>
        /// <returns>list of product</returns>
        public static List<Product> SearchProductId(string searchId) 
        {
            List<Product> listOfSearch=null;
            if (File.Exists(pathProduct))
            {
                using (StreamReader sReader = new StreamReader(pathProduct))
                {
                    String line = sReader.ReadLine();
                    listOfSearch = new List<Product>();
                    while (line != null)
                    {
                        string[] column = line.Split(',');
                        string id = column[0];
                        if (id==searchId)
                        {
                            if (id.Substring(0, 1) == "B")
                            {
                                string name = column[1];
                                double price = double.Parse(column[2]);
                                string category = column[3];
                                string isbn = column[4];
                                string publisher = column[5];
                                string yearPub = column[6];
                                string authorFirstName = column[7];
                                string authorLastName = column[8];
                                int quantity = Int32.Parse(column[9]);
                                //Author anAuthor = new Author(authorFirstName,authorLastName);
                                Book aBook = new Book(id, name, price, category, isbn, publisher, yearPub, authorFirstName, authorLastName,quantity);
                                listOfSearch.Add(aBook);
                            }
                            else if (id.Substring(0, 1) == "S")
                            {
                                string name = column[1];
                                double price = double.Parse(column[2]);
                                string category = column[3];
                                string isbn = column[4];
                                string publisher = column[5];
                                string platform = column[6];
                                int quantity = Int32.Parse(column[7]);
                                Software aSoftware = new Software(id, name, price, category, isbn, publisher, platform,quantity);
                                listOfSearch.Add(aSoftware);
                            }
                            break;
                        }
                        line = sReader.ReadLine();
                    }
                }
            }
            else
            {
                MessageBox.Show("There is no Products.dat file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listOfSearch;
        }


        /// <summary>
        /// search product information by product Id
        /// </summary>
        /// <param name="searchId"></param>
        /// <returns>list of product</returns>
        public static Product SearchProductInfoById(string searchId)
        {
            Product productInfo = null;
            if (File.Exists(pathProduct))
            {
                using (StreamReader sReader = new StreamReader(pathProduct))
                {
                    String line = sReader.ReadLine();
                    productInfo = new Product();
                    while (line != null)
                    {
                        string[] column = line.Split(',');
                        string id = column[0];
                        if (id == searchId)
                        {
                            if (id.Substring(0, 1) == "B")
                            {
                                string name = column[1];
                                double price = double.Parse(column[2]);
                                string category = column[3];
                                string isbn = column[4];
                                string publisher = column[5];
                                string yearPub = column[6];
                                string authorFirstName = column[7];
                                string authorLastName = column[8];
                                int quantity = Int32.Parse(column[9]);
                                //Author anAuthor = new Author(authorFirstName,authorLastName);
                                Book aBook = new Book(id, name, price, category, isbn, publisher, yearPub, authorFirstName, authorLastName, quantity);
                                productInfo=aBook;
                            }
                            else if (id.Substring(0, 1) == "S")
                            {
                                string name = column[1];
                                double price = double.Parse(column[2]);
                                string category = column[3];
                                string isbn = column[4];
                                string publisher = column[5];
                                string platform = column[6];
                                int quantity = Int32.Parse(column[7]);
                                Software aSoftware = new Software(id, name, price, category, isbn, publisher, platform, quantity);
                                productInfo=aSoftware;
                            }
                            break;
                        }
                        line = sReader.ReadLine();
                    }
                }
            }
            else
            {
                MessageBox.Show("There is no Products.dat file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return productInfo;
        }

        /// <summary>
        /// search product information by product name
        /// </summary>
        /// <param name="searchName"></param>
        /// <returns>list of product</returns>
        public static List<Product> SearchProductName(string searchName)
        {
            List<Product> listOfSearch = null;
            if (File.Exists(pathProduct))
            {
                using (StreamReader sReader = new StreamReader(pathProduct))
                {
                    String line = sReader.ReadLine();
                    listOfSearch = new List<Product>();
                    while (line != null)
                    {
                        string[] column = line.Split(',');
                        string id = column[0];
                        string name = column[1];
                        if (name == searchName)
                        {
                            if (id.Substring(0, 1) == "B")
                            {                             
                                double price = double.Parse(column[2]);
                                string category = column[3];
                                string isbn = column[4];
                                string publisher = column[5];
                                string yearPub = column[6];
                                string authorFirstName = column[7];
                                string authorLastName = column[8];
                                int quantity = Int32.Parse(column[9]);
                                //Author anAuthor = new Author(authorFirstName,authorLastName);
                                Book aBook = new Book(id, name, price, category, isbn, publisher, yearPub, authorFirstName, authorLastName,quantity);
                                listOfSearch.Add(aBook);
                            }
                            else if (id.Substring(0, 1) == "S")
                            {
                                double price = double.Parse(column[2]);
                                string category = column[3];
                                string isbn = column[4];
                                string publisher = column[5];
                                string platform = column[6];
                                int quantity = Int32.Parse(column[7]);
                                Software aSoftware = new Software(id, name, price, category, isbn, publisher, platform,quantity);
                                listOfSearch.Add(aSoftware);
                            }
                            //break;
                        }
                        line = sReader.ReadLine();
                    }
                }
            }
            else
            {
                MessageBox.Show("There is no Products.dat file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listOfSearch;
        }
    }
}


