using System;
using System.Collections.Generic;

namespace BookHaven.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int CustomerId { get; set; }
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
        public string CustomerPhone { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
