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
    public partial class AddNewSupplierScreen : Form
    {
        private int supplierId = -1;
        private void populateData()
        {
            if (supplierId == -1)
            {
                lblFormTitle.Text = "New Supplier";
                btnSubmit.Text = "Add Supplier";
            }
            else
            {
                lblFormTitle.Text = "Edit Supplier";
                btnSubmit.Text = "Update Supplier";
                txtBxEmail.Enabled = false;
                txtBxPhone.Enabled = false;

                BookHeavenContext db = new BookHeavenContext();
                var supplier = db.Suppliers.FirstOrDefault(s => s.SupplierId == supplierId);
                if (supplier != null)
                {
                    txtBxPhone.Text = supplier.SupplierPhone;
                    txtBxEmail.Text = supplier.SupplierEmail;
                    txtBxName.Text = supplier.SupplierName;
                    txtBxAddress.Text = supplier.SupplierAddress;
                }
                else
                {
                   Messages.NotFound("Supplier");
                }
            }
        }
        public AddNewSupplierScreen(int supplierId = -1)
        {
            InitializeComponent();
            this.supplierId = supplierId;
            populateData();

        }

        private void lbl_closeBtn_Click(object sender, EventArgs e)
        {
            DashboardLayout dash = new DashboardLayout(Tabs.Suppliers);
            dash.Show();
            this.Dispose();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Validations.isEmpty(
                new string[]
                {
                   txtBxPhone.Text,
                   txtBxEmail.Text,
                   txtBxName.Text,
                   txtBxAddress.Text
                }
                ))
            {
                Messages.EmptyFields();
            }
            else
            {
                if (!Validations.isEmail(txtBxEmail.Text) || !Validations.isPhone(txtBxPhone.Text))
                {
                    Messages.InvalidFields();
                }
                else
                {
                    BookHeavenContext db = new BookHeavenContext();

                    // find is there is a supplier with the same phone or email
                    var availableSupplier = db.Suppliers.FirstOrDefault(s => s.SupplierPhone == txtBxPhone.Text || s.SupplierEmail == txtBxEmail.Text);
                    if (supplierId == -1)
                    {
                        if (availableSupplier != null)
                        {
                            Messages.Duplicate("Supplier", "phone or email");
                        }
                        else
                        {
                            Supplier supplier = new Supplier()
                            {
                                SupplierName = txtBxName.Text,
                                SupplierPhone = txtBxPhone.Text,
                                SupplierEmail = txtBxEmail.Text,
                                SupplierAddress = txtBxAddress.Text
                            };
                            db.Suppliers.Add(supplier);
                            db.SaveChanges();
                            Messages.Success("Supplier addition");
                            DashboardLayout dash = new DashboardLayout(Tabs.Suppliers);
                            dash.Show();
                            this.Dispose();
                        }
                    }
                    else
                    {
                        var supplier = db.Suppliers.FirstOrDefault(s => s.SupplierId == supplierId);
                        if (supplier != null)
                        {
                            if (availableSupplier != null && availableSupplier.SupplierId != supplierId)
                            {
                                Messages.Duplicate("Supplier", "phone or email");
                            }
                            else
                            {
                                supplier.SupplierName = txtBxName.Text;
                                supplier.SupplierPhone = txtBxPhone.Text;
                                supplier.SupplierEmail = txtBxEmail.Text;
                                supplier.SupplierAddress = txtBxAddress.Text;
                                db.SaveChanges();
                                Messages.Success("Supplier update");
                                DashboardLayout dash = new DashboardLayout(Tabs.Suppliers);
                                dash.Show();
                                this.Dispose();
                            }
                        }
                        else
                        {
                            Messages.NotFound("Supplier");
                        }
                    }
                }
            }
        }
    }
}
