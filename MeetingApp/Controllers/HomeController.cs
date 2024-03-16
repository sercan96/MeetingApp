using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MeetingApp.Controllers
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
            int hour = DateTime.Now.Hour;
            string desc = hour > 12 ? "Ýyi Günler" : "Günaydýn";
            return View(model : desc); // string olarak deðilde model olarak gönderiyoruz.
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
