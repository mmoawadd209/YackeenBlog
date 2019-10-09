using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YackeenBlog.Startup))]
namespace YackeenBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
