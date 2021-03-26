using System;

namespace _45_classException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                object obj = "you";
                int num = (int)obj; // InvalidCastException
                Console.WriteLine($"Result: {num}");

                int[] number = new int[4];
                number[7] = 9; // IndexOutOfRangeException


                int x = 5;
                int y = 0;
                int z = x / y; // DivideByZeroExcetion

               
            }
            /*catch(InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }*/
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            /*
             * Однако так как тип Exception является базовым типом для всех исключений, 
             * то выражение catch (Exception ex) будет обрабатывать все исключения, которые могут возникнуть
             */
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}"); //  хранит сообщение об исключении, текст ошибки
                Console.WriteLine($"Method: {ex.TargetSite}"); // возвращает метод, в котором и было вызвано исключение
                Console.WriteLine($"Stack Tracer: {ex.StackTrace}"); // возвращает строковое представление стека вызывов, которые привели к возникновению исключения
            }

            Console.ReadKey();
        }
    }
}
