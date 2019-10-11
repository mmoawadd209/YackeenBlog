using System;

using System.Web.Mvc;
using YackeenBlog.Models;
using YackeenBlog.Repositories;

namespace YackeenBlog.Controllers
{
    public class CommentController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public CommentController()
        {
            unitOfWork = new UnitOfWork();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(string Content,int ArticleId)
        {
            var model = new Comment
            {
                Content = Content,
                ArticleId = ArticleId,
                CreatedOn = DateTime.Now
            };
                unitOfWork.Comments.Add(model);
                unitOfWork.Complete();

                return RedirectToAction("Details","Article",new { id = ArticleId});                   
        }
    }
}