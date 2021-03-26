using System;

namespace _36_VirtualMethodsAndProperties
{


    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }

        public virtual void Dispaly()
        {
            Console.WriteLine(Name);
        }

    }
    class Employee : Person
    {
        public string Company { get; set; }

        public Employee(string name, string company)
            : base(name)
        {
            Company = company;
        }

        /*
         * Также можно запретить переопределение методов и свойств. В этом случае их надо объявлять с модификатором sealed
         * При создании методов с модификатором sealed надо учитывать, что sealed применяется в паре с override, то есть только в переопределяемых методах.
         */
        public override sealed void Dispaly()
        {
            base.Dispaly(); // С помощю ключевого слова base можно обращатся к другим членам базового класса. В данном случае обращается к методу Dispaly() класса Person.
            Console.WriteLine($"Name: {Name}, Company: {Company}");
        }

    }

    /* При переопределении виртуальных методов следует учитывать ряд ограничений:

        Виртуальный и переопределенный методы должны иметь один и тот же модификатор доступа. 
        То есть если виртуальный метод определен с помощью модификатора public, то и переопредленный метод также должен иметь модификатор public.

        Нельзя переопределить или объявить виртуальным статический метод. 
    */
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("tom");
            person1.Dispaly();

            Employee person2 = new Employee("Bob", "Apple");
            person2.Dispaly();

            Person person3 = new Employee("Tim", "Microsoft");
            person3.Dispaly();

            Console.WriteLine("************************** Credit ********************************");

            LongCredit credit = new LongCredit { Sum = 6000 };
            credit.Sum = 490;
            Console.WriteLine(credit.Sum);
            Console.ReadKey();


        }
    }



    class Credit
    {
        public virtual decimal Sum { get; set; }
    }

    class LongCredit : Credit
    {
        private decimal sum;
        public override decimal Sum
        {
            get
            {
                return sum;
            }
            set
            {
                if (value > 1000)
                {
                    sum = value;
                }
            }
        }
    }
}
