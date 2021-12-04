using System;

namespace Entities
{
    public class MyStack
    {
        int[] items;
        readonly static int defaultSize = 100;
        public int Count { get; private set; }
        public int Capacity => items.Length;
        public MyStack()
        {
            items = new int[defaultSize];
        }
        private bool HasSpace()
        {
            return Capacity > Count;
        }
        public int Pop()
        {
            if (Count > 0)
            {
                return items[--Count];
            }
            throw new Exception("Can't pop nothing.");
            
        }
        public void Push(int item)
        {
            if (!HasSpace())
            {
                throw new Exception("Stack is full.");
            }
            items[Count++] = item;
        }
    }
}
