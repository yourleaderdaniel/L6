using Microsoft.AspNetCore.Mvc;
using PizzaOrderingApp.Models;

namespace PizzaOrderingApp.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            
            var user = TempData["User"] as User;
            if (user == null)
            {
                return RedirectToAction("Register", "Account");
            }

            return View(new OrderViewModel { User = user });
        }

        [HttpPost]
        public IActionResult Create(OrderViewModel order)
        {
            
            return View("Summary", order);
        }
    }
}
