
using System.Data.Entity;
using YackeenBlog.Models;

namespace YackeenBlog.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext context) 
            : base(context)
        {
        }




        public ApplicationDbContext AppDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
