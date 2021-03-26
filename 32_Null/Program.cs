using System;

namespace _32_Null
{
    class Program
    {
        static void Main(string[] args)
        {
            object o = null;
            string s = null;

            object x = null;
            object y = x ?? 100; // Оператор null-объединения


            object z = 200;
            object t = z ?? 100;


            User user = new User();
            string name = user.Phone.Company.Name;
            user.Phone = new Phone { Company = new Company { Name = "Yandex" } };

            string companyName = user?.Phone?.Company?.Name ?? "Unknown name of company";

            Console.WriteLine(companyName);




        }


        class User
        {
            public Phone Phone { get; set; }
        }

        class Phone
        {
            public Company Company { get; set; }
        }

        class Company
        {
            public string Name { get; set; }
        }
    }
}
