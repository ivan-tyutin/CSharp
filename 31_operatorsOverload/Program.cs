using System;

// Перегрузка операторов

namespace _31_operatorsOverload
{


    class State
    {
        public decimal Population { get; set; }
        public decimal Area { get; set; }



        public static State operator +(State s1, State s2)
        {
            return new State { Area = s1.Area + s2.Area,
                Population = s1.Population + s2.Population };
        }


        public static bool operator <(State s1, State s2)
        {
            return s1.Population < s2.Population;
        }
        public static bool operator >(State s1, State s2)
        {
            return s1.Population > s2.Population;
        }
    }



    class Counter
    {
        public int Value { get; set; }


        public static Counter operator +(Counter c1, Counter c2)
        {
            return new Counter { Value = c1.Value + c2.Value };
        }

        public static bool operator >(Counter c1, Counter c2)
        {
            return c1.Value > c2.Value;
        }

        public static bool operator <(Counter c1, Counter c2)
        {
            return c1.Value < c2.Value;
        }

        public static int operator +(Counter c1, int value)
        {
            return c1.Value + value;
        }

        public static bool operator true(Counter c1)
        {
            return c1.Value != 0;
        }

        public static bool operator false(Counter c1)
        {
            return c1.Value == 0;
        }

    }



    class Bread
    {
        public int Weight { get; set; }

        public static Sandwich operator +(Bread bread, Butter butter)
        {
            return new Sandwich { Weight = bread.Weight + butter.Weight };
        }
    }


    class Butter
    {
        public int Weight { get; set; }
    }

    class Sandwich
    {
        public int Weight { get; set; }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Counter c1 = new Counter { Value = 25 };
            Counter c2 = new Counter { Value = 12 };

            bool result = c1 > c2;
            Counter c3 = c1 + c2;

            Console.WriteLine(c3.Value + 12);
            c1.Value = 0;
            if (c1)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }



            Bread bread = new Bread { Weight = 80 };
            Butter butter = new Butter { Weight = 20 };

            Sandwich sandwich = bread + butter;

            Console.WriteLine(sandwich.Weight);
        }
    }
}
