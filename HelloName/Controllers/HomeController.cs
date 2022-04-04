using HelloName.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HelloName.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult HelloUser(User user)
        {
            return View(user);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}