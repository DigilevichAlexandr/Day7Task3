using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Task3
{
    public class CustomQueue<T>
    {
        private readonly T[] _queue;
        int _length;
        public int Count { get { return _queue.Length; } }
        public CustomQueue(T[] arr)
        {
            _queue = arr;
            _length = arr.Length;
        }

        public void Enqueue(T element)
        {
            _queue[_length++] = element;
        }

        public T Denqueue()
        {
            if (_length > 0)
            {
                var result = _queue[0];
                for (int i = 0; i < _length; )
                    _queue[i] = _queue[++i];
                return result;
            }
            else
                return default(T);
        }

        public T Peek()
        {
            if (_length > 0)
            {
                return _queue[0];
            }
            else
                return default(T);
        }

        private T PeekInd(int ind)
        {
            return _queue[ind];
        }
        
        public CustomIterator Iterator()
        {
            return new CustomIterator(this);
        }

        public class CustomIterator
        {
            private readonly CustomQueue<T> collection;
            private int currentIndex;

            internal CustomIterator(CustomQueue<T> collection)
            {
                this.currentIndex = -1;
                this.collection = collection;
            }

            public T Current
            {
                get
                {
                    if (currentIndex == -1 || currentIndex == collection.Count)
                    {
                        throw new InvalidOperationException();
                    }
                    return collection.PeekInd(currentIndex);
                }
            }

            public void Reset()
            {
                currentIndex = -1;
            }

            public bool MoveNext()
            {
                return ++currentIndex < collection.Count;
            }
        }
    }
}
