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
    public partial class CustomersTab : UserControl
    {
        public CustomersTab()
        {
            InitializeComponent();
            BookHeavenContext db = new BookHeavenContext();
            var customers = db.Customers.ToList();
            foreach (var customer in customers)
            {
                int i = pnlItemsContainer.Controls.Count;
                CustomerRow customerRow = new CustomerRow(customer.FirstName, customer.LastName, customer.CustomerPhone, customer.CustomerId);
                customerRow.Location = new Point(0, i * 45);
                pnlItemsContainer.Controls.Add(customerRow);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewCustomerScreen addNewCustomerScreen = new AddNewCustomerScreen();
            addNewCustomerScreen.Show();
            this.Parent.Parent.Hide(); // later dispose
        }
    }
}
