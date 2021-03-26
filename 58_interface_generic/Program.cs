using System;

namespace _58_interface_generic
{
    /*
     * Интерфейсы в обобщениях
     * 
     */



    interface IClientAccount : IClient, IAccount
    {

    }

    class ClientAccount : IClientAccount
    {
        private int _sum;
        public ClientAccount(string name, int sum)
        {
            Name = name;
            _sum = sum;
        }
        public string Name { get; set; }
        public int CurrentSum
        {
            get { return _sum; }
        }
        public void Put(int sum)
        {
            _sum += sum;
        }

        public void Withdraw(int sum)
        {
            if (_sum >= sum)
            {
                _sum -= sum;
            }
        }
    }

    interface IAccount
    {
        int CurrentSum { get; }
        void Put(int sum);
        void Withdraw(int sum);
    }

    interface IClient
    {
        string Name { get; set; }
    }

    class Client : IAccount, IClient
    {
        private int _sum;
        public Client(string name, int sum)
        {
            Name = name;
            _sum = sum;
        }
        public string Name { get; set; }
        public int CurrentSum
        {
            get { return _sum; }
        }
        public void Put(int sum)
        {
            _sum += sum;
        }

        public void Withdraw(int sum)
        {
            if (_sum >= sum)
            {
                _sum -= sum;
            }
        }

    }

    /*
     * Используем выше перечисленные интерфейсы в качестве ограничений обобщенного класса
     * 
     * В данном случае параметр T представляет тип, который который реализует сразу два интерфейса IAccount и IClient. 
     * Например, выше определен класс Client, который реализует оба интерфейса, поэтому мы можем данным типом типизировать объекты Transaction
     * 
     */

    class Transaction<T> where T: IAccount, IClient
    {
        public void Operate(T acc1, T acc2, int sum) 
        {
            acc1.Withdraw(sum);
            acc2.Put(sum);
            Console.WriteLine($"{acc1.Name} : {acc1.CurrentSum}\n{acc2.Name} : {acc2.CurrentSum}");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Client tom = new Client("Tom", 200);
            Client bob = new Client("Bob", 300);
            Transaction<Client> transaction = new Transaction<Client>();
            transaction.Operate(tom, bob, 50);

            // Также параметр T может представлять интерфейс, который наследуется от обоих интерфейсов

            ClientAccount tim = new ClientAccount("Tim", 100);
            ClientAccount jon = new ClientAccount("Jon", 200);
            Transaction<ClientAccount> transaction1 = new Transaction<ClientAccount>();
            transaction1.Operate(tim, jon, 30);
        }
    }
}
