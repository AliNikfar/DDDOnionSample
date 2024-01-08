using DDDOnionSample.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDOnionSample.Contract.Orders
{
    public interface IOrderRepository
    {
        List<OrderDTO> Orders();
        Order Find(int id);
    }
}
