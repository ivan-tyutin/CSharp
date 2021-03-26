using System;
using System.Collections;


namespace ITrydifferentThings
{

    interface ITest
    {

        // Интерфейс не может содержать конструктор

        string LastName
        {
            get { return null; }
            set { }
        }
        string Name { get; set; }

        static int n = 24;
        static void Foo()
        {
            Console.Write("Foo");
        }
    }


    abstract class Test<T> where T : new()
    {
        public static void Foo()
        {
            Console.WriteLine("StaticFoo");
        }
    }

     struct ChildStruct
    {
        public int n;
        public int N
        {
            get
            {
                return n;
            }
            set
            {
                n = value;
            }
        }
    }


    public interface IShape
    {
        int CalcSquare();
    }

    class Rect : IShape
    {
        public virtual int  Width { get; set; }
        public virtual int  Height { get; set; }

        public int CalcSquare()
        {
            return Width * Height;
        }
    }

    class Square : IShape
    {
        public int SideLength { get; set; }
        public int CalcSquare()
        {
            return SideLength * SideLength;
        }
    }


    static class AreaCalculator {

        /*public static int CalcSquare(Square squrae)
        {
            return squrae.Height * squrae.Height;
        }

        public static int CalcSquare(Rect rect)
        {
            return rect.Height * rect.Width;
        }*/

    }


    class Program
    {
        static void Main(string[] args)
        {

            ArrayList list = new ArrayList();
            list.Add(3.4);
            list.Add(43);
            list.Add("hello");
            list.Add('d');
            list.Add(64.43);

            foreach (object o in list)
            {
                Console.Write(o + " ");
            }
            Console.WriteLine();

            string line = "hello world";
            line.Print();


            Console.WriteLine("****************************");

            IShape shape = new Rect { Height = 4, Width = 2 };
            Console.WriteLine(shape.CalcSquare());

            IShape shape1 = new Square { SideLength = 10 };
            Console.WriteLine(shape1.CalcSquare());




        }
    }


    static class MyExstatsion
    {
        public static void Print(this string str)
        {
            Console.WriteLine(str);
        }
    }


    class Person
    {
        public string Name { get; set; } = "Tom";


        private int age = 25;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }


    }


    struct Student
    {
        public string Name { get; set; }
    }


    static class MyClass
    {
        public static double PI = 3.14;

    }
}
