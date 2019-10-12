using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


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

        public ICollection<Comment> Comments { get; set; }

        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }


        public Article()
        {
           Comments = new List<Comment>();
        }
    }
}