using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pizza.Domain.Entities;
using System.Security.Claims;

namespace Pizza.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly DataManager dataManager;
        public CartController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index()
        {
            ViewBag.isAut = HttpContext.User.Identity.IsAuthenticated;
            ViewBag.Name = HttpContext.User.Identity.Name;
            ClaimsPrincipal currentUser = this.User;
            var currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            return View(dataManager.UserProducts.GetByUserId(System.Guid.Parse(currentUserID)));
        }

        public IActionResult Add(string id)
        {
            ViewBag.isAut = HttpContext.User.Identity.IsAuthenticated;
            ViewBag.Name = HttpContext.User.Identity.Name;
            ClaimsPrincipal currentUser = this.User;
            var currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            dataManager.UserProducts.SaveProduct(new UserProducts { Id = new System.Guid(),
                                                                    IdProduct = System.Guid.Parse(id), 
                                                                    IdUser = System.Guid.Parse(currentUserID)
            });
            return RedirectToAction(nameof(CartController.Index));
        }

        public IActionResult Delete(string id)
        {
            ViewBag.isAut = HttpContext.User.Identity.IsAuthenticated;
            ViewBag.Name = HttpContext.User.Identity.Name;
            ClaimsPrincipal currentUser = this.User;
            var currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            dataManager.UserProducts.DeleteProduct(System.Guid.Parse(id), System.Guid.Parse(currentUserID));
            return RedirectToAction(nameof(CartController.Index));
        }
    }
}
