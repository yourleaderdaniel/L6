using Microsoft.AspNetCore.Mvc;
using PizzaOrderingApp.Models;

namespace PizzaOrderingApp.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View(new User());
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid && user.Age >= 16)
            {
                
                TempData["User"] = user;
                return RedirectToAction("Create", "Order");
            }
            return View(user);
        }
    }
}
