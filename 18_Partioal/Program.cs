using System;


/* 
 * Частичные типы
 * 
 * partial классы
 * 
 * partial методы
 * 
 */


/* 
 * Просто так разбивать класс большого смысла нет
 */


namespace _18_Partioal
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Benedikt", "Kemberbage");
            person.PrintFullName();
        }
    }
}
