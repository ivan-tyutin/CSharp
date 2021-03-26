using System;

namespace Static
{
    class MyClass
    {
        public int a;

        private static int b = 25;

        public void SetB(int b)
        {
            //this.b так нельзя
            MyClass.b = b;
        }

        public void PrintB2()
        {
            Console.WriteLine(b);
        }

        public static void PrintB()
        {
            Console.WriteLine(b);
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            MyClass class1 = new MyClass();
            class1.a = 234;

            MyClass class2 = new MyClass();
            class2.a = 1;

            class2.SetB(21);
            class2.PrintB2();

         
        }
    }
}
