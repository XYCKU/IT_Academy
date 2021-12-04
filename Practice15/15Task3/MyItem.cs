using System;

namespace _15Task3
{
    public class MyItem
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public MyItem() : this(0, "No name"){}
        public MyItem(int age, string name)
        {
            Age = age;
            Name = name;
        }
    }
}
