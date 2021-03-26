using System;

namespace Enum
{

    enum Time : byte
    {
        Morning,
        Afternoon,
        Evening,
        Night
    }


    enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    


    class Program
    {
        enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            Days day = Days.Friday;
            Console.WriteLine((int)day);

            Time time = Time.Evening;
            Console.WriteLine(time);

            Console.ReadLine();
        }
    }
}
