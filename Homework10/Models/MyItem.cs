using System;

namespace Models
{
    public class MyItem
    {
        private string name;
        private int pages;
        public string Name { 
            get => name;
            private set {
                name = value ?? throw new ArgumentNullException(nameof(value));
            } 
        }
        public int Pages { 
            get => pages; 
            private set => pages = (value > 0) ? value : throw new ArgumentOutOfRangeException(nameof(value));
        }

        public MyItem(string name = "No name", int pages = 1)
        {
            Name = name;
            Pages = pages;
        }

        public override string ToString() => $"Name: {Name}, Pages: {Pages}";
    }
}
