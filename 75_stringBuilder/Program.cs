using System;
using System.Text;

namespace _75_stringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            // При складывание большого количества строк StringBuilder работает значительно быстрее чем все другие способы.
            StringBuilder sb = new StringBuilder();
            sb.Append("My ");
            sb.Append("name ");
            sb.Append("is ");
            sb.Append("John");
            sb.AppendLine("!"); // Переводит каретку на новую строку
            sb.AppendLine("New line");

            
            string str = sb.ToString();
            Console.WriteLine(str);
            
        }
    }
}
