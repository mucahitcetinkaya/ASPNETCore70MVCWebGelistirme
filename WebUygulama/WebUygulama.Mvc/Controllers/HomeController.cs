using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebUygulama.Mvc.Models;

namespace WebUygulama.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

/*

Index Privacy kısmı uygulama acıldıgında sayfalara denk geliyor 
View kısmı Views içindeki kısım
Index yazıyorsa Views içinde de Home içinde Index.cshtml olması lazım 
Baslıgından birbirini buluyor

Pricavy de öyle

Views içinde Home içinde Pricavy.cshtml

*/