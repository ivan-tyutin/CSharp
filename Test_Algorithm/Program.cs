using System;


namespace Test_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "hello world!";

            
            Console.WriteLine(FindSubstring(testString, "wor"));
           // Console.ReadLine();


            Console.WriteLine(ToUpperSpecifiedLetter("helllo wordl! how are you?"));

            Console.WriteLine(DeleteAllSpaces("   HHH   Hldfj  asdfa asdf     asdfjlkj a   fe a df  fdaf    aklsdjf   "));



        }




        public static int FindSubstring(string str, string findValue)
        {
            

            return str.IndexOf(findValue, 0, str.Length);

        }

        public static string ToUpperSpecifiedLetter(string str)
        {
            var tmp = str.ToCharArray();

            bool flag = true;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(tmp[i]))
                {
                    tmp[i] = flag ? char.ToUpper(tmp[i]) : char.ToLower(tmp[i]);
                    flag = false;
                }
                else
                {
                    flag = true;
                }

               
            }

            return new string(tmp);
        }


        public static string DeleteAllSpaces(string str)
        {
            var strRet = new System.Text.StringBuilder();

            bool flag = false;
            for(int i = 0; i < str.Length; i++)
            {
                if (!char.IsWhiteSpace(str[i]))
                {
                    strRet.Append(str[i]);
                    flag = true;
                }
                else if (flag) 
                {
                    strRet.Append(' ');
                    flag = false;
                }
            }


            return strRet.ToString(); 
        }
    }
}
