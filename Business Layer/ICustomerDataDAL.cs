using TCS_Royal_Assignment_Web.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCS_Royal_Assignment_Web.Business_Layer
{

    /// <summary>
    /// Interface to which will help to implement the different data providers like CSV , JSON , Database
    /// </summary>
    public interface ICustomerDataDAL
    {
        List<Customer> ReadCustomerData();
    }
}
