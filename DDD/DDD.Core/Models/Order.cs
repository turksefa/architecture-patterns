namespace DDD.Core.Models
{
    public class Order
    {
        public Guid Id { get; private set; }
        public List<OrderItem> Items { get; private set; }
        public DateTime OrderDate { get; private set; }

        public Order(Guid id, List<OrderItem> items)
        {
            Id = id;
            Items = items ?? throw new ArgumentNullException(nameof(items));
            OrderDate = DateTime.UtcNow;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public decimal GetTotal()
        {
            return Items.Sum(i => i.Price * i.Quantity);
        }
    }

    public class OrderItem
    {
        public Guid ProductId { get; private set; }
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }

        public OrderItem(Guid productId, int quantity, decimal price)
        {
            ProductId = productId;
            Quantity = quantity;
            Price = price;
        }
    }
}