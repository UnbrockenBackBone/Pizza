using Microsoft.AspNetCore.Mvc;
using Pizza.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Controllers
{
    public class MenuController : Controller
    {
        private readonly DataManager dataManager;
        public MenuController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index()
        {
            ViewBag.isAut = HttpContext.User.Identity.IsAuthenticated;
            ViewBag.Name = HttpContext.User.Identity.Name;
            return View(dataManager.Products.GetProducts());
        }
    }
}
