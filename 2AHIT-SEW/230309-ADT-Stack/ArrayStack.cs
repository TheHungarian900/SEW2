using System;
using System.Collections.Generic;
using System.Text;

namespace _230309_ADT_Stack
{
    class ArrayStack<T>
    {
        //Push, Pop, Peek, IsEmpty

        /*
        public T Element { get; set; }

        public T getElem() { return Element; }
        public void setElem(T elem) { this.Element = elem; }
        */

        private readonly long size;
        public long Size { get { return size; } }


        private long pointer = 0;
        public long Counter { get { return pointer; } }


        private T[] elements; // array of elements of type T

        public ArrayStack(long size) // ctor
        {
            this.size = size;
            elements = new T[size];
        }

        public void Push(T element)
        {
            if(pointer == size)
            {
                throw new Exception("StackFull");
            }
            else
            {
                elements[pointer++] = element;
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
                return elements[--pointer];
            }
        }

        public T Peek()
        {
            if(this.IsEmpty())
            {
                throw new Exception("StackEmpty");
            }
            else
            {
                return elements[pointer - 1];
            }
        }

        public bool IsEmpty()
        {
            return pointer == 0;
        }
    }
}
