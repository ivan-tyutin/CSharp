using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Console.WriteLine("Enter a namber: ");
            int value = Convert.ToInt32(Console.ReadLine());

            if (value > 5 && value < 10)
            {
                Console.WriteLine("The value more then 5 and less then 10");
            }
            else
            {
                Console.WriteLine("Unknow number!");
            }

            Console.WriteLine(stringLower("Hello World!"));*/

            int[] arr1 = { 2, 1, 4, 6, 1, 3, 8, 2, 32, 1, 34, 9, 8, 14 };
            int[] arr2 = { 6, 11, 4, 9, 2, 1, 0, 3 };


            QuickSort(arr1, 0, arr1.Length-1);
            QuickSort(arr2, 0, arr2.Length - 1);

            int[] retval = Arr(arr1, arr2);
            foreach (int x in retval)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

            Console.ReadKey();

            int a = 23;
            int b = 12;
            Swap(ref a,ref b);

            Console.WriteLine($"A: {a}, B: {b}");

            Console.WriteLine(StringToUpper("Hello World!"));

        }


        static string stringLower(string str)
        {
            string retval = str;
            str.ToLower();
            return retval.ToLowerInvariant();
        }


        static int[] Arr(int[] arr1, int[] arr2)
        {
            int it1, it2;
            it1 = it2 = 0;

            //QuickSort(arr1, 0, arr1.Length-1);
            //QuickSort(arr2, 0, arr2.Length-1);

            int[] retArr = new int[arr1.Length + arr2.Length];


            while (it1 < arr1.Length && it2 < arr2.Length)
            {
                if (arr1[it1] < arr2[it2])
                {
                    retArr[it1 + it2] = arr1[it1];
                    it1++;
                }
                else
                {
                    retArr[it1 + it2] = arr2[it2];
                    it2++;
                }
            }

            while (it1 < arr1.Length)
            {
                retArr[it1 + it2] = arr1[it1];
                it1++;
            }
            while (it2 < arr2.Length)
            {
                retArr[it1 + it2] = arr2[it2];
                it2++;
            }

            return retArr;


        }



        static void QuickSort(int[] arr, int l, int r)
        {
            if (l >= r) return;

            int split = Partiotion(arr, l, r);

            QuickSort(arr, l, split);
            QuickSort(arr, split + 1, r);
        }

        static int Partiotion(int[] arr, int l, int r)
        {

            int pivot = arr[(l + r) / 2];
            while (l < r)
            {
                while (arr[l] < pivot)
                {
                    l++;
                }
                while (arr[r] > pivot)
                {
                    r--;
                }
                if (l >= r)
                {
                    break;
                }
                else
                {
                    Swap(ref arr[l], ref arr[r]);
                    l++;
                    r--;
                }
            }
            return r;
        }



        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }



        static string StringToUpper(string str)
        {
            /*char[] arr = str.ToCharArray();
            string retstr = str;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = char.ToUpper(arr[i]);
                Console.Write(arr[i]);
            }*/

            string retstr = new string("");
            char[] arr = str.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = char.ToUpper(arr[i]);
                retstr.Insert(i, arr[i].ToString());
            }

            //string retstr = new string(arr);




            return retstr;

        }
    }
}
