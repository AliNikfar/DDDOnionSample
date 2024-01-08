using AutoMapper;
using DDDOnionSample.Entities.Customers;
using DDDOnionSample.Entities.Goods;
using DDDOnionSample.Entities.Orders;
using DDDOnionSample.Entities.SalesMan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDOnionSample.Data.EF.Commmon
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<MyMappings>();
            });
        }
    }

    public class MyMappings : Profile
    {
        public MyMappings()
        {
            CreateMap< List<Customer>,  List<CustomerDTO>>();
            CreateMap< List<Good>, List<GoodDTO>>();
            CreateMap< List<Saleman>, List<SalemanDTO>>();
            CreateMap< List<Order>, List<OrderDTO>>();

            CreateMap <Customer, CustomerDTO>();
            CreateMap <Good, GoodDTO>();
            CreateMap <Saleman, SalemanDTO>();
            CreateMap <Order, OrderDTO>();
        }
    }
}