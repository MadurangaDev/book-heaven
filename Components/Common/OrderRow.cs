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
    public partial class OrderRow : UserControl
    {
        private int id;
        private string customer;
        private DateTime date;
        private decimal total;
        private string status;
        public OrderRow(int id, string customer, DateTime date, decimal total, string status)
        {
            this.id = id;
            this.customer = customer;
            this.date = date;
            this.total = total;
            this.status = status;
            InitializeComponent();
            lblOrderId.Text = id.ToString();
            lblCustomer.Text = customer;
            lblDate.Text = date.ToString("dd/MM/yyyy");
            lblTotal.Text = $"{total.ToString()} LKR";
            lblStatus.Text = status;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            UpdateOrderStatusScreen updateScreen = new UpdateOrderStatusScreen(this.id);
            updateScreen.Show();
            this.Parent.Parent.Parent.Parent.Hide(); // later dispose
        }
    }
}
