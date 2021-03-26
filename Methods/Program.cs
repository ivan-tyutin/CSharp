using System;

namespace Methods
{
    class Program
    {
        static int Sum(int x, int y) => x + y;


        static int Sum2(int a, int b, int c = 4, int g = 20)
        {
            return a + b + c + g;
        }

        // Передача параметра по ссылке
        static void IncrementNumber(ref int number)
        {
            number++;
        }
        
        static void foo(out int x, out int y)
        {
            y = 34;
            x = 25;
        }


        static void cst(in int value )
        {
            Console.WriteLine(value);
        }


        static void SumOfElements(params int[] integer)
        {
            int result = 0;
            for (int i = 0; i < integer.Length; i++)
            {
                result += integer[i];
            }
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {

            Console.WriteLine(Sum(2, 3));
            Console.WriteLine(Sum2(2, 3, 4));

            Console.WriteLine();

            int number = 5;
            Console.WriteLine(number);
            IncrementNumber(ref number);
            Console.WriteLine(number);

            Console.WriteLine();


            int x = 11;
            Console.WriteLine(x);
            foo(out x, out int value);
            Console.WriteLine($" x: {x}, y: {value}");

            Console.WriteLine();
            int val = 23;
            cst(val);

            Console.WriteLine();
            SumOfElements(new int[] { 1, 2, 3, 4});



        }



    }
}
