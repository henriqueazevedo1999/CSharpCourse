using FixationExercise.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixationExercise.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            OrderItems.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            OrderItems.Remove(item);
        }

        public double Total()
        {
            return OrderItems.Sum(x => x.SubTotal());
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine($"Order moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine($"Client: {Client.Name} {Client.BirthDate.ToString("(dd/MM/yyyy)")} - {Client.Email}");

            sb.AppendLine("Order items:");
            foreach (OrderItem orderItem in OrderItems)
            {
                sb.AppendLine($"{orderItem.Product.Name}, ${orderItem.Price.ToString("F2")}, Quantity: {orderItem.Quantity}, Subtotal: {orderItem.SubTotal().ToString("F2")}");
            }
            sb.AppendLine($"Total price: ${Total().ToString("F2")}");

            return sb.ToString();
        }
    }
}
