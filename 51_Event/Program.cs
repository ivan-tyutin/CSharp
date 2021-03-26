using System;

namespace _51_Event
{

    class Account
    {

        /* События объявляются в классе с помощью ключевого слова event, после которого указывается тип делегата, который представляет событие */


        public delegate void AccountHandler(string massage);
        private event AccountHandler notify;
        public event AccountHandler Notify
        {
            add
            {
                notify += value;
                Console.WriteLine($"{value.Method.Name} added");
            }
            remove
            {
                notify -= value;
                Console.WriteLine($"{value.Method.Name} removed");
            }
        }


        public int Sum { get; private set; }
        public Account(int sum)
        {
            Sum = sum;
        }

        public void Put(int sum)
        {
            Sum += sum;
            notify?.Invoke($"Income: Sum is {Sum}"); ;
        }

        public void Take(int sum)
        {
            if(Sum >= sum)
            {
                Sum -= sum;
                notify?.Invoke($"Outcome: Sum is {Sum}");
            }
            else
            {
                notify?.Invoke($"There is not enough money at the account: Sum is {Sum}");
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Account acc = new Account(100);
            acc.Notify += DisplayMessage;
            acc.Notify += DisplayRedMessage;
            acc.Put(20);
            acc.Take(70);
            acc.Notify -= DisplayRedMessage;
            acc.Take(150);
            acc.Notify -= DisplayMessage;

            acc.Notify += delegate (string str)
            {
                Console.WriteLine(str);
            };
            acc.Put(124);
            acc.Put(50);

            acc.Notify += mes => Console.WriteLine("Lambda - " + mes);
            acc.Put(124);
            acc.Put(50);

            Console.ReadKey();



        }

        public static void DisplayMessage(string str)
        {
            Console.WriteLine(str);
        }

        public static void DisplayRedMessage(string str)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(str);
            Console.ResetColor();
        }
    }

    
}
