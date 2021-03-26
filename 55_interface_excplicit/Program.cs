using System;

namespace _55_interface_excplicit
{

    /*
     * Члены интерфейса могут иметь разные модификаторы доступа. Если модификатор доступа не public,
     * а какой-то другой, то для реализации метода, свойства или события интерфейса в классах и 
     * структурах также необходимо использовать явную реализацию интерфейса
     * 
     */

    interface IAction
    {
        void Move();
    }

    class BaseAction : IAction
    {
        public void Move()
        {
            Console.WriteLine("move in Base class");
        }
    }

    class HeroAction : BaseAction, IAction
    {
        void IAction.Move()
        {
            Console.WriteLine("move in Hero class");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HeroAction hero = new HeroAction();
            BaseAction action = new BaseAction();

            ((IAction)hero).Move();
            ((IAction)action).Move();

            
        }
    }


    interface IMovable
    {
        protected internal void Move();
        protected internal string Name { get; set; }
        delegate void MoveHandler();
        protected internal event MoveHandler MoveEvent;
    }

    class Person : IMovable
    {
        
        string IMovable.Name { get; set; } // явная реализация свойства - в виде автосвойства

        IMovable.MoveHandler _moveEvent; // явная реализация события - дополнительно создается переменная
        event IMovable.MoveHandler IMovable.MoveEvent 
        {
            add => _moveEvent += value;
            remove => _moveEvent -= value;
        }

        void IMovable.Move() // явная реализация метода
        {
            Console.WriteLine("Person is welking");
            _moveEvent();
        }

    }

    /*
     * В данном случае опять же надо учитывать, что напрямую мы можем обратиться к подобным методам, 
     * свойствам и событиям через переменную интерфейса, но не переменную класса.
     */
}
