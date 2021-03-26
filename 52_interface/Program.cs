using System;

/*
 * Интерфейс представляет ссылочный тип, который может определять некоторый функционал - набор методов и свойств без реализации. 
 * Затем этот функционал реализуют классы и структуры, которые применяют данные интерфейсы.
 * 
 * Интерфейсы могут определять: Методы, свойства, индексаторы, события, статические поля и константы
 * Однако интерфейсы не могут определять нестатические переменные.
 * 
 * если его члены - методы и свойства не имеют модификаторов доступа, но фактически по умолчанию доступ public, 
 * так как цель интерфейса - определение функционала для реализации его классом. Это касается также и констант и статических переменных
 * 
 * Но также, начиная с версии C# 8.0, мы можем явно указывать модификаторы доступа у компонентов интерфейса
 * 
 * Начиная с версии C# 8.0 интерфейсы поддерживают реализацию методов и свойств по умолчанию. 
 * Это значит, что мы можем определить в интерфейсах полноценные методы и свойства, которые имеют реализацию как в обычных классах и структурах
 * 
 * Стоит отметить, что если интерфейс имеет приватные методы и свойства (то есть с модификатором private), то они должны иметь реализацию по умолчанию. 
 * То же самое относится к любым статическим методам и свойствам (не обязательно приватным)
 * 
 * 
 * Как и классы, интерфейсы по умолчанию имеют уровень доступа internal, 
 * то есть такой интерфейс доступен только в рамках текущего проекта. Но с помощью модификатора public мы можем сделать интерфейс общедоступным
 * 
 * 
 * С реализацией свойств по умолчанию в интерфейсах дело обстоит несколько сложнее, поскольку мы не можем определять в интерфейсах нестатические переменные, 
 * соответственно в свойствах интерфейса мы не можем манипулировать состоянием объекта. Тем не менее реализацию по умолчанию для свойств мы тоже можем определять
 * 
 */


namespace _52_interface
{

     class Test
    {
        public delegate void FooHandler();
        public event FooHandler eventHandler;
        public FooHandler fooHandler;

        public int x = 24;

        public int X { get; protected set; } = 2334;

        static public int Y = 234;

        public abstract void Foo();

    }

    interface ITest
    {
        delegate void FooHandler();
        event FooHandler eventHandler;

    }

    interface IMovable
    {
        const int minSpeed = 0;

        private static int maxSpeed = 60;

        

        int MaxSpeedd
        {
            get { return 0; }
        }

        void Move()
        {
            Console.WriteLine("walking");
        }

        static double GetTime(double distance, double speed) => distance / speed;

        static int MaxSpeed
        {
            get { return maxSpeed; }
            set
            {
                if (value > 0) maxSpeed = value;
            }
        }

        string Name { get; set; }

        delegate void MoveHandler(string message);

        event MoveHandler MoveEvent;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IMovable.MaxSpeed);
            IMovable.MaxSpeed = 65;
            Console.WriteLine(IMovable.MaxSpeed);
            double time = IMovable.GetTime(100, 10);
            Console.WriteLine(time);

            Test test = new Test();
            test.eventHandler += delegate { Console.WriteLine("hello wordl"); };
            test.fooHandler = () => Console.WriteLine("Hello world");
            test.eventHandler += () => { Console.WriteLine("hello world"); };
            
        }
    }
}
