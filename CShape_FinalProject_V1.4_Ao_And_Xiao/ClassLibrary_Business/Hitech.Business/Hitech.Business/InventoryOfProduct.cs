using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hitech.Business
{
    public class InventoryOfProduct
    {
        //- productId:string
        //- qoh:int

        private string productId;
        private int qoh;

        public string ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        public int Qoh
        {
            get { return qoh; }
            set { qoh = value; }
        }

        //constructor
        public InventoryOfProduct(string productId, int qoh) 
        {
            this.productId = productId;
            this.qoh = qoh;
        }

    }
}
