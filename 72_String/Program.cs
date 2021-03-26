using System;

namespace _72_String
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "abracadabra";

            string abc = string.Concat("a", "b", "c");

            bool containsA = abc.Contains('a'); // Содержит ли строка char

            Console.WriteLine(containsA);

            Console.WriteLine(int.MaxValue);

            int x = 253;
            string xStr = x.ToString();

            Console.WriteLine();

            // Заканчивается ли строка оперделенной строчкой
            bool endsWithAbra = name.EndsWith("abra");
            Console.WriteLine("endsWithAbra " + endsWithAbra);

            bool startsWithAbra = name.StartsWith("abra");
            Console.WriteLine("startsWithAbra " + endsWithAbra);

            Console.WriteLine();

            int indexOfA = name.IndexOf('a');
            Console.WriteLine($"index of {indexOfA}");

            Console.WriteLine($"index of {name.IndexOf('a', 1)}");

            Console.WriteLine();

            int LastIndexOfA = name.LastIndexOf('a');
            Console.WriteLine($"LastIndexOfA {LastIndexOfA}");

            Console.WriteLine("\n" + name.Length);

            string substrFrom5 = name.Substring(5);
            string substrFromTo = name.Substring(0, 4);
            Console.WriteLine($"substrFrom5 {substrFrom5}");
            Console.WriteLine($"substrFromTo {substrFromTo}");

        }
    }
}
