// Controllers/HomeController.cs
using Microsoft.AspNetCore.Mvc;

namespace KarolTickets.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Tickets() => View();
        public IActionResult Media() => View();
        public IActionResult Contact() => View();
        public IActionResult Sponsors() => View();
    }
}

