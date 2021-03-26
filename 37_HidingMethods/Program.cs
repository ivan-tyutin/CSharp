using System;

namespace _37_HidingMethods
{

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public virtual  void Display()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }

    class Employee : Person
    {
        public string Company { get; set; }

        public new string FirstName { get; } //  Скрывает реализицию базового класса.
        public new string LastName { get; } //  Скрывает реализицию базового класса.


        public Employee(string firstName, string lastName, string company)
            : base(firstName, lastName)
        {
            Company = company;
        }

        /* Ключевое слово new скрывает реализацию данного метода из базового класса */
        public override void Display()
        {
            Console.WriteLine($"{FirstName} {LastName} works for {Company}");
        }
    }



    class Manager : Employee
    {
        public string Departament { get; set; }

        public Manager(string firstName, string secondName, string company)
            : base(firstName, secondName, company)
        {

        }

        public override void Display()
        {
            Console.WriteLine("Manager");
            base.Display();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person bob = new Person("bob", "robertson");
            bob.Display();

            Person tom = new Employee("tom", "tomson", "Microsoft");
            tom.Display();
            

            Person tim = new Manager("Tim", "Timson", "Apple");
            tim.Display();

            Console.ReadKey();
            
        }
    }
}
