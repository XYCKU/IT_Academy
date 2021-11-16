using System;

namespace Models
{
    public class Car : Transport
    {
        public Car(int speed = 10, string name = "myCar") : base(speed, name) { }
        public override string Move()
        {
            return "I'm driving";
        }
    }
}
