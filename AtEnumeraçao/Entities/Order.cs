using System;
using System.Collections.Generic;
using System.Text;
using AtEnumeraçao.Entities.enuns;
using System.Globalization;

namespace AtEnumeraçao.Entities
{
    class Order
    {
        public DateTime Momment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Itens { get; set; } = new List<OrderItem>();


        public Order() { }

        public Order(DateTime momment, OrderStatus status, Client client)
        {
            Momment = momment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Itens.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Itens.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach(OrderItem item in Itens)
            {
                sum += item.Subtotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine("Order moment: " + Momment.ToString("dd/MM/yyyy  HH:mm:ss"));
            sb.AppendLine("Order Status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order Itens: ");
            foreach(OrderItem item in Itens)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total Price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
