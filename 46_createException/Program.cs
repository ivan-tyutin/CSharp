using System;

namespace _46_createException
{



    class Person
    {
        private int age;
        public string Name { get; set; }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 18)
                {
                    throw new PersonException("Лицам до 18 лет регистарция запрещена.", value);
                }
                else
                {
                    age = value;
                }
            }
        }
    }

    class PersonException : Exception
    {

        public int Value { get; }
        public PersonException(string msg, int value) 
            : base(msg) 
        {
            Value = value;
        }
    }

    class Program
    {



        static void Main(string[] args)
        {
           
            try
            {
                Person p = new Person { Name = "Tom", Age = 17 };
            }
            catch (PersonException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"Incorrect value: {ex.Value}");
            }
            Console.ReadKey();
        }
    }

    
}
