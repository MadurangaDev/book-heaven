using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BookHaven.Helpers
{
    internal class Messages
    {
        public static bool ConfirmLogout()
        {
            var result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }
        public static bool ConfirmDelete(string item)
        {
            var result = MessageBox.Show("Are you sure you want to delete " + item + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        public static void NotFound(string item)
        {
            MessageBox.Show(item + " not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void Success(string task)
        {
            MessageBox.Show(task + " was successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void EmptyFields()
        {
            MessageBox.Show("Empty field(s) detected. Please fill those and try again.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void InvalidFields()
        {
            MessageBox.Show("Invalid field(s) detected. Please check those and try again.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void Duplicate(string item, string property) {
            MessageBox.Show(item + " with this " + property + " already exists. Please try again.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void InvalidCredentials()
        {
            MessageBox.Show("The credentials you entered seems to be wrong. Please try again.", "Invalid credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void DBError()
        {
            MessageBox.Show("Couldn't connect to the database. Please try again", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void UndefinedErr()
        {
            MessageBox.Show("The developer didn't handle this error. Please contact him.", "Undefined error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void PassMissMatch()
        {
            MessageBox.Show("Your password confirmation didn't match with your password.", "Password missmatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void EmailTaken()
        {
            MessageBox.Show("Your email is already registered in our system. Please try with different one.", "User ID is taken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void SomethingWrong(string task)
        {
            MessageBox.Show("Something went wrong when " + task, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void UserAdded()
        {
            MessageBox.Show("User registered successfully. Now trying to sign you in.", "Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void UserNotFound()
        {
            MessageBox.Show("Couldn't indentify user.", "Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void StockExceeded()
        {
            MessageBox.Show("You can't add more than stock amount items to your cart.", "Stock exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void ItemAlreadyAdded()
        {
            MessageBox.Show("This item is already added to your cart.", "Item already added", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void EmptyCart()
        {
            MessageBox.Show("Your cart is empty. Please add items to your cart.", "Empty cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void OrderSuccess()
        {
            MessageBox.Show("Your order has been placed successfully.", "Order Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
