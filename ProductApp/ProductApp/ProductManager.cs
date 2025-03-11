using System;
using System.Collections.Generic;

namespace ProductApp
{
    public class ProductManager
    {
        private List<Product> products = new List<Product>();

        public void AddProduct()
        {
            Console.Write("Nhap ID san pham: ");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int id))
            {
                Console.WriteLine("ID khong hop le, vui long nhap so.");
                return;
            }

            Console.Write("Nhap ten san pham: ");
            string? name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Ten san pham khong duoc de trong.");
                return;
            }

            Console.Write("Nhap gia san pham: ");
            string? priceInput = Console.ReadLine();

            if (!double.TryParse(priceInput, out double price) || price < 0)
            {
                Console.WriteLine("Gia san pham khong hop le, vui long nhap so duong.");
                return;
            }

            products.Add(new Product { ID = id, ProductName = name, Price = price });
            Console.WriteLine("San pham da duoc them!");
        }

        public void ShowProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("Chua co san pham nao.");
                return;
            }

            Console.WriteLine("\nDanh sach san pham:");
            foreach (var product in products)
            {
                Console.WriteLine($"ID: {product.ID}, Ten: {product.ProductName}, Gia: {product.Price:C}");
            }
        }
    }
}
