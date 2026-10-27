using System;

namespace DSA.Lab02
{
    public sealed class ArrayStack<T>
    {
        private readonly T[] _items;
        private int _count;

        public ArrayStack(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(capacity));
            }

            _items = new T[capacity];
        }

        public int Count => _count;
        public int Capacity => _items.Length;

        public void Push(T item)
        {
            // TODO: place the item at the logical top and update the state.
            
            // If the the stack is full, returns this message
            if (_count >= _items.Length)
            {
                throw new InvalidOperationException("The stack is full.");
            }
            _items[_count] = item;
            _count++;
        }

        public T Peek()
        {
            // If the the stack is empty, returns this message
            if (_count <= 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }

            return _items[_count - 1];
        }

        public T Pop()
        {
            // If the the stack is empty, returns this message
            if (_count <= 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }

            _count--;

            // Since we don't know the type, we write T to signal it's generic
            T item = _items[_count];
            _items[_count] = default!;

            return item;
        }
    }
}
