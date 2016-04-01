using System;
using System.Collections.Generic;
using System.Linq;

namespace SolidPrinciples.SingleObject
{
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

        public List<string> Address { get; }

        public void ModifyAddress(List<string> newAddress)
        {
            string[] temporal;
            newAddress.CopyTo(temporal);
            Address = temporal.ToList();
        }           
    }
}


