using CategoryMovieApp.Models;
using CategoryMovieApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CategoryMovieApp.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository cr = new CategoryRepository();
        public IActionResult CategoryList()
        {
            return View(cr.List());
        }
        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category c)
        {
            cr.Add(c);     
            return RedirectToAction("CategoryList");
        }
        public IActionResult CategoryUpdate(Category c)
        {
            cr.Update(c);
            return View();
        }
        public IActionResult CategoryDelete(int id)
        {
            cr.Delete(new Category { CategoryId = id});
            return RedirectToAction("CategoryList");
        }
        public IActionResult GetCategory(int id)
        {
            var category = cr.Get(id);
            return View(category);
        }
    }
}
