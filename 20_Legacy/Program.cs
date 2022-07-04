using System;


/* Наследование в ООП */
// Множественное наследование в С# запрещено

namespace _20_Legacy
{



    
    //HEllo
    class Program
    {
        static void Main(string[] args)
        {
            Person tim = new Person {FirstName = "Tim", LastName = "Blumberg"};
            tim.PrintName();

            Student student = new Student();
            student.Learn();

            Student tom = new Student() { FirstName = "Tom", LastName = "Benington"};
            PrintFullName(tom);

            object obj = new object();
            
        }

        static void PrintFullName(Person person)
        {
            Console.WriteLine($"FirstName: {person.FirstName} LastName: {person.LastName}");
        }

    }


    class Person
    {
        public string FirstName { get; set; }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        } 


        /*public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }*/

        public void PrintName()
        {
            Console.WriteLine($"My name is {FirstName} {lastName}");
        }


    }



    class Student : Person
    {
        public void Learn()
        {
            Console.WriteLine("I'm learning");
        }
    }

}
