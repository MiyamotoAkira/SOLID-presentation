using System;

namespace SolidPrinciples.Liskov
{
	public class AccountBase
	{
		private decimal _overdraft;
		private decimal _balance;
		
		public AccountBase(decimal overdraft)
		{
			_overdraft = overdraft;
		}

		public virtual void Transfer (AccountBase account, decimal amount)
		{
			account.Deposit(amount);
			this.Withdraw(amount);
		}

		public virtual void Deposit(decimal amount)
		{
			_balance += amount;
		}

		public virtual void Withdraw(decimal amount)
		{
			_balance += amount;
		}
	}

	public class ConsoleAccount : AccountBase
	{
		public ConsoleAccount(decimal overdraft):base(overdraft){}

		public override void Transfer(AccountBase account, decimal amount)
		{
			Console.WriteLine($"We are transferring {account.ToString()}");
			base.Transfer(account, amount);
		}
	}
}


