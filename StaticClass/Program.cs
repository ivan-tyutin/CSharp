using System;

namespace StaticClass
{
    // Статический класс



    /* 
     * Статический класс может содержать только статические члены, 
     * то есть все поля и методы должны быть с модификатором static
     * Так же мы можем создать статический конструктор.
     * Внутри такого класса мы не можем использовать ключевое слово this
     * Не умеют в наследование и в реализацию интерфейсов
     */
    static class MyClass
    {
        public static void Foo()
        {
            Console.WriteLine("Foo()");
        }


       
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass.Foo();
        }
    }
}
