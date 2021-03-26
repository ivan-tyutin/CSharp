using System;

namespace _40_Generics_homework
{

    class Instantiator<T>
    {
        public T instance;

        public Instantiator()
        {
            instance = default(T);
        }

       
    }

    class Collection<T>
    {
        private T[] collection;


        public Collection(params T[] arr)
        {
            collection = arr;
        }


        public T this[int index]
        {
            get 
            {
                return collection[index];
            }
        }

        public void AddFront(T x)
        {
            T[] temp = new T[collection.Length + 1];
            temp[0] = x;
            Array.Copy(collection, 0, temp, 1, collection.Length);
            collection = temp;
        }

        public void AddBack(T x)
        {
            T[] temp = new T[collection.Length + 1];
            Array.Copy(collection, temp, collection.Length);
            temp[collection.Length] = x;
            collection = temp;
        }

        public T[] ToArray()
        {
            T[] retCol = new T[collection.Length];
            Array.Copy(collection, retCol, retCol.Length);

            return retCol;
        }


        public int GetLength()
        {
            return collection.Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Collection<int> arr = new Collection<int>(1, 2, 3 ,4 ,5);
            arr.AddFront(3);
            arr.AddFront(5);
            arr.AddBack(23);

            int[] arr1 = arr.ToArray();

            foreach(int x in arr1)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

           

        }


    }

    
}
