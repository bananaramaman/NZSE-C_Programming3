using System;
using System.Collections.Generic;
using System.Text;

namespace Account
{
    public class IAccount
    {
        public static void Withdraw(double amount)
        {
            double m_balance = 1356.89;
            if (m_balance >= amount)
            {
                m_balance -= amount;
            }
            else
            {
                throw new ArgumentException(nameof(amount), "Withdrawal exceeds balance!");
            }

            Console.WriteLine(m_balance);
        }
    }
}
