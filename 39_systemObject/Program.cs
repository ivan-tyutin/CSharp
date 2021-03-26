using System;

namespace _39_systemObject
{

    class Clock
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public override string ToString()
        {
            return $"{Hours}:{Minutes}:{Seconds}";
        }
    }

    class Person
    {
        public string Name { get; set; }

        public override string ToString()
        {
            if (String.IsNullOrEmpty(Name))
            {
                return base.ToString();
            }
            return Name;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            
            Person person = (Person)obj;
            return this.Name == person.Name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            /* 
             *      ToString 
             *  Для базовоых будет выводится их сроковое значение
             *  Для классов этот метод выводит полное название класса с указанием пространства имен
             *  Мы можем переопределить этот метод
             */
            int i = 5;
            Console.WriteLine(i.ToString());

            double d = 3.5;
            Console.WriteLine(d.ToString());

            int[] arr1 = { 3, 4, 5, 1 };
            int[] arr2 = { 3, 1, 5 };


            Clock clock = new Clock { Hours = 21, Minutes = 43, Seconds = 11 };
            Console.WriteLine(clock.ToString());

            Array.Copy(arr1, arr2, arr2.Length);

            foreach(int x in arr2)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

            Person person = new Person { Name = "Tim"};
            Console.WriteLine(person.ToString());

            // GetType - не переоперделяется в отлииции от классов ToString Equals, GetHashCode

            Person person1 = new Person { Name = "bob" };
            Console.WriteLine(person1.GetType());
            Console.WriteLine(arr1.GetType());
            Console.WriteLine(d.GetType());

            object pers = new Person { Name = "Tom" };
            if (pers.GetType() == typeof(Person))
            {
                Console.WriteLine("this is a real Person class");
            }

            // Метод Equals позволяетс сравнить два объекта на равенство


            object obj = new Person();
            Console.WriteLine(obj.GetType());
            Console.WriteLine(obj.Equals(person));

        }
    }
}
