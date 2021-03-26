using System;
using System.Collections;
using System.Linq;

namespace _66_arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(3.4); // Добавить в колекцию объект
            list.Add(55);
            list.AddRange(new string[] { "hello", "world" }); // Добавить в список объекты колекции, которя представляет интерфейс ICollection


            foreach(object obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAt(0); // Удалить первый элемент
            list.Reverse(); // Переворачивает список
            Console.WriteLine(list[0]); // Получить элемент по индексу

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }


            Console.ReadKey();
            


        }
    }
}
