using System;

namespace _48_delegate
{
    class Program
    {

        class Math
        {
            public int Sum(int x, int y)
            {
                return x + y;
            }
        }

        /* В данном случае делегат определяется внутри класса, но также можно определить делегат вне класса внутри пространства имен */
        delegate void Message();
        delegate int Operation(int x, int y);

        static void Main(string[] args)
        {
            Message mes; // Объявляется переменная этого делегата.

            if (DateTime.Now.Hour < 12)
            {
                mes = GoodMorning;
            }
            else
            {
                mes = GoodEvening;
            }
            mes();
            Console.ReadKey();

            Operation del = Sum;
            int result = del(4, 5);
            Console.WriteLine(result);

            del = Mul;
            del -= Mul;
            del -= Mul;
            //result = del(4, 5);
            //Console.WriteLine(result);

            Math math = new Math();
            del = math.Sum;
            result = del(3, 4);
            Console.WriteLine(result);


        }


        public static int Sum(int x, int y)
        {
            return x + y;
        }

        public static int Mul(int x, int y)
        {
            return x * y;
        }

        public static void GoodMorning()
        {
            Console.WriteLine("Good Morning");
        }

        public static void GoodEvening()
        {
            Console.WriteLine("Good Evening");
        }
    }
}
