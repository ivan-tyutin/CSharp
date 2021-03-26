using System;
using System.Text;


namespace Algorithm
{
    class Program
    {

        static string toupper(string str)
        {
            var temp = new char[str.Length];
            
            for (int i = 0, j = 1; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    temp[i] = j % 3 == 0 ? char.ToUpper(str[i]) : char.ToLower(str[i]);
                    j++;
                }
                else
                {
                    temp[i] = str[i];
                }
            }
            return new string(temp);
        }


        static string MyFoo(string str)
        {
            /*if (str.Length == 0)
            {
                Console.WriteLine("return str");
                return str;
            }*/
                


            var temp = str.ToCharArray();

            for (int i = 0; i < str.Length-1; i++)
            {
                if (!char.IsLetter(temp[i]) && char.IsLetter(temp[i])) 
                {
                    temp[i] = char.ToUpper(temp[i]);
                }
            }
            return new string(temp);
        }

        static void Main(string[] args)
        {

            string str = "  hello world! how are you?";
            Console.WriteLine(str);

            str = toupper(str);
            Console.WriteLine(str);

            Console.ReadKey();

            string str2 = "  hello world! how are you?";

            Console.WriteLine(MyFoo(str2));


            string str3 = "";
            Console.WriteLine(MyFoo(str3));

            StringBilder

        }
    }
}
