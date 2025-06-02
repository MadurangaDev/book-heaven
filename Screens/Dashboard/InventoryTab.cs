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
    public partial class InventoryTab : UserControl
    {
        public InventoryTab()
        {
            InitializeComponent();
            BookHeavenContext db = new BookHeavenContext();
            var records = db.InventoryRecords.Include(r => r.Book).ToList();
            foreach (var record in records)
            {
                int i = pnlItemsContainer.Controls.Count;
                InventoryRow recordRow = new InventoryRow(record.Book.BookTitle, record.Qty, record.BoughtFor, record.CreatedAt ?? DateTime.MinValue);
                recordRow.Location = new Point(0, i * 45);
                pnlItemsContainer.Controls.Add(recordRow);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewRecordScreen addNewRecordScreen = new AddNewRecordScreen();
            addNewRecordScreen.Show();
            this.Parent.Parent.Hide(); // later dispose  
        }
    }
}
