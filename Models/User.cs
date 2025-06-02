using System;
using System.Collections.Generic;

namespace BookHaven.Models
{
    public partial class User
    {
        public User()
        {
            Books = new HashSet<Book>();
            InventoryRecords = new HashSet<InventoryRecord>();
            Orders = new HashSet<Order>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
        public string UserEmail { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string UserPhone { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public string UserType { get; set; } = null!;

        public virtual ICollection<Book> Books { get; set; }
        public virtual ICollection<InventoryRecord> InventoryRecords { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
