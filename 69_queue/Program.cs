using System;
using System.Collections.Generic;

// Класс Queue<T> представляет обычную очередь, работающую по алгоритму FIFO ("первый вошел - первый вышел").


namespace _69_queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> number = new Queue<int>();
            number.Enqueue(3);
            number.Enqueue(4);
            number.Enqueue(5);

            int queueElement = number.Dequeue();
            Console.WriteLine(queueElement);

            Queue<Person> persons = new Queue<Person>();
            persons.Enqueue(new Person() { Name = "Tom" });
            persons.Enqueue(new Person() { Name = "Bill" });
            persons.Enqueue(new Person() { Name = "John" });

            Person p = persons.Peek(); // Получаем первый элемент без его извлечения
            Console.WriteLine(p.Name);

            Console.WriteLine("Сейчас в очереди {0} человек", persons.Count);

            // теперь в очереди Tom, Bill, John
            foreach(Person pp in persons)
            {
                Console.Write(pp.Name + " ");
            }
            Console.WriteLine();


            Person person = persons.Dequeue();
            Console.WriteLine(person.Name);

            Console.ReadLine();

        }


        class Person
        {
            public string Name { get; set; }
        }
    }
}
