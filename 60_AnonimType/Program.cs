using System;

/* 
 * Анонимные типы
 * 
 * Анонимные типы позволяют создать объект с некоторым набором свойств без определения класса. 
 * Анонимный тип определяется с помощью ключевого слова var и инициализатора объектов
 * 
 * Для исполняющей среды CLR анонимные типы будут также, как и классы, представлять ссылочный тип.
 * 
 * Если в программе используются несколько объектов анонимных типов с одинаковым набором свойств, то для них компилятор создаст одно определение анонимного типа
 * 
 * 
 * Следует учитывать, что свойства анонимного объекта доступны для установки только в инициализаторе. Вне инициализатора присвоить им значение мы не можем.
 */


namespace _60_AnonimType
{
    
    class User
    {
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var user = new { Name = "Tom", Age = 12 }; // Анонимный тип
            var student = new { Name = "Alice", Age = 19 };

            Console.WriteLine(user.GetType()); // И юсер и студент имеют одинаковый тип данных
            Console.WriteLine(student.GetType());

            User bob = new User { Name = "Bob" };
            int age = 34;
            var student1 = new { bob.Name, age }; //Иницилизация с проекцией, названия свойств и переменных (Name и age) будут использоваться в качесте названий свойств объекта
            Console.WriteLine(student1.Name + " " + student1.age);

            // Также можно определять массивы объектов анонимных типов
            var people = new[]
            {
                new {Name = "Tim"},
                new {Name = "bob"},
                new {Name = "Fil"}
            };

            foreach(var x in people)
            {
                Console.WriteLine(x.Name);
            }


        }
    }
}
