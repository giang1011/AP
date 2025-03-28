using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager
{
    public class ProductManagers
    {
        private List<Product> products = new List<Product>();

        public void AddProduct()
        {
            Product product = new Product();
            product.ID = Validate.InputInt("Nhap ID: ");
            product.ProductName = Validate.InputString("Nhap ten san pham: ");
            product.Price = Validate.InputDouble("Nhap gia: ");

            products.Add(product);
            Console.WriteLine(" San pham da duoc them!");
        }

        public void DisplayProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine(" Danh sach san pham trong!");
                return;
            }

            Console.WriteLine("\n Danh sach san pham:");
            foreach (var product in products)
            {
                product.Display();
            }
        }
    }
}
