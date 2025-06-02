using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Helpers
{
    public static class Validations
    {
        public static bool isEmpty(string[] array)
        {
            foreach (var item in array)
            {
                if (string.IsNullOrWhiteSpace(item))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool isEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }
            else
            {
                return System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            }
        }
        public static bool isPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
            {
                return false;
            }
            else
            {
                return System.Text.RegularExpressions.Regex.IsMatch(phone, @"^0\d{9}$");
            }
        }
    }
}
