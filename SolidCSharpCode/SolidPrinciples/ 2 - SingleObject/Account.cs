using System;

namespace SolidPrinciples.SingleObject
{
    public class Account
    {
        private Guid accountHolderId;

        public Account(Guid accountId)
        {
            accountHolderId = accountId;
        }

        public decimal Balance { get;}

        public void Deposit(decimal money)
        {
            Balance += money;
        }

        public void Withdraw(decimal money)
        {
            Balance -= money;
        }
    }
}

