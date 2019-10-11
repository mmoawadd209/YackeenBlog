
using System.Collections.Generic;
using System.Web.Http;
using YackeenBlog.Models;
using YackeenBlog.Repositories;

namespace YackeenBlog.Controllers.APIs
{
    public class ArticlesController : ApiController
    {

        private readonly IUnitOfWork unitOfWork;
        public ArticlesController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

    
        [HttpGet]
        public  IEnumerable<Article> GetProjects(int id)
        {          
            var articles = unitOfWork.Articles.GetArticlesByCategory(id);
            
            return (articles);
        }
    }
}