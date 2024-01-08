using AutoMapper;
using DDDOnionSample.Contract.Orders;
using DDDOnionSample.Data.EF.Commmon;
using DDDOnionSample.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDOnionSample.Data.EF.Orders
{
    public class OrderRepository : BaseEFRepository, IOrderRepository
    {
        private readonly IMapper _mapper;
        public OrderRepository(ApplicationDbContext ctx) : base(ctx)
        {
        }

        public Order Find(int id)
        {
            var result = _ctx.Orders.Where(p => p.OrderID == id).First();
            if (result is not null)
                return result;
            return null;
        }

        public List<Order> Orders()
        {
            var result = _ctx.Orders.ToList();
            if (result.Count > 0)
            {
                //var ResultDTO = _mapper.Map<List<OrderDTO>>(result);
                return result;
            }
            return null;
        }
    }
}
