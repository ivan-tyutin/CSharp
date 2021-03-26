using System;

namespace _42_InheritanceGenerics
{

    /* 
     * Cтоит учитывать, что если на уровне базового класса для универсального параметра установлено ограничение, 
     * то подобное ограничение должно быть определено и в производных классах, которые также используют этот параметр 
     */


    class NewAccount<T> where T : struct
    {
        public T Id { get; set; }
        public NewAccount(T _id)
        {
            Id = _id;
        }
    }

    class NewTransaction<T> : NewAccount<int> 
        where T : class
    {
        public T transaction;
        public NewTransaction(int _id) : base(_id)
        {

        }
    }


    class Account<T>
    {
        public T Id { get; set; }
        public Account(T id)
        {
            Id = id;
        }
    }

    class UniversalAccount<T> : Account<T>
    {
        public UniversalAccount(T id) 
            : base(id)
        {

        }
    }

    class StringAccount : Account<string>
    {
        public StringAccount(string str)
            : base(str)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }


        public static void Foo<K, T>(K value, T value1)
            where K : struct
            where T : new()
        {
            Console.WriteLine(value);
        }
    }
}
