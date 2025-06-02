using BookHaven.Components.Common;
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

namespace BookHaven.Screens.Dashboard
{
    public partial class CartTab : UserControl
    {
        private void loadBooks(string query = "")
        {
            pnlItemsContainer.Controls.Clear(); // clear previous search results
            BookHeavenContext db = new BookHeavenContext();
            //var books = db.Books.ToList();
            var books = db.Books
                .Where(b => b.BookTitle.Contains(query) || b.BookAuthor.Contains(query) || b.IsbnNumber.Contains(query))
                .ToList();
            foreach (var book in books)
            {
                int i = pnlItemsContainer.Controls.Count;
                BookSearchRow row = new BookSearchRow(book.BookTitle, book.BookAuthor, book.StockQty, book.Price, book.BookId, this);
                row.Location = new Point(0, i * 45);
                pnlItemsContainer.Controls.Add(row);
            }
        }
        private void loadCustomers()
        {
            BookHeavenContext db = new BookHeavenContext();
            var customers = db.Customers.ToList();
            foreach (var customer in customers)
            {
                cmbBxCustomer.Items.Add(new { Text = $"{customer.FirstName} {customer.LastName}", Value = customer.CustomerId });
            }
        }

        public void loadCartItems()
        {
            pnlCartContainer.Controls.Clear(); // <- This line is necessary to refresh the UI

            foreach (var cartItem in SharedVariables.cartItems)
            {
                int i = pnlCartContainer.Controls.Count;
                CartRow row = new CartRow(cartItem.Title, cartItem.Qty, cartItem.stockAmount, cartItem.Price, cartItem.id, this);
                row.Location = new Point(0, i * 45);
                pnlCartContainer.Controls.Add(row);
            }
            lblTotal.Text = $"LKR {SharedVariables.cartItems.Sum(x => x.Price * x.Qty).ToString()}";
        }
        public CartTab()
        {
            InitializeComponent();
            loadCustomers();
            loadBooks();
            loadCartItems();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewCustomerScreen addNewCustomerScreen = new AddNewCustomerScreen();
            addNewCustomerScreen.Show();
            this.Parent.Parent.Hide(); // later dispose
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only if enter pressed
            if (e.KeyChar == (char)Keys.Enter)
            {
                loadBooks(txtBxSearch.Text);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // check is cart empty    
            if (SharedVariables.cartItems.Count == 0)
            {
                Messages.EmptyCart();
                return;
            }

            BookHeavenContext db = new BookHeavenContext();

            // add order    
            Order order = new Order
            {
                CustomerId = cmbBxCustomer.SelectedItem != null
        ? (int)((dynamic)cmbBxCustomer.SelectedItem).Value
        : null,
                DeliveryAddress = !Validations.isEmpty(new string[] { txtBxAddress.Text })
        ? txtBxAddress.Text
        : null,
                TotalPrice = SharedVariables.cartItems.Sum(x => x.Price * x.Qty),
                OrderStatus = !Validations.isEmpty(new string[] { txtBxAddress.Text })
        ? "Processing" : "Pending",
                DeliveryCost = (int)numBxFee.Value,
                OrderType = !Validations.isEmpty(new string[] { txtBxAddress.Text })
        ? "DELIVERY" : "PICKUP",
                PlacedBy = 1 // <- Set this to the logged-in user ID
            };


            db.Orders.Add(order);
            db.SaveChanges();

            Messages.OrderSuccess(); // Ensure this method exists in the Messages class  
        }
    }
    public class CartItem
    {
        public string Title { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }

        public int stockAmount { get; set; }

        public int id { get; set; }
    }
}
