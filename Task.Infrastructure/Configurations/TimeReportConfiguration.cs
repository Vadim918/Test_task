using System.Data.Entity.ModelConfiguration;
using Task.Core.Entities;

namespace Task.Infrastructure.Configurations
{
    internal sealed class TimeReportConfiguration : EntityTypeConfiguration<TimeReport>
    {
        public TimeReportConfiguration()
        {
            ToTable("time_reports");
            HasKey(x => x.Id);

            Property(x => x.Date).HasColumnType("date");
            Property(x => x.Hours).HasColumnType("float");
            Property(x => x.EmployeeId).HasColumnName("employee_id").IsRequired();

            HasRequired(x => x.Employee);
        }
    }
}