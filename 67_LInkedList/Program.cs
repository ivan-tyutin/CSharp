using System;
using System.Collections.Generic;

namespace _67_LInkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> number = new LinkedList<int>();

            number.AddLast(1); // Вставляем узел со значением 1 на последнее место
            // так как в списке нет узлов, то последнее будет также первым

            number.AddFirst(2); // Вставляем узел со значением 2 на первое место

            number.AddAfter(number.Last, 3); // Вставляем после последнего узла новый узел со значением 3

            foreach(int i in number)
            {
                Console.WriteLine(i);
            }

            LinkedList<Person> persons = new LinkedList<Person>();

            LinkedListNode<Person> tom = persons.AddLast(new Person() { Name = "Tom" });
            persons.AddLast(new Person() { Name = "John" });
            persons.AddFirst(new Person() { Name = "Bill" });

            Console.WriteLine(tom.Previous.Value.Name); // Получаем узел перед томом и его значение 
            Console.WriteLine(tom.Next.Value.Name); // Получаем узел после тома и его значение

            foreach(var i in persons)
            {
                Console.Write(i.Name + " ");
            }
            Console.WriteLine();

            Console.ReadLine();

        }

        class Person
        {
            public string Name { get; set; }
        }
    }
}
