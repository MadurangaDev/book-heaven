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
    public partial class AddNewCustomerScreen : Form
    {
        private int customerId = -1;
        private void populateData()
        {
            if (customerId == -1)
            {
                lblFormTitle.Text = "New Customer";
                btnSubmit.Text = "Add Customer";
            }
            else
            {
                lblFormTitle.Text = "Edit Customer";
                btnSubmit.Text = "Update Customer";
                txtBxPhone.Enabled = false;

                BookHeavenContext db = new BookHeavenContext();
                var customer = db.Customers.FirstOrDefault(s => s.CustomerId == customerId);
                if (customer != null)
                {
                    txtBxLastName.Text = customer.LastName;
                    txtBxPhone.Text = customer.CustomerPhone;
                    txtBxFirstName.Text = customer.FirstName;
                }
                else
                {
                   Messages.NotFound("Customer");
                }
            }
        }
        public AddNewCustomerScreen(int customerId = -1)
        {
            InitializeComponent();
            this.customerId = customerId;
            populateData();

        }

        private void lbl_closeBtn_Click(object sender, EventArgs e)
        {
            DashboardLayout dash = new DashboardLayout(Tabs.Customers);
            dash.Show();
            this.Dispose();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Validations.isEmpty(
                new string[]
                {
                   txtBxLastName.Text,
                   txtBxPhone.Text,
                   txtBxFirstName.Text
                }
                ))
            {
                Messages.EmptyFields();
            }
            else
            {
                if (!Validations.isPhone(txtBxPhone.Text))
                {
                    Messages.InvalidFields();
                }
                else
                {
                    BookHeavenContext db = new BookHeavenContext();

                    // find is there is a supplier with the same phone or email
                    var availableCustomer = db.Customers.FirstOrDefault(s => s.CustomerPhone == txtBxPhone.Text);
                    if (customerId == -1)
                    {
                        if (availableCustomer != null)
                        {
                            Messages.Duplicate("Customer", "phone or email");
                        }
                        else
                        {
                            Customer customer = new Customer()
                            {
                                CustomerPhone = txtBxPhone.Text,
                                FirstName = txtBxFirstName.Text,
                                LastName = txtBxLastName.Text,
                            };
                            db.Customers.Add(customer);
                            db.SaveChanges();
                            Messages.Success("Customer addition");
                            DashboardLayout dash = new DashboardLayout(Tabs.Customers);
                            dash.Show();
                            this.Dispose();
                        }
                    }
                    else
                    {
                        var customer = db.Customers.FirstOrDefault(s => s.CustomerId == customerId);
                        if (customer != null)
                        {
                            if (availableCustomer != null && availableCustomer.CustomerId != customerId)
                            {
                                Messages.Duplicate("Customer", "phone or email");
                            }
                            else
                            {
                                customer.FirstName = txtBxFirstName.Text;
                                customer.LastName = txtBxLastName.Text;
                                customer.CustomerPhone = txtBxPhone.Text;
                                db.SaveChanges();
                                Messages.Success("Customer update");
                                DashboardLayout dash = new DashboardLayout(Tabs.Customers);
                                dash.Show();
                                this.Dispose();
                            }
                        }
                        else
                        {
                            Messages.NotFound("Customer");
                        }
                    }
                }
            }
        }
    }
}
