using DDDOnionSample.Entities.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDOnionSample.Contract.Customers
{
    public  interface  IGetAllCustomerQuery
    {
        List<Customer> Execute();
    }
}
