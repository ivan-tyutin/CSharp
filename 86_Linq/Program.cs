using System;
using System.Collections.Generic;

namespace _86_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessPlayer.MinMaxSumAverage("Top100.txt");


            List<int> list = new List<int> { 1, 2, 3, 4, 5 };

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] <= 3)
                {
                    list.RemoveAt(i);
                    i--;
                }
       
            }

            foreach(int x in list)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }

         class Test 
        {
            public readonly int N = 234;
        }


    }
}
