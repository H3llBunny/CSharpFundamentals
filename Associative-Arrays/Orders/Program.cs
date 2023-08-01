using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Orders
{
    internal class Program
    {
        public class Products
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }

            public Products(string name, double price, int quantity)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
            }
        }
        static void Main(string[] args)
        {
            List<Products> products = new List<Products>();
            string input;

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] product = input.Split();
                string productName = product[0];
                double price = double.Parse(product[1]);
                int quantity = int.Parse(product[2]);

                bool doesProductExits = products.Any(x => x.Name == productName);

                if (doesProductExits)
                {
                    for (int i = 0; i < products.Count; i++)
                    {
                        if (products[i].Name == productName)
                        {
                            products[i].Price = price;
                            products[i].Quantity += quantity;
                        }
                    }
                }
                else
                {
                    products.Add(new Products(productName, price, quantity));
                }
            }

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} -> {(product.Price * product.Quantity):f2}");
            }
        }
    }
}