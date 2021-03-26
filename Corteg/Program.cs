using System;

namespace Corteg
{

    class Person
    {
        public string name;
        public int age = 18;


        public Person() : this("Unkonw")
        {
        }

        public Person(string name ) : this( name, 18)
        {
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void GetInfo() => Console.WriteLine($"Name: {name}, Age: {age}");
    }



    class Program
    {


        static (int, int) GetCorteg()
        {
            var result = (1, 3);
            return result;
        }



        static void Main(string[] args)
        {
            var tuple = (4, 10);
            Console.WriteLine($"Item1: {tuple.Item1}, Item2: {tuple.Item2}");


            (string, int, double) value = ("hello", 24, 23.55);
            Console.WriteLine($"Item1: {value.Item1}, Item2: {value.Item2}, Item3: {value.Item3} ");

            (decimal sum, char letter, byte flag) value2 = (sum: 234.43m, letter: 'A', flag: 128); // Можно просто объявить переменную типа var
            Console.WriteLine($"Item1: {value2.sum}, Item2: {value2.letter}, Item3: {value2.flag} ");


            var TwoValues = GetCorteg();
            Console.WriteLine($"Item1: {TwoValues.Item1}, Item2: {TwoValues.Item2}");


            (int x, int y) point = (3, 4);
            Console.WriteLine($"X: {point.x}, Y: {point.y}");


            Person tom = new Person { name = "Tom", age = 32 };
            tom.GetInfo();




        }
    }
}
