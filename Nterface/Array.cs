using System;
using System.Collections.Generic;
using System.Text;

namespace Nterface
{
    public class Array<T> where T:IComparable<T>
    {
        T[] array;
        public int length { get { return array.Length; } }

   

        public T this [int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }


        public Array(int size)
        {
            array = new T[size];
        }

        public void Sort()
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                int j = i;
                while (j >= 0 && (array[j].CompareTo(array[j + 1]) > 0))
                {
                    T temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    j--;
                }
            }
        }
    }
}
