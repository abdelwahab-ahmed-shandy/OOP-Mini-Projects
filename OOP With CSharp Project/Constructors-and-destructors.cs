/*
Constructors and destructors
Create a C# program that prompts the user for three names of people and stores them in an array of Person-type objects. To do this,
first create a Person class that has a Name property of type string,
a constructor that receives the name as a parameter, 
a destructor that assigns the name to empty and overwrites the ToString () method.

End the program by reading the people and executing the ToString () method on screen.
*/
using System.Xml.Linq;

namespace Any_task
{
    public class Person
    {
        public string Name { get; set; }
        public Person(string name = "Null")
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Enter any name");
            Name = name;
        }
        ~Person()
        {
            Name = string.Empty;
            Console.WriteLine("Destractor ");
        }
        public override string ToString()
        {
            return $"Hello! My name is {Name}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var persons = new Person[3];

            Console.WriteLine("Enter Three Name :");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter Name : {i + 1}");
                string EnterName = Console.ReadLine();
                persons[i] = new Person(EnterName);
            }
            Console.WriteLine("===================================");
            Console.WriteLine("The Name Three persons :");
            foreach (Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
