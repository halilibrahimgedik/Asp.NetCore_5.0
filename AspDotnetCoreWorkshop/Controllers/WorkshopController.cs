using AspDotnetCoreWorkshop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

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

        // !QueryString İle Kullanıcıdan Veri Alma
        public IActionResult GetDataWithQueryString(string isim, int yas)
        {
            return View();
        }

        //!QueryString İle Model üzerinden veri taşıma
        public IActionResult GetDataWithModelQueryString(Model model)
        {
            return View();
        }

        //!Route Parameter İle veri taşıma
        public IActionResult RouteParameter(int yas, string ad)
        {
            return View();
        }

        // ! DataAnnatations ile Validasyon
        public IActionResult ValidationsWithDataAnnatations()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ValidationsWithDataAnnatations(User user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }
            else
            {
                return View();
            }
        }

        // ! FluentValidation ile Validasyon
        public IActionResult FluentValidations()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FluentValidations(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }
            else
                return View();
        }

       
    }
}
