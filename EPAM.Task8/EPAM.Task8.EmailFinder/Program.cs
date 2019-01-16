using System;
using System.Text.RegularExpressions;

namespace EPAM.Task8.EmailFinder
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string input = Console.ReadLine();

            Regex regex = new Regex(@"([0-9a-zA-Z][a-zA-Z0-9_\.-][0-9a-zA-Z]+)\@([0-9a-zA-Z-]+\.)+([0-9a-zA-Z-\.]{2,6})");

            Console.WriteLine("Founded e-mail adresses: ");

            foreach(var item in regex.Matches(input))
            {
                Console.WriteLine(item);
            }
        }
    }
}
