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
    /// Author:Ao Hu
    /// Date:2015-11-11
    /// Description:1.implement the interface 
    ///             2.set/get
    /// </summary>
    /// 
    public class Software : Product
    {
        // base class
        //- productId:string
        //- productName:string
        //- unitPrice:double
        //- category:string
        //- ISBN:string
        //- yearPublished:string
        //- publisher:string
        //- qoh:int
        //- platform:string

        //fields

        private string platform;

        //constructor
        public Software(string productId, string productName, double unitPrice, string category, string isbn, string publisher,string platform)
        {
            base.ProductId = productId;
            base.ProductName = productName;
            base.UnitPrice = unitPrice;
            base.Category = category;
            base.Isbn= isbn;
            base.Publisher = publisher;
            base.Qoh=0;
            this.Platform = platform;
        }

        public Software(string productId, string productName, double unitPrice, string category, string isbn, string publisher, string platform,int quantity)
        {
            base.ProductId = productId;
            base.ProductName = productName;
            base.UnitPrice = unitPrice;
            base.Category = category;
            base.Isbn = isbn;
            base.Publisher = publisher;
            base.Qoh = quantity;
            this.Platform = platform;
        }

        public Software() { }

        //properties

        public string Platform
        {
            get { return platform; }
            set { platform = value; }
        }

        //implemtment the interface
        public override void SaveInformation(Product pro)
        {
            //throw new NotImplementedException();
            ProductDataMangement.WriteSoftwareDA(pro);
        }

        public override void UpdateInformation(Product oldPro, Product newPro)
        {
            //throw new NotImplementedException();
            oldPro.DeleteInformation(oldPro);
            ProductDataMangement.WriteSoftwareDA(newPro);
        }

        //public override void DeleteInformation(Product pro)
        //{
        //    throw new NotImplementedException();
        //}

        public override List<Product> SearchInformation(Product pro)
        {
            throw new NotImplementedException();
        }

        public override List<Product> ReadInformation()
        {
            //throw new NotImplementedException();
            List<Product> listOfSoftware = ProductDataMangement.ReadSoftwareDA();

            return listOfSoftware;
        }
    }
}
