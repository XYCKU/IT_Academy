using System;

namespace Entities.Task5
{
    public class Hero : Entity
    {
        private int damage;
        public int Damage
        {
            get => damage;
            set
            {
                damage = (value >= 0) ? value : throw new ArgumentOutOfRangeException(nameof(value));
            }
        }
        public Hero(string name, int hp, int damage) : base(name, hp)
        {
            Damage = damage;
        }
        public override string Action()
        {
            return "I attack monsters";
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Damage: {Damage}";
        }
    }
}
