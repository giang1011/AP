using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp
{
    public class Product
    {
        public int ID { get; set; }
        public required string ProductName { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {ProductName}, Price: {Price:C}";
        }
    }
}

