using ExercicioLpooProduto.Entities;
using System;
using System.Globalization;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the number of products: ");
            int numberOption = int.Parse(Console.ReadLine());

            List<Product> productsList = new List<Product>();

            for (int i = 1; i <= numberOption; i++)
            {
                Console.WriteLine($"Product #{i} date: ");
                Console.Write("Common, used or imported: (c / u / i )? ");
                char option = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                if (option == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsfee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine();
                    productsList.Add(new ImportedProduct(name, price, customsfee));
                }
                else if (option == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine();
                    productsList.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    productsList.Add(new Product(name, price));
                    Console.WriteLine();
                }
                
            }
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product product in productsList)
            {
                Console.WriteLine(product.PriceTag());
            }









        }
    }
}