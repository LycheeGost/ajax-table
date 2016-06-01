using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AJAXTable.Startup))]
namespace AJAXTable
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
