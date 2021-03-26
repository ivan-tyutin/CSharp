using System;

namespace _74_emptyString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = string.Empty; // Same as ""

            string empty = "";
            string whiteSpaced = " ";
            string notEmpty = " b";
            string nullString = null; // Сецальный летирал null

            Console.WriteLine("isNullOfEmpty");

            bool isNullorEmpty = string.IsNullOrEmpty(empty);
            Console.WriteLine(isNullorEmpty);

            isNullorEmpty = string.IsNullOrEmpty(whiteSpaced);
            Console.WriteLine(isNullorEmpty);

            isNullorEmpty = string.IsNullOrEmpty(notEmpty);
            Console.WriteLine(isNullorEmpty);

            isNullorEmpty = string.IsNullOrEmpty(nullString);
            Console.WriteLine(isNullorEmpty);


            Console.WriteLine();
            Console.WriteLine("isNullorWhiteSpace");

            isNullorEmpty = string.IsNullOrWhiteSpace(empty);
            Console.WriteLine(isNullorEmpty);

            isNullorEmpty = string.IsNullOrWhiteSpace(whiteSpaced);
            Console.WriteLine(isNullorEmpty);

            isNullorEmpty = string.IsNullOrWhiteSpace(notEmpty);
            Console.WriteLine(isNullorEmpty);

            isNullorEmpty = string.IsNullOrWhiteSpace(nullString);
            Console.WriteLine(isNullorEmpty);


            test testClass = new testChild();
           
        }


        interface ITest
        {
            string ReturnString(string retStr);
        }


        abstract class test : ITest
        {
            abstract public void Fooo();
            abstract public string ReturnString(string RetVal); // Можно не реализовывать метод сделав его базовым
            
        } 

        class testChild : test
        {
            public override void Fooo()
            {
                Console.WriteLine("Method Fooo, Class testChild");
            }

            public override string ReturnString(string retStr)
            {
                return retStr;
            }
        }
    }
}
