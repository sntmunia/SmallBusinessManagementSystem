using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2MVC.BLL.BLL;
using Project2MVC.Models.Model;

namespace Project2.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        CustomerManager _customerManager = new CustomerManager();
        private Customer _customer = new Customer();


        //Add customer
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Customer customer)
        {

            if (ModelState.IsValid)
            {
                if (_customerManager.Add(customer))
                {
                    ViewBag.SuccessMsg = "Customer added";
                }
                else
                {
                    ViewBag.FailMsg = "Customer exist with this code";
                }
            }
            else
            {
                ViewBag.FailMsg = "Validation Error";
            }

            return View();
        }

        //Edit customer

        [HttpGet]
        public ActionResult Edit(string code)
        {
            _customer.Code = code;
            var customer = _customerManager.GetByCode(_customer);
            return View(customer);
        }

        [HttpPost]
        public ActionResult Edit(Customer customer)
        {

            if (ModelState.IsValid)
            {
                if (_customerManager.Update(customer))
                {
                    ViewBag.SuccessMsg = "Updated";
                }
                else
                {
                    ViewBag.FailMsg = "No customer exist with this code";
                }
            }
            else
            {
                ViewBag.FailMsg = "Validation Error";
            }

            return View(customer);
        }

        public string Delete(string code)
        {
            _customer.Code = code;
            if(_customerManager.Delete(_customer))
                return "Deleted";
            else
            {

                return "No customer with this code";
            }
        }
    }
}