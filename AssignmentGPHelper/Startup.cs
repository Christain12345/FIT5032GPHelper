using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AssignmentGPHelper.Startup))]
namespace AssignmentGPHelper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
