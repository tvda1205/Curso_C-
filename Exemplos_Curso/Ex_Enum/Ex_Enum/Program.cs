using Ex_Enum.Entities;
using Ex_Enum.Entities.Enum;

namespace Ex_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1990,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment

            };
            

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus status = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(status);

        }
    }
}
