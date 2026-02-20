using Modulo08EnumAula001.Entities;
using Modulo08EnumAula001.Entities.Enums;
using System;


namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order()
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);
            
            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");


            Console.WriteLine(os);
            Console.WriteLine(txt);



        }
    }
}
