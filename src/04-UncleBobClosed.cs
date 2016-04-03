using System;

namespace SolidPrinciples.OpenClosed
{
	public interface BobAccount
	{
		decimal Balance {get;}
		void Deposit (decimal amount);
		void Withdraw(decimal amount);
	}
	
	public class UncleBobAccount : BobAccount
	{
		public decimal Balance {get; private set;}

		public void Deposit (decimal amount)
		{
			Balance += amount;
		}

		public void Withdraw(decimal amount)
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

	public class UncleBobAccountExtended : BobAccount
	{
		private decimal _overdraft;
		
		public UncleBobAccountExtended(decimal overdraft)
		{
			_overdraft = overdraft;
		}

		public decimal Balance {get; private set;}

		public void Deposit (decimal amount)
		{
			Balance += amount;
		}

		public void Withdraw(decimal amount)
		{
			if (Balance - amount >= (- _overdraft))
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
