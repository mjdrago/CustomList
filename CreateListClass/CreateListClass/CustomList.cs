using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateListClass
{
    public class CustomList<T>
    {
        T[] activeArray;
        public CustomList()
        {
            activeArray = new T[0];
        }
        public CustomList(int sizeOfInitialArray)
        {
            activeArray = new T[sizeOfInitialArray];
        }

        public T[] GetActiveArray()
        {
            return activeArray;
        }
        
        public void Add(T elementToAdd)
        {

        }
    }
}
