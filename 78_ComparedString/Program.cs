using System;


// Сравнение строк

namespace _78_ComparedString
{

    // stringComparison.Ordinal - сравнивает байтовую репрезентацию каждого символа в сравниваемых строках (используем в большенстве случаев)
    // stringComparison.InvariantCulture - стараться избегать
    // stringComparison.CurrentCulture - сравнение с учетом лингвистические особености разных языков

    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "abcde";
            string str2 = "abcde";

            bool areEqula = str1 == str2;
            Console.WriteLine(areEqula);

            areEqula = string.Equals(str1, str2, StringComparison.Ordinal); // same as str1 == str2
            Console.WriteLine(areEqula);


            string[] strings = Console.ReadLine().Split(" ");

            double result = Geron(double.Parse(strings[0]), double.Parse(strings[1]), double.Parse(strings[2]));
            Console.WriteLine($"{result:f4}");
            
        }

        static double Geron(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double result = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return result;
        }

        
        abstract class Test
        {
            

        }
    }
}
