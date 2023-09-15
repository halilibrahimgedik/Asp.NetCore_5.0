using AspDotnetCoreWorkshop.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspDotnetCoreWorkshop.Controllers
{
    public class WorkshopController : Controller
    {
        public IActionResult Index()
        {

            Product product = new()
            {
                Id = 1,
                Name = "Iphone 15",
                Quantity = 5
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
    }
}
