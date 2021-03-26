using System;

// Свойства (Properties)
// Автоматические свойства

namespace GetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Point point = new Point(1, 1, 1);
            //point.Y = 25;
            int y = point.Y;

            point.D = 12;
            int d = point.D;

          }
    }



    class Point
    {
        private int x;
        private int z;
        private int y = 2;
        

        public Point(int x , int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }


        public int Y
        {
            get { return y; } // Аксесоры
            
            private set  // можно так же устанавливать модификаторы доступа
            {
                if (value < 1)
                {
                    y = 1;
                } 
                else if (value > 5)
                {
                    y = 5;
                }
                else
                {
                    y = value;
                }
            } // value в данном случае это ключевое слово, по сути это входящий параметр
        }



        public int D { get; set; } = 23; // В автоматический свойствах не может быть только set
        /* Автосвойству можно присоить значение по умолчанию */

        public void SetZ(int z)
        {
            if (z < 1)
            {
                this.z = 1;
            } 
            else if (z > 5)
            {
                this.z = 5; 
            } 
            else
            {
                this.z = z;
            }
            
        }


        public void SetX(int x) => this.x = x;
        public int GetX() => x;


        

    }
}
