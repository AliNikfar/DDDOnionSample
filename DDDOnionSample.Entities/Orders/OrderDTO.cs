using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDOnionSample.Entities.Orders
{
    public class OrderDTO
    {
        public int OrderID { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int TotalPrice { get; set; }
        public string GoodName  { get; set; }
        public string SaleManName  { get; set; }
        public string CustomerName  { get; set; }

    }
}
