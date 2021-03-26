using System;

namespace _77_FormatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            int age = 30;
            string str1 = string.Format($"My name is {name} and I,m {age}");
            Console.WriteLine(str1);

            str1 = String.Format("My name is {0} and I,m {1}", name, age);
            Console.WriteLine(str1);

           
            string str2 = $"My name is {name} and I'm {age}"; // Интарполирование строк
            Console.WriteLine(str2);


            string str3 = "My name is\nJohn"; // Перевод на новую строку
            string str4 = $"My name is {Environment.NewLine} John"; // В разных ОС \t работает по разному, а такая запись позволяет унифицировать ее исполнение для всех OC;

            string str6 = "C:\\tmp\\test_text.txt";
            Console.WriteLine(str6);

            string str7 = @"C:\tmp\test_text.txt";
            Console.WriteLine(str7);



            int answer = 42;
            string result1 = string.Format("{0:d}", answer);
            Console.WriteLine(result1); 

            string result2 = string.Format("{0:d4}", answer); // Число после d означает количество символов
            Console.WriteLine(result2);


            double answer1 = 43.236;
            result1 = string.Format("{0:f}", answer1);
            Console.WriteLine(result1);

            result2 = string.Format("{0:f4}", answer1); // Выведится с округлением 
            Console.WriteLine(result2);

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            result1 = string.Format("{0:C}", answer1);
            Console.WriteLine(result1);

            result2 = string.Format("{0:C4}", answer1);
            Console.WriteLine(result2);

            Console.WriteLine(answer1.ToString("C2"));

            var result = $"{answer1:C2}";
            Console.WriteLine(result);


        }
    }
}
