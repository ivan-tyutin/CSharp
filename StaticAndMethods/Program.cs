using System;

namespace StaticAndMethods
{
    /* 
     * Ключевое слово static
     * 
     * Статические методы класса
     * 
     * Статические свойства класса
     * 
     * 
     */


    class MyClass
    {
        

        private int b;

        public static void Foo(MyClass cls)
        {
            Console.WriteLine("Вызван метод Foo()");
            // В статических методах мы не можем использовать не статические поля класса
            cls.Bar();
        }

        public static void Foo2()
        {
            Console.WriteLine("Вызван метод Foo2()");
            a = 23;
            Console.WriteLine($"a: {a}");
        }

        public void Bar()
        {
            Console.WriteLine("Вызван метод Bar()");
            Foo2();
        }

        private static int a;

        public static int A
        {
            get { return a; }
            set { a = value; }
        }

        public static int B { get; set; }

    }


    class MyClass2
    {
        private static int count;

        public static int Counter
        {
            get { return count; }
            private set { count = value; }
        }

        public MyClass2()
        { 
            Counter++;
        }

        ~MyClass2()
        {
            Counter--;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyClass.Foo(myClass);
            MyClass.Foo2();


            MyClass.B = 24;
            {
                MyClass2 newEl = new MyClass2();
                Console.WriteLine(MyClass2.Counter);

            }

            Console.WriteLine(MyClass2.Counter);

            Console.WriteLine();
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(MyClass2.Counter);
                MyClass2 NewElement = new MyClass2();
            }

            //myClass.Bar();
        }
    }
}
