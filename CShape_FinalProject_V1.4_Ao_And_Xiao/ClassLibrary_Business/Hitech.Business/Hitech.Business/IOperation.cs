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
    /// Description:define the methods to implement     
    /// </summary>
    interface IOperation<T>
    {
        void SaveInformation(T t);
        void UpdateInformation(T t, T tt);
        void DeleteInformation(T t);
        List<T> SearchInformation(T t);
        List<T> ReadInformation();
    }
}
