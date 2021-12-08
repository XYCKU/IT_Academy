using System;
using System.ComponentModel.DataAnnotations;

namespace Models.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class AgeAttribute : ValidationAttribute
    {
        private int minAge, maxAge;
        public int MinAge
        {
            get => minAge;
            private set
            {
                minAge = (value >= 0) ? value : throw new ArgumentOutOfRangeException(nameof(value));
            }
        }
        public int MaxAge
        {
            get => maxAge;
            private set
            {
                maxAge = (value >= 0) ? value : throw new ArgumentOutOfRangeException(nameof(value));
            }
        }

        public AgeAttribute() : this(0, 150) { }
        public AgeAttribute(int minAge, int maxAge)
        {
            MinAge = minAge;
            MaxAge = maxAge;
        }
        public override bool IsValid(object item)
        {
            int age = (int)item;
            var result = age >= minAge && age <= maxAge;
            if (!result)
            {
                this.ErrorMessage = string.IsNullOrEmpty(this.ErrorMessage) ? "napisesh suda" : this.ErrorMessage;
            }

            return result;
        }
    }
}
