using CategoryMovieApp.Models;
using CategoryMovieApp.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace CategoryMovieApp.Controllers
{
    [Authorize]
    public class ContactController : Controller
    {
        ContactRepository cr = new ContactRepository();
        [AllowAnonymous]
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult ContactList(int page = 1)
        {
            return View(cr.List().Where(x => x.ContactDate <= DateTime.Now).OrderBy(x => x.ContactId).ToPagedList(page, 12));
        }
        [AllowAnonymous]
        public PartialViewResult ContactAdd(int id)
        {
            ViewBag.Id = id;
            return PartialView();
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult ContactAdd(Contact c)
        {   ContactRepository cr = new ContactRepository();
            c.ContactDate = DateTime.Today;
            c.ContactStatu = true;
            cr.Add(c);
            return RedirectToAction("Contact");
        }
        public IActionResult ContactUpdate(Contact c)
        {
            var contact = cr.Get(c.ContactId);
            contact.ContactId = c.ContactId;
            contact.ContactName = c.ContactName;
            contact.ContactPhone = c.ContactPhone;
            contact.ContactText = c.ContactText;
            contact.ContactDate = c.ContactDate;
            contact.ContactStatu = c.ContactStatu;
            cr.Update(contact);
            return RedirectToAction("ContactList");
        }
        public IActionResult ContactDelete(int id)
        {
            cr.Delete(new Contact { ContactId = id });
            return RedirectToAction("ContactList");
        }
        public IActionResult GetContact(int id)
        {
            var Contact = cr.Get(id);
            Contact c = new Contact()
            {
                ContactId = Contact.ContactId,
                ContactName = Contact.ContactName,
                ContactPhone = Contact.ContactPhone,
                ContactText = Contact.ContactText,
                ContactDate = Contact.ContactDate,
                ContactStatu = Contact.ContactStatu
            };
            return View(c);
        }
    }
}
