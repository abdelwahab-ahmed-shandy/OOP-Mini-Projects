/*
Manage Company Employees

Required:
Create a class named Employee.
The class contains the following properties: Name, Position, Salary.

Make Salary private and add a function:
To change the salary if the user has permissions (for example via a password).
To display employee data.
 */
namespace Manage_Company_Employees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Abdoo", ".net Dev", 7000);
            employee1.PrintEmployee();
            employee1.ChangeSalary(10000);

            Console.WriteLine();

            Employee employee2 = new Employee("Admin", "Manager", 5000, true);
            employee2.PrintEmployee();
            employee2.ChangeSalary(10000);
            employee2.PrintEmployee();
        }
    }
}
