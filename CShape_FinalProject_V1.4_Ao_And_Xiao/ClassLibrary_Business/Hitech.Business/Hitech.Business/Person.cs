using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hitech.Business
{
    /// <summary>
    /// Author:Xiao Su
    /// Date:2015-11-07
    /// Description:define the abstract class   
    /// </summary>
    public abstract class Person
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
    }
}
