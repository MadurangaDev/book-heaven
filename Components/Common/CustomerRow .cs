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
    public partial class CustomerRow : UserControl
    {
        private string firstName;
        private string lastName;
        private string phone;
        private int customerId;
        public CustomerRow(string fname, string lname, string phone, int customerId)
        {
            this.firstName = fname;
            this.lastName = lname;
            this.phone = phone;
            this.customerId = customerId;
            InitializeComponent();
            lblFirstName.Text = fname;
            lblLastName.Text = lname;
            lblPhone.Text = phone;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Messages.ConfirmDelete("customer"))
            {
                BookHeavenContext db = new BookHeavenContext();
                var customer = db.Customers.FirstOrDefault(s => s.CustomerId == this.customerId);
                if (customer != null)
                {
                    db.Customers.Remove(customer);
                    db.SaveChanges();
                    Messages.Success("Customer deletion");
                    this.Parent.Controls.Remove(this);
                }
                else
                {
                    Messages.NotFound("Customer");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddNewCustomerScreen updateScreen = new AddNewCustomerScreen(this.customerId);
            updateScreen.Show();
            this.Parent.Parent.Parent.Parent.Hide(); // later dispose
        }
    }
}
