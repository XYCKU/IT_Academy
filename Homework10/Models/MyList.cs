using System;
using System.Collections;
using System.Collections.Generic;

namespace Models
{
    public class MyList : IList<MyItem>, IEnumerator<MyItem>
    {
        private MyItem[] items;
        private int position = -1;
        public MyItem this[int index] { get => items[index]; 
                                    set { items[index] = value; } }

        public int Count { get; private set; }
        public int Capacity { get => items.Length; }
        public bool IsReadOnly => false;

        public MyItem Current => items[position];

        object IEnumerator.Current => Current;

        MyItem IList<MyItem>.this[int index] { get => items[index]; set => items[index] = value; }

        private void ExtendCollection()
        {
            MyItem[] temp = items;
            items = new MyItem[temp.Length * 2];
            TransferData(temp);
        }
        private void TransferData(MyItem[] from)
        {
            for (int i = 0; i < Count; i++)
            {
                this[i] = from[i];
            }
        }
        public MyList()
        {
            items = new MyItem[1];
        }
        public void Clear()
        {
            Count = 0;
            items = new MyItem[1];
        }

        public bool HasSpace()
        {
            return Capacity > Count;
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < Count; i++)
            {
                this[i] = this[i + 1];
            }
            Count--;
        }
        public int IndexOf(MyItem item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (this[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Insert(int index, MyItem item)
        {
            if (!HasSpace())
            {
                ExtendCollection();
            }
            for (int i = Count; i > index; i--)
            {
                this[i] = this[i - 1];
            }
            this[index] = item;
            Count++;
        }

        public void Add(MyItem item)
        {
            if (!HasSpace())
            {
                ExtendCollection();
            }
            items[Count++] = item;
        }

        public bool Contains(MyItem item)
        {
            foreach (var it in items)
            {
                if (it.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(MyItem[] array, int arrayIndex)
        {
            items.CopyTo(array, arrayIndex);
        }

        public bool Remove(MyItem item)
        {
            int index = IndexOf(item);
            if (index >= 0)
            {
                RemoveAt(index);
                return true;
            }
            return false;
        }

        IEnumerator<MyItem> IEnumerable<MyItem>.GetEnumerator()
        {
            return (IEnumerator<MyItem>)items.GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return items.GetEnumerator();
        }

        public bool MoveNext()
        {
            ++position;
            return position < Count;
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {
            
        }
    }
}
