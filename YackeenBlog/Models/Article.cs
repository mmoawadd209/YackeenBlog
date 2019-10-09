using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YackeenBlog.Models
{
    public class Article
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastEditedOn { get; set; }
        public bool IsDeleted { get; set; }

        public Article()
        {
           Comments = new List<Comment>();
        }
    }
}