using Entities.IdentityUsers;
using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using MyDatabase;
using Owin;
using System.Linq;

[assembly: OwinStartupAttribute(typeof(Travel_Agency.Startup))]
namespace Travel_Agency
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
           // PopulateUserAndRoles();
        }
        //public void PopulateUserAndRoles()
        //{
        //    ApplicationDbContext db = new ApplicationDbContext();
        //    if (!db.Roles.Any(x=>x.Name=="Admin"))
        //    {
        //        var store = new RoleStore<IdentityRole>(db);
        //        var manager = new RoleManager<IdentityRole>(store);
        //        var role = new IdentityRole() { Name = "Admin" };

        //        manager.Create(role);
        //    }
        //    if (!db.Users.Any(x=>x.UserName=="Admin"))
        //    {
        //        var store = new UserStore<ApplicationUser>(db);
        //        var userManager = new UserManager<ApplicationUser>(store);
        //        var passwordHash = new PasswordHasher();

        //        var user = new ApplicationUser()
        //        {
        //            UserName = "Admin",
        //            FirstName = "Ektoras",
        //            LastName = "Gatsos",
        //            Email = "admin@gmail.com",
        //            Birthday = new DateTime(1978, 02, 03),
        //            PasswordHash = passwordHash.HashPassword("Admin1234!")
        //        };
        //        userManager.Create(user);
        //        userManager.AddToRole(user.Id, "Admin");
        //    }
        //}
    }
}
