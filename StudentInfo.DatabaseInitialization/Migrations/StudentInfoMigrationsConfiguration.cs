namespace StudentInfo.DatabaseInitialization.Migrations
{
    using StudentInfo.Domain.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class StudentInfoMigrationsConfiguration : DbMigrationsConfiguration<StudentInfo.DatabaseInitialization.StudentInfoContext>
    {
        public StudentInfoMigrationsConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(StudentInfo.DatabaseInitialization.StudentInfoContext context)
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

            context.Students.AddOrUpdate(
                s => new { s.FirstName, s.LastName },
                new Student { FirstName = "Jboy", LastName = "Flaga"}
            );
        }
    }
}
