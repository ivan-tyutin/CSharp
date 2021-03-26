using System;

namespace _63_Switch
{



    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = Select(1, 4, 10);
                Console.WriteLine(x);

                x = Select(12, 4, 10);
                Console.WriteLine(x);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static int Select(int op, int a, int b) => op switch 
        {
            1 => a + b,
            2 => a - b,
            3 => a * b,
            _ => throw new ArgumentException("Unacceptable oparation code")
        };
            
      

    }

    

    internal static class MyClass
    {

    }
}
