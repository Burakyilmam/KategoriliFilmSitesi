using CategoryMovieApp.Models;
using CategoryMovieApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList;

namespace CategoryMovieApp.Controllers
{
    public class CommentController : Controller
    {
        CommentRepository cr = new CommentRepository();
        public IActionResult CommentList(int page = 1)
        {
            return View(cr.List("Movie","User").Where(x => x.CommentDate <= DateTime.Now).OrderBy(x=>x.MovieId).ToPagedList(page, 12));
        }
        [HttpGet]
        public PartialViewResult CommentAdd(int id)
        {
            ViewBag.Id = id;
            return PartialView();
        }
        [HttpPost]
        public IActionResult CommentAdd(Comment c)
        {
            c.CommentDate = DateTime.Today;
            c.CommentStatu = true;
            c.UserId = 1;
            cr.Add(c);
            return RedirectToAction("MoviePage", "Movie", new { @id = c.MovieId });

        }
        public IActionResult CommentUpdate(Comment c)
        {
            var comment = cr.Get(c.CommentId);
            comment.CommentId = c.CommentId;
            comment.CommentText = c.CommentText;
            comment.CommentDate = c.CommentDate;
            comment.CommentStatu = c.CommentStatu;
            comment.MovieId = c.MovieId;
            comment.UserId = c.UserId;
            cr.Update(comment);
            return RedirectToAction("CommentList");
        }
        public IActionResult CommentDelete(int id)
        {
            cr.Delete(new Comment { CommentId = id });
            return RedirectToAction("CommentList");
        }
        public IActionResult GetComment(int id)
        {
            var comment = cr.Get(id);
            Comment c = new Comment()
            {
                CommentId = comment.CommentId,
                CommentText = comment.CommentText,
                CommentDate = comment.CommentDate,
                CommentStatu = comment.CommentStatu,
                MovieId = comment.MovieId,
                UserId = comment.UserId,

        };
            UserRepository ur = new UserRepository();
            MovieRepository mr = new MovieRepository();

            var users = ur.List();
            var movies = mr.List();

            var userItems = users.Select(c => new SelectListItem
            {
                Value = c.UserId.ToString(),
                Text = c.UserName
            }).ToList();
            var movieItems = movies.Select(c => new SelectListItem
            {
                Value = c.MovieId.ToString(),
                Text = c.MovieNameTR
            }).ToList();

            ViewBag.Users = userItems;
            ViewBag.Movies = movieItems;

            return View(c);
        }
    }
}