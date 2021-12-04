using System;

namespace Entities.Task5
{
    public class Entity
    {
        private string name;
        private int hp;

        public string Name
        {
            get => name;
            set
            {
                name = value ?? throw new ArgumentNullException(nameof(value));
            }
        }
        public int HP
        {
            get => hp;
            set
            {
                hp = (value > 0) ? value : throw new ArgumentOutOfRangeException(nameof(value));
            }
        }
        public Entity(string name, int hp)
        {
            Name = name;
            HP = hp;
        }
        public virtual string Action()
        {
            return "I do nothing.";
        }
        public override string ToString()
        {
            return $"Name: {Name}, HP: {HP}";
        }
        public virtual void Display()
        {
            Console.WriteLine(ToString());
        }
    }
}
