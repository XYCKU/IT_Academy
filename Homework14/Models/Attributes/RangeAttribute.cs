using System;

namespace Models.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class RangeAttribute : ValidationAttribute
    {
        private int minValue, maxValue;
        public int MinRange
        {
            get => minValue;
            private set
            {
                minValue = (value >= 0) ? value : throw new ArgumentOutOfRangeException(nameof(value));
            }
        }
        public int MaxRange
        {
            get => maxValue;
            private set
            {
                maxValue = (value >= 0) ? value : throw new ArgumentOutOfRangeException(nameof(value));
            }
        }
        public RangeAttribute() : this(0, 150) { }
        public RangeAttribute(int minAge, int maxAge)
        {
            MinRange = minAge;
            MaxRange = maxAge;
        }
        public override bool IsValid(object item)
        {
            int age = (int)item;
            var result = age >= minValue && age <= maxValue;
            if (!result)
            {
                this.ErrorMessage = string.IsNullOrEmpty(this.ErrorMessage) ? "Range is not valid" : this.ErrorMessage;
            }

            return result;
        }
    }
}
