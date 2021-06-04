using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pizza.Controllers;
using Pizza.Domain.Entities;
using Pizza.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AddProductController : Controller
    {
        private readonly DataManager dataManager;
        IWebHostEnvironment appEnvironment;

        public AddProductController(DataManager dataManager, IWebHostEnvironment appEnvironment)
        {
            this.dataManager = dataManager;
            this.appEnvironment = appEnvironment;
        }

        // GET: AddProductController/Create
        public ActionResult Create()
        {
            ViewBag.isAut = HttpContext.User.Identity.IsAuthenticated;
            ViewBag.Name = HttpContext.User.Identity.Name;
            return View();
        }

        // POST: AddProductController/Create
        [HttpPost]
        public async Task<IActionResult> Create(ProductViewModel product)
        {
            ViewBag.isAut = HttpContext.User.Identity.IsAuthenticated;
            ViewBag.Name = HttpContext.User.Identity.Name;
            try
            {
                Product item = new Product();
                item.Category = product.Category;
                item.Name = product.Name;
                item.Price = product.Price;
                item.Subtitle = product.Subtitle;

                if (product.uploads != null)
                {
                    bool first = true;
                    foreach (var uploadedFile in product.uploads)
                    {
                        if (first)
                        {
                            item.TitleImagePath = "/images/" + uploadedFile.FileName;
                            first = false;
                        }
                        // путь к папке images
                        string path = "/images/" + uploadedFile.FileName;
                        // сохраняем файл в папку images в каталоге wwwroot
                        using (var fileStream = new FileStream(appEnvironment.WebRootPath + path, FileMode.Create))
                        {
                            await uploadedFile.CopyToAsync(fileStream);
                        }
                    }
                }
                else
                    throw new Exception();

                dataManager.Products.SaveProduct(item);
                return RedirectToAction("Index", "Menu", new { area = "~" });
            }
            catch
            {
                return View();
            }
        }

        // GET: AddProductController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.isAut = HttpContext.User.Identity.IsAuthenticated;
            ViewBag.Name = HttpContext.User.Identity.Name;
            return View();
        }

        // POST: AddProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            ViewBag.isAut = HttpContext.User.Identity.IsAuthenticated;
            ViewBag.Name = HttpContext.User.Identity.Name;
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
