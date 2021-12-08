using System;
using System.Reflection;
using System.Text.RegularExpressions;
using Models.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Person
    {
        private string firstName, lastName;
        private int age;
        [Regex(ErrorMessage = "First name is not valid")]
        public string FirstName
        {
            get => firstName;
            private set
            {
                firstName = value ?? throw new ArgumentNullException(nameof(value));
            }
        }
        [Regex(ErrorMessage = "Last name is not valid")]
        public string LastName
        {
            get => lastName;
            private set
            {
                lastName = value ?? throw new ArgumentNullException(nameof(value));
            }
        }
        [Attributes.Range(5, 26, ErrorMessage = "Age is not valid")]
        public int Age
        {
            get => age;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                age = value;
            }
        }
        public Person() : this("No name", "No family", 0) { }
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public override string ToString() => $"{FirstName} {LastName} {Age}";
    }
}
