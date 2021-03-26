using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _82_Stack
{
    public class MyStack<T> : IEnumerable<T>
    {
        private T[] _items;

        public int Count { get; private set; }

        public int Capacity
        {
            get
            {
                return _items.Length;
            }
        }

        public MyStack()
        {
            const int defaultCapacity = 4;
            _items = new T[defaultCapacity];
        }

        public MyStack(int capacity)
        {
            _items = new T[capacity];
        }

        public void Push(T item)
        {
            if (_items.Length == Count)
            {
                T[] largerArray = new T[Count * 2];
                Array.Copy(_items, largerArray, Count);
                _items = largerArray;
            }
            _items[Count++] = item;
        }

        public object Pop()
        {
            if(Count == 0)
            {
                throw new InvalidOperationException();
            }

            object returnItem = _items[--Count];
            _items[Count] = default;

            return returnItem;
        }

        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            return _items[Count - 1];
        }

        /*public IEnumerator<T> GetEnumerator()
        {
            return new StackEnumerator<T>(_items, Count);
        }*/

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                yield return _items[i]; // То же самое что и сверху написано 
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public class StackEnumerator<T> : IEnumerator<T>
        {

            private readonly T[] array;

            private readonly int count;
            
            private int position;

            public StackEnumerator(T[] array, int count)
            {
                this.array = array;
                position = count;
                this.count = count;
                
            }

            public T Current => array[position];

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                position--;
                return position > -1;
            }

            public void Reset()
            {
                position = count;
            }
        }
    }
}
