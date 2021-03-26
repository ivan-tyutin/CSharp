using System;
using System.Collections.Generic;
using System.Numerics;

namespace _71_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            // Двух одинаковых ключей в словаре быть не может, если добавим то возникнет исключение
            Dictionary<int, string> countries = new Dictionary<int, string>(5);

            countries.Add(1, "Russia");
            countries.Add(2, "Great Britan");
            countries.Add(3, "USA");
            countries.Add(4, "France");
            countries.Add(5, "China");


            foreach(KeyValuePair<int, string> keyValue in countries)
            {
                Console.WriteLine(keyValue.Key + " " + keyValue.Value);
            }

            // Получить значение элемента по ключу
            string country = countries[4];

            // Изменить объект
            countries[4] = "Spain";

            countries.Remove(2);

            Console.ReadLine();

            

        }
    }

    
}


