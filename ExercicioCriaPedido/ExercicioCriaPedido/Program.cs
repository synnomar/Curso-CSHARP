using System;
using System.Globalization;
using ExercicioCriaPedido.Entities;
using ExercicioCriaPedido.Entities.Enum;


namespace MyApplication
{
    class Progeam
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());


            Client client = new Client(name,email, birthDate);
            Order order = new Order(DateTime.Now, orderStatus,client );

            Console.Write("How many items to this order? ");
            int numItem = int.Parse(Console.ReadLine());

            
            

            for (int i = 1; i <= numItem; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product produto = new Product(productName, productPrice);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                
                OrderItem orderItem = new OrderItem(quantity, productPrice, produto);

                order.Items.Add(orderItem);

            }
            
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);










        }
    }
}