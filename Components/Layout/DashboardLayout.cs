using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookHaven.Assets.Data;
using BookHaven.Enums;
using BookHaven.Helpers;
using BookHaven.Screens.Auth;
using BookHaven.Screens.Dashboard;
using BookHaven.Util;

namespace BookHaven.Components.Layout
{
    public partial class DashboardLayout : Form
    {
        // default constructor
        public DashboardLayout(Tabs tab = Tabs.None)
        {
            InitializeComponent();
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;

            if (tab == Tabs.Cart || tab == Tabs.None)
            {
                switchTab(new CartTab());
            }
            else if (tab == Tabs.Orders)
            {
                switchTab(new OrdersTab());
            }
            else if (tab == Tabs.Inventory)
            {
                switchTab(new InventoryTab());
            }
            else if (tab == Tabs.Customers)
            {
                switchTab(new CustomersTab());
            }
            else if (tab == Tabs.Suppliers)
            {
                switchTab(new SuppliersTab());
            }
            else
            {
                switchTab(new BooksTab());
            }
            if (SharedVariables.isAdmin)
            {
                panel4.Visible = true;
                panel5.Visible = true;
                panel6.Visible = true;
            }
            else
            {
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
            }
        }

        private void lbl_closeBtn_Click(object sender, EventArgs e)
        {
            CommonFunctions.closeBtnClick();
        }

        private void lbl_minimizeBtn_Click(object sender, EventArgs e)
        {
            CommonFunctions.minimizeBtnClick(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CommonFunctions.logout(this);
        }
        private void switchTab(UserControl userControl)
        {
            pnlTabContainer.Controls.Clear();
            pnlTabContainer.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
        }


        private void label3_Click(object sender, EventArgs e)
        {
            switchTab(new OrdersTab());
        }

        private void label5_Click(object sender, EventArgs e)
        {
            switchTab(new CustomersTab());
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            switchTab(new CartTab());
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            switchTab(new InventoryTab());
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            switchTab(new BooksTab());
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            switchTab(new InventoryTab());
        }

        private void panel5_Paint(object sender, EventArgs e)
        {
            switchTab(new SuppliersTab());
        }
    }
}
