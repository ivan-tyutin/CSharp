using System;

namespace methodsOverload
{

    class Person
    {
        private string firstName;
        private string secondName;
        // Спецальные  методы класса которые называются свойства, предостовляют быстрй доступ к полям класса.
        // В них можно писать дополнительную логику для иницилизации полей класса.
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }
        // Автоматичесток свойство
        public int age { get; set; } = 25;


        // Конструктор с параметрами по умолчанию, можно с делигирующими конструкторами
        /*public Person(string firstName = "noFirsName", string secondName = "noSecondName", int age = 0) // : Person("noName")
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.age = age;
        }*/


        // Делигирующий конструктор
        public Person() : this("noName")
        {
        }
        public Person(string firstName) : this(firstName, "noSecondName")
        {
            this.firstName = firstName;
        }
        public Person(string firstName, string secondName) : this(firstName, secondName, 18)
        {
            this.firstName = firstName;
            this.secondName = secondName;
        }

        public Person(string firstName, string secondName, int age) 
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.age = age;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
