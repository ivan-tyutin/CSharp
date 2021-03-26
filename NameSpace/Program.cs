using System;
using static System.Math;
using static NameSpace.Geomety;
using NameSpace.AccountSpace; // для использования класса Account
using printer = System.Console; // Псевдоним
using Person = NameSpace.User;

/* 
 * Выражение using static подключает все статические методы и свойства, а также константы 
 * и после этого можно не указывать название класса при вызове метода 
 */

namespace NameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountSpace.Account account = new AccountSpace.Account(3);
            Account account2 = new Account(4);

            printer.WriteLine("hello world!"); // Теперь мы можем использовать данный псевдоним за место Console

            Person person = new Person();

            printer.WriteLine(GetArea(23.5));



        }
    }

    class Geomety
    {
        public static double GetArea(double radius)
        {
            return PI * radius * radius;
        }
    }


    class User
    {
        public string name;
    }


    namespace AccountSpace
    {
        class Account
        {
            public int Id { get; private set; }
            public Account(int _id)
            {
                Id = _id;
            }
        }
    }
}
