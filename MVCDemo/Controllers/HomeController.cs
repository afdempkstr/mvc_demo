using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About(string name, int? ID)
        {
            //ID.HasValue
            if (ID == null)
            { }

            if (ID.HasValue)
            {
                var id = ID.Value;
            }

            var id2 = ID ?? 0;

            string s = null; // != "" == string.Empty

            Console.WriteLine(s?.Length ?? 0);



            ViewBag.Message = $"Your application description page for {ID}," +
                $"Name = {name}.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Model()
        {
            //dynamic d;
            //d.MyName = "Kostas";
            //d.Test = 3.14;
            //d.Action = new Action(Console.WriteLine);

            // 9999999999999999.0 - 9999999999999998.0

            var customer = new Customer()
            {
                Name = "First Last",
                Balance = -20,
                Birthday = DateTime.Today.AddYears(-30),
                NumberOfChildren = 1
            };

            using (var dbContext = new MyDbContext())
            {
                dbContext.Customers.Add(customer);
                dbContext.SaveChanges();
            }
            
            var customerList = new List<Customer>(new[] { customer, customer, customer });
            
            ViewBag.Message = "Model page";
            ViewBag.Name = "My name";
            ViewBag.Customer = customer;
            return View(customerList);
        }

        public ActionResult Invoice()
        {
            var customer = new Customer()
            {
                Name = "Customer with Invoices",
                Balance = 0m,
                NumberOfChildren = 0,
                Birthday = DateTime.Today
            };

            var invoice = new Invoice()
            {
                Amount = 5.0m,
                InvoiceDate = DateTime.Now,
                Customer = customer
            };

            using (var dbcontext = new MyDbContext())
            {
                dbcontext.Invoices.Add(invoice);
                dbcontext.SaveChanges();
            }

            return View(invoice);
        }
    }
}