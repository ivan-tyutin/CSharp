using System;

namespace ConsolInpuOutput
{
    class Program
    {

        static int NOD(int FirstValue, int SecondValue)
        {
            while (FirstValue != SecondValue)
            {
                if (FirstValue > SecondValue) 
                    FirstValue -= SecondValue;
                else 
                    SecondValue -= FirstValue;
            }

            return FirstValue;
        }

        static void Main(string[] args)
        {

            string hello = "hello world!";
            Console.WriteLine(hello);

            Console.WriteLine("Добро пожаловать в С#");

            Console.WriteLine(24.5);


            string name = "Ivan";
            int age = 25;
            int height = 171;
            
            // Такая операция называется интерполяцией
            Console.WriteLine($"Name: {name}, Age: {age}, Height: {height}");

            
            try
            {
                Console.WriteLine("Name: {0}, Age: {1}, Height: {3}", name, age, height);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            // Еще один способ выводить на консоль сразу несколько имен

            //***************************** Консольный ввод ***************************************

            Console.WriteLine("Enter a name: ");
            string MyName = Console.ReadLine();

            Console.WriteLine($"Name: {MyName}");



            Console.WriteLine("Enter a Name: ");
            string name1 = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            int age1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your height: ");
            double height1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the salary: ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine($"Name: {name1}, Age: {age1}, Height: {height1}, Salary: {salary}");

            int a, b;
            Console.WriteLine("Enter two values: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine($"nod: {NOD(a, b)}");




            Console.ReadLine();



        }
    }
}
