using Ex001.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex001.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public List<HourContract> Contract { get; set; } = new List<HourContract>();

        public Department Department { get; set; } = new Department();
   
        public Worker() { }

        public Worker(string name, double baseSalary, WorkerLevel level, string departament)
        {
            Name = name;
            BaseSalary = baseSalary;
            Level = level;
            Department = new Department(departament);
        }
        public void AddContract(HourContract contract)
        {
            Contract.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contract.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach (HourContract contract in Contract)
            {
              
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue(); 
                }
            }

            return sum;
        }            
    }
}
