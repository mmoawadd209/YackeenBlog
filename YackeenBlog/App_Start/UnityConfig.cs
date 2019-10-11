using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using YackeenBlog.Repositories;

namespace YackeenBlog
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<IArticleRepository, ArticleRepository>();
            container.RegisterType<ICategoryRepository, CategoryRepository>();
            container.RegisterType<ICommentRepository, CommentRepository>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}