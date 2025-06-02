using BookHaven.Screens.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Helpers
{
    public static class SharedVariables
    {
        public static List<CartItem> cartItems = new List<CartItem>();
        public static bool isAdmin = false;
    }
}
