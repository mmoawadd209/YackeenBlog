using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YackeenBlog.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public Article Article { get; set; }
        public string Content { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastEditedOn { get; set; }
        public bool IsDeleted { get; set; }

    }
}