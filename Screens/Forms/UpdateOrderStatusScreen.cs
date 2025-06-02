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
    public partial class UpdateOrderStatusScreen : Form
    {
        private int orderId;
        private void populateData()
        {
                BookHeavenContext db = new BookHeavenContext();
                var order = db.Orders.FirstOrDefault(s => s.OrderId == orderId);
                if (order != null)
                {
                    cmbBxStatus.SelectedItem = order.OrderStatus;
                }
                else
                {
                   Messages.NotFound("Order");
                }
            
        }
        public UpdateOrderStatusScreen(int orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
            populateData();

        }

        private void lbl_closeBtn_Click(object sender, EventArgs e)
        {
            DashboardLayout dash = new DashboardLayout(Tabs.Orders);
            dash.Show();
            this.Dispose();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Validations.isEmpty(
                new string[]
                {
                   cmbBxStatus.SelectedItem.ToString()
                }
                ))
            {
                Messages.EmptyFields();
            }
            else
            {
                
                    BookHeavenContext db = new BookHeavenContext();

                    // find is there is a supplier with the same phone or email
                    var availableOrder = db.Orders.FirstOrDefault(s => s.OrderId == orderId);
                if (availableOrder != null)
                {
                    availableOrder.OrderStatus = cmbBxStatus.SelectedItem.ToString();
                    db.SaveChanges();
                    Messages.Success("Order Status Updated");
                    DashboardLayout dash = new DashboardLayout(Tabs.Orders);
                    dash.Show();
                    this.Dispose();
                }
                else
                {
                    Messages.NotFound("Order");
                }


            }
        }
    }
}
