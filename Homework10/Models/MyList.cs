using System;
using System.Collections;
using System.Collections.Generic;

namespace Models
{
    public class MyList : IList<MyItem>
    {
        static readonly int defaultSize = 4;
        private MyItem[] items;
        private int version;
        private int position = -1;
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
        public MyItem Current => items[position];

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
            items = new MyItem[defaultSize];
        }
        public void Clear()
        {
            Count = 0;
            items = new MyItem[defaultSize];
            version++;
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
            this[Count - 1] = null;
            Count--;
            version++;
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
            Count++;
            version++;
            this[index] = item;
        }

        public void Add(MyItem item)
        {
            Insert(Count, item);
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

        public void CopyTo(MyItem[] array, int arrayIndex) => items.CopyTo(array, arrayIndex);

        public bool Remove(MyItem item)
        {
            int index = IndexOf(item);
            if (index >= 0)
            {
                RemoveAt(index);
                return true;
            }
            version++;
            return false;
        }
        //Сделано по приколу, на проде такое бы не городил)
        public override string ToString()
        {
            MyItem[] temp = new MyItem[Count];
            
            for (int i = 0; i < Count; i++)
            {
                temp[i] = this[i];
            }
            return String.Join<MyItem>(Environment.NewLine, temp) + Environment.NewLine +
                $"Count: {Count}, Capacity: {Capacity}";
        }
        // Конец прикола
        IEnumerator<MyItem> IEnumerable<MyItem>.GetEnumerator() => new Enumerator(this);

        public Enumerator GetEnumerator() => new Enumerator(this);

        IEnumerator IEnumerable.GetEnumerator() => new Enumerator(this);

        public struct Enumerator : IEnumerator<MyItem>
        {
            private readonly MyList collection;
            private readonly int version;
            private int currentIndex;

            internal Enumerator(MyList collection)
            {
                this.collection = collection ?? throw new ArgumentNullException(nameof(collection));
                this.version = collection.version;
                this.currentIndex = -1;
            }

            public MyItem Current
            {
                get
                {
                    if (this.currentIndex < 0 || this.currentIndex >= this.collection.Count)
                    {
                        throw new InvalidOperationException();
                    }

                    return this.collection.items[this.currentIndex];
                }
            }

            object IEnumerator.Current => this.Current;

            void IDisposable.Dispose()
            { }

            public bool MoveNext()
            {
                if (this.version != this.collection.version)
                {
                    throw new InvalidOperationException("Collection cannot be modified.");
                }

                return ++this.currentIndex < this.collection.Count;
            }

            public void Reset() => this.currentIndex = -1;
        }
    }
}
