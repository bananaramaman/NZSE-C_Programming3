using System;
using System.Collections.Generic;
using System.Text;

namespace Account
{
    public class CheckingAccount
    {
        public static void Main(string[] args)
        {
            double amount = 52.50;

            IAccount.Withdraw(amount);
        }
    }
}
