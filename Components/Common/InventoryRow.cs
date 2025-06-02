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
    public partial class InventoryRow : UserControl
    {
        private string bookTitle;
        private int qty;
        private decimal boughtFor;
        private DateTime date;

        public InventoryRow(string bookTitle, int qty, decimal boughtFor, DateTime date)
        {
            this.bookTitle = bookTitle;
            this.qty = qty;
            this.boughtFor = boughtFor;
            this.date = date;
            InitializeComponent();
            lblTitle.Text = bookTitle;
            lblQty.Text = qty.ToString();
            lblPrice.Text = $"{boughtFor.ToString()} LKR";
            lblDate.Text = date.ToString("dd/MM/yyyy");
        }
    }
}
