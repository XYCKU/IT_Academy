using System;
using System.Collections;
using System.Collections.Generic;

namespace Models
{
    public class MyList : IList<MyItem>
    {
        private MyItem[] items;
        public MyItem this[int index] { 
            get
            {
                if (index < 0 || index >= Count) 
                { 
                    throw new ArgumentOutOfRangeException(nameof(index));
                }
                return items[index];
            } 
            set {
                if (index < 0 || index >= Count)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }
                items[index] = value; 
            } 
        }

        public int Count { get; private set; } = 0;
        public int Capacity => items.Length;
        public bool IsReadOnly => false;

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
            for (int i = index + 1; i < Count; i++)
            {
                this[i - 1] = this[i];
            }
            Count--;
        }
        public int IndexOf(MyItem item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (this[i] == item)
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
                if (it == item)
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
    }
}
