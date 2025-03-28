using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager
{
    public class Validate
    {
        public static int InputInt(string message)
        {
            int number;
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out number) && number > 0)
                    return number;
                Console.WriteLine(" Loi: Vui long nhap so nguyen duong!");
            }
        }

        public static double InputDouble(string message)
        {
            double number;
            while (true)
            {
                Console.Write(message);
                if (double.TryParse(Console.ReadLine(), out number) && number > 0)
                    return number;
                Console.WriteLine(" Loi: Vui long nhap so thuc duong!");
            }
        }

        public static string InputString(string message)
        {
            string input;
            while (true)
            {
                Console.Write(message);
                input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                    return input;
                Console.WriteLine(" Loi: Khong duoc de trong!");
            }
        }

        public static string InputMenuOption(string message, string[] validOptions)
        {
            string choice;
            while (true)
            {
                Console.Write(message);
                choice = Console.ReadLine();
                foreach (var option in validOptions)
                {
                    if (choice == option)
                        return choice;
                }
                Console.WriteLine(" Loi: Lua chon khong hop le!");
            }
        }
    }
}
