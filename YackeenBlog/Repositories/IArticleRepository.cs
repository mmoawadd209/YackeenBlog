
using System.Collections.Generic;
using YackeenBlog.Models;

namespace YackeenBlog.Repositories
{
    public interface IArticleRepository : IRepository<Article>
    {
        IEnumerable<Article> GetArticlesWithComments();
        IEnumerable<Article> GetArticlesByCategory(int id);
    }
}
