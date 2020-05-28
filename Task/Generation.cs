using System;
using System.Text;
using Task.Infrastructure.Repositories;

namespace Task
{
    public class Generation
    {
        private readonly DayOfWeek[] _arr =
        {
            DayOfWeek.Monday,
            DayOfWeek.Tuesday,
            DayOfWeek.Wednesday,
            DayOfWeek.Thursday,
            DayOfWeek.Friday,
            DayOfWeek.Saturday,
            DayOfWeek.Sunday
        };

        private readonly Repo _repository;

        public Generation()
        {
            _repository = new Repo();
        }

        public void Write()
        {
            foreach (var t in _arr)
            {
                var sb = new StringBuilder();
                _ = sb.Append($"| {t} | ");
                foreach (var variable in _repository.All(t))
                {
                    if (t != variable.Date.DayOfWeek) continue;
                    sb.Append($" {variable.Employee.Name}  ({Math.Round(variable.Hours, 2)} hours) ");
                    sb.Append("|");
                }

                Console.WriteLine(sb.ToString());
            }
        }
    }
}