using BookHaven.Screens;
using Microsoft.EntityFrameworkCore;
using BookHaven.Models;
using BookHaven.Screens.Auth;
using BookHaven.Components.Layout;
using BookHaven.Screens.Forms;

namespace BookHaven
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            //// Setup your DbContext options with your connection string
            //var optionsBuilder = new DbContextOptionsBuilder<BookHeavenContext>();
            //optionsBuilder.UseMySql("server=localhost;user=root;password=;database=book_heaven",
            //    ServerVersion.AutoDetect("server=localhost;user=root;password=;database=book_heaven"));

            //// Instantiate your DbContext with options
            //using (var context = new BookHeavenContext(optionsBuilder.Options))
            //{
            //    // Perform any startup actions with the DbContext if needed
            //}

            ApplicationConfiguration.Initialize();
            //Application.Run(new DashboardLayout());
            Application.Run(new LoadingScreen());
        }
    }
}