using System;

namespace _34_Inheritance
{
    

     class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public void Display()
        {
            Console.WriteLine(Name ?? "No Name");
        }
    }


    class Employee : Person 
    {

        private static int counter;

        public static int Counter
        {
            get { return counter; }
            set { counter = value; }
        }

        static Employee()
        {

        }

        public string Company { get; set; }
        public Employee(string name, string company) 
            : base(name)

        {
            Company = company;
        }
    }


    // У данного класса недопустимо создавать наследников
    sealed class Admin
    {

    }


    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Bob", "Apple") { Name = "tom"};
            employee?.Display();
            ((Person)employee).Display();
        }
    }
}
