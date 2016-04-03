using System;

namespace SolidPrinciples.OpenClosed
{
	public class MeyerAccount
	{
		public decimal Balance {get; set;}

		public virtual void Deposit (decimal amount)
		{
			Balance += amount;
		}

		public virtual void Withdraw(decimal amount)
		{
			if (Balance - amount >= 0)
			{
				Balance -= amount;
			}
			else
			{
				throw new Exception("The account doesn't have enough funds");
			}
		}
	}

	public class MeyerAccountExtended : MeyerAccount
	{
		private decimal _overdraft;
		
		public MeyerAccountExtended(decimal overdraft)
		{
			_overdraft = overdraft;
		}
		
		public override void Withdraw(decimal amount)
		{
			if (Balance - amount >= -_overdraft)
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
