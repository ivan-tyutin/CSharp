using System;

/*
 * Реализация интерфейсов в базовых и производных классах
 * 
 * Если класс применяет интерфейс, то этот класс должен реализовать все методы и свойства интерфейса, которые не имеют реализации по умолчанию. 
 * Однако также можно и не реализовать методы, сделав их абстрактными, переложив право их реализации на производные классы
 * 
 * При реализации интерфейса учитываются также методы и свойства, унаследованные от базового класса.
 * 
 * Eсли класс одновременно наследует другой класс и реализует интерфейс, то название базового класса должно быть указано до реализуемых интерфейсов
 * 
 * 
 */

namespace _56_interface
{
    interface IMovable
    {

        delegate void MethodHandler();

        void Move();
    }

    abstract class Person : IMovable
    {
        public delegate void MetHandler();
        public abstract void Move(); // Абстрактный метод, можно не реализовывать метод интерфейса
    }

    class Driver : Person
    {
        public override void Move()
        {
            Console.WriteLine("Drive");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver();
            IMovable.MethodHandler method = driver.Move;
            
        }
    }


    interface IAction
    {
        void Move();
    }

    class BaseClass
    {
        public void Move()
        {
            Console.WriteLine("Move in BaseClass");
        }
    }

    class HeroClass : BaseClass, IAction
    {
        // Так как метод Move() уже оперделен в базовом классе, то можно не обявлять его для переоперделения метода IAction
    }
}
