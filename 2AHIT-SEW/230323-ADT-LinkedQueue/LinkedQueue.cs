using System;
using System.Collections.Generic;
using System.Text;

namespace _230323_ADT_LinkedQueue
{
    class LinkedQueue<T>
    {
        class Node
        {
            public T Item;
            public Node Next;
            public Node(T item) { this.Item = item; }
        }

        private Node head;
        private Node tail;

        private long count;

        public void Enqueue(T item)
        {
            if (this.head != null)
            {
                this.tail.Next = new Node(item);
                this.tail = this.tail.Next;
            }
            else
            {
                this.head = new Node(item);
                this.tail = this.head;
            }
            this.count++;
        }

        public T Dequeue()
        {
            if (this.head == null)
            {
                throw new InvalidOperationException("Queue empty!");
            }
            
            T item = this.head.Item;
            this.head = this.head.Next;

            if (this.head == null)
            {
                this.tail = null;
            }
            this.count--;
            
            return item;
        }
    }
}
