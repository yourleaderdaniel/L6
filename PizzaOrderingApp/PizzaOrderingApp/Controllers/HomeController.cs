using Microsoft.AspNetCore.Mvc;

namespace PizzaOrderingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

}
