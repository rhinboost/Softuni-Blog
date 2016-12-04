using Microsoft.Owin;
using Owin;
using SoftuniBlog.Models;
using SoftuniBlog.Migrations;
using System.Data.Entity;

[assembly: OwinStartupAttribute(typeof(SoftuniBlog.Startup))]
namespace SoftuniBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BlogDbContext, Configuration>());
            ConfigureAuth(app);
        }
    }
}
