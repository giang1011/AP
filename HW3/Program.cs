namespace ProductManager
{
    internal class Program
    {
        static void Main()
        {
            ProductManagers manager = new ProductManagers();
            string[] menuOptions = { "1", "2", "3" };

            while (true)
            {
                Console.WriteLine("\n==== Quan ly San pham ====");
                Console.WriteLine("1. Nhap san pham");
                Console.WriteLine("2. Hien thi san pham");
                Console.WriteLine("3. Thoat");

                string choice = Validate.InputMenuOption(" Chon chuc nang: ", menuOptions);

                switch (choice)
                {
                    case "1":
                        manager.AddProduct();
                        break;
                    case "2":
                        manager.DisplayProducts();
                        break;
                    case "3":
                        Console.WriteLine(" Thoat chuong trinh...");
                        return;
                }
            }
        }
    }
}
