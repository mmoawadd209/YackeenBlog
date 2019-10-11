
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Web.Security;
using YackeenBlog.Models;
using YackeenBlog.Repositories;
using YackeenBlog.ViewModels;

namespace YackeenBlog.Controllers
{
    [Authorize]
    public class ArticleController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ApplicationDbContext dbContext;
        public ArticleController()
        {
            unitOfWork = new UnitOfWork();
            dbContext = new ApplicationDbContext();
        }


        [HttpGet]
        public ActionResult Index()
        {
            var viewmodel = new ArticleViewModel
            {
                Articles = unitOfWork.Articles.GetAll(),
                Categories = unitOfWork.Categories.GetAll()
            };

            return View(viewmodel);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            if (id == 0)            
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var categories = unitOfWork.Categories.GetAll().ToList();
            var article = unitOfWork.Articles.GetArticleWithComments(id);

            if (article == null)            
                return HttpNotFound();

            //var userName = dbContext.Users.FirstOrDefault(x => x.Id == article.CreatedBy).UserName;

            var viewModel = new ArticleDetailsViewModel()
            {
                DomainModel = article,
                Categories = categories,
                //AuthorName = userName
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
