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
    public partial class SuppplierRow : UserControl
    {
        private string name;
        private string phone;
        private string email;
        private string address;
        private int supplierId;
        public SuppplierRow(string name, string phone, string email, string address, int supplierId)
        {
            this.name = name;
            this.phone = phone;
            this.email = email;
            this.address = address;
            this.supplierId = supplierId;
            InitializeComponent();
            lblName.Text = this.name;
            lblPhone.Text = this.phone;
            lblEmail.Text = this.email;
            lblAddress.Text = this.address;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Messages.ConfirmDelete("supplier"))
            {
                BookHeavenContext db = new BookHeavenContext();
                var supplier = db.Suppliers.FirstOrDefault(s => s.SupplierId == this.supplierId);
                if (supplier != null)
                {
                    db.Suppliers.Remove(supplier);
                    db.SaveChanges();
                    Messages.Success("Supplier deletion");
                    this.Parent.Controls.Remove(this);
                }
                else
                {
                    Messages.NotFound("Supplier");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddNewSupplierScreen updateScreen = new AddNewSupplierScreen(this.supplierId);
            updateScreen.Show();
            this.Parent.Parent.Parent.Parent.Hide(); // later dispose
        }
    }
}
