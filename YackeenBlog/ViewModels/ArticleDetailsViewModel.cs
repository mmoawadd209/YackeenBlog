﻿using System;
using System.Collections.Generic;

using YackeenBlog.Models;

namespace YackeenBlog.ViewModels
{
    public class ArticleDetailsViewModel
    {
        public Article DomainModel { get; set; }
        public List<Category> Categories { get; set; }

        public Comment CommentModel { get; set; }


    }
}