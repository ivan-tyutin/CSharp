using System;

namespace _76_changeString
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameConcat = string.Concat("My ", "name ", "is ", "John");
            Console.WriteLine(nameConcat);

            nameConcat = string.Join(" ", "My", "name", "is", "John");
            Console.WriteLine(nameConcat);

            nameConcat = nameConcat.Insert(0, "By the way, "); 
            Console.WriteLine(nameConcat);

            nameConcat = nameConcat.Remove(0, 1);
            Console.WriteLine(nameConcat);

            string replaced = nameConcat.Replace('n', 'z');
            Console.WriteLine(replaced);

            string data = "12; 32; 34; 235; 132";
            string[] arrayString = data.Split(';');
            foreach(string str in arrayString)
            {
                int i;
                if(int.TryParse(str, out i))
                    Console.Write(i + " ");
            }
            Console.WriteLine();

            char[] chars = nameConcat.ToCharArray();

            string john = "  My name is John ";
            john = john.Trim();
            Console.WriteLine(john);


        }


        static void Foo(string name = "NoName", int age = 15)
        {
            Console.WriteLine($"{name} {age}");
        }
    }
}
