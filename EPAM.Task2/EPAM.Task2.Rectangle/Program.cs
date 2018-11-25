using System;

namespace EPAM.Task2.Rectangle
{
    class MainClass
    {
        public static int InputChecking()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            

            return n;
        }

        public static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the side A of rectangle: ");
            int a = InputChecking();

            Console.WriteLine("Enter the side B of rectangle: ");
            int b = InputChecking();

            Console.WriteLine($"The area of the rectangle is equal to {a * b}");
        }
    }
}
