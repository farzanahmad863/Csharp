using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> ProductsList = new List<Product>();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Please enter the product Name!");
                string productName = Console.ReadLine();
                if (productName.ToLower() == "q")
                {
                    exit = true;
                    List<Product> SortedList = ProductsList.OrderBy(item => item.Price).ToList();
                    int sumOfPrices = 0;
                    Console.WriteLine("Name".PadRight(20) + "Category".PadRight(20) + "Price");
                    foreach (var product in SortedList)
                    {
                        Console.WriteLine(product.Name.PadRight(20) + product.Category.PadRight(20) + product.Price);
                        sumOfPrices += Int32.Parse(product.Price);
                    }
                    Console.WriteLine("sum:".PadRight(40) + sumOfPrices);
                    break;
                }
                Console.WriteLine("Please enter the product Category!");
                string productCategory = Console.ReadLine();
                Console.WriteLine("Please enter the product Price!");
                string productPrice = Console.ReadLine();
                Product userProduct = new Product(); //Created object of product
                userProduct.AddProductDetails(productName, productCategory, productPrice); //replaced user given values in object
                ProductsList.Add(userProduct); //added the object to the list }
            }
        }
        class Product
        {
            public string Name { get; set; }
            public string Category { get; set; }
            public string Price { get; set; }
            public void AddProductDetails(string name, string category, string price)
            {
                Name = name;
                Category = category;
                Price = price;
            }
        }
    }
}

