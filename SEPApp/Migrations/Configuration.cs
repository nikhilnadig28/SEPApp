namespace SEPApp.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using SEPApp.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SEPApp.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SEPApp.Models.ApplicationDbContext";
        }

        protected override void Seed(SEPApp.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //context.Roles.AddOrUpdate(
            //    r => r.Name,
            //    new IdentityRole { Name = "Admin" },
            //    new IdentityRole { Name = "ProductionManager" },
            //    new IdentityRole { Name = "HRManager" },
            //    new IdentityRole { Name = "AdminManager" },
            //    new IdentityRole { Name = "FinancialManager" },
            //    new IdentityRole { Name = "SeniorCustomerCare" },
            //    new IdentityRole { Name = "CustomerCare" },
            //    new IdentityRole { Name = "TeamMember" }
            //    );

            var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            string[] roleNames = { "Admin", "ProductionManager", "HRManager", "HRTeam", "AdminManager", "FinancialManager", "SeniorCustomerCare", "CustomerCare", "ServiceTeamMember", "ServiceManager", "ProductionTeamMember" };
            IdentityResult roleResult;
            foreach (var roleName in roleNames)
            {
                if (!RoleManager.RoleExists(roleName))
                {
                    roleResult = RoleManager.Create(new IdentityRole(roleName));
                }
            }
            var userRoleList = new TupleList<string, string>
            {
                { "customercare", "CustomerCare" },
                { "seniorcustomercare", "SeniorCustomerCare" },
                { "adminmanager", "AdminManager" },
                { "financialmanager", "FinancialManager" },
                { "productionmanager", "ProductionManager" },
                { "servicemanager", "ServiceManager" },
                { "hrmanager", "HRManager" },
                { "hrteam1", "HRTeam" },
                { "serviceteam1", "ServiceTeamMember" },
                { "productionteam1", "ProductionTeamMember" },

            };

            foreach (var userRole in userRoleList)
            {
                if (!context.Users.Any(u => u.UserName == userRole.Item1))
                {
                    var store = new UserStore<ApplicationUser>(context);
                    var manager = new UserManager<ApplicationUser>(store);
                    var user = new ApplicationUser { UserName = userRole.Item1 };

                    manager.Create(user, userRole.Item1);
                    manager.AddToRole(user.Id, userRole.Item2);
                }
            }

            //List<string> employeeList = new List<string> { "teammember1" , "teammember2", "teammember3", "teammember4" };

            //foreach (var item in employeeList)
            //{
            //    if (!context.Users.Any(u => u.UserName == item))
            //    {
            //        var store = new UserStore<ApplicationUser>(context);
            //        var manager = new UserManager<ApplicationUser>(store);
            //        var user = new ApplicationUser { UserName = item };

            //        manager.Create(user, item);
            //        manager.AddToRole(user.Id, "TeamMember");
            //    }
            //}
            
            //string[] userNames = { "customercare", "seniorcustomercare", "adminmanager", "financialmanager", "productionmanager", "servicemanager", "hrmanager", "hrteam1" };
           // var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
           // UserManager.AddToRoles("User ");
        }

    }
    public class TupleList<T1, T2> : List<Tuple<T1, T2>>
    {
        public void Add(T1 item, T2 item2)
        {
            Add(new Tuple<T1, T2>(item, item2));
        }
    }
}
