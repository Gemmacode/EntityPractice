using EntityPractice.AppContext;

using System.Data.Entity.Migrations;

namespace EntityPractice.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<StudentDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(StudentDbContext context)
        {
            SeedDepartments(context);
            SeedStudents(context);
        }

        private void SeedDepartments(StudentDbContext context) 
        {
            context.Departments.AddOrUpdate(
                new Models.Department { DepartmentName = "Crop Production" },
                new Models.Department { DepartmentName = "Animal Production" },
                new Models.Department { DepartmentName = "Soil Science" }
                );
            context.SaveChanges();
        }

        private void SeedStudents(StudentDbContext context)
        {
            context.Students.AddOrUpdate(
                new Models.Student { StudentName = "Abdul Jemmimah Adiburmi", StudentEmail = "abduljemmimah@gmail.com", StudentPhone = "08101132951"},
                new Models.Student { StudentName = "Unekwu Theophilus Shaibu", StudentEmail = "unekwutheophilus@gmail.com", StudentPhone = "08165408132" }
                );
            context.SaveChanges();
        }
    }
}
