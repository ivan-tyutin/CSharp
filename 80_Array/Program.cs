using System;
using System.Collections.Generic;

namespace _80_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1;
            a1 = new int[10];

            int[] a2 = new int[5];

            int[] a3 = new int[5] { 1, 3, -2, 5, 10 };

            int[] a4 = { 1, 3, 2, 5, 6 };

            Array.Sort(a4);

            foreach(int x in a4)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

            Array myArray = new int[5];

            myArray.SetValue(12, 0);
            Console.WriteLine(myArray.GetValue(0));

            int[] numbers = { 1, 2, 4, 5, 6, 7, 8 };
            int index = Array.BinarySearch(numbers, 2);
            Console.WriteLine(index);

            int[] copy = new int[10];
            Array.Copy(numbers, copy, numbers.Length);

            int[] anotherCopy = new int[10];
            copy.CopyTo(anotherCopy, 0);

            Array.Reverse(copy);
            foreach(var c in copy)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            Array.Sort(copy);
            foreach (var c in copy)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            Array.Clear(copy, 0, copy.Length);



        }
    }
}
