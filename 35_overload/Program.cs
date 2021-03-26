using System;

namespace _35_overload
{
    class Clock
    {
        public int Hours { get; set; }

        public static implicit operator Clock(int x)
        {
            return new Clock { Hours = x % 24 };
        }  
        
        public static explicit operator int(Clock clock)
        {
            return clock.Hours ;
        }
    }


    class Celcius
    {
        public double Gradus { get; set; }

        public static implicit operator Celcius(Fahrenheit far)
        {
            return new Celcius { Gradus = 5.0 / 9.0 * (far.Gradus - 32.0) };
        }


    }

    class Fahrenheit
    {
        public double Gradus { get; set; }
        
        public static implicit operator Fahrenheit(Celcius cel)
        {
            return new Fahrenheit { Gradus = 9.0 / 5.0 * cel.Gradus + 32.0 };
        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            int second = 66;
            Clock clock = second;
            Console.WriteLine(clock.Hours);

            second = (int)clock;
            Console.WriteLine(second);

            Console.WriteLine("************************* temperatura *********************************");

            Celcius temper1 = new Celcius { Gradus = 25.234 };
            Fahrenheit temper2 = temper1;
            Console.WriteLine(temper2.Gradus);

            temper1 = temper2;
            Console.WriteLine(temper1.Gradus);

            Console.WriteLine("************************ Euro and Dollars****************************");

            Dollar dollar = new Dollar { Sum = 24.5m };
            Euro euro = dollar;
            Console.WriteLine(euro.Sum);

            dollar = (Dollar)euro;
            Console.WriteLine(dollar.Sum);

        }
    }


    class Dollar
    {
        public decimal Sum { get; set; }


        public static explicit operator Dollar(Euro euro)
        {
            return new Dollar { Sum = euro.Sum / 1.19m };
        }

        public static implicit operator Euro(Dollar dollar)
        {
            return new Euro { Sum = dollar.Sum * 1.19m };
        }
    }


    class Euro
    {
        public decimal Sum { get; set; }
    }
}
