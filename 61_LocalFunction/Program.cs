using System;

namespace _61_LocalFunction
{



    class Program
    {
        delegate bool Compare(int x);

        static void Main(string[] args)
        {

            var result = GetResult(new int[] { -3, -2, -1, 1, 2, 4 });
            Console.WriteLine(result);

            result = GetResult1(new int[] { -3, -2, -1, 1, 2, 4 }, x => x < 0);
            Console.WriteLine(result);

            result = GetResult1(new int[] { -3, -2, -1, 1, 2, 4 }, delegate(int x)
            {
                return x < 2;
            });
            Console.WriteLine(result);

        }
        /* 
         * Здесь в методе GetResult определена локальная функция IsMoreThan(), которая может быть вызвана только внутри этого метода. 
         * Локальная функция задает еще одну область видимости, где мы можем определять переменные и выполнять над ними действия. 
         * В то же время ей доступны все переменные, которые определены в том же методе
         * 
         * При использовании локальных функций следует помнить, что они не могут иметь модификаторов доступа
         * 
         * Начиная с версии C# 8.0 можно определять статические локальные функции. 
         * Их особенностью является то, что они не могут обращаться к переменным окружения, то есть метода, в котором статическая функция определена.
         * 
         * 
         */

        static int GetResult(int[] numbers)
        {
            int limit = 0;


            bool IsMoreThan(int number)
            {
                return number > limit;
            }
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (IsMoreThan(numbers[i]))
                {
                    result += numbers[i];
                }
            }
            return result;
        }



        static int GetResult1(int[] numbers, Compare compare)
        {
           
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (compare(numbers[i]))
                {
                    result += numbers[i];
                }
            }
            return result;
        }


    }
}
