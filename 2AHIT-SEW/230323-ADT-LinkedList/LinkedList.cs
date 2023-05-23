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
                throw new InvalidOperationException("List empty!");
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
            while(this.head != null)
            {
                if (this.head == null)
                {
                    throw new InvalidOperationException("List empty!");
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

        public void Insert(T item)
        {
            Node temp = new Node(item);

            if(this.Count == 0)
            {
                this.head = temp;
                this.tail = temp;
                this.currentNode = temp;
            }
            else if(this.currentNode == this.tail)
            {
                this.tail = temp;
            }
            else
            {
                temp.Next = currentNode.Next;
                currentNode.Next = temp;
            }

            count++;
        }

        public T Remove()
        {
            Node p;
            T temp;

            p = this.head;

            if(this.Count == 0)
            {
                throw new InvalidOperationException("List empty!");

                if(this.CurrentNode == null)
                {
                    this.CurrentItem = default(T);
                }
                else
                {
                    this.CurrentItem = this.CurrentNode.Item;
                }
            }
            else if(this.CurrentNode == this.head)
            {
                T item = this.head.Item;
                this.head = this.head.Next;

                if (this.head == null)
                {
                    this.tail = null;
                }
                this.count--;

                return item;
            }
            else if(this.CurrentNode == this.tail)
            {
                do
                {
                    p = p.Next;

                } while (p.Next != this.CurrentNode);

                temp = this.CurrentNode.Item;
                p.Next = this.CurrentNode.Next;
                this.CurrentNode = p;
                this.tail = p;

                this.count--;
                return temp;
            }
            else
            {
                do
                {
                    p = p.Next;

                } while (p.Next != this.CurrentNode);

                temp = this.CurrentNode.Item;
                p.Next = this.CurrentNode.Next;
                this.CurrentNode = p;

                this.count--;
                return temp;
            }
        }



        public bool MoveNext()
        {
            if (this.currentNode == null || this.currentNode.Next == null) { return false; }
            this.currentNode = this.currentNode.Next;
            return true;
        }

        public bool MoveLast()
        {
            if (this.tail == null) { return false; }
            else { this.currentNode = this.tail; return true; }
        }

        public bool MoveFirst()
        {
            if (this.head == null) { return false; }
            else { this.currentNode = this.head; return true; }
        }

        public bool IsEmpty()
        {
            return head == null;
        }
    }
}
