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
            data = new T[0];
            count = 0;
            capacity = 0;
        }
        public CustomList(int sizeOfInitialArray)
        {
            data = new T[sizeOfInitialArray];
            count = 0;
            capacity = sizeOfInitialArray;
        }
        public CustomList(T[] initialArray)
        {
            data = initialArray;
            count = initialArray.Length;
            capacity = initialArray.Length;
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
                return data[i];
            }
            set
            {

            }
        }
        
        public void Add(T elementToAdd)
        {
            if (CheckIfNewArrayNeeded(1))
            {
                T[] newArray = CreateNewArray(1, 3);
                ChangeCapacity(newArray.Length);
                InputArrayData(newArray, data, count);
                InputSingleEntryToArray(newArray, count, elementToAdd);
                IncreaseCount(1);
                UpdateData(newArray);
            }
            else
            {
                InputSingleEntryToArray(data, count, elementToAdd);
                IncreaseCount(1);
            }
        }
        private bool CheckIfNewArrayNeeded (int numberToAdd)
        {
            if (numberToAdd + count > capacity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private T[] CreateNewArray(int numberToAdd,int extraRoom)
        {
            return new T[count + numberToAdd + extraRoom];
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
