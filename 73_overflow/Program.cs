using System;

namespace _73_overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            // Такая конструкция проверяет значения на переполнения
            // Блок checked замедляет выполнение программы
            checked
            {
                int x = int.MaxValue;


                Console.WriteLine(x + 1);
            }
        }
    }
}
