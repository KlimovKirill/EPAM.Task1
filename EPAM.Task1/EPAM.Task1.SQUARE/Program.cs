using System;

namespace EPAM.Task1.SQUARE
{
    class MainClass
    {
        public static void MakingSquare(int n){

            for (int i = 0; i < n; i++){

                for (int j = 0; j < n; j++)
                {
                    if(i==(n-1)/2 && j==(n-1)/2)
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            MakingSquare(n);

            Console.ReadKey();
        }
    }
}
