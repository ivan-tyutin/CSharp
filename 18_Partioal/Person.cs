using System;
using System.Collections.Generic;
using System.Text;

//hello
namespace _18_Partioal
{
     partial class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }




    }
}
