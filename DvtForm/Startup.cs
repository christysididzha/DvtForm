using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DvtForm.Startup))]
namespace DvtForm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
