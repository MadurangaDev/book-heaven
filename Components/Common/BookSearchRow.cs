using BookHaven.Helpers;
using BookHaven.Models;
using BookHaven.Screens.Dashboard;
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
    public partial class BookSearchRow : UserControl
    {
        private string title;
        private string author;
        private int stockQty;
        private decimal price;
        private int id;
        private CartTab parent;

        public BookSearchRow(string title, string author, int stockQty, decimal price, int id, CartTab parent)
        {
            this.title = title;
            this.author = author;
            this.stockQty = stockQty;
            this.price = price;
            this.id = id;
            this.parent= parent;
            InitializeComponent();
            lblTitle.Text = title;
            lblAuthor.Text = author;
            lblPrice.Text = price.ToString();
            if (stockQty <= 0)
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(stockQty <= 0)
            {
                Messages.StockExceeded();
                return;
            }
            // is already added
            if (SharedVariables.cartItems.Any(x => x.id == id))
            {
                Messages.ItemAlreadyAdded();
                return;
            } 
            SharedVariables.cartItems.Add(new CartItem
            {
                Title = title,
                Qty = 1,
                stockAmount = stockQty,
                Price = price,
                id = id
            });

            // call loadCartItems method from CartTab here
            parent.loadCartItems();
        }
    }
}
