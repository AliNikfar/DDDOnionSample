using DDDOnionSample.Entities.Customers;
using DDDOnionSample.Entities.Goods;
using DDDOnionSample.Entities.SalesMan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDOnionSample.Entities.Orders
{
    public class Order
    {
        private int _quantity { get; set; }
        private int _price { get; set; }
        private int _totalPrice { get; set; }
        public int OrderID { get; set; }
        public Good Good { get; set; }
        public Saleman SaleMan{ get; set; }
        public Customer customer{ get; set; }
        public int Quantity{
            get
            { return _quantity; }

            set 
            { 
                _quantity = value;
                UpdateTotalPrice(); 
            }
        }
        public int Price{ 
            get
            { return _price; }
            set
            {
                _price = value;
                UpdateTotalPrice();
            }
        }
        public int TotalPrice
        {
            get
            {
                return _totalPrice;
            }
            private set
            {
                _totalPrice = value;
            }
        }
        void UpdateTotalPrice()
        {
            _totalPrice = Quantity * Price;
        }

    }
}
