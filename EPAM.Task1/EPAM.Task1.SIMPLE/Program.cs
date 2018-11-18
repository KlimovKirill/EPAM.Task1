using System;

namespace EPAM.Task1.SIMPLE
{
    class MainClass
    {
        public static bool IsPrime(int n){

            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    return false;
            return true;
        }

        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (IsPrime(n))
                Console.WriteLine("This is a prime number");
            else 
                Console.WriteLine("This is not a prime number");

            Console.ReadKey();
        }
    }
}
