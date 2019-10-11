
using System;

namespace YackeenBlog.Repositories
{
   public interface IUnitOfWork : IDisposable
    {
        IArticleRepository Articles { get; }
        ICommentRepository Comments { get; }
        ICategoryRepository Categories { get; }

        void Complete();
    }
}
