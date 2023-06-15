using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using SystemZarzadzaniaPracownikami.Models;

namespace SystemZarzadzaniaPracownikami.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
        [Route("polityka-prywatnosci")]
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Redirect() {
            return RedirectToAction("Privacy");
        }
        [Route("testowy-root/{name}")]
        public IActionResult User(string name)
        {
            return View();
        }
    }
}