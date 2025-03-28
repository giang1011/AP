using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        public void Display()
        {
            Console.WriteLine($"ID: {ID}, Ten: {ProductName}, Gia: {Price}");
        }
    }
}
