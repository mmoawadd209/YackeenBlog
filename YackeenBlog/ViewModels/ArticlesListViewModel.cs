using System.Collections.Generic;
using YackeenBlog.Models;

namespace YackeenBlog.ViewModels
{
    public class ArticlesListViewModel
    {
        public IEnumerable<Article> Articles { get; set; }
        public IEnumerable<Category> Categories { get; set; }

    }
}