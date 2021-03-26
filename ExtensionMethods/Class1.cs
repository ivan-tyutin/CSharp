using System;
using System.Collections.Generic;
using System.Text;

namespace lesson_MyExstension
{

    static class MyExtensions
    {
        /* 
         * Первым параметром для расширения всегда идет переменная с тем типом данных для которого пишется расширение 
         */
        public static void Print(this DateTime dateTime)
        {
            Console.WriteLine(dateTime);
        }

        public static bool IsDayOfWeek(this DateTime dateTime, DayOfWeek dayOfWeek)
        {
            return dateTime.DayOfWeek == dayOfWeek;
        }
    }
}


namespace hello
{
    static class MyClass
    {
        public static void Print()
        {
            Console.WriteLine("Hello world");
        }
    }
}


namespace hello
{

    static class MyClass2
    {
        public static void PrintHello()
        {
            Console.WriteLine("Hello");
        }
    }


}