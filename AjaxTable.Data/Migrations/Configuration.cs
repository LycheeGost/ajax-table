namespace AjaxTable.Data.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AjaxTable.Data.EmployeeDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AjaxTable.Data.EmployeeDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Employees.AddOrUpdate(
              new Employee { Name = "Andrew Peters", Salary = 3500000, CreatedDate = DateTime.Now, Status = true },
              new Employee { Name = "Brice Lambson", Salary = 3600000, CreatedDate = DateTime.Now, Status = true },
              new Employee { Name = "Andrew Johnson", Salary = 5400000, CreatedDate = DateTime.Now, Status = true },
              new Employee { Name = "Rowan Miller", Salary = 5400000, CreatedDate = DateTime.Now, Status = true },
              new Employee { Name = "Michael Peters", Salary = 3500000, CreatedDate = DateTime.Now, Status = true },
              new Employee { Name = "John Miller", Salary = 1600000, CreatedDate = DateTime.Now, Status = true },
              new Employee { Name = "Rowan Baker", Salary = 1400000, CreatedDate = DateTime.Now, Status = true },
              new Employee { Name = "Tom Miller", Salary = 6400000, CreatedDate = DateTime.Now, Status = true },
                new Employee { Name = "Marry Miller", Salary = 1500000, CreatedDate = DateTime.Now, Status = true },
              new Employee { Name = "Harry Miller", Salary = 1400000, CreatedDate = DateTime.Now, Status = true }
            );

            context.SaveChanges();
        }
    }
}
