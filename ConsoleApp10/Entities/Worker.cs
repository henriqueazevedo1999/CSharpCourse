using Exercise1.Entities.Enums;
using System.Collections.Generic;
using System.Linq;

namespace Exercise1.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }

        private List<HourContract> _contracts = new List<HourContract>();

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract hourContract)
        {
            _contracts.Add(hourContract);
        }

        public void RemoveContract(HourContract hourContract)
        {
            _contracts.Remove(hourContract);
        }

        public double Income(int year, int month)
        {
            return _contracts.Where(x => x.Date.Year == year && x.Date.Month == month).Sum(x => x.TotalValue()) + BaseSalary;
        }
    }
}
