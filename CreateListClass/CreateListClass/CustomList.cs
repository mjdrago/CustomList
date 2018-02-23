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
        private T[] data;
        private int count;
        private int capacity;

        public CustomList()
        {
            capacity = 5;
            data = new T[capacity];
            count = 0;
        }
        public CustomList(int sizeOfInitialArray)
        {
            capacity = sizeOfInitialArray;
            data = new T[capacity];
            count = 0;
        }
        public CustomList(T[] initialArray)
        {
            capacity = 5;
            while (initialArray.Length * 2 >= capacity )
            {
                capacity *= 2;
            }
            data = new T[capacity];
            for (int i = 0; i < initialArray.Length; i++)
            {
                data[i] = initialArray[i];
            }
            count = initialArray.Length;
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {

            }
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        public T this[int i]
        {
            get
            {
                if (i > capacity - 1 )
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return data[i];
                }                
            }
            set
            {

            }
        }
        
        public void Add(T elementToAdd)
        {
            if (CheckIfNewArrayNeeded(1,capacity))
            {
                DoubleDataArraySize(1);
            }
                InputSingleEntryToArray(data, count, elementToAdd);
                IncreaseCount(1);
        }
        public void Remove(T elementToRemove) {
        }
        private bool CheckIfNewArrayNeeded (int numberToAdd, int maxElements)
        {
            if ((numberToAdd + count) * 2 > maxElements)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void DoubleDataArraySize(int numberOfNewElements)
        {
            T[] newArray = CreateNewArray(numberOfNewElements);
            ChangeCapacity(newArray.Length);
            InputArrayData(newArray, data, count);
            UpdateData(newArray);
        }
        private T[] CreateNewArray(int numberOfNewElements)
        {
            int newCapacity = 2 * capacity;
            while (CheckIfNewArrayNeeded(numberOfNewElements,newCapacity))
            {
                newCapacity *= 2;
            }
            return new T[newCapacity];
        }

        private void IncreaseCount(int amount)
        {
            count += amount;
        }
        private void DecreaseCount(int amount)
        {
            count -= amount;
        }
        private void ChangeCapacity(int amount)
        {
            capacity = amount;
        }
        private void InputSingleEntryToArray(T[] targetArray, int locationToAdd, T valueToAdd)
        {
            targetArray[locationToAdd] = valueToAdd;
        }

        private void InputArrayData(T[] targetArray,T[] dataToAdd,int numberOfItemsToAdd)
        {
            for (int i = 0; i < numberOfItemsToAdd; i++)
            {
                //targetArray[i] = dataToAdd[i];
                InputSingleEntryToArray(targetArray, i, dataToAdd[i]);
            }
        }

        private void UpdateData(T[] newData)
        {
            data = newData;
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
