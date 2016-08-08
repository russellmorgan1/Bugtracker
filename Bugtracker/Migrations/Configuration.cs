namespace Bugtracker.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Bugtracker.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Bugtracker.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Bugtracker.Models.ApplicationDbContext";
        }
        protected override void Seed(Bugtracker.Models.ApplicationDbContext context)
        {
            var roleManager = new RoleManager<IdentityRole>(
            new RoleStore<IdentityRole>(context));
            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
            }
            var userManager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));
            if (!context.Users.Any(u => u.Email == "russellmorgan233@gmail.com"))
            {
                userManager.Create(new ApplicationUser
                {
                    UserName = "russellmorgan233@gmail.com",
                    Email = "russellmorgan233@gmail.com",
                    FirstName = "Russell",
                    LastName = "Morgan",
                    DisplayName = "Russellmorgan233@gmail.com"
                }, "Colleen1@");
                var userId = userManager.FindByEmail("russellmorgan233@gmail.com").Id;
                userManager.AddToRole(userId, "Admin");
            }
            if (!context.Roles.Any(r => r.Name == "Project Manager"))
            {
                roleManager.Create(new IdentityRole { Name = "Project Manager" });
            }
            if (!context.Users.Any(u => u.Email == "projectmanager@coderfoundry.com"))
            {
                userManager.Create(new ApplicationUser
                {
                    UserName = "ProjectManager",
                    Email = "projectmanager@coderfoundry.com",
                    FirstName = "Project",
                    LastName = "Manager",
                    DisplayName = "Project Manager"
                }, "Project1@");
                var userId = userManager.FindByEmail("projectmanager@coderfoundry.com").Id;
                userManager.AddToRole(userId, "Project Manager");
            }
            if (!context.Roles.Any(r => r.Name == "Developer"))
            {
                roleManager.Create(new IdentityRole { Name = "Developer" });
            }
            if (!context.Users.Any(u => u.Email == "developer@coderfoundry.com"))
            {
                userManager.Create(new ApplicationUser
                {
                    UserName = "Developer",
                    Email = "developer@coderfoundry.com",
                    FirstName = "Project",
                    LastName = "Developer",
                    DisplayName = "Developer"
                }, "Developer1@");
                var userId = userManager.FindByEmail("developer@coderfoundry.com").Id;
                userManager.AddToRole(userId, "Developer");
            }
            if (!context.Roles.Any(r => r.Name == "Submitter"))
            {
                roleManager.Create(new IdentityRole { Name = "Submitter" });
            }
        }
    }
}
