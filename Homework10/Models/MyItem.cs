using System;

namespace Models
{
    public class MyItem
    {
        public string Name { get; private set; }
        public int Pages { get; private set; }
        public MyItem(string name = "No name", int pages = 0)
        {
            Name = name;
            Pages = pages;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Pages: {Pages}";
        }
    }
}
