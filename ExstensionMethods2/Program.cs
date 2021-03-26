using System;
using Exstension;

namespace ExstensionMethods2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student tom = new Student() { FirstName = "Tom", LastName = "Jankis" };

            Console.WriteLine(tom.GetFullName());
        }
    }
}
