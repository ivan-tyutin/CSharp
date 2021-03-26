using System;
using System.Collections.Generic;
using System.Text;
using ExstensionMethods2;

namespace Exstension
{
    static class MyExtension
    {
        public static string GetFullName(this Student student)
        {
            return student.FirstName + " " + student.LastName;
        }


    }
}
