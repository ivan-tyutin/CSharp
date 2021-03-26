using System;


/* 
 * 
 * Приведение типов
 * 
 * Использование операторов операторов as и is
 * 
 */


namespace _22_as_is
{

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void ShowPoints()
        {
            Console.WriteLine($"X: {X}, Y: {Y}");
        }

        protected internal int b;
        protected private int a;
        
    }




    class Program
    {
        static void Main(string[] args)
        {
            Object obj = new Point { X = 23, Y = 12 }; // неявное приведение типов 
            Point point = (Point)obj; // Что бы использовать данные класса Point необходимо явно преобразовать obj к классу Point
            //point.ShowPoints();

            Foo(point);
            Bar(point);

            Object a = 4;
            Object str = "Hello World!";

            Bar(str);
            Foo(a);

            Counter count = new Counter { Value = 10 , Value2 = 23};

            Counter counter2 = count;
            count++;
            ++count;
             

            Console.WriteLine(count.Value + " " + count.Value2);
            Console.WriteLine((++count).Value + " " + count.Value2);
            Console.WriteLine(count.Value + " " + count.Value2);


            Console.WriteLine(count.Value);
            Console.WriteLine((count++).Value);
            Console.WriteLine(count.Value);

        }

        static void Foo(object obj)
        {
            Point point = obj as Point; 
            /*
             * Оператор as проверяет дейстивтельно ли можно привести obj к классу 
             * Point и если можно то передает в переменную значения из obj как Point, а если нельзя, то возвращает null
             * 
             */
            if (point != null)
            {
                point.ShowPoints();
            }
        }


        static void Bar(object obj)
        {
            /* 
             * Проверяет действительно ли в объекте obj класс Point, и если да, 
             * то возварщает true и создает новый объект тип Point и присваивет туда значение из obj 
             */
            if (obj is Point point) 
            {
                point.ShowPoints();
            }
        }

        class Counter
        {
            public int Value { get; set; }
            public int Value2 { get; set; }


            public static Counter operator ++(Counter count)
            {
                return new Counter { Value = count.Value + 2 };

            }

        }
    }
}
