using System;

namespace _48_delegateHomework
{

    


    class Program
    {
        public delegate T SomeDel<T>(T x, T y);

        static void Main(string[] args)
        {
            SomeDel<int> del = Sum;
            del += Mul;
            del += Sab;

            SomeDel<int>[] arrDel = { Sum, Mul, Sab, Div };


            for (int i = 0; i < arrDel.Length; i++ )
            {
                Console.WriteLine(arrDel[i].Invoke(12, 4));
            }

            MyException ex = new MyException("hello1");

            ex.show = new MyException.ShowMessage(Message);
            

        }

        public static void Message(string str)
        {
            Console.WriteLine(str);
        }


        class MyException : Exception
        {

            public MyException(string msg)
                : base(msg)
            {
                message = "hello";

            }

            public delegate void ShowMessage(string msg);

            public ShowMessage show;

            private string message;
            public override string Message
            {
                get { return message; }
            }
        }

        public static void Foo(SomeDel<int> del, int x, int y)
        {
            Console.WriteLine(del(x, y));
        }
        

        public static int Sum(int x, int y)
        {
            return x + y;
        }

        public static int Div(int x, int y)
        {
            return x / y;
        }

        public static int Mul(int x, int y)
        {
            return x * y;
        }

        public static int Sab(int x, int y)
        {
            return x - y;
        }
    }
}
