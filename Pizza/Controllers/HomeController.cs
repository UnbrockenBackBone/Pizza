using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pizza.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Pizza.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger; 
        private IHttpContextAccessor _accessor;

        public HomeController(ILogger<HomeController> logger, IHttpContextAccessor accessor)
        {
            _logger = logger;
            _accessor = accessor;
        }

        public IActionResult Index()
        {
            _accessor.HttpContext.Session.SetInt32("count", 2);
            ViewBag.isAut = HttpContext.User.Identity.IsAuthenticated;
            ViewBag.Name = HttpContext.User.Identity.Name;
            return View();
        }

        public IActionResult About()
        {
            ViewBag.isAut = HttpContext.User.Identity.IsAuthenticated;
            ViewBag.Name = HttpContext.User.Identity.Name;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
