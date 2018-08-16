using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XmsExamToDo.Startup))]
namespace XmsExamToDo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
