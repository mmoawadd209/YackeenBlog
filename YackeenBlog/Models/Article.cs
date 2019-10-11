using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YackeenBlog.Models
{
    public class Article
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }

        public IEnumerable<Comment> Comments { get; set; }

        [Required]
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? LastEditedOn { get; set; }
        public bool IsDeleted { get; set; }

        public Article()
        {
           Comments = new List<Comment>();
        }
    }
}