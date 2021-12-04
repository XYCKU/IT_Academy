using System;
using Models;

namespace EntryPoint
{
    internal class Program
    {
        public static void FindProducts(string storeName, Product[] products)
        {
            bool foundAnything = false;
            foreach (var product in products)
            {         
                if (storeName.Equals(product.StoreName, StringComparison.OrdinalIgnoreCase))
                {
                    foundAnything = true;
                    Console.WriteLine(product);
                }
            }
            if (!foundAnything)
            {
                throw new WrongStoreNameException($"Магазина с названием {storeName} не существует!");
            }
        }
        static void Main(string[] args)
        {
            Product[] products = new Product[5] { new Product("Apple", "Alconaft"), 
                                                    new Product("Peach", "General Store"), 
                                                    new Product("Milk", "White Fluids Co."), 
                                                    new Product("Meat", "7/11"), 
                                                    new Product("Bread", "Alconaft") };
            Array.Sort(products);
            try
            {
                FindProducts("alconaft", products);
                FindProducts("lconaft", products);
            }
            catch (WrongStoreNameException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}