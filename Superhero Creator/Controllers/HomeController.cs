using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Superhero_Creator.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Superhero_Creator.Controllers
{
    public class HomeController : Controller// forget about the controller part,, just home
    {
        //private readonly ILogger<HomeController> _logger;

        public HomeController()
        {
          
        }

        public IActionResult Index()//
        {
            return View();//this is under views, home, index
        }

        public IActionResult Privacy()
        {
            return View();// this is under views, home, privacy
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
