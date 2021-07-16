using System;
using System.Globalization;
using AtEnumeraçao.Entities;
using AtEnumeraçao.Entities.enuns;

namespace AtEnumeraçao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date: ");
            DateTime Bdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client (name, email, Bdate);
            Order order = new Order(DateTime.Now, status, client);
           
            Console.Write("How many itens to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter #" + i + " item data:");
                Console.Write("Product name: ");
                string Pname = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(Pname, price); 

                Console.Write("Quantity: ");
                int qtd = int.Parse(Console.ReadLine());

                OrderItem oItem = new OrderItem(qtd, price, product);

                order.AddItem(oItem);

            }

            Console.WriteLine();
            Console.WriteLine("Order Summary:");
            Console.WriteLine(order);
        }
    }
}
