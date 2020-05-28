using System;

namespace Task.Core.Entities
{
    public  class TimeReport : Entity<int>
    {
        public int EmployeeId { get; set; }
        public float Hours { get; set; }
        public DateTime Date { get; set; }

        public virtual Employee Employee { get; set; }
    }
}