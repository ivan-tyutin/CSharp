using System;

namespace Class
{
    class Person
    {
        public string name;
        public int age;

        /*
        public Person() : this ("Unknown")
        {
        }

        public Person(string name) : this(name, 18)
        {
        }

        public Person(string name, int age) 
        {
            this.name = name;
            this.age = age;
        }
        */

        public Person(string name = "Unknown", int age = 18)
        {
            this.name = name;
            this.age = age;
        }

        public void GetInfo() => Console.WriteLine($"Name: {name}, Age: {age}");
        public string GetName() => name;
        public int GetAge() => age;

    }





    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person("tom", 25);
            Person bob = new Person { name = "bob", age = 21 };
            Person tim; // Ты можещь объявить переменную данного класса, но она будет указывать на null
        }
    }
}
