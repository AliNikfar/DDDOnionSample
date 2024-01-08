using DDDOnionSample.Entities.Customers;
using DDDOnionSample.Entities.Goods;
using DDDOnionSample.Entities.Orders;
using DDDOnionSample.Entities.SalesMan;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDOnionSample.Data.EF.Commmon
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Customer> Customers;
        public DbSet<Good> Goods;
        public DbSet<Order> Orders;
        public DbSet<Saleman> Salemans;

        public ApplicationDbContext()
        {
            AutoMapperConfiguration.Configure();
        }
    }


}
