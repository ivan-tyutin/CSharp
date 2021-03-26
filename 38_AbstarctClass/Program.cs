using System;



namespace _38_AbstarctClass
{
    /* 
     *  Мы не можем использовать коструктор абстрактного класса что бы создать его объект.
     *  
     *  Кроме обычных свойств и методов абстрактный класс может иметь абстрактные члены классов, 
     *  которые определяются с помощью ключевого слова abstract и не имеют никакого функционала
     *  Абастрактными могут быть: методы, свойства, индексаторы, события.
     *  
     *  Абстрактные члены классов не должны иметь модификатор private. 
     *  При этом производный класс обязан переопределить и реализовать все абстрактные методы и свойства, которые имеются в базовом абстрактном классе.
     *  При переопределении в производном классе такой метод или свойство также объявляются с 
     *  модификатором override (как и при обычном переопределении виртуальных методов и свойств)
     *  
     *  
     *  
     *  Если класс имеет хотя бы одный абстрактный метод (или абстрактные свойство, индексатор, событие), то этот класс должен быть определен как абстрактный.
     *  
     *  
     *  Абстрактные члены также, как и виртуальные, являются частью полиморфного интерфейса. 
     *  Но если в случае с виртуальными методами мы говорим, что класс-наследник наследует реализацию, 
     *  то в случае с абстрактными методами наследуется интерфейс, представленный этими абстрактными методами.
     *  
     *  
     *  
     *  В классе Person определено абстрактное свойство LastName. Оно похоже на автосвойство, но это не автосвойство. 
     *  Так как данное свойство не должно иметь реализацию, то оно имеет только пустые блоки get и set. 
     *  В производных классах мы можем переопределить это свойство, сделав его полноценным свойством (как в классе Client), 
     *  либо же сделав его автоматическим (как в классе Employee).
     *  
     *  
     */
    abstract class Human
    {
        public int Lenght { get; set; }
        public double Weight { get; set; }
    }

    abstract class Person
    {
        public string Name { get; set; }

        public abstract string LastName { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public abstract void Display();
    }


    class Client : Person
    {
        public int Sum { get; set; }

        public override string LastName { get; set; }

        public Client(string name, int sum)
            : base(name)
        {
            Sum = sum;
        }

        public override void Display()
        {
            Console.WriteLine($"Name: {Name}, Sum: {Sum}");
        }
    }


    class Employee : Person
    {
        public string Position { get; set; }

        public override string LastName { get; set; }

        public Employee(string name, string position)
            : base(name)
        {
            Position = position;
        }

        public override void Display()
        {
            Console.WriteLine($"Name: {Name}, Sum: {Position}");
        }
    }


    abstract class Manger : Person
    {
        // Мы можем отказаться от реализации абстрактных методов и свойст, но тогда такой класс должен быть абстрактным.

        public Manger(string name) : base(name)
        { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Tom", 500);
            Employee employee = new Employee("Bob", "Manager");
            client.Display();
            employee.Display();
            //Person person = new Person("Tim"); // Мы не можем создать экземпляр класса используя конструктор класса Person
            //И хотя в примере выше конструктор класса Person не вызывается, тем не менее производные классы Client и Employee могут обращаться к нему.
        }
    }
}
