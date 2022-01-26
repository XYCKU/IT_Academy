using System;

namespace Models.Task6
{
    [Serializable]
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Person() { }
        public Person(int id, string name) { Id = id; Name = name; }
        public override string ToString() => $"Id: {Id}, Name: {Name}";
    }
}
