using System;
using System.Collections.Generic;
using System.Linq;

namespace SolidPrinciples.SingleObject
{
    public class AccountBase
    {
        private Guid accountHolderId;

        public AccountBase(Guid accountId)
        {
            accountHolderId = accountId;
        }

        public decimal Balance { get; private set;}

        public void Deposit(decimal money)
        {
            Balance += money;
        }

        public void Withdraw(decimal money)
        {
            Balance -= money;
        }
    }

	public class AccountHolder
    {
        public AccountHolder(string firstName, string lastName)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
        }

        public Guid Id { get;}

        public string FirstName { get; }

        public string LastName { get; }

        public List<string> Address { get; private set;}

        public void ModifyAddress(List<string> newAddress)
        {
            string[] temporal = new string[newAddress.Count];
            newAddress.CopyTo(temporal);
            Address = temporal.ToList();
        }           
    }
}

