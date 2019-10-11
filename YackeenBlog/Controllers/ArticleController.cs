
using PagedList;
using System;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using YackeenBlog.Models;
using YackeenBlog.Repositories;
using YackeenBlog.ViewModels;

namespace YackeenBlog.Controllers
{
    [Authorize]
    public class ArticleController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public ArticleController()
        {
            unitOfWork = new UnitOfWork();
        }
        public ActionResult Index(string sortOrder, string CurrentSort, int? page)
        {
           
            int pageSize = 10;
            int pageIndex = 1;
            pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            ViewBag.CurrentSort = sortOrder;
            sortOrder = String.IsNullOrEmpty(sortOrder) ? "Name" : sortOrder;
            IPagedList<Article> articles = unitOfWork.Articles.GetAll().ToPagedList(pageIndex, pageSize);
            switch (sortOrder)
            {
                case "Title":
                    if (sortOrder.Equals(CurrentSort))
                        articles = unitOfWork.Articles.GetAll().OrderByDescending
                                (m => m.Title).ToPagedList(pageIndex, pageSize);
                    else
                        articles = unitOfWork.Articles.GetAll().OrderBy
                                (m => m.Title).ToPagedList(pageIndex, pageSize);
                    break;
                case "CreatedOn":
                    if (sortOrder.Equals(CurrentSort))
                        articles = unitOfWork.Articles.GetAll().OrderByDescending
                                (m => m.CreatedOn).ToPagedList(pageIndex, pageSize);
                    else
                        articles = unitOfWork.Articles.GetAll().OrderBy
                                (m => m.CreatedOn).ToPagedList(pageIndex, pageSize);
                    break;
                    
                case "Default":
                    articles = unitOfWork.Articles.GetAll().OrderBy
                        (m => m.Title).ToPagedList(pageIndex, pageSize);
                    break;
            }


            ViewBag.Categories = unitOfWork.Categories.GetAll();
            return View(articles);
        }

        //[HttpGet]
        //public ActionResult Index()
        //{
        //    var viewmodel = new ArticleViewModel
        //    {
        //        Articles = unitOfWork.Articles.GetAll(),
        //        Categories = unitOfWork.Categories.GetAll()
        //    };

        //    return View(viewmodel);
        //}

        [HttpGet]
        public  ActionResult Details(int id)
        {
            if (id == 0)            
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var article = unitOfWork.Articles.GetArticleWithComments(id);

            if (article == null)            
                return HttpNotFound();


            var viewModel = new ArticleDetailsViewModel()
            {
                DomainModel = article,
                Categories = unitOfWork.Categories.GetAll().ToList(),
                CommentModel=new Comment
                {
                    ArticleId = article.Id,
                }
            };

            
            
            return View(viewModel);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var viewModel = new ArticleViewModel() {
                DomainModel = new Article(),
                Categories = unitOfWork.Categories.GetAll()
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ArticleViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

                unitOfWork.Articles.Add(viewModel.DomainModel);
                unitOfWork.Complete();

                return RedirectToAction("Index");                   
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Details(ArticleDetailsViewModel viewmodel)
        {

            viewmodel.CommentModel.CreatedOn = DateTime.Now;
            unitOfWork.Comments.Add(viewmodel.CommentModel);
            unitOfWork.Complete();

            return RedirectToAction("Details", "Article", new { id = viewmodel.CommentModel.ArticleId });
        }



        [HttpGet]
        public ActionResult Edit(int id)
        {
            if (id == 0)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var article = unitOfWork.Articles.Get(id);
            if (article == null)
                return HttpNotFound();

            var viewModel = new ArticleViewModel {DomainModel = article};

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ArticleViewModel viewModel)
        {
                if (!ModelState.IsValid)
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

                var article = unitOfWork.Articles.Get(viewModel.DomainModel.Id);

                if (article == null)
                    return HttpNotFound();

                article.Title = viewModel.DomainModel.Title;
                article.Content = viewModel.DomainModel.Content;
               

                unitOfWork.Complete();

                return RedirectToAction("Index");        
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            if (id == 0)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var article = unitOfWork.Articles.Get(id);

            if (article == null)
                return HttpNotFound();

            unitOfWork.Articles.Remove(article);
            unitOfWork.Complete();

            return RedirectToAction("Index");
        }
    }
}
