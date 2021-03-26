using System;

namespace _43_tryCatch
{
    class Program
    {

        /* 
         * В данной кострукции обязателен блок try. При наличии блока catch мы можем опустить блок finally, 
         * и наоборот, при наличии finally мы можем опустить блок catch. Однако хотя с точки зрения синтаксиса последняя кострукция и коррктна
         * тем не менее, поскольку CLR не сможет найти нужный блок catch, то исключение не будет обработано, и программа аварийно завершится
         * 
         */
        static void Main(string[] args)
        {

            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Result: {y}");
            }
            catch
            {
                Console.WriteLine("An exception was thrown");
            }
            finally
            {
                Console.WriteLine("Block finally was called");
            }
            
            Console.WriteLine("The end of the program");
            Console.Read();


            Console.WriteLine("Enter a namber: ");
            int yy;
            while(!Int32.TryParse(Console.ReadLine(),out yy))
            {
                Console.WriteLine("Wrong type of data");
            }
            
            Console.WriteLine(yy);


            int xx = Int32.Parse(Console.ReadLine());


        }
    }
}
