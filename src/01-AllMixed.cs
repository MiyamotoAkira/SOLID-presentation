using System;
using System.Collections.Generic;
using System.Linq;

namespace SolidPrinciples.NoSingleObject
{
    public class AllMixed
    {
        public AllMixed(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName {get; private set;}
        public string LastName {get; private set;}
        public List <string> Address {get; private set;}
        public decimal Balance {get; private set;}


        public void ModifyAddress (List<string> newAddress)
        {
            string[] temporal = null;
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
