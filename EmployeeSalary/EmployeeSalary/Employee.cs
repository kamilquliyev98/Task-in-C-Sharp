using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    class Employee
    {
        public string Name;
        public string Surname;
        public string Position;
        public int DailySalary;
        public int Salary;

        public void MonthlySalary(string Name, string Surname, string Position, int DailySalary)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Position = Position;
            this.DailySalary = DailySalary;
            int Salary = DailySalary * 30;

            Console.WriteLine($"{Name} {Surname} {Position} {Salary}");
        }
    }
}
