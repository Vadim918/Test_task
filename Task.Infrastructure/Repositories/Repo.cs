using System;
using System.Collections.Generic;
using System.Linq;
using Task.Core.Entities;


namespace Task.Infrastructure.Repositories
{
    public class Repo
    {
        private readonly AppDbContext _ctx;

        public Repo()
        {
            _ctx = new AppDbContext();
        }

        public List<TimeReport> All(DayOfWeek dayOfWeek)
        {
            var list = _ctx.TimeReports.ToList()
                .OrderByDescending(x => x.Hours)
                .Where(cd => cd.Date.DayOfWeek == dayOfWeek)
                .Take(3)
                .ToList();

            return list;
        }
    }
}