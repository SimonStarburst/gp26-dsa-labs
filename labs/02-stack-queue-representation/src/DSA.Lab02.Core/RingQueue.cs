using System;

namespace DSA.Lab02
{
    public sealed class RingQueue<T>
    {
        private readonly T[] _items;
        private int _head;  // Index of the next value to remove, first in line
        private int _tail;  // Index where the next value will be inserted, last in line
        private int _count; // Number of stored values

        public RingQueue(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(capacity));
            }

            _items = new T[capacity];
        }

        public int Count => _count;
        public int Capacity => _items.Length;

        public void Enqueue(T item)
        {
            // TODO: write at tail, advance tail with wrap-around, update count.
            
            // Sends error message if queue is full
            if (_count == _items.Length)
            {
                throw new InvalidOperationException("The queue is full.");
            }

            _items[_tail] = item;                   // Adds item at the index value of the int _tail
            _tail = (_tail + 1) % _items.Length;    // The int that is _tail, + 1, then the sum is divided by the length of the queue. The quotient is then applied as _tail
            _count++;                               // Count = Count + 1, to show how many items are in the queue & decide whether queue is full or not
        }

        public T Peek()
        {
            // If the the queue is empty, returns this message
            if (_count == 0)
            {
                throw new InvalidOperationException("The queue is empty.");
            }

            // Peeks on the one that has been waiting longest and returns what it is without removing it
            return _items[_head];
        }

        public T Dequeue()
        {
            // TODO: read/clear at head, advance head with wrap-around, update count.

            // If the the queue is empty, returns this message
            if (_count == 0)
            {
                throw new InvalidOperationException("The queue is empty.");
            }

            // Since we don't know the type, we write T to signal it's generic
            T item = _items[_head];
            _items[_head] = default!;
            _head = (_head + 1) % _items.Length;
            _count--;
            return item;
        }
    }
}
