using BookHaven.Components.Common;
using BookHaven.Models;
using BookHaven.Screens.Forms;
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
    public partial class BooksTab : UserControl
    {
        public BooksTab()
        {
            InitializeComponent();
            BookHeavenContext db = new BookHeavenContext();
            var books = db.Books.ToList();
            foreach (var book in books)
            {
                int i = pnlItemsContainer.Controls.Count;
                BookRow bookRow = new BookRow(book.BookTitle, book.BookAuthor, book.IsbnNumber, book.Genre, book.StockQty, book.Price, book.BookId);
                bookRow.Location = new Point(0, i * 45);
                pnlItemsContainer.Controls.Add(bookRow);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewBookScreen addNewBookScreen = new AddNewBookScreen();
            addNewBookScreen.Show();
            this.Parent.Parent.Hide(); // later dispose
        }
    }
}
