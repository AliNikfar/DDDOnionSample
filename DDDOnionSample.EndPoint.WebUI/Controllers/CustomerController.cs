using DDDOnionSample.Contract.Customers;
using Microsoft.AspNetCore.Mvc;

namespace DDDOnionSample.EndPoint.WebUI.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IGetAllCustomerQuery _getAllCustomerQuery;

        public CustomerController(IGetAllCustomerQuery getAllCustomerQuery)
        {
            _getAllCustomerQuery = getAllCustomerQuery;
        }

        public IActionResult Index()
        {
            var items = _getAllCustomerQuery.Execute();
            return View(items);
        }
    }
}
