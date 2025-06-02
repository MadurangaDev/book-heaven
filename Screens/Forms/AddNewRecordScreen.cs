using BookHaven.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookHaven.Helpers;
using BookHaven.Models;
using BookHaven.Components.Layout;
using BookHaven.Enums;

namespace BookHaven.Screens.Forms
{
    public partial class AddNewRecordScreen : Form
    {
        private void loadBooks()
        {
            BookHeavenContext db = new BookHeavenContext();
            var books = db.Books.ToList();
            foreach (var book in books)
            {
                cmbBxBook.Items.Add(new { Text = $"[{book.IsbnNumber}]-{book.BookTitle}", Value = book.BookId });
            }
        }
        public AddNewRecordScreen()
        {
            InitializeComponent();
            loadBooks();

        }

        private void lbl_closeBtn_Click(object sender, EventArgs e)
        {
            DashboardLayout dash = new DashboardLayout(Tabs.Inventory);
            dash.Show();
            this.Dispose();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Validations.isEmpty(
                new string[]
                {
                   cmbBxBook.SelectedItem?.ToString()??String.Empty,
                   numBxPrice.Value.ToString(),
                   numBxQty.Value.ToString(),
                }
                ))
            {
                Messages.EmptyFields();
            }
            else
            {
                BookHeavenContext db = new BookHeavenContext();

                // add new record and update connected book's stock amount
                var record = new InventoryRecord()
                {
                    BookId = ((dynamic)cmbBxBook.SelectedItem).Value,
                    BoughtFor = numBxPrice.Value,
                    Qty = (int)numBxQty.Value,
                    AddedBy = 1,
                };
                db.InventoryRecords.Add(record);
                var book = db.Books.Find(record.BookId);
                book.StockQty += (int)numBxQty.Value;
                db.Books.Update(book);
                db.SaveChanges();
                Messages.Success("Record Added");
                DashboardLayout dash = new DashboardLayout(Tabs.Inventory);
                dash.Show();
                this.Dispose();

            }
        }
    }
}
