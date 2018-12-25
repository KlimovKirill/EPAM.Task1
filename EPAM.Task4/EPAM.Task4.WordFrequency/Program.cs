using System;
using System.Collections.Generic;
using System.IO;

namespace EPAM.Task4.WordFrequency
{
    class MainClass
    {
        public static void WordSearching (string currentString, ref Dictionary<string,int> wordFrequency)
        {
            currentString.ToLower();

            char[] separators = new char[2] { ' ', '.' };

            while (currentString.Length != 0)
            {
                int indexOfSeparator = currentString.IndexOfAny(separators);

                if (indexOfSeparator == -1)
                {
                    indexOfSeparator = currentString.Length;
                }

                if (!wordFrequency.ContainsKey(currentString.Substring(0, indexOfSeparator)))
                {
                    if (currentString.Substring(0, indexOfSeparator) != " " && currentString.Substring(0, indexOfSeparator) != ".")
                    {
                        wordFrequency.Add(currentString.Substring(0, indexOfSeparator), 1);
                    }
                }
                else
                {
                    wordFrequency[currentString.Substring(0, indexOfSeparator)]++;
                }

                if (indexOfSeparator >= currentString.Length)
                {
                    indexOfSeparator = currentString.Length - 1;
                }

                currentString = currentString.Remove(0, indexOfSeparator + 1);
            }
        }

        public static void Main(string[] args)
        {
            Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

            StreamReader streamReader = new StreamReader("input.txt");

            string currentString = streamReader.ReadToEnd();

            WordSearching(currentString, ref wordFrequency);

            foreach (var item in wordFrequency)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }
    }
}
