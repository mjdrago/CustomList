using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateListClass
{
    public class CustomList<T>:IEnumerable<T>
    {
        T[] data;
        public CustomList()
        {
            data = new T[0];
        }
        public CustomList(int sizeOfInitialArray)
        {
            data = new T[sizeOfInitialArray];
        }
        public CustomList(T[] initialArray)
        {

        }

        public int Capacity
        {
            get
            {
                return 5;
            }
            set
            {

            }
        }
        public int Count
        {
            get
            {
                return 5;
            }
        }
        public T this[int i]
        {
            get
            {
                return data[i];
            }
        }
        
        public void Add(T elementToAdd)
        {

        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
