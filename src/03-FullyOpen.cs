using System;

namespace SolidPrinciples.OpenClosed
{
	public class Account
	{
//		private decimal _overdraft;
		
		// public Account(decimal overdraft)
		// {
		// 	_overdraft = overdraft;
		// }
		
		public decimal Balance {get; private set;}

		public virtual void Deposit (decimal amount)
		{
			Balance += amount;
		}

		public virtual void Withdraw(decimal amount)
		{
			if (Balance - amount >= 0)
//			if (Balance - amount >= -_overdraft)
			{
				Balance -= amount;
			}
			else
			{
				throw new Exception("The account doesn't have enough funds");
			}
		}
	}
}
