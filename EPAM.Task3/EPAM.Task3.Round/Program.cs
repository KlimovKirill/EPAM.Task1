using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task3.Round
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This program demonstrates the use of a circle with user input data.");

            try
            {
                Console.WriteLine("Enter x coordinate: ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter y coordinate: ");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter radius: ");
                int r = int.Parse(Console.ReadLine());

                Round round = new Round(x, y, r);
                Console.WriteLine($"Area = {round.Area}{Environment.NewLine}Circumference = {round.Circumference}");
            }
            catch
            {
                Console.WriteLine("You have entered wrong input data, radius cannot be negative. Let's try again!");
            }
        }
    }
}
