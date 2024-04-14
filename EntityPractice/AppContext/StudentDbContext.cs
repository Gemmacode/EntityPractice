using EntityPractice.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace EntityPractice.AppContext
{
    public class StudentDbContext : DbContext
    {
        public static string ConnString { get; set; } = "Data Source=DESKTOP-DBKTTOV\\SQLEXPRESS;Database=AAStudentsDb;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Connect Timeout=60;Encrypt=False;Trust Server Certificate=True;Command Timeout=0";
        public StudentDbContext() : base(ConnString)
        {
            Database.SetInitializer<StudentDbContext>(new MigrateDatabaseToLatestVersion<StudentDbContext,Migrations.Configuration>());
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //configure student model
            modelBuilder.Entity<Student>().HasKey(x => x.StudentId);
            modelBuilder.Entity<Student>().Property(x => x.StudentId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Student>().Property(x => x.StudentPhone);
            modelBuilder.Entity<Student>().Property(x => x.StudentName);
            modelBuilder.Entity<Student>().Property(x => x.StudentEmail);
            modelBuilder.Entity<Student>()
               .HasRequired(s => s.Department).WithMany(d => d.Students)
               .HasForeignKey(s => s.DepartmentId);

            //configure department model
            modelBuilder.Entity<Department>().HasKey(x => x.DepartmentId);
            modelBuilder.Entity<Department>().Property(x => x.DepartmentId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Department>().Property(x => x.DepartmentName);           
        }

    }
}
