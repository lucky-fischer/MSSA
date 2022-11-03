using Microsoft.AspNetCore.Mvc;
//using PCAD7_Project_MVC.Filters;
using Microsoft.AspNetCore.Authorization;
using PCAD7_Project_MVC.Models;
using System.Diagnostics;

namespace PCAD7_Project_MVC.Controllers
{

    //[TypeFilter(typeof(ExceptionFilter))] // This is not neccessary, this is another option to handle errors. this is located in the filters  folder.
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Privacy()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult About()
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