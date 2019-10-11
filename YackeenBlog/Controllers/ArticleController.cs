
using System;
using System.Net;
using System.Web.Mvc;
using YackeenBlog.Repositories;
using YackeenBlog.ViewModels;

namespace YackeenBlog.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        public ArticleController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }


        [HttpGet]
        public ActionResult Index()
        {
            var viewmodel = new ArticlesListViewModel
            {
                Categories = unitOfWork.Categories.GetAll()
            };

            return View(viewmodel);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            if (id == 0)            
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            
            var article = unitOfWork.Articles.Get(id);

            if (article == null)            
                return HttpNotFound();

            var viewModel = new ArticleViewModel {DomainModel = article};

            return View(viewModel);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var viewModel = new ArticleViewModel();

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
                article.LastEditedOn = DateTime.Now;

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
