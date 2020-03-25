using System;
using System.Collections.Generic;
using System.Text;

namespace Nterface
{
    class Box<T>
    {
        public Box <T> prev;
        public Box <T> next;
        public T value;
    }
    class Queue<T>
    {
        Box<T> counter;
        Box<T> head;
        
        public Queue()
        {
           
        }

        public void Enqueue(T n)
        {
            Box<T> b = new Box<T>();
            b.value = n;
            if (counter == null)
            {
                counter = b;
                head = b;
            }
            counter.next = b;
            counter = b;
        }

        public T Dequeue()
        {
            if (head != null)
            {
                T getItem = head.value;
                head = head.next;
                return getItem;
            }
            else
            {
                return default(T);
            }

        }
    }
}
