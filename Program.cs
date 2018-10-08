using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator");

            do
            {
                //prompts user for length, width, and height measurements
                Console.WriteLine("Enter Length: ");
                string length = Console.ReadLine();
                double lengthNumber = double.Parse(length);
                Console.WriteLine("Enter Width: ");
                string width = Console.ReadLine();
                double widthNumber = double.Parse(width);
                Console.WriteLine("Enter Height: ");
                string height = Console.ReadLine();
                double heightNumber = double.Parse(height);

                //calculates area, perimeter, and volume
                double areaNumber = widthNumber * lengthNumber;
                double perimeterNumber = (2 * widthNumber) + (2 * lengthNumber);
                double volumeNumber = (widthNumber * lengthNumber * heightNumber);

                //Displays values to user
                Console.WriteLine("Area: " + areaNumber);
                Console.WriteLine("Perimeter: " + perimeterNumber);
                Console.WriteLine("Volume: " + volumeNumber);
                Console.ReadLine();

                //prompts user to try again
                Console.WriteLine("Continue? (y/n)");
                

            }
            //loops back to start of program with "y" response, otherwise program is exited
            while (Console.ReadLine().ToLower() == "y");
                       

        }
    }
}
