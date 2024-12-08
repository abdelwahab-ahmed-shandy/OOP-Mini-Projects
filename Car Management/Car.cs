using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Management
{
    class Car
    {
        private string model;
        private int speed;
        private int fuelLevel;

        public void PrintInfoModel()
        {
            Console.WriteLine($"\nModel : {Model}");
            Console.WriteLine($"Speed : {Speed}");
            Console.WriteLine($"Fuel Level : {FuelLevel}");
        }
        public string Model
        {
            get { return model; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Error: Enter the model name correctly");
                model = value;
            }

        }

        public int Speed
        {
            get { return speed; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Error : The Speed must be positive ");
                speed = value;
            }
        }

        public int FuelLevel
        {
            get { return fuelLevel; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Error: It must have gasoline in it to work");
                fuelLevel = value;
            }
        }

        public void Accelerate(int value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Error : Accelerate must be greater than zero");

            int FuelNeed = 5;
            if (fuelLevel < FuelNeed)
                throw new ArgumentOutOfRangeException("Error : Not enough fuel for Acceleration");

            speed = speed + value;
            fuelLevel = fuelLevel - FuelNeed;
        }
        public void Decelerate(int value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Error : Decelerate must be greater than zero");
            int FualNeed = 2;
            if (fuelLevel < FualNeed)
                throw new ArgumentOutOfRangeException("Error : Not enough fuel for Acceleration");

            speed = speed - value;
            fuelLevel = fuelLevel - FualNeed;
        }
    }
}