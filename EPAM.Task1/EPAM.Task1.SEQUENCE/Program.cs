using System;

namespace EPAM.Task1.SEQUENCE
{
    class MainClass
    {
        public static void MakingString(int n) {

            string resultString = null;

            for (int i = 1; i <= n; i++) {
                resultString += i;
                if (i != n)
                    resultString += ", ";
            }

            Console.WriteLine(resultString);
        }

        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            MakingString(n);

            Console.ReadKey();
        }
    }
}
