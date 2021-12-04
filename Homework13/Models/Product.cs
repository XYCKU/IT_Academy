using System;

namespace Models
{
    public class Product : IComparable<Product>
    {
        private string name;
        private string storeName;
        public string Name
        {
            get => name;
            private set
            {
                name = value ?? throw new ArgumentNullException(nameof(value));
            }
        }
        public string StoreName
        {
            get => storeName;
            private set
            {
                storeName = value ?? throw new ArgumentNullException(nameof(value));
            }
        }
        public Product(string name, string storeName)
        {
            Name = name;
            StoreName = storeName;
        }
        public int CompareTo(Product other)
        {
            int result = StoreName.CompareTo(other.StoreName);
            if (result == 0)
            {
                return Name.CompareTo(other.Name);
            }
            return result;
        }
        public override string ToString()
        {
            return $"Name: {Name}, StoreName: {StoreName}";
        }
    }
}
