using System;

namespace _49_AnonymousMethod
{


    /* 
     * Анонимные методы 
     * 
     * 
     * Анонимный метод не может существовать сам по себе, он используется для инициализации экземпляра делегата, 
     * как в данном случае переменная handler представляет анонимный метод. И через эту переменную делегата можно вызвать данный анонимный метод.
     * 
     * 
     * Если анонимный метод использует параметры, то они должны соответствовать параметрам делегата. Если для анонимного метода не требуется параметров, 
     * то скобки с параметрами опускаются. При этом даже если делегат принимает несколько параметров, то в анонимном методе можно вовсе опустить параметры
     * 
     * 
     * То есть если анонимный метод содержит параметры, они обязательно должны соответствовать параметрам делегата. 
     * Либо анонимный метод вообще может не содержать никаких параметров, тогда он соответствует любому делегату, который имеет тот же тип возвращаемого значения.
     * 
     * При этом параметры анонимного метода не могут быть опущены, если один или несколько параметров определены с модификатором out.
     * 
     */


    class Program
    {

        delegate void MessageHandler(string message);
        delegate int Operation(int x, int y);

        static void Main(string[] args)
        {
            MessageHandler handler = delegate (string msg)
            {
                Console.WriteLine(msg);
            };
            handler("hello world");


            ShowMessage("hello world from ShowMessage()", delegate(string str)
            {
                Console.WriteLine(str);
            });

            ShowMessage("hello short", delegate
            {
                Console.WriteLine("no parameters");
            });

            int z = 34;
            Operation operation = delegate (int x, int y)
            {
                return x + y + z; // При этом анонимный метод имеет доступ ко всем переменным, определенным во внешнем коде
            };
            Console.WriteLine(operation(3, 4));



            Console.ReadKey();
        }


        static void ShowMessage(string str, MessageHandler handler)
        {
            handler(str);
        }

   
           

    }
}
