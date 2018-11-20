using System;

namespace EPAM.Task1.SQUARE
{
    class MainClass
    {
        public static void MakingSquare(int n){

            for (int i = 0; i < n; i++){

                for (int j = 0; j < n; j++)
                {
                    if (i == (n - 1) / 2 && j == (n - 1) / 2)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }

                Console.WriteLine();
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the side of square (positive odd integer number): ");

            int n = int.Parse(Console.ReadLine());

            if ( n > 1 && n % 2 != 0 && n % 1 == 0)
            {
                MakingSquare(n);
            }
            else
            {
                Console.WriteLine("Your number is wrong! Let's try again!");
            }
        }
    }
}
