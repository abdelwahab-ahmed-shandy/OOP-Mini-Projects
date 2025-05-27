using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managing_Student_Data
{
    class Student
    {
        private string name { get; set; }
        private int age { get; set; }
        private int grade { get; set; }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name Can Not Be Empty");
                else
                    name = value;
            }
        }
        public int Grade
        {
            get { return age; }
            set
            {
                if (value >= 0 && value <= 100)
                    grade = value;
                else
                    throw new ArgumentException("The number must be between 0 and 100.");
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 18 && value <= 30)
                    age = value;
                else
                    throw new ArgumentException("Age must be between 18 and 30.");
            }
        }

        public void PrintStudentInfo()
        {
            Console.WriteLine($"Student Name : {Name}");
            Console.WriteLine($"Age : {Age}");
            Console.WriteLine($"Grade : {Grade}");
        }
    }

}
