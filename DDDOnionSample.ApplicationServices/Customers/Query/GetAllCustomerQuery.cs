using DDDOnionSample.Contract.Customers;
using DDDOnionSample.Entities.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDOnionSample.ApplicationServices.Customers.Query
{
    public class GetAllCustomerQuery : IGetAllCustomerQuery
    {
        private readonly ICustomerRepository _customerRepository;

        public GetAllCustomerQuery(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public List<Customer> Execute() => _customerRepository.Customers();

    }
}
