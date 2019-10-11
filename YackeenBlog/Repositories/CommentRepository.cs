
using System.Data.Entity;
using YackeenBlog.Models;

namespace YackeenBlog.Repositories
{
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        public CommentRepository(DbContext context) 
            : base(context)
        {
        }




        public ApplicationDbContext AppDbContext
        {
            get { return Context as ApplicationDbContext; }
        }

    }
}
