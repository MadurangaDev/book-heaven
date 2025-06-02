using BookHaven.Models;
using BookHaven.Helpers;
using BookHaven.Screens.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHaven.Screens
{
    public partial class LoadingScreen : Form
    {
        private System.Windows.Forms.Timer animationTimer;
        private int targetWidth = 960; // Final width for the panel
        private int animationSpeed = 10; // Speed of the animation (pixels per tick)

        private bool connectionChecked = false; // To check DB connection only once

        public LoadingScreen()
        {
            InitializeComponent();

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            animationTimer = new System.Windows.Forms.Timer
            {
                Interval = 50 // Set interval to 10ms (you can adjust this)
            };
            animationTimer.Tick += (sender, e) =>
            {
                // Gradually increase the panel's width
                if (pnl_loader.Width < targetWidth)
                {
                    pnl_loader.Width += animationSpeed;

                    // When halfway, check database connection
                    if (pnl_loader.Width >= targetWidth / 2 && !connectionChecked)
                    {
                        connectionChecked = true;

                        // Run database check synchronously on the UI thread
                        bool dbConnected = CheckDatabaseConnection();

                        if (!dbConnected)
                        {
                            // Stop the animation immediately
                            animationTimer.Stop();

                            Messages.DBError();

                            Application.Exit(); // Close the application
                        }
                    }
                }
                else
                {
                    // Stop the animation once the target width is reached
                    animationTimer.Stop();

                    // Show the login screen if the database check passed
                    if (connectionChecked)
                    {
                        LoginScreen loginScreen = new LoginScreen();
                        loginScreen.Show();
                        this.Hide();
                    }
                }
            };



            // Start the animation when the form loads
            animationTimer.Start();
        }


        private bool CheckDatabaseConnection()
        {
            try
            {
                using (var context = new BookHeavenContext())
                {
                    return context.Database.CanConnect();
                }
            }
            catch
            {
                return false;
            }
        }

    }
}
