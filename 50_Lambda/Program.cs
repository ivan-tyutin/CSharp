using System;

namespace _50_Lambda
{


    delegate int Operation(int x, int y);
    delegate int Square(int x);
    delegate void Hello();
    delegate void ChangeHandler(ref int x);
    delegate bool isEqual(int x);



    class Program
    {
        static void Main(string[] args)
        {
            int x = 12;
            Operation operation = (x, y) => x + y; // Лямбда выражение 
            Square squre = i => i * i; // Если лямбда-выражение принимает один параметр, то скобки вокруг параметра можно опустить
            
            Hello hello = () => Console.WriteLine("Hello world!");
            // Бывает, что параметров не требуется. В этом случае вместо параметра в лямбда-выражении используются пустые скобки. 
            // Также бывает, что лямбда-выражение не возвращает никакого значения


            /*
             * Как видно, из примеров выше, нам необязательно указывать тип параметров у лямбда-выражения. 
             * Однако, нам обязательно нужно указывать тип, если делегат, которому должно соответствовать лямбда-выражение, 
             * имеет параметры с модификаторами ref и out
             */
            ChangeHandler handler = (ref int x) => x = x * 2;

            hello += () => ShowMessage(); 
            Hello message = () => ShowMessage(); // Лямбда-выражения также могут выполнять другие методы



            Console.WriteLine(operation(3, 4));
            Console.WriteLine(squre(3));
            hello();
            handler(ref x);
            Console.WriteLine(x);
            message();

            Console.ReadKey();


            int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine(Sum(integers, x => x > 5)); // Сумма чисек которые больше 5
            Console.WriteLine(Sum(integers, x => x % 2 == 0));





        }


        private static int Sum(int[] arr, isEqual del)
        {
            int result = 0;
            foreach(int x in arr)
            {
                if (del(x))
                {
                    result += x;
                }
            }
            return result;
        }


        public static void ShowMessage()
        {
            Console.WriteLine("Message");
        }
    }
}
