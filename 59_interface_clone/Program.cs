using System;

namespace _59_interface_clone
{
    class Company
    {
        public string Name { get; set; }
    }
    class Person : ICloneable
    {

        public string Name { get; set; }
        public int Age { get; set; }

        public Company Work { get; set; }

        public object Clone()
        {
            Company company = new Company { Name = Work.Name };
            Person person = new Person
            {
                Age = this.Age,
                Name = this.Name,
                Work = company
            };
            return person;
        }
        
    }


    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "hello world!";
            string str2 = str1;

            Console.WriteLine(str1);
            

            Console.WriteLine(str2);
            Console.WriteLine(str1);

            Person person1 = new Person
            {
                Name = "Ivan",
                Age = 12,
                Work = new Company { Name = "Apple" }
            };

            Person person2 = (Person)person1.Clone();

            person1.Age = 2134;
            Console.WriteLine(person2.Age);
            Console.WriteLine(person1.Age);

        }
    }
}
