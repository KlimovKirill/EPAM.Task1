using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task3.Triangle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This program demonstrates the use of a triangle with user data.");

            try
            {
                Console.WriteLine("Enter a: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter b: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter c: ");
                int c = int.Parse(Console.ReadLine());

                Triangle triangle = new Triangle(a, b, c);
                Console.WriteLine($"Area = {triangle.Area}{Environment.NewLine}Perimeter = {triangle.Perimeter}");
            }
            catch
            {
                Console.WriteLine("You have entered wrong input data. Let's try again!");
            }
        }
    }
}
