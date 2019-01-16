using System;
using System.Text.RegularExpressions;

namespace EPAM.Task8.TimeCounter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string input = Console.ReadLine();

            Regex regex = new Regex(@"[ 0-2][0-9]\:[0-5][0-9]");

            MatchCollection match = regex.Matches(input);

            Console.WriteLine($"Time in the text occurs {match.Count} time(-s).");
        }
    }
}
