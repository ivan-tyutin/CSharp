using System;

namespace _82_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var ms = new MyStack<int>();
            ms.Push(1);
            ms.Push(2);
            ms.Push(3);

            // Console.WriteLine(ms.Peek());

            //Console.WriteLine($"Pop() {ms.Pop()}");
            //Console.WriteLine($"Pop() {ms.Pop()}");

            // Console.WriteLine(ms.Peek());

            ms.Push(3);
            ms.Push(4);
            ms.Push(5);

            //Console.WriteLine(ms.Peek());
            Console.WriteLine($"Capacity {ms.Capacity}");
            Console.WriteLine($"Count {ms.Count}");

            Console.WriteLine();
            foreach(var x in ms)
            {
                Console.Write(x + " ");
            }


            Console.ReadLine();

        }
    }
}
