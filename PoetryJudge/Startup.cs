using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PoetryJudge.Startup))]
namespace PoetryJudge
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
