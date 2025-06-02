using System;
using System.Collections.Generic;

namespace BookHaven.Models
{
    public partial class Book
    {
        public Book()
        {
            InventoryRecords = new HashSet<InventoryRecord>();
            OrderItems = new HashSet<OrderItem>();
        }

        public int BookId { get; set; }
        public string IsbnNumber { get; set; } = null!;
        public string BookTitle { get; set; } = null!;
        public string BookAuthor { get; set; } = null!;
        public string Genre { get; set; } = null!;
        public decimal Price { get; set; }
        public int StockQty { get; set; }
        public int SupplierId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int AddedBy { get; set; }

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual Supplier Supplier { get; set; } = null!;
        public virtual ICollection<InventoryRecord> InventoryRecords { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
