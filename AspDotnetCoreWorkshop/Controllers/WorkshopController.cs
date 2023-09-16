﻿using AspDotnetCoreWorkshop.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspDotnetCoreWorkshop.Controllers
{
    public class WorkshopController : Controller
    {
        // !tuple nesnesi ile veri gönderimi
        public IActionResult Index()
        {

            Product product = new()
            {
                Name = "Iphone 15",
                Quantity = 5,
                Price = 15000
            };

            User user = new()
            {
                Id = 1,
                NameSurname = "Halil Gedik",
                Email = "asdw@gmail.com"
            };

            (Product products, User users) userProductTuple = (product, user);

            return View(userProductTuple);
        }

        // ! Model Binding
        public IActionResult CreateProduct()
        {
            Product product = new()
            {
                Name = "Xiaomi mi 15",
                Quantity = 5,
                Price = 20000
            };

            return View(product);
        }

        [HttpPost]
        public IActionResult CreateProduct(Product p)
        {
            if (p != null)
            {

                Product product = new()
                {
                    Name = p.Name,
                    Quantity = p.Quantity,
                    Price = p.Price
                };

            }



            return RedirectToAction("CreateProduct");
        }
    }
}
