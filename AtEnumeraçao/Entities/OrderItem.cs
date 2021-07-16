using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace AtEnumeraçao.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Products { get; set; }


        OrderItem() { }

        public OrderItem(int quantity, double price, Product products)
        {
            Quantity = quantity;
            Price = price;
            Products = products;
        }

        public double Subtotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Products.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + Subtotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
