using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example06
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Product[] products = new Product[4];
            products[0] = new Product()
            {
                Name = "iPhone 7",
                Price = 28000
            };
            products[1] = new Product()
            {
                Name = "iPhone 6",
                Price = 2800
            };
            products[2] = new Product()
            {
                Name = "iPhone 5",
                Price = 280
            };
            products[3] = new Product()
            {
                Name = "iPhone 4",
                Price = 28
            };
            Random random = new Random();
            List<Product> shoppingCart = new List<Product>();
            for (var count = 1; count <= 10; count++)
            {
                var index = random.Next(0, products.Length);
                shoppingCart.Add(products[index]);
                Console.WriteLine(products[index].Name);
            }
        }
    }
}