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
    public partial class SuppliersTab : UserControl
    {
        public SuppliersTab()
        {
            InitializeComponent();
            BookHeavenContext db = new BookHeavenContext();
            var suppliers = db.Suppliers.ToList();
            foreach (var supplier in suppliers)
            {
                int i = pnlItemsContainer.Controls.Count;
                SuppplierRow supplierRow = new SuppplierRow(supplier.SupplierName, supplier.SupplierPhone, supplier.SupplierEmail, supplier.SupplierAddress, supplier.SupplierId);
                supplierRow.Location = new Point(0, i * 45);
                pnlItemsContainer.Controls.Add(supplierRow);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewSupplierScreen addNewSupplierScreen = new AddNewSupplierScreen();
            addNewSupplierScreen.Show();
            this.Parent.Parent.Hide(); // later dispose
        }
    }
}
