using System;
using System.Collections.Generic;

namespace BookHaven.Models
{
    public partial class InventoryRecord
    {
        public int RecordId { get; set; }
        public int BookId { get; set; }
        public int Qty { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public decimal BoughtFor { get; set; }
        public int AddedBy { get; set; }

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual Book Book { get; set; } = null!;
    }
}
