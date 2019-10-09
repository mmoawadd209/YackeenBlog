using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YackeenBlog.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastEditedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}