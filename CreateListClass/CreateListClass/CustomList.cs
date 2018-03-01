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
        public bool Remove(T elementToRemove)
        {
            int indexValue = IndexOf(elementToRemove);
            if (indexValue >= 0)
            {
                RemoveAt(indexValue);
                return true;
            }
            return false;
        }
        private int IndexOf(T searchValue)
        {
            for (int i = 0; i < count; i++)
            {
                if (data[i].Equals(searchValue))
                {
                    return i;
                }
            }
            
            return -1;
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
        private void RemoveAt(int indexToRemove)
        {
            if (indexToRemove > count)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                T[] newArray = new T[capacity];
                RemoveOneElement(newArray, data, count, indexToRemove);
                UpdateData(newArray);
                DecreaseCount(1);
            }
        }
        private void RemoveOneElement(T[] targetArray,T[] dataToAdd,int numberOfItemsToAdd,int elementToRemove)
        {
            int j = 0;
            for (int i = 0; i < numberOfItemsToAdd; i++)
            {
                if (i!=elementToRemove)
                {
                    InputSingleEntryToArray(targetArray, j, data[i]);
                    j += 1;
                }                
            }
        }
        private void UpdateData(T[] newData)
        {
            data = newData;
        }

        public override string ToString()
        {
            string outputString = count + "/" + capacity + " Spots Filled\n";
            for (int i = 0; i < count; i++)
            {
                outputString += "Index " + i + ": " + data[i]+"\n";
            }
            return outputString;
        }



        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public static CustomList<T> operator +(CustomList<T> valueOne, CustomList<T> valueTwo)
        {
            return new CustomList<T>();
        }
        public static CustomList<T> operator -(CustomList<T> valueOne, CustomList<T> valueTwo)
        {
            return new CustomList<T>();
        }
    }
}
