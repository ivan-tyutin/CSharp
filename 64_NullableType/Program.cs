using System;

namespace _64_NullableType
{

    /*
     * Значение null по умолчанию могут принимать только объекты ссылочных типов. Однако в различных ситуациях бывает удобно, 
     * чтобы объекты числовых типов данных имели значение null, то есть были бы не определены.
     * 
     * Но фактически запись ? является упрощенной формой использования структуры System.Nullable<T>.
     * 
     * Для всех типов Nullable определено два свойства: Value, 
     * которое представляет значение объекта, и HasValue, которое возвращает true, если объект Nullable хранит некоторое значение.
     * 
     * Также структура Nullable с помощью метода GetValueOrDefault() позволяет использовать значение по умолчанию (для числовых типов это 0)
     * 
     */

    class Program
    {
        static void Main(string[] args)
        {
            int? z = null;
            bool? enable = null;
            double? d1 = 3.3;

            Nullable<int> z2 = null;
            Nullable<bool> enable2 = null;
            Nullable<double> d2 = null;

            int? x = 7;
            Console.WriteLine(x.Value);
            State state = new State() { Name = "Narnia" };
            Console.WriteLine(state.Name);

            Console.WriteLine(d1.GetValueOrDefault());
            Console.WriteLine(d2.GetValueOrDefault());

            if(z.HasValue)
            {
                Console.WriteLine(z.Value); // Получим ошибку.
            }
            else
            {
                Console.WriteLine(z.GetValueOrDefault());
            }


            

            Console.ReadLine();

        }


        class State
        {
            public string Name { get; set; }
        }
    }
}
