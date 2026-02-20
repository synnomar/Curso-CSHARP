using System;
using Modulo08EnumAula001.Entities.Enums;


namespace Modulo08EnumAula001.Entities
{
    class Order
    {
        public int Id { get; init; }
        public DateTime Moment { get; set; }

        public OrderStatus Status { get; set; }


        public override string ToString()
        {
            return Id
                +", "
                +Moment
                + ", "
                +Status
                ;
        }




    }
}
