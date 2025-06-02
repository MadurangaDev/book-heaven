using BookHaven.Helpers;
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

namespace BookHaven.Components.Common
{
    public partial class BookRow : UserControl
    {
        private string title;
        private string author;
        private string ISBN;
        private string genre;
        private int qty;
        private decimal price;
        private int id;

        public BookRow(string title, string author, string ISBN, string Genre, int qty, decimal price, int id)
        {
            this.title = title;
            this.author = author;
            this.ISBN = ISBN;
            this.genre = Genre;
            this.qty = qty;
            this.price = price;
            this.id = id;
            InitializeComponent();
            lblTitle.Text = title;
            lblAuthor.Text = author;
            lblSBN.Text = ISBN;
            lblGenre.Text = Genre;
            lblQuantity.Text = qty.ToString();
            lblPrice.Text = price.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Messages.ConfirmDelete("book"))
            {
                BookHeavenContext db = new BookHeavenContext();
                var book = db.Books.FirstOrDefault(b => b.BookId == this.id);
                if (book != null)
                {
                    db.Books.Remove(book);
                    db.SaveChanges();
                    Messages.Success("Book deletion");
                    this.Parent.Controls.Remove(this);
                }
                else
                {
                    Messages.NotFound("Book");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddNewBookScreen updateScreen = new AddNewBookScreen(this.id);
            updateScreen.Show();
            this.Parent.Parent.Parent.Parent.Hide(); // later dispose
        }
    }
}
