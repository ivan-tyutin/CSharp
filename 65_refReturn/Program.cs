using System;

namespace _65_refReturn
{   /*
     * В версии C# 7.0 была добавлена возможность возвращать ссылку на объект с помощью ключевого слова ref и 
     * определять локальную переменную, которая будет хранить ссылку. 
     *
     *
     * При этом мы не можем просто определить переменную-ссылку, нам обязательно надо присвоить ей некоторое значение.
     * 
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {

            int x = 6;
            int b = 4;
            ref int y = ref x;

            //ref int z; // Ошибка

            Console.WriteLine(x);
            y = 23;
            Console.WriteLine(x);
            y = 1233;
            Console.WriteLine(x);

            y = ref b; // возможность переназначить ссылку появилась только с версии 7.3

            int[] arr = { 1, 2, 3, 4 };

            ref int value = ref Foo(2, arr); //
            value = 25;
            foreach(int val in arr)
            {
                Console.Write(val + " ");
            }



        }

        /*
         * Метод который возвращает ссылку не может возвращать: значение null, константу, значение enum, свойство класса или структруры,  поле для чтения.
         */

        static ref int Foo(int number, int[] numbers)
        {

            for (int i = 0; i < numbers.Length; i++)
            {
                if (number == numbers[i])
                {
                    return ref numbers[i];
                }
            }
            throw new IndexOutOfRangeException("can not find the value");
        }
    }
}
