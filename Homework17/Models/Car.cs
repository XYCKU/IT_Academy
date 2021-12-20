using System;

namespace Models
{
    public class Car
    {
        private int age;
        public int Age 
        { 
            get => age;
            set => age = (value < 0) ? throw new ArgumentOutOfRangeException(nameof(value)) : value; 
        }
        public Car(int age = 0)
        {
            Age = age;
        }
    }
}
