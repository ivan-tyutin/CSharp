using System;

namespace _59_interface_generic
{

    /*
     * Как и классы, интерфейсы могут быть обобщенными
     * 
     * 
     */


    interface IUser<T>
    {
        T Id { get; }
    }

    class User<T> : IUser<T>
    {
        T _id;

        public User(T id)
        {
            _id = id;
        }
        public T Id { get { return _id; } }
    }

    class Program
    {
        


        static void Main(string[] args)
        {
            IUser<int> user1 = new User<int>(5452);
            Console.WriteLine($"{user1.Id}");

            IUser<string> user2 = new User<string>("12435");
            Console.WriteLine(user2.Id);
        }

        
    }
}
