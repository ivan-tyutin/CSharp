using System;

/* 
 * Обобщения (generics)
 *
 */





namespace _40_Generics
{


    /*
     * Угловые скобки в описании class Account<T> указывают, что класс является обобщенным, а тип T, заключенный в угловые скобки, 
     * будет использоваться этим классом. Необязательно использовать именно букву T, это может быть и любая другая буква или набор символов. 
     * Причем сейчас нам неизвестно, что это будет за тип, это может быть любой тип. 
     * Поэтому параметр T в угловых скобках еще называется универсальным параметром, так как вместо него можно подставить любой тип.
     */

    class Account<T>
    {
        public static T session; // Для разных типов будет создан свой набор статических элементов.

        public T Id { get; set; }
        public int Sum { get; set; }

        public T Id2 { get; set; } = default(T); // Если необходимо присвоить значение по умолчанию, то используется такая конструкция. refType = null, ValType = 0;

    }

    class Transaction<U, V>
    {
        public U FromAccount { get; set; }
        public U ToAccount { get; set; }
        public V Code { get; set; }

        public int Sum { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Account<int> account1 = new Account<int> { Id = 1, Sum = 500 };
            Account<string> account2 = new Account<string> { Id = "3434", Sum = 5006 };

            int id1 = account1.Id;
            string id2 = account2.Id;

            Console.WriteLine(id1);
            Console.WriteLine(id2);

            Account<int> account3 = new Account<int> { Id = 3, Sum = 3255 };
            Transaction<Account<int>, string> transaction = new Transaction<Account<int>, string>
            {
                FromAccount = account1,
                ToAccount = account3,
                Code = "34839859",
                Sum = 300
            };

           
          

        }


        // Так же можно создавать обобщенные методы, которые точно также будут использовать унивирсальные параметры.
        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }





    

    
}
