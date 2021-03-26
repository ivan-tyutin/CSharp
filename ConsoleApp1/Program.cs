using System;
using System.Collections.Generic;

// Класс List<T> из пространства имен System.Collections.Generic представляет простейший список однотипных объектов.

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int>() { 1, 3, 6, 2, 4, 1, 35, 12, };
            number.Add(4); // Добавление элемента
            number.AddRange(new int[] { 7, 8, 9 });

            number.Insert(5, 555); // Вставляем на шестое место в списке число 555

            number.RemoveAt(1); // Удаляем второй элемент

            number.Sort(delegate(int x, int y) 
            { 
                return y - x; 
            });

            foreach(int i in number)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            List<Person> people = new List<Person>(3); // Передаем начальную емкость списка
            people.Add(new Person() { Name = "Tom" });
            people.Add(new Person() { Name = "Bill" });

            foreach(var p in people)
            {
                Console.Write(p.Name + "\t");
            }
            Console.WriteLine();

            
                
        }

        class Person
        {
            public string Name { get; set; }
        }
    }
}
