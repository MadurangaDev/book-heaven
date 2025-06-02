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
using BookHaven.Components.Layout;
using BookHaven.Enums;
using BookHaven.Models;

namespace BookHaven.Screens.Forms
{
    public partial class AddNewBookScreen : Form
    {
        private int bookId = -1;
        private void populateData()
        {
            if (bookId == -1)
            {
                lblFormTitle.Text = "Add New Book";
                btnSubmit.Text = "Add Book";
            }
            else
            {
                lblFormTitle.Text = "Edit Book";
                btnSubmit.Text = "Update Book";
                txtBxISBN.Enabled = false;

                BookHeavenContext db = new BookHeavenContext();
                var book = db.Books.FirstOrDefault(b => b.BookId == bookId);
                if (book != null)
                {
                    txtBxTitle.Text = book.BookTitle;
                    txtBxAuthor.Text = book.BookAuthor;
                    txtBxISBN.Text = book.IsbnNumber;
                    foreach (var item in cmbBxSuppliers.Items)
                    {
                        var supplier = (dynamic)item;
                        if (supplier.Value == book.SupplierId)
                        {
                            cmbBxSuppliers.SelectedItem = item;
                            break;
                        }
                    }
                    numBxPrice.Value = book.Price;
                    cmbBxGenre.SelectedItem = book.Genre;
                }
                else
                {
                    Messages.NotFound("Book");
                }
            }
        }
        private void populateSuppliers()
        {
            BookHeavenContext db = new BookHeavenContext();
            var suppliers = db.Suppliers.ToList();
            foreach (var supplier in suppliers)
            {
                cmbBxSuppliers.Items.Add(new { Text = supplier.SupplierName, Value = supplier.SupplierId });
            }
        }
        public AddNewBookScreen(int bookId = -1)
        {
            InitializeComponent();
            this.bookId = bookId;
            populateSuppliers();
            populateData();

        }

        private void lbl_closeBtn_Click(object sender, EventArgs e)
        {
            DashboardLayout dash = new DashboardLayout(Tabs.Books);
            dash.Show();
            this.Dispose();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Validations.isEmpty(
                new string[]
                {
                   txtBxTitle.Text,
                   txtBxAuthor.Text,
                   txtBxISBN.Text,
                   cmbBxSuppliers.SelectedItem?.ToString() ?? string.Empty, // Fix for CS8602  
                   cmbBxGenre.SelectedItem?.ToString() ?? string.Empty,    // Fix for CS8602  
                }
                ))
            {
                Messages.EmptyFields();
            }
            else
            {
                BookHeavenContext db = new BookHeavenContext();
                var availableBook = db.Books.FirstOrDefault(b => b.IsbnNumber == txtBxISBN.Text);
                if (bookId == -1)
                {
                    if (availableBook != null)
                    {
                        Messages.Duplicate("Book", "ISBN number");
                    }
                    else
                    {
                        int supplierId = ((dynamic)cmbBxSuppliers.SelectedItem).Value;
                        Book newBook = new Book()
                        {
                            BookTitle = txtBxTitle.Text,
                            BookAuthor = txtBxAuthor.Text,
                            IsbnNumber = txtBxISBN.Text,
                            SupplierId = ((dynamic)cmbBxSuppliers.SelectedItem).Value,
                            Genre = cmbBxGenre.SelectedItem?.ToString() ?? string.Empty,
                            Price = numBxPrice.Value,
                            StockQty = 0,
                            AddedBy = 1,
                            Supplier = db.Suppliers.FirstOrDefault(s => s.SupplierId == supplierId)
                        };
                        db.Books.Add(newBook);
                        db.SaveChanges();
                        Messages.Success("Book addition");
                        DashboardLayout dash = new DashboardLayout(Tabs.Books);
                        dash.Show();
                        this.Dispose();
                    }
                }
                else
                {
                    var book = db.Books.FirstOrDefault(b => b.BookId == bookId);
                    if (book != null)
                    {
                        if (availableBook != null && availableBook.BookId != bookId)
                        {
                            Messages.Duplicate("Book", "ISBN number");
                        }
                        else
                        {
                            book.BookTitle = txtBxTitle.Text;
                            book.BookAuthor = txtBxAuthor.Text;
                            book.IsbnNumber = txtBxISBN.Text;
                            book.SupplierId = ((dynamic)cmbBxSuppliers.SelectedItem).Value;
                            book.Genre = cmbBxGenre.SelectedItem.ToString();
                            book.Price = numBxPrice.Value;
                            db.SaveChanges();
                            Messages.Success("Book update");
                            DashboardLayout dash = new DashboardLayout(Tabs.Books);
                            dash.Show();
                            this.Dispose();
                        }
                    }
                    else
                    {
                        Messages.NotFound("Book");
                    }
                }
            }
        }
    }
}
