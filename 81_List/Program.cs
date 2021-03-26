using System;
using System.Collections.Generic;
using System.Linq;

namespace _81_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var intList = new List<int>() { 1, 2, 3, 4 };

            intList.Add(7);
            intList.AddRange(new int[] { 11, 22, 34 });

            if (intList.Remove(11)) // first occurence
            {

            }

            intList.RemoveAt(0); // index
            intList.Reverse();
            bool contains = intList.Contains(3);

            int max = intList.Max();
            int min = intList.Min();

            Console.WriteLine($"Max = {max}, Min = {min}");

            foreach (var x in intList)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine(intList[2]);
            intList[1] = 24;

            foreach(var x in intList)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

            intList.Sort();

            foreach (var x in intList)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

        }
    }
}
