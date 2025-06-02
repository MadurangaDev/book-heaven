using BookHaven.Components.Common;
using BookHaven.Models;
using BookHaven.Screens.Forms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHaven.Screens.Dashboard
{
    public partial class OrdersTab : UserControl
    {
        public OrdersTab()
        {
            InitializeComponent();
            BookHeavenContext db = new BookHeavenContext();
            var orders = db.Orders.Include(r => r.Customer).ToList();
            foreach (var order in orders)
            {
                int i = pnlItemsContainer.Controls.Count;
                OrderRow orderRow = new OrderRow(order.OrderId, order.Customer!=null?$"{order.Customer.FirstName} {order.Customer.LastName}":"-", order.CreatedAt ?? DateTime.MinValue, order.TotalPrice, order.OrderStatus);
                orderRow.Location = new Point(0, i * 45);
                pnlItemsContainer.Controls.Add(orderRow);
            }
        }
    }
}
