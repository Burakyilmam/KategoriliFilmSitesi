using CategoryMovieApp.Models;
using CategoryMovieApp.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace CategoryMovieApp.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        CategoryRepository cr = new CategoryRepository();
        public IActionResult CategoryList(int page = 1)
        {
            return View(cr.List().ToPagedList(page,5));
        }
        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category c)
        {
            c.CategoryStatu = true;
            cr.Add(c);     
            return RedirectToAction("CategoryList");
        }
        public IActionResult CategoryUpdate(Category c)
        {
            var category = cr.Get(c.CategoryId);
            category.CategoryNameTR = c.CategoryNameTR;
            category.CategoryNameEN = c.CategoryNameEN;
            category.CategoryStatu = c.CategoryStatu;
            category.CategoryId = c.CategoryId;
            cr.Update(category);
            return RedirectToAction("CategoryList");
        }
        public IActionResult CategoryDelete(int id)
        {
            cr.Delete(new Category { CategoryId = id});
            return RedirectToAction("CategoryList");
        }
        public IActionResult GetCategory(int id)
        {
            var category = cr.Get(id);
            Category c = new Category()
            {
                CategoryId = category.CategoryId,
                CategoryNameTR = category.CategoryNameTR,
                CategoryNameEN = category.CategoryNameEN,
                CategoryStatu = category.CategoryStatu
            };
            return View(c);
        }
    }
}
