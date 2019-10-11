using System;
using System.Collections.Generic;
using YackeenBlog.Models;

namespace YackeenBlog.ViewModels
{
    public class ArticleViewModel
    {
        public Article DomainModel { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Article> Articles { get; set; }

    }
}