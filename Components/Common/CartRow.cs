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
    public partial class CartRow : UserControl
    {
        private string title;
        private int qty;
        private int stockQty;
        private decimal price;
        private int id;
        private CartTab parent;

        public CartRow(string title, int qty, int stockQty, decimal price, int id, CartTab parent)
        {
            this.title = title;
            this.qty = qty;
            this.stockQty = stockQty;
            this.price = price;
            this.id = id;
            this.parent = parent;
            InitializeComponent();
            lblTitle.Text = title;
            lblQty.Text = qty.ToString();
            lblPrice.Text = price.ToString();
            lblTotal.Text = (qty * price).ToString();
            if(qty >= stockQty)
            {
                button1.Enabled = false;
            }
            //if(qty <= 1)
            //{
            //    button2.Enabled = false;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (qty <= 1)
            {
                if (Messages.ConfirmDelete("cart item"))
                {
                    // delete from cart    
                    SharedVariables.cartItems = SharedVariables.cartItems
                        .Where(x => x.id != id)
                        .ToList();
                }
            }
            else
            {
                // decrease qty    
                SharedVariables.cartItems
                    .Where(x => x.id == id)
                    .ToList()
                    .ForEach(x => x.Qty--);
            }
            parent.loadCartItems();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (qty >= stockQty)
            {
                Messages.StockExceeded();
            }
            else
            {
                SharedVariables.cartItems = SharedVariables.cartItems
                    .Where(x => x.id == id)
                    .Select(x => { x.Qty++; return x; })
                    .ToList();
            }
            parent.loadCartItems();
        }
    }
}