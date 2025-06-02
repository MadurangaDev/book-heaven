using System;
using System.Collections.Generic;

namespace BookHaven.Models
{
    public partial class OrderItem
    {
        public int BookId { get; set; }
        public int OrderId { get; set; }
        public int Qty { get; set; }
        public decimal BoughtPrice { get; set; }
        public decimal Total { get; set; }

        public virtual Book Book { get; set; } = null!;
        public virtual Order Order { get; set; } = null!;
    }
}
