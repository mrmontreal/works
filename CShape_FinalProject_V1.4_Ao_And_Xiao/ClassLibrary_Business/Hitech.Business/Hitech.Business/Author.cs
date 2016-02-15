using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hitech.Business
{
    /// <summary>
    /// Author:Ao Hu
    /// Date:2015-11-11
    /// Description:1.create author class 
    /// </summary>
    public class Author : Person
    {
        public Author(string firstName, string lastName) : base()
        {
            //this.authorId = authorId;
            base.FirstName = firstName;
            base.LastName = lastName;
        }
    }
}
