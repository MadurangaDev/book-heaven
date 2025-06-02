using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookHaven.Components.Layout;
using BookHaven.Enums;
using BookHaven.Helpers;
using BookHaven.Util;
using BCrypt.Net;
using BookHaven.Models;

namespace BookHaven.Screens.Auth
{
    public partial class LoginScreen : Form
    {
        
        private UserRole loginType = UserRole.CASHIER;

        private void changeLoginType(UserRole type)
        {
            loginType = type;
            if (type == UserRole.ADMIN)
            {
                btn_adminTypeBtn.BackColor = Color.White;
                btn_cashierTypeBtn.BackColor = Colors.backShadeGrey;
                btn_adminTypeBtn.ForeColor = Colors.text;
                btn_cashierTypeBtn.ForeColor = Colors.textSecondary;
            }
            else
            {
                btn_cashierTypeBtn.BackColor = Color.White;
                btn_adminTypeBtn.BackColor = Colors.backShadeGrey;
                btn_cashierTypeBtn.ForeColor = Colors.text;
                btn_adminTypeBtn.ForeColor = Colors.textSecondary;
            }
        }

        public LoginScreen()
        {
            InitializeComponent();
        }

        public void lbl_closeBtn_Click(object sender, EventArgs e)
        {
            CommonFunctions.closeBtnClick();
        }

        public void lbl_minimizeBtn_Click(object sender, EventArgs e)
        {
            CommonFunctions.minimizeBtnClick(this);
        }

        private void btn_cashierTypeBtn_Click(object sender, EventArgs e)
        {
            changeLoginType(UserRole.CASHIER);
        }

        private void btn_adminTypeBtn_Click(object sender, EventArgs e)
        {
            changeLoginType(UserRole.ADMIN);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (Validations.isEmpty(new string[] { txtbx_Pass.Text, txtbx_email.Text }))
            {
                Messages.EmptyFields();
            }
            else
            {
                BookHeavenContext context = new BookHeavenContext();
                var user = context.Users.FirstOrDefault(user => user.UserEmail == txtbx_email.Text && user.UserType == (loginType == UserRole.CASHIER ? "CASHIER" : "ADMIN"));
                if (user != null)
                {

                    if (BCrypt.Net.BCrypt.Verify(txtbx_Pass.Text, user.PasswordHash))
                    {
                        SharedVariables.isAdmin = user.UserType == "ADMIN";
                        DashboardLayout dashboardLayout = new DashboardLayout();
                        dashboardLayout.Show();
                        this.Hide();
                    }
                    else
                    {
                        Messages.InvalidCredentials();
                    }
                }
                else
                {
                    Messages.InvalidCredentials();
                }
            }
        }
    }
}
