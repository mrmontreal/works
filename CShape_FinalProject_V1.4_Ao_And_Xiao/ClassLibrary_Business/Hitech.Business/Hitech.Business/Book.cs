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
    public class Book : Product
    {
        // base class
        //- productId:string
        //- productName:string
        //- unitPrice:double
        //- category:string
        //- ISBN:string
        //- publisher:string
        //- qoh:int
        //- yearPublished:string
        //- author:Author

        //fields
        private string yearPublished;
        private Author author;

        //constructor
        public Book(string productId, string productName, double unitPrice, string category, string isbn, string publisher, string yearPublished, string authorFn, string authorLn)
        {
            base.ProductId = productId;
            base.ProductName = productName;
            base.UnitPrice = unitPrice;
            base.Category = category;
            base.Isbn = isbn;
            base.Publisher = publisher;
            base.Qoh=0;
            this.YearPublished = yearPublished;
            this.Author = new Author(authorFn, authorLn);
        }

        public Book(string productId, string productName, double unitPrice, string category, string isbn, string publisher, string yearPublished, string authorFn, string authorLn, int quantity)
        {
            base.ProductId = productId;
            base.ProductName = productName;
            base.UnitPrice = unitPrice;
            base.Category = category;
            base.Isbn = isbn;
            base.Publisher = publisher;
            base.Qoh=quantity;
            this.YearPublished = yearPublished;
            this.Author = new Author(authorFn, authorLn);
        }

        public Book() { }

        //properties     

        public string YearPublished
        {
            get { return yearPublished; }
            set { yearPublished = value; }
        }

        public Author Author
        {
            get { return author; }
            set { author = value; }
        }

        //implemtment the interface
        public override void SaveInformation(Product pro)
        {
            //throw new NotImplementedException();
            ProductDataMangement.WriteBookDA(pro);
        }

        public override void UpdateInformation(Product oldPro, Product newPro)
        {
            //throw new NotImplementedException();
            oldPro.DeleteInformation(oldPro);
            ProductDataMangement.WriteBookDA(newPro);
        }

        //public override void DeleteInformation(Product pro)
        //{
        //    throw new NotImplementedException();
        //}

        //public override List<Product> SearchInformation(Product pro)
        //{
        //    throw new NotImplementedException();
        //}

        /// <summary>
        /// read book information from product.dat
        /// </summary>
        /// <returns>List of books</returns>
        public override List<Product> ReadInformation()
        {
            //throw new NotImplementedException();
            List<Product> listOfBooks = ProductDataMangement.ReadBookDA();
            return listOfBooks;
        }
    }
}
