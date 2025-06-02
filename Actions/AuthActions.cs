using BookHaven.Helpers;
using System;

namespace BookHaven.Actions
{
    public class AuthActions
    {
        private DBConnect _dbConnect;

        public AuthActions()
        {
            _dbConnect = new DBConnect();
        }

    }
}
