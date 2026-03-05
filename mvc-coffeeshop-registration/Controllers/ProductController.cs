using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc_coffeeshop_registration.Models;

namespace mvc_coffeeshop_registration.Controllers
{
    public class ProductController : Controller
    {
        private CoffeeshopDbContext _coffeeshopDbContext = new CoffeeshopDbContext();
        //Call in the database

        public IActionResult Index()
        {
            List<Product> result = _coffeeshopDbContext.Products.ToList();
            //Make a list of the products from the database
            //Use the ToList() method
            return View(result);
        }

        public IActionResult Detail(int id)
        {
            Product result = _coffeeshopDbContext.Products.FirstOrDefault(x => x.Id == id);

            return View(result); =
        }
    }
}