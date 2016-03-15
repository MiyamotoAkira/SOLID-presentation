using System;
using System.Collections.Generic;
using System.Linq;

namespace NotSingleObject
{
    public class AllMixed
    {
        public AllMixed(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName {get;}
        public string LastName {get;}
        public List<string> Address {get;}
        public decimal Balance {get;}


        public void ModifyAddress (List<string> newAddress)
        {
            string[] temporal;
            newAddress.CopyTo(temporal);
            Address = temporal.ToList();
        }

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

