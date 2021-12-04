using System;

namespace Entities.Task5
{
    public class Monster : Entity
    {
        private int defense;
        public int Defense
        {
            get => defense;
            set
            {
                defense = (value >= 0) ? value : throw new ArgumentOutOfRangeException(nameof(value));
            }
        }
        public Monster(string name, int hp, int defense) : base(name, hp)
        {
            Defense = defense;
        }
        public override string Action()
        {
            return "I'm just a dummy for beating.(";
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Defense: {Defense}";
        }
    }
}
