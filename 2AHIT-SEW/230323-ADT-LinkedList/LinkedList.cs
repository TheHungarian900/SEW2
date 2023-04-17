using System;
using System.Collections.Generic;
using System.Text;

namespace _230323_ADT_LinkedList
{
    class LinkedList<T>
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
        public long Count { get { return this.count; } }

        private Node currentNode;
        private Node CurrentNode { get { return currentNode; } set { currentNode = value; } }

        private Node first;
        private Node First { get { return first; } set { first = value; } }

        private Node last;
        private Node Last { get { return last; } set { last = value; } }

        public T CurrentItem
        {
            get { if (this.currentNode == null) return default;
                else return this.currentNode.Item;
            }
            set { currentNode.Item = value; }
        }

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

        public void Clear()
        {
            while(this.head.Next != null)
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
            }
        }

        public T Peek()
        {
            if (this.IsEmpty())
            {
                throw new Exception("StackEmpty");
            }
            else
            {
                return this.head.Item;
            }
        }

        public bool MoveNext()
        {
            if (this.currentNode == null || this.currentNode.Next == null) { return false; }
            else { this.currentNode = this.currentNode.Next; return true; }
        }

        public bool MoveLast()
        {
            if (this.Last == null) { return false; }
            else { this.currentNode = this.last; return true; }
        }

        public bool MoveFirst()
        {
            if (this.First == null) { return false; }
            else { this.currentNode = this.first; return true; }
        }

        public bool IsEmpty()
        {
            return head == null;
        }
    }
}
