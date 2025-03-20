using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.Domain.Entities
{
    public class Order
    {
        public int Id { get; private set; }
        public int CustomerId { get; private set; }
        public List<OrderItem> Items { get; private set; } = new();
        public Money Total => Money.FromDecimal(Items.Sum(i => i.Price.Value));

        public Order(int customerId)
        {
            CustomerId = customerId;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
    }
    public class OrderItem
    {
        public int Id { get; private set; }
        public string ProductName { get; private set; }
        public Money Price { get; private set; }

        public OrderItem(string productName, Money price)
        {
            ProductName = productName;
            Price = price;
        }
    }
}
