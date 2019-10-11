

using System.Data.Entity;
using YackeenBlog.Models;

namespace YackeenBlog.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IArticleRepository Articles { get; private set; }
        public ICommentRepository Comments { get; private set; }
        public ICategoryRepository Categories { get; private set; }


        public UnitOfWork()
        {
            _context = new ApplicationDbContext();
            Articles = new ArticleRepository(_context);
            Comments = new CommentRepository(_context);
            Categories = new CategoryRepository(_context);
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
