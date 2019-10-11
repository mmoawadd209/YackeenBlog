

using YackeenBlog.Models;

namespace YackeenBlog.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IArticleRepository Articles { get; private set; }
        public ICommentRepository Comments { get; private set; }
        public ICategoryRepository Categories { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Articles = new ArticleRepository(context);
            Comments = new CommentRepository(context);
            Categories = new CategoryRepository(context);
        }
      

        public void Complete()
        {
              _context.SaveChanges();
        }
        public void Dispose()
        {
           _context.Dispose();
        }
    }
}
