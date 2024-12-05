/*
Create a C# program that requests three names of people from the user and stores them in an array of objects of type Person.
To do this, first create a Person class that has a Name property of type string and override the ToString() method.

End the program by reading people and executing the ToString() method on the screen.
*/
namespace Any_task
{
    public class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Enter any name");
            Name = name;
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
