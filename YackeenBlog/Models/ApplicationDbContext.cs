using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace YackeenBlog.Models
{


    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }


        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}