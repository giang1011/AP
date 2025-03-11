using System;

namespace ProductApp
{
    public class Menu
    {
        private ProductManager productManager = new ProductManager();

        public void ShowMenu()
        {
            int choice;
            do
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("1. Nhap san pham");
                Console.WriteLine("2. Hien thi san pham");
                Console.WriteLine("3. Thoat");
                Console.Write("Chon: ");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            productManager.AddProduct();
                            break;
                        case 2:
                            productManager.ShowProducts();
                            break;
                        case 3:
                            Console.WriteLine("Thoat chuong trinh.");
                            break;
                        default:
                            Console.WriteLine("Vui long chon tu 1 den 3.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Vui long nhap so hop le.");
                }
            } while (choice != 3);
        }
    }
}
