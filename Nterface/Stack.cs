using System;
using System.Collections.Generic;
using System.Text;

namespace Nterface
{
    class Stack<T>
    {
        public Box<T> current;

        public void Push(T n)
        {
            Box<T> b = new Box<T>();
            b.value = n;
            if (current != null)
            {
                b.prev = current;
                current = b;
            }
            current = b;
        }

        public T Pop()
        {
            if (current != null)
            {

                T getItem = current.value;
                current = current.prev;
                return getItem;
            }
            else
            {
                return default(T);
            }
        }
    }
}
