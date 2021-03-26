using System;

namespace _44_catchDefinition
{




    class Program
    {
        static void Main(string[] args)
        {

            int x = 4;
            int y = 0;

            try
            {
                
                int z = x / y;


            }
            /* 
             * Фильтры исключений позволяют обрабатывать исключения в зависимости от определенных условий. 
             * Для их применения после выражения catch идет выражение when, после которого в скобках указывается условие
             */
            catch (DivideByZeroException) when (x == 0 && y == 0)
            {
                Console.WriteLine("y must not be 0 ");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
