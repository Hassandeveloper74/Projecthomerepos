using Microsoft.AspNetCore.Mvc;
using secondproject.Models;
using System.Diagnostics;

namespace secondproject.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

      

    }
}
