using System;

namespace _53_interface
{
    /*
     * Интерфейс представляет некое описание типа, набор компонентов, который должен иметь тип данных. 
     * И, собственно, мы не можем создавать объекты интерфейса напрямую с помощью конструктора, как например, в классах
     * 
     * В конечном счете интерфейс предназначен для реализации в классах и структурах
     * 
     * 
     * При применении интерфейса, как и при наследовании после имени класса или структуры указывается двоеточие и затем идут названия применяемых интерфейсов. 
     * При этом класс должен реализовать все методы и свойства применяемых интерфейсов, если эти методы и свойства не имеют реализации по умолчанию
     * 
     * Начиная с версии C# 8.0 интерфейсы поддерживают реализацию методов и свойств по умолчанию.
     * 
     * В С# класс может наследовать сразу несколько интерфейсов. Все реализуемые интерфейсы указываются через запятую.
     * 
     */


    interface IMovable
    {
        virtual void Move()
        {
            Console.WriteLine("I'm walking");
        }
    }

    // Применение интерфейса в классе
    class Person : IMovable
    {
        public void Move()
        {
            Console.WriteLine("I'm walking");
        }
    }

    //Применение интерфейса в структуре
    struct Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("I'm Driving");
        }
    }

    class Truck : IMovable
    {
        // Класс не реализует метод move(), поэтому приментся реализация по умолчанию из интерфейса IMovable
    }

    class Program
    {
        public static void Action(IMovable movable)
        {
            movable.Move();
        }

        static void Main(string[] args)
        {
            IMovable person = new Person();
            IMovable car = new Car();
            IMovable truck = new Truck();
            Truck truck1 = new Truck();

            Action(person);
            Action(car);
            Action(truck);
            Action(truck1);
            // truck1.Move(); // Не можем так седлать потому что метод не определен в Классе




            Client client = new Client("Bob", 5000);
            client.Put(30);
            Console.WriteLine(client.CurrentSum);
            client.Withdraw(100);
            Console.WriteLine(client.CurrentSum);
            Console.ReadKey();


            IAccount account = new Client("Tom", 300); // Все объекты Client являются объектами IAccount 
            account.Put(200);
            Console.WriteLine(account.CurrentSum);
            Client client1 = (Client)account; // Не все объекты IAccount являются объектами Client, необходимо явное приведение
            string clientNama = ((Client)account).Name; // Интерфейс IAccount не имеет свойства Name, необходимо явное приведение


        }
    }


    interface IAccount
    {
        int CurrentSum { get;  }
        void Put(int sum);
        void Withdraw(int sum); // 
    }

    interface IClient
    {
        string Name { get; set; }
    }

    class Client : IAccount, IClient
    {
        int _sum; 
        public string Name { get; set; }
        public Client(string name, int sum)
        {
            Name = name;
            _sum = sum;
        }

        public int CurrentSum { get { return _sum; } }

        public void Put(int sum) => _sum += sum;

        public void Withdraw(int sum)
        {
            if (_sum >= sum)
            {
                _sum -= sum;
            }
            
        }
    }
}
