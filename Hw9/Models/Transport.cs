using System;

namespace Models
{
    public class Transport : IVehicle
    {
        public int Speed { get; private set; }
        public string Name { get; private set; }

        public Transport(int speed = 0, string name = "")
        {
            Speed = speed;
            Name = name;
        }
        public virtual string Move()
        {
            return "Transport moving";
        }
        public override string ToString()
        {
            return $"Speed: {Speed}, Name: {Name}";
        }
    }
}
