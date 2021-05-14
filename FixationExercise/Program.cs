using FixationExercise.Entities;
using FixationExercise.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string clientName;
            string clientEmail;
            DateTime clientBirthDate;
            Client client;

            OrderStatus orderStatus;
            Order order;

            int itemQuantity;
            OrderItem orderItem;

            string productName;
            double productPrice;
            Product product;

            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            clientName = Console.ReadLine();
            Console.Write("Email: ");
            clientEmail = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            clientBirthDate = DateTime.Parse(Console.ReadLine());

            client = new Client(clientName, clientEmail, clientBirthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status (PendingPayment/Processing/Shipped/Delivered): ");
            orderStatus = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());

            order = new Order(DateTime.Now, orderStatus, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                productName = Console.ReadLine();
                Console.Write("Product price: ");
                productPrice = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

                product = new Product(productName, productPrice);

                Console.Write("Quantity: ");
                itemQuantity = int.Parse(Console.ReadLine());

                orderItem = new OrderItem(itemQuantity, product);
                order.AddItem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine(order.ToString());
        }
    }
}
