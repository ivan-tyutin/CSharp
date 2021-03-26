using System;

namespace _54_interface_excplicit
{
    /* 
     *  Явная реализация интерфейсов
     *  
     *  При явной реализации указывается название метода или свойства вместе с названием интерфейса, 
     *  при этом мы не можем использовать модификатор public, то есть методы являются закрытыми
     *  
     *  Следует учитывать, что при явной реализации интерфейса его методы и свойства не являются частью интерфейса класса. 
     *  Поэтому напрямую через объект класса мы к ним обратиться не сможем
     *  
     *  В какой ситуации может действительно понадобиться явная реализация интерфейса? 
     *  Например, когда класс применяет несколько интерфейсов, но они имеют один и тот же метод с одним и тем же возвращаемым 
     *  результатом и одним и тем же набором параметров
     *  
     */


    interface IAction
    {
        void Move();
    }

    class BaseAction : IAction
    {
        void IAction.Move()
        {
            Console.WriteLine("Move in Base Class");
        }
    }

    class HeroAction : BaseAction, IAction
    {

    }


    class Program
    {


        static void Main(string[] args)
        {
            BaseAction action = new BaseAction();
            ((IAction)action).Move(); // Необходимо привести к типу IAction

            IAction action2 = new BaseAction();
            action2.Move();

            

            Person person = new Person();
            ((ISchool)person).Study();
            ((IUniversity)person).Study();            

            Console.ReadKey();
        }
    }



    class Person : ISchool, IUniversity
    {
        void ISchool.Study()
        {
            Console.WriteLine("I study at school");
        }

        void IUniversity.Study()
        {
            Console.WriteLine("I study at university");
        }
    }

    interface ISchool
    {
        void Study();
    }

    interface IUniversity
    {
        void Study();
    }
}
