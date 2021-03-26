using System;

namespace _33_Index
{

    class Person
    {
        public string Name { get; set; }
    }


    class People
    {
        Person[] data;
        public int Index { get; }
        public People(int index)
        {
            this.Index = index;
            data = new Person[this.Index];
        }


        public Person this[int index]
        {
            get
            {
                return data[index];
            }

            set
            {
                data[index] = value;
            }
        }
    }



    class User
    {
        string name;
        string email;
        string phone;


        public void Print()
        {
            Console.WriteLine($"Name: {name}, Email: {email}, Phone: {phone}");
        }

        public string this[string propName]
        {
            get
            {
                switch(propName)
                {
                    case "name": return name;
                    case "email": return email;
                    case "phone": return phone;
                    default: return null;
                }
            }

            set
            {
                switch (propName)
                {
                    case "name": name = value ;
                        break;
                    case "email": email = value;
                        break;
                    case "phone": phone = value;
                        break;
                    
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            People crowd = new People(5);
            crowd[0] = new Person { Name = "Tom" };
            crowd[1] = new Person { Name = "Bob" };
            crowd[2] = new Person { Name = "Tim" };

            Person tom = crowd[0];
            Console.WriteLine(tom?.Name);

            User sven = new User();
            sven["name"] = "sven";
            sven["email"] = "sven@gmail.com";
            sven["phone"] = "+7923 353 11 33";

            sven.Print();
        }
    }
}
