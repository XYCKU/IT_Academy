using System;

namespace Models
{
    public class MyCollection<T>
    {
        public int Capacity { get; private set; } = 1;
        public int Count { get; private set; } = 0;
        T[] items;
        public T this[int index] => items[index];
        public MyCollection()
        {
            items = new T[Capacity];
        }
        private void ExtendCollection()
        {
            T[] temp = items;
            Capacity *= 2;
            items = new T[Capacity];
            TransferData(temp);
        }
        private void TransferData(T[] from)
        {
            for (int i = 0; i < Count; i++)
            {
                items[i] = from[i];
            }
        }
        public void Add(T item)
        {
            if (Count >= Capacity)
            {
                ExtendCollection();
            }
            items[Count++] = item;
        }
        public bool Remove(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (item.Equals(items[i]))
                {
                    for (int j = i + 1; j < Count; j++)
                    {
                        items[j - 1] = items[j];
                    }
                    return true;
                }
            }
            return false;
        }
        public void Clear()
        {
            Count = 0;
            Capacity = 1;
            items = new T[Capacity];
        }
    }
}
