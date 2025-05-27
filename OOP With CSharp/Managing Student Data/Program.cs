/*
Managing Student Data
Required:

Create a class named Student.
The class has the following properties: Name, Age, Grade.
Make the properties private and use getters and setters to control access to them.

Add constraints to validate the data:
Name cannot be empty.
Age must be between 18 and 30.
Grade must be between 0 and 100.
Add a function to print the student data.
 */
namespace Managing_Student_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var student = new Student();

                student.Name = "Abdelwahab";
                student.Age = 22;
                student.Grade = 99;

                student.PrintStudentInfo();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }
        }
    }
}
