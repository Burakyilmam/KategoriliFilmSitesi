using CategoryMovieApp.Models;
using CategoryMovieApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace CategoryMovieApp.Controllers
{
    public class LanguageController : Controller
    {
        LanguageRepository lr = new LanguageRepository();
        public IActionResult LanguageList(int page = 1)
        {
            return View(lr.List().ToPagedList(page, 10));
        }
        [HttpGet]
        public IActionResult LanguageAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LanguageAdd(Language l)
        {
            l.LanguageStatu = true;
            lr.Add(l);
            return RedirectToAction("LanguageList");
        }
        public IActionResult LanguageUpdate(Language l)
        {
            var Language = lr.Get(l.LanguageId);
            Language.LanguageNameTR = l.LanguageNameTR;
            Language.LanguageNameEN = l.LanguageNameEN;
            Language.LanguageStatu = l.LanguageStatu;
            Language.LanguageId = l.LanguageId;
            lr.Update(Language);
            return RedirectToAction("LanguageList");
        }
        public IActionResult LanguageDelete(int id)
        {
            lr.Delete(new Language { LanguageId = id });
            return RedirectToAction("LanguageList");
        }
        public IActionResult GetLanguage(int id)
        {
            var Language = lr.Get(id);
            Language l = new Language()
            {
                LanguageId = Language.LanguageId,
                LanguageNameTR = Language.LanguageNameTR,
                LanguageNameEN = Language.LanguageNameEN,
                LanguageStatu = Language.LanguageStatu,
            };
            return View(l);
        }
    }
}
