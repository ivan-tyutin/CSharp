using System;

namespace _62_Deconstructro
{
    /* 
     * Деконструкторы (не путать с деструкторами) позволяют выполнить декомпозицию объекта на отдельные части
     * 
     * При использовании деконструкторов следует учитывать, что метод Deconstruct должен принимать как минимум два выходных параметра
     */

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Deconstruct(out string name, out int age)
        {
            name = this.Name;
            age = this.Age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { Name = "Tim", Age = 25 };
            (string name, int age) = person;

            Console.WriteLine(name);
            Console.WriteLine(age);

        }
    }
}
