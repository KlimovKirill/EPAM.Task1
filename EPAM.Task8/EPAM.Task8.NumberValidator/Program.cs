using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace EPAM.Task8.NumberValidator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();

            Regex conventionalNotation = new Regex(@"[+-]?([0-9]*[.])?[0-9]+");
            Regex scientificNotation = new Regex(@"[+-]?[0-9]+\.[0-9]+e-?[0-9]");

            if (conventionalNotation.Match(input).ToString().Count() == input.Count())
            {
                Console.WriteLine("Conventional notation");
            }
            else if (scientificNotation.Match(input).ToString().Count() == input.Count())
            {
                Console.WriteLine("Scientific notation");
            }
            else
            {
                Console.WriteLine("It is not a number");
            }
        }
    }
}
