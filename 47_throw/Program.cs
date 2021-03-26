using System;

namespace _47_throw
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter a line: ");
                    string line = Console.ReadLine();
                    if (line.Length > 6)
                    {
                        throw new Exception("The length of string is longer than 6 symbols");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    throw; // В подобном виде оператор throw может использоваться только в блоке catch
                    // В данном случае при вводе строки с длиной больше 6 символов возникнет исключение, которое будет обработано внутренним блоком catch. 
                    // Однако поскольку в этом блоке используется оператор throw, то исключение будет передано дальше внешнему блоку catch
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
            Console.ReadLine();
           
        }
    }
}
