using System;
using System.Collections.Generic;
using System.Text;

namespace _230309_ADT_Stack
{
    class LinkedStack<T>
    {
        internal class Node // Knoten
        {
            public T Item; // data
            public Node Next; // link to next node in array

            public Node(T item, Node next)
            {
                this.Item = item;
                this.Next = next; // link to previous top (head) item
            }
        }

        private Node top; // reference to head element


        private long count; // number of stack elements
        public long Count { get { return this.count; } }

        public void Push(T element)
        {
            if (count == 0)
            {
                this.top = new Node(element, null);
            }
            else
            {
                this.top = new Node(element, this.top);
            }
        }

        public T Pop()
        {
            if (this.IsEmpty())
            {
                throw new Exception("StackEmpty");
            }
            else
            {
                T temp = this.Peek();

                this.top = this.top.Next;

                return temp;
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
                return this.top.Item;
            }
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }
}
