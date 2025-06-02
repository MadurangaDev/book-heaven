using System;
using System.Collections.Generic;

namespace BookHaven.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public decimal TotalPrice { get; set; }
        public string OrderStatus { get; set; } = null!;
        public int PlacedBy { get; set; }
        public string OrderType { get; set; } = null!;
        public int DeliveryCost { get; set; }
        public string? DeliveryAddress { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual User PlacedByNavigation { get; set; } = null!;
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
