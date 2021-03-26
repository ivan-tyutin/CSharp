using System;

namespace StaticConstructor
{
    /* Статический конструктор */




    class MyClass
    {
        public MyClass ()
        {
            Console.WriteLine("Констуктор");
        }

        /* 
         * Для статичкских конструкторов не используются модификаторы доступа 
         * В любом классе может быть лишь один статический конструктор.
         * Статический констуктор не может принимать параметры
         * Статический констуктор выполняется только один раз.
         * Статический констуктор всегда будет вызван перед обычным конструктором.
         * Статический конструктор будет вызван в начале любого взаимодействия с классом для начальной иницилизации статических параметров.
         */
        static MyClass ()
        {
            Console.WriteLine(b);
            Console.WriteLine("Статический конструктор"); 
        }


        public static void Foo()
        {
            Console.WriteLine(b);
            Console.WriteLine("Foo()");
        }


        private static readonly int b;

    }


    class Program
    {
        static void Main(string[] args)
        {
            MyClass.Foo();

            MyClass myClass1 = new MyClass();

            new MyClass();
            new MyClass();
            new MyClass();
        }
    }
}
