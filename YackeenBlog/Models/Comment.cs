using System;
using System.ComponentModel.DataAnnotations;

namespace YackeenBlog.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }

        [Required]
        public string Content { get; set; }

        public Article Article { get; set; }

        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}