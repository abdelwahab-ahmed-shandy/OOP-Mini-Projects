/*
Car Management
Required:
Create a class named Car.
The class has the following properties: Model, Speed, FuelLevel.

Make the properties private, and use methods to control:
Accelerate.
Decelerate.
Check fuel level.
Refill fuel.
 */
namespace Car_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var vCar1 = new Car();
                vCar1.Model = "BMW";
                vCar1.Speed = 200;
                vCar1.FuelLevel = 100;

                vCar1.PrintInfoModel();

                vCar1.Accelerate(50);
                vCar1.PrintInfoModel();

                vCar1.Decelerate(30);
                vCar1.PrintInfoModel();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }
        }
    }
}
