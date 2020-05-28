using System.Data.Entity;
using Task.Core.Entities;
using Task.Infrastructure.Configurations;

namespace Task.Infrastructure
{
    public class AppDbContext : DbContext
    {
        private const string Connection =
            "Data Source=(localdb)\\MSSQLLocalDB;" +
            "Initial Catalog=Db;" +
            "Integrated Security=True";

        public DbSet<Employee> Employees { get; set; }
        public DbSet<TimeReport> TimeReports { get; set; }

        public AppDbContext() : base(Connection)
        {
            Database.SetInitializer<AppDbContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Configurations.Add(new EmployeeConfiguration());
            builder.Configurations.Add(new TimeReportConfiguration());
        }
    }
}