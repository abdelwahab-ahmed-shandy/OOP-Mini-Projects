using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Company_Employees
{
    class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public double Salary { get; private set; }
        public bool IsPermaision { get; set; }
        public Employee(string name = "Null", string position = "Null", double salary = 900, bool isPermaision = false)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("You Must Enter Name");
            if (string.IsNullOrWhiteSpace(position))
                throw new ArgumentNullException("You Must Enter Position");
            if (salary <= 0)
                throw new ArgumentOutOfRangeException("You Must Enter Salary");

            this.Name = name;
            this.Position = position;
            this.Salary = salary;
            IsPermaision = isPermaision;
        }
        public void PrintEmployee()
        {
            Console.WriteLine($"Name is {Name} And Position {Position} And Salary Is {Salary}");
        }

        public void ChangeSalary(double value)
        {
            if (IsPermaision)
            {
                Salary = value;
                Console.WriteLine("Change Salary.");
            }
            else
            {
                Console.WriteLine("Can Not Change Salary");
            }

        }
    }
}
