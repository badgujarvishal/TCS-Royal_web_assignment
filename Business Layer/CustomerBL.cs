using TCS_Royal_Assignment_Web.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCS_Royal_Assignment_Web.Business_Layer
{
    class CustomerBL
    {
        /// <summary>
        /// Injector class will help to call the function based on the object
        /// </summary>
        public ICustomerDataDAL customerDAL;
        public CustomerBL(ICustomerDataDAL customerDAL)
        {
            this.customerDAL = customerDAL;
        }
        public List<Customer> ReadCustomerData()
        {
            return customerDAL.ReadCustomerData();
        }
    }
}
