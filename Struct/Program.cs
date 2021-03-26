using System;

namespace Struct
{

    struct User
    {
        public string name;
        public int age;

        /* Если мы содаем конструктор, то нам необходимо иницилизировать все атрибуты класса */
        public User(string name, int age) 
        {
            this.name = name;
            this.age = age;
        }

        public void DisplayInfo() => Console.WriteLine($"Name: {name}, Age: {age}");
    }


    struct User2
    {
        //public string name = "Unknown"; // Не возможно иницилизировать поля стрктуры по умолчанию
        public int age;
        public string name;

        /*public User2() // Структуры не могут содеражать конструкторов без параметров
        {
            this.age = 18;
            this.name = "Unknown";
        }*/


        public void GetInfo() => Console.WriteLine($"Name: {name}, Age: {age}");
    }



    class Program
    {
        static void Main(string[] args)
        {
            User tom; // Можно обявить переменную данного класса и потом уже присвоить ей значения
            // При таком обявления до моменто присоения атрибутам класса конкретных значения там будет хранится мусор и компилатор не дасть скомпилироватся такой программе

            tom = new User();

            //tom.age = 25;
            //tom.name = "Tom";
            tom.DisplayInfo();

            User2 bob = new User2 { name = "bob", age = 41};
            bob.GetInfo();






        }
    }
}
