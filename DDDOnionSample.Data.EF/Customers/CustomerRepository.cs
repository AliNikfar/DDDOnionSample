using AutoMapper;
using DDDOnionSample.Contract.Customers;
using DDDOnionSample.Data.EF.Commmon;
using DDDOnionSample.Entities.Customers;


namespace DDDOnionSample.Data.EF.Customers
{
    public class CustomerRepository : BaseEFRepository, ICustomerRepository
    {
        private readonly IMapper _mapper;
        public CustomerRepository(ApplicationDbContext ctx) : base(ctx)
        {
        }

        public List<CustomerDTO> Customers()
        {
            var result = _ctx.Customers.ToList();
            if (result.Count > 0)
            {
                var ResultDTO = _mapper.Map<List<CustomerDTO>>(result);
                return ResultDTO;
            }
            return null;
        }

        public Customer Find(int id)
        {
            var result = _ctx.Customers.Where(p => p.CustomerId == id).First();
            if (result is not null)
                return result;
            return null;
        }
    }
}
