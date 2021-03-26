using System;

/* Наследование, конструкторы класса и ключевое слово base */


namespace _21_base
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2D point2d = new Point2D(2, 3);
            Point3D point = new Point3D(4, 2, 1);
            point.Print3D();

           //Point2D basePoint = new Point3D();
           
        }
    }


    class Point2D
    {

        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
            Console.WriteLine("called constructor Point2D");
        }
        public int X { get; set; }
        public int Y { get; set; }

        public void Print2D()
        {
            Console.WriteLine($"X:\t{X}, Y\t{Y}");
        }


    }

    sealed class Point3D : Point2D
    {

        public Point3D(int x, int y, int z) : base(x, y) // для иницилизации конструктора базового класса
        {
            Z = z;
            Console.WriteLine("Called constructor Point3D");
        }

        public int Z { get; set; }

        public void Print3D()
        {
            base.Print2D(); // Нужно во избежание неодназначнасти, если методы у наследника и родителя называются одинаково.
            Console.WriteLine($"Z:\t{Z}");
        }

    }


}
