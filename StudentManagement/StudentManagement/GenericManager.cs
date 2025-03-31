using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class GenericManager<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public List<T> GetAll()
        {
            return new List<T>(items);
        }

        public void Update(int index, T item)
        {
            if (index >= 0 && index < items.Count)
            {
                items[index] = item;
            }
            else
            {
                Console.WriteLine("Student not found with this ID.");
            }
        }

        public void Delete(int index)
        {
            if (index >= 0 && index < items.Count)
            {
                items.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Student not found with this ID.");
            }
        }
    }
}
