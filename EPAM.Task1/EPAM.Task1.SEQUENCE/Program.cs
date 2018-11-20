using System;

namespace EPAM.Task1.SEQUENCE
{
    class MainClass
    {
        public static void MakingString(int n) {

            for (int i = 1; i <= n; i++)
            {
                if (i != n)
                {
                    Console.Write($"{i}, ");
                }
                else
                {
                    Console.Write($"{i}");
                }
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number for sequence: ");

            int n = int.Parse(Console.ReadLine());

            MakingString(n);
        }
    }
}
