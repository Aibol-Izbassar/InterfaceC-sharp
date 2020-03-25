using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Nterface
{
    public class Human:IComparable<Human>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo([AllowNull] Human other)
        {
            return Age - other.Age;
        }
    }

    public class FamilyEnumerator<T> : IEnumerator<T>
    {
        public T Current => humans[index];

        object IEnumerator.Current => throw new NotImplementedException();

        T[] humans;
        int index = -1;

        public FamilyEnumerator(params T []h)
        {
            humans = h;
        }

        public void Dispose()
        {
           // throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if (index < humans.Length - 1)
            {
                index++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            index = 0;
        }
    }
     
    

    public class Family: IEnumerable<Human>
    {
        public Human mother;
        public Human father;
        public Human brother;
        public Human sister;
        public Human grandmother;
        public Human grandfather;

        public IEnumerator<Human> GetEnumerator()
        {
            return new FamilyEnumerator<Human> ( grandfather, grandmother, mother, father, brother, sister );
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
