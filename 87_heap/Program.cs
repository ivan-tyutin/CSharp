using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _87_heap
{
    class Program
    {
        static void Main(string[] args)
        {
            MaxHeap<int> heap = new MaxHeap<int>(4);
            heap.Insert(1);
            heap.Insert(2);
            heap.Insert(3);
            heap.Insert(4);
            heap.Insert(5);
            heap.Insert(6);

            foreach(int x in heap.Values())
            {
                Console.Write(x + " ");
            }

            Console.WriteLine();

            MaxHeap<double> heapD = new MaxHeap<double>(4);
            heapD.Insert(1.3);
            heapD.Insert(2.21);
            heapD.Insert(3);
            heapD.Insert(4);
            heapD.Insert(5);
            heapD.Insert(6);

            List<double> list = heapD.Values().ToList();


            foreach (var x in list)
            {
                Console.Write(x + " ");
            }

            

        }
       
        


    }

    public class MaxHeap<T> where T : IComparable<T>
    {
        private const int DefaultCapacity = 4;
        private T[] _heap;

        public int Count { get; private set; }

        public bool IsFull => Count == _heap.Length;
        public bool IsEmpty => Count == 0;

        public void Insert(T value)
        {
            if (IsFull)
            {
                var newHeap = new T[_heap.Length * 2];
                Array.Copy(_heap, newHeap, _heap.Length);
                _heap = newHeap;
            }
            _heap[Count] = value;

            Swim(Count);

            Count++;
        }

        private void Swim(int indexOfSwimmingItem)
        {
            T newValue = _heap[indexOfSwimmingItem];
            while (indexOfSwimmingItem > 0 && IsParentLess())
            {
                _heap[indexOfSwimmingItem] = GetParent(indexOfSwimmingItem);
                indexOfSwimmingItem = ParentIndex(indexOfSwimmingItem);
            }
            _heap[indexOfSwimmingItem] = newValue;

            bool IsParentLess()
            {
                return newValue.CompareTo(GetParent(indexOfSwimmingItem)) > 0;
            }
        }

        private void Sink(int indexOfSinkingItem)
        {
            /*int lastHeapIndex = Count - 1;
            while (indexOfSinkingItem <= lastHeapIndex)
            {
                int leftChildIndex = LeftChildIndex(indexOfSinkingItem);
                int rightChildIndex = RightChildIndex(indexOfSinkingItem);

                if (leftChildIndex > lastHeapIndex)
                {
                    break;
                }

                int childIndexToSwap = GetChildIndexToSwap(leftChildIndex, rightChildIndex);

                if (S)
            }*/
        }

        private int LeftChildIndex(int index)
        {
            return index * 2 + 1;
        }

        private int RightChildIndex(int index)
        {
            return index * 2 + 2;
        }

        /*public IEnumerator GetEnumerator()
        {
            return _heap.GetEnumerator();
        }*/


        public IEnumerable<T> Values()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return _heap[i];
            }
        }

        private T GetParent(int index)
        {
            return _heap[ParentIndex(index)];
        }

        private int ParentIndex(int index)
        {
            return (index - 1) / 2;
        }


        public void Sort()
        {
            int lastHeapIndex = Count - 1;
            for (int i = 0; i < lastHeapIndex; i++)
            {
                Exchange(0, lastHeapIndex - i);

            }
        }

        private void Exchange(int leftIndex, int rightIndex)
        {
            T tmp = _heap[leftIndex];
            _heap[leftIndex] = _heap[rightIndex];
            _heap[rightIndex] = tmp;
        }

        public MaxHeap() : this(DefaultCapacity)
        {

        }
        public MaxHeap(int capacity)
        {
            _heap = new T[capacity];
        }
    }
}
