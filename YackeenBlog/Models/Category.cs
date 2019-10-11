using System;
using System.ComponentModel.DataAnnotations;

namespace YackeenBlog.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
       
    }
}