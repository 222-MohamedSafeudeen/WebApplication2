using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            IList<Customer> customers = new List<Customer>();
            customers.Add(new Customer() { CustomerID = 123, CustomerName = "Mohamed", CustomerAddress = "TamilNadu" });
            customers.Add(new Customer() { CustomerID = 456, CustomerName = "Thousif", CustomerAddress = "Bihar" });
            customers.Add(new Customer() { CustomerID = 789, CustomerName = "Saif", CustomerAddress = "Uttarpradesh" });

            ViewData["Customer"] = customers;
            return View();
        }
    }
}