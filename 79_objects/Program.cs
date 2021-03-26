using System;

namespace _79_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            object obj = x; // boxing
            int y = (int)obj; // unboxing

            double pi = 3.14;
            object obj1 = pi;


            PointRef point = new PointRef { Name = "Tim" };
        }


        static void Do(object obj)
        {
            if( obj is PointRef pr )
            {
                pr = (PointRef)obj;
                Console.WriteLine(pr.Name);
            }

            PointRef pr1 = obj as PointRef;
            if (pr1 != null)
            {
                Console.WriteLine(pr1.Name);
            }
        }


        class PointRef
        {
            public string Name { get; set; } = "Unknow";
        }
    }
}
