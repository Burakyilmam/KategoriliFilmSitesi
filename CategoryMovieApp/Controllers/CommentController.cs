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
        public IActionResult CommentUpdate(Comment c)
        {
            var comment = cr.Get(c.CommentId);
            comment.CommentId = c.CommentId;
            comment.CommentText = c.CommentText;
            comment.CommentDate = c.CommentDate;
            comment.CommentLike = c.CommentLike;
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
                CommentLike = comment.CommentLike,
                CommentStatu = comment.CommentStatu,
                MovieId = comment.MovieId,
                UserId = comment.UserId,

        };
            return View(c);
        }
    }
}