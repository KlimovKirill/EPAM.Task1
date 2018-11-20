using System;

namespace EPAM.Task1.SIMPLE
{
    class MainClass
    {
        public static bool CheckingSimplicity(int n){
        
            for (int i = 2; i < Math.Sqrt(n); i++)

                if (n % i == 0)
                  return false;

            return true;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter positive integer number: ");

            int n = int.Parse(Console.ReadLine());

            if (CheckingSimplicity(n))
                Console.WriteLine("This is a prime number");
            else 
                Console.WriteLine("This is not a prime number");
        }
    }
}
