using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Helpers;
using BookHaven.Screens.Auth;

namespace BookHaven.Util
{
    public static class CommonFunctions
    {
        public static void closeBtnClick()
        {
            Application.Exit();
        }

        public static void minimizeBtnClick(Form t)
        {
            t.WindowState = FormWindowState.Minimized;
        }

        public static void logout(Form currentWindow)
        {
            // confirm logout and redirect to login screen
            if (Messages.ConfirmLogout())
            {
                // clear loged user data. and then
                LoginScreen loginScreen = new LoginScreen();
                loginScreen.Show();
                //currentWindow.Dispose();
                currentWindow.Hide();
            }
        }
    }
}
