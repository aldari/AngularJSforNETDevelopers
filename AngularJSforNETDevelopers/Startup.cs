using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularJSforNETDevelopers.Startup))]
namespace AngularJSforNETDevelopers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
