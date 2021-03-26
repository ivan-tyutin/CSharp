using System;
using System.Linq;

namespace _41_LimitGenerics
{

    /* Ограничение обобщений */


    class Account<T>
    {
        public T Id { get; private set; } // Номер счета

        public int Sum { get; set; }

        public Account (T _id)
        {
            Id = _id;
        }
    }

    /*
     * С помощью выражения where T : Account мы указываем, что используемый тип T обязательно должен быть классом Account или его наследником. 
     * Благодаря подобному ограничению мы можем использовать внутри класса Transaction все объекты типа T именно 
     * как объекты Account и соответственно обращаться к их свойствам и методам.
     * 
     * Следует учитывать, что только один класс может использоваться в качестве ограничения.
     * 
     * В качестве ограничения также может выступать и обобщенный класс
     * 
     */


    //В данном случае класс Transaction типизирован классом Account<int>. Класс Account 
    //же может быть типизирован абсолютно любым типом. Однако класс Transaction может использовать только объекты класса Account<int> или его наследников.
    class Transaction<T> where T : Account<int>
    {
        public T FromAccount { get; set; }
        public T ToAccount { get; set; }

        public int Sum { get; set; }

        public void Execute()
        {
            if (FromAccount.Sum > Sum)
            {
                FromAccount.Sum -= Sum;
                ToAccount.Sum += Sum;
                Console.WriteLine($"Account {FromAccount.Id} : {FromAccount.Sum} \nAccount {ToAccount.Id} : {ToAccount.Sum}");
            }
            else
            {
                Console.WriteLine($"There is not enough money on account {FromAccount.Id}"); 
            }
        }
    }





    class Program
    {
        // Так же можно использовать ограничения методов
        public static void Transact<T>(T acc1, T acc2, int sum) where T : Account<int>
        {
            if(acc1.Sum > sum)
            {
                acc1.Sum -= sum;
                acc2.Sum += sum;
            }
            Console.WriteLine($"acc1: {acc1.Sum}  acc2: {acc2.Sum}");
        }

        static void Main(string[] args)
        {
            Account<int> acc1 = new Account<int>(1834) { Sum = 4500 };
            Account<int> acc2 = new Account<int>(4244) { Sum = 5000 };
            Transaction<Account<int>> transaction1 = new Transaction<Account<int>>()
            {
                FromAccount = acc1,
                ToAccount = acc2,
                Sum = 300
            };
            transaction1.Execute();

            int[] arr = { 11, 3, 5, 3, 1, 3, 6, 4, 2, 1, 34, 5, 1, };
            Array.Sort(arr);
            


            foreach(int x in arr.Distinct<int>().ToArray<int>())
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

            Console.ReadKey();

            Console.WriteLine(countingValleys(60, "UDDDUDUUDDDDUUUUUUDDDDDDDDUUUUUUUU"));

            Console.WriteLine(repeatedString("dbfd", 100));
        }



        static int sockMerchant(int n, int[] ar)
        {
            int retVal = 0;
            int count = 1;
            Array.Sort(ar);
            for (int i = 1; i < ar.Length; i++)
            {
                if (ar[i-1] == ar[i])
                {
                    count++;
                }
                else
                {
                    retVal += count / 2;
                    count = 1;
                }
                
            }
            retVal += count / 2;
            return retVal;
        }


        static int countingValleys(int step, string path)
        {
            int level = 0;
            int countVale = 0;
            foreach(char x in path)
            {
                switch(x)
                {
                    case 'U': level++; if (level == 0) countVale++; 
                        break;
                    case 'D': level--;
                        break;
                }
            }
            return countVale;
        }
        static long repeatedString(string s, long n)
        {
            if (s.Length == 1) return n;

            long counter = 1;
            char ch = s[0];
            for(int i = 1; i < s.Length; i++)
            {
                if (ch == s[i]) counter++;
            }

            if (n > s.Length) 
                counter *= n / s.Length;

            for (int i = 0; i < n % s.Length; i++)
            {
                if (ch == s[i]) counter++;
            }

            return counter;
        }
    }


   
}
