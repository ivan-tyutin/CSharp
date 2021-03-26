using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 3, 4, 5, 12, 64, 43, 8 };


            foreach ( int x in arr)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

            int temp;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                temp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = temp;
            }

            foreach (int x in arr)
            {
                Console.Write(x + " ");
            }

            int[,] arr2 = new int[2, 3] { {3, 2, 1}, { 1, 2, 3} };
            int[,,] arr3 = new int[3, 4, 5];



            Console.WriteLine();
            Console.WriteLine(arr3.Rank);
            Console.WriteLine(arr3.GetLength(0));
            Console.WriteLine(arr3.GetLength(1));
            Console.WriteLine(arr3.GetLength(2));

            Console.WriteLine(arr3.GetUpperBound(0));
            Console.WriteLine(arr3.GetUpperBound(1));
            Console.WriteLine(arr3.GetUpperBound(2));

            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                for (int j = 0; j < arr3.GetLength(1); j++)
                {
                    for (int k = 0; k < arr3.GetLength(2); k++)
                    {
                        arr3[i, j, k] = i * arr3.GetLength(1) * arr3.GetLength(2) + j * arr3.GetLength(2) + k;
                    }
                }
            }

            foreach (int x in arr3)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine("********************************************");

            int[][] myArray = new int[4][];
            Console.WriteLine(myArray.Rank);
            Console.WriteLine(myArray.GetLength(0));


            myArray[0] = new int[] { 1, 2, 3, 4 };
            myArray[1] = new int[] { 1, 2 };


            

        }
    }
}
