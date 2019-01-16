using System;
using System.Text.RegularExpressions;

namespace EPAM.Task8.DateExsitance
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter text, which contains date (format: dd-mm-yyyy): ");
            string input = Console.ReadLine();

            Regex regex1 = new Regex(@"[0][1-9]-[0][1-9]-[0-2][0-9][0-9][0-9]");
            Regex regex2 = new Regex(@"[0][1-9]-[1][0-2]-[0-2][0-9][0-9][0-9]");

            Regex regex3 = new Regex(@"[1-2][0-9]-[0][1-9]-[0-2][0-9][0-9][0-9]");
            Regex regex4 = new Regex(@"[1-2][0-9]-[1][0-2]-[0-2][0-9][0-9][0-9]");

            Regex regex5 = new Regex(@"[3][01]-[0][1-9]-[0-2][0-9][0-9][0-9]");
            Regex regex6 = new Regex(@"[3][01]-[1][0-2]-[0-2][0-9][0-9][0-9]");

            MatchCollection match1 = regex1.Matches(input);
            MatchCollection match2 = regex2.Matches(input);
            MatchCollection match3 = regex3.Matches(input);
            MatchCollection match4 = regex4.Matches(input);
            MatchCollection match5 = regex5.Matches(input);
            MatchCollection match6 = regex6.Matches(input);

            if (match1.Count > 0 || match2.Count > 0 || match3.Count > 0 ||
            match4.Count > 0 || match5.Count > 0 || match6.Count > 0)
            {
                Console.WriteLine($"Text \"${input}\" contains date.");
            }
            else
            {
                Console.WriteLine($"Text \"${input}\" does not contain date.");
            }
        }
    }
}
