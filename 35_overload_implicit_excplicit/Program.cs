using System;

namespace _35_overload_implicit_excplicit
{

    class Counter
    {
        public int Second { get; set; }


        // Такая форма у пергрузки операции преобразования типов
        /* можно указывать в какой форме будет применятся в явной(explicit) или неявной(implicit) */
        public static implicit operator Counter(int x)
        {
            return new Counter { Second = x };
        }

        public static explicit operator int(Counter counter)
        {
            return counter.Second;
        }

        public static explicit operator Counter(Timer timer)
        {
            int h = timer.Hours * 3600;
            int m = timer.Minutes * 60;

            return new Counter { Second = h + m + timer.Seconds };
        }

        public static implicit operator Timer(Counter counter)
        {
            int h = counter.Second / 3600;
            int m = (counter.Second % 3600) / 60;
            int s = counter.Second % 60;
            return new Timer { Hours = h, Minutes = m, Seconds = s };
        }

    }

    class Timer
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public void Print()
        {
            Console.WriteLine($"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int x = 50;
            byte y = (byte)x; // Явное преобразование от int к byte (explicit)
            int z = y; // Неявное преобразование от byte к int (inplicit)
            Console.WriteLine();

            int second = 23;

            Counter counter = new Counter { Second = 55};
            counter = second;

            Console.WriteLine((int)counter);


            Timer timer = new Timer { Hours = 2, Minutes = 33, Seconds = 11 };
            timer.Print();

            Counter counter1 = (Counter)timer;
            Console.WriteLine(counter1.Second);

            timer = counter1;
            timer.Print();


        }
    }
}
