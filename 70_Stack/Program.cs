using System;
using System.Collections.Generic;

namespace _70_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();

            numbers.Push(3);
            numbers.Push(5);
            numbers.Push(8);

            int stackElemetn = numbers.Pop();
            Console.WriteLine(stackElemetn);

            Stack<Person> persons = new Stack<Person>();

            persons.Push(new Person() { Name = "Tim" });
            persons.Push(new Person() { Name = "Bob" });
            persons.Push(new Person() { Name = "John" });

            foreach(Person pp in persons)
            {
                Console.Write(pp.Name + " ");
            }
            Console.WriteLine();

            Person person = persons.Pop();
            Console.WriteLine(person);

        }


        class Person
        {
            public string Name { get; set; }

            /*public override string ToString()
            {
                return Name;
            }*/
        }
    }
}
