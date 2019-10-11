using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using YackeenBlog.Models;

namespace YackeenBlog.Repositories
{
    public class ArticleRepository : Repository<Article>, IArticleRepository
    {
        public ArticleRepository(DbContext context) 
            : base(context)
        {
        }


        public override void Add(Article entity)
        {
            entity.CreatedOn = DateTime.Now;
            entity.CreatedBy = System.Web.HttpContext.Current.User.Identity.GetUserId();
            base.Add(entity);
        }
        public IEnumerable<Article> GetArticlesWithComments()
        {
            return AppDbContext.Articles.Include(p => p.Comments).ToList();
        }

        public IEnumerable<Article> GetArticlesByCategory(int id)
        {
            if (id==0)
                return AppDbContext.Articles.Include(a => a.Comments).ToList();

            return AppDbContext.Articles.Include(a => a.Comments).Where(a=>a.CategoryId==id).ToList();
        }
        public ApplicationDbContext AppDbContext
        {
            get { return Context as ApplicationDbContext; }
        }

    }
}