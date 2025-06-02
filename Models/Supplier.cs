using System;
using System.Collections.Generic;

namespace BookHaven.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            Books = new HashSet<Book>();
        }

        public int SupplierId { get; set; }
        public string SupplierName { get; set; } = null!;
        public string SupplierPhone { get; set; } = null!;
        public string SupplierEmail { get; set; } = null!;
        public string SupplierAddress { get; set; } = null!;

        public virtual ICollection<Book> Books { get; set; }
    }
}
