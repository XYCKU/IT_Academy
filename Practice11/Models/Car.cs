using System;

namespace Models
{
    public class Car : IComparable<Car>
    {
        public int Age { get; private set; }
        public Colors Color { get; private set; }
        public Car(int age, Colors color)
        {
            Age = age;
            Color = color;
        }
        public override bool Equals(object obj)
        {
            return (obj is Car) && Equals((Car)obj);
        }
        public bool Equals(Car other)
        {
            return (Age == other.Age && Color == other.Color);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Age, Color);
        }
        public override string ToString()
        {
            return $"Age: {Age}, Color: {Color}";
        }
        public int CompareTo(Car other)
        {
            if (this < other)
            {
                return -1;
            } else
            {
                if (this == other)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        public static bool operator==(Car lhs, Car rhs)
        {
            return lhs.Equals(rhs);
        }
        public static bool operator!=(Car lhs, Car rhs)
        {
            return !(lhs == rhs);
        }
        public static bool operator<(Car lhs, Car rhs)
        {
            return (lhs.Age < rhs.Age) ||
                (lhs.Age == rhs.Age && lhs.Color < rhs.Color);
        }
        public static bool operator>(Car lhs, Car rhs)
        {
            return !(lhs < rhs || lhs == rhs);
        }
    }
}
