using System;
using System.Collections.Generic;

namespace EPAM.Task4.Lost
{
    class MainClass
    {
        public static int SearchingLastPerson(Queue<int> roundOfPeople)
        {
            bool flag = true;
            while (roundOfPeople.Count != 1)
            {
                if (flag)
                {
                    roundOfPeople.Enqueue(roundOfPeople.Dequeue());
                    flag = !flag;
                }
                else
                {
                    roundOfPeople.Dequeue();
                    flag = !flag;
                }
            }

            return roundOfPeople.Peek();
        }

        public static void Main(string[] args)
        {
            Queue<int> roundOfPeople = new Queue<int>();

            Console.WriteLine("Enter amount of people N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                roundOfPeople.Enqueue(i);
            }

            Console.WriteLine($"Last person is {SearchingLastPerson(roundOfPeople)}");
        }
    }
}
