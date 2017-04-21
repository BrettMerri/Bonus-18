using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Grand Circus Motors Admin Console"; //Sets title of the console window

            //Sets default Console colors
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Welcome to the Grand Circus Motors admin console!");
            Console.Write("How many cars are you entering (1-10): "); //Prompts user to enter a number 1-10

            int AmountOfCars = GetIntegerInRange(1, 10); //Gets a valid integer between 1 and 10

            Car[] ListOfCars = new Car[AmountOfCars]; //Creates a list of Car objects

            GetCarInformation(AmountOfCars, ListOfCars); //Prompts user for the Make, Model, Year, and Price for each car

            GetTableOfCars(AmountOfCars, ListOfCars); //Generates a table of cars
        }

        public static void GetTableOfCars(int AmountOfCars, Car[] ListOfCars)
        {
            Console.WriteLine("Current Inventory:");
            for (int i = 0; i < AmountOfCars; i++)
                Console.WriteLine($"{ListOfCars[i].CarMake}\t{ListOfCars[i].CarModel}\t{ListOfCars[i].CarYear}\t{ListOfCars[i].CarPrice}");
        }
        public static void GetCarInformation(int AmountOfCars, Car[] ListOfCars)
        {
            for (int i = 0; i < AmountOfCars; i++)
            {
                ListOfCars[i] = new Car();
                Console.Write($"Enter Car #{i + 1} Make: ");
                ListOfCars[i].CarMake = Console.ReadLine();

                Console.Write($"Enter Car #{i + 1} Model: ");
                ListOfCars[i].CarModel = Console.ReadLine();

                Console.Write($"Enter Car #{i + 1} Year: ");
                ListOfCars[i].CarYear = GetIntegerInRange(1885, 2018);

                Console.Write($"Enter Car #{i + 1} Price: ");
                ListOfCars[i].CarPrice = GetDoubleInRange(0, 999999999.99);

                Console.WriteLine();
            }
        }

        public static int GetValidInteger()
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a valid input.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return input;
        }

        public static int GetIntegerInRange(int min, int max)
        {
            int input = GetValidInteger();
            while (input < min || input > max)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter an integer between {0} and {1}.", min, max);
                Console.ForegroundColor = ConsoleColor.White;
                input = GetValidInteger();
            }
            return input;
        }

        public static double GetValidDouble()
        {
            double input;
            while (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a valid input.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return input;
        }
        //Validates that integer is within a given range
        public static double GetDoubleInRange(double min, double max)
        {
            double input = GetValidDouble();
            while (input < min || input > max)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter an integer between {0} and {1}.", min, max);
                Console.ForegroundColor = ConsoleColor.White;
                input = GetValidDouble();
            }
            return input;
        }

    }
}
