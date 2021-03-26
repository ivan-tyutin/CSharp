using System;


// Const and Readonly

namespace _19_ConstVsReadonly
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass(23);
            double i = 25 * MyClass.PI;

            MyClass myClass2 = new MyClass(12);
            Console.WriteLine(myClass.a);
            Console.WriteLine(myClass2.a);


        }
    }


    class MyClass
    {
        public const double PI = 3.14; // Нобходимо сразу же иницилизировать перменную типа const, иначе проект не скомпилируется
        // Так же const поля неявно статические и так как они неявно статические, то такие константы можно использовать в static методах

        public const string MY_ERROR = "some error";

        public readonly int a; // не является неявно статическим, также не обязательно при обявление присаивать значение.
        // Можно сделать его явно статическим
        // Можно присвоить значнеие в конструкторе
        public static readonly int b;

        static MyClass()
        {
            b = 12;
        }
        
        public MyClass(int a)
        {
            this.a = a; // Можно присво
        }

        public void Foo()
        {
            //a = 32;
        }
    }

}



