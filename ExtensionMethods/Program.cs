using System;
using System.Collections.Generic;
using lesson_MyExstension; // для того что бы работал медот расширения, если он опрделен в другом пространстве имен

/* 
 * Методы расширения, расширяющие методы 
 * 
 * Методы расширения должны находится в статическом класса и сами быть статическими
 */

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            currentDateTime.Print();

            DateTime.Now.Print();


            Console.WriteLine(currentDateTime.IsDayOfWeek(DayOfWeek.Tuesday));


            //Console.WriteLine(currentDateTime);

        }
    }
}
