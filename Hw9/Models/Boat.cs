using System;

namespace Models
{
    public class Boat : Transport
    {
        public Boat(int speed = 5, string name = "myBoat") : base(speed, name) { }
        public override string Move()
        {
            return "I'm sailing";
        }
    }
}
