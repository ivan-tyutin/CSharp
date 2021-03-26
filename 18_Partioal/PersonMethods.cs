using System;
using System.Collections.Generic;
using System.Text;


namespace _18_Partioal
{
    partial class Person
    {
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine(GetFullName());
        }
    }
}
