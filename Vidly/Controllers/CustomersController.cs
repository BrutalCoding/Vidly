using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public IndexCustomerViewModel viewModel { get; set; }
        public CustomersController()
        {
            var customer1 = new Customer() { Id = 0, Name = "Daniel" };
            var customer2 = new Customer() { Id = 1, Name = "Daniel2" };
            viewModel = new IndexCustomerViewModel
            {
                Customers = new List<Customer>() { customer1, customer2 }
            };
        }
        // GET: Customers
        public ActionResult Index()
        {
            return View(viewModel);
        }

        public ActionResult Details(int? id)
        {
            if (!id.HasValue)
            {
                return View(new Customer());
            }
            else
            {
                Customer customer = viewModel.Customers.ElementAtOrDefault(id.Value) != null ? viewModel.Customers[id.Value] : new Customer();
                return View(customer);
            }
        }
    }
}