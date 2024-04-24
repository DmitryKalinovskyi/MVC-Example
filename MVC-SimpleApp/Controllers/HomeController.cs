using Microsoft.AspNetCore.Mvc;
using MVC_SimpleApp.Models;
using System.Diagnostics;

namespace MVC_SimpleApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Greet(GreetViewModel greetViewModel)
        {
            return View(greetViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
