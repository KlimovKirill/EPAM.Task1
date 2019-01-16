using System;
using System.Text.RegularExpressions;

namespace EPAM.Task8.HTMLReplacer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string input = Console.ReadLine();

            Regex regex = new Regex(@"(<(/?[^>]+)>)");

            string result = regex.Replace(input,"_");
            Console.WriteLine($"Replace result: {result}");
        }
    }
}
