using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hitech.DataAccess;

namespace Hitech.Business
{
    /// <summary>
    /// Author:Ao Hu
    /// Date:2015-11-11
    /// Description:1.delete product information in the file 
    ///             2.set/get
    ///             3.overload to compare two products
    ///             4.search same product information according to object pro
    ///             5.get a product information according to object pro which has product Id
    ///             6.check parameter id is existed in file or not
    /// </summary>

    public class Product : IOperation<Product>
    {
        //- productId:string
        //- productName:string
        //- unitPrice:double
        //- category:string
        //- isbn:string
        //- publisher:string
        //- qoh:int

        private string productId;
        private string productName;
        private string category;
        private double unitPrice;
        private string isbn;
        private string publisher;
        private int qoh;

        //constructor
        public Product(string productId, string productName, double unitPrice, string category, string isbn, string publisher)
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.UnitPrice = unitPrice;
            this.Category = category;
            this.Isbn = isbn;
            this.Publisher = publisher;
            //this.qoh = qoh;
        }

        public Product() { }

        public string ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public double UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        public int Qoh
        {
            get { return qoh; }
            set { qoh = value; }
        }

        //inheriant from interface
        public virtual void SaveInformation(Product pro)
        {
            throw new NotImplementedException();
        }

        public virtual void UpdateInformation(Product oldPro,Product newPro)
        {
            throw new NotImplementedException();
        }

        public virtual List<Product> ReadInformation()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// delete product information in the file
        /// </summary>
        /// <param name="pro"></param>
        public void DeleteInformation(Product pro)
        {
            //throw new NotImplementedException();
            List<Product> listOfProducts=ProductDataMangement.ReadProductDA(pro);
            ProductDataMangement.WriteProductDA(listOfProducts);
        }

        /// <summary>
        /// search same product information according to object pro
        /// </summary>
        /// <param name="pro"></param>
        /// <returns></returns>
        public virtual List<Product> SearchInformation(Product pro)
        {
            //throw new NotImplementedException();
            List<Product> listOfProducts = null;
            if (pro.productId!="")
            {
                listOfProducts = ProductDataMangement.SearchProductId(pro.productId);
            }
            else if (pro.productName!="")
            {
                listOfProducts = ProductDataMangement.SearchProductName(pro.productName);
            }
            return listOfProducts;
        }

        /// <summary>
        /// get a product information according to object pro which has product Id
        /// </summary>
        /// <param name="pro"></param>
        /// <returns>product</returns>
        public  Product GetInformation(Product pro)
        {
            Product proInfo =new Product();
            if (pro.productId != "")
            {
                proInfo = ProductDataMangement.SearchProductInfoById(pro.productId);
            }
            
            return proInfo;
        }


        /// <summary>
        /// check parameter id is existed in file or not
        /// </summary>
        /// <param name="id"></param>
        /// <returns>true/false</returns>
        public bool CheckProduct(string id)
        {
            bool find = false;
            Product proInfo = ProductDataMangement.SearchProductInfoById(id);
            if (proInfo.productId!=null)
            {
                find = true;
            }
            return find;
        }

        /// <summary>
        /// judge a product is equal to other product or not 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>true/false</returns>
        public override bool Equals(object obj)
        {
            Product otherProduct = (Product)obj;
            if (ProductId == otherProduct.ProductId)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// override get hash code
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.productId.GetHashCode();
        }
    }
}

///