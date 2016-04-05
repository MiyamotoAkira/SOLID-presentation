namespace SolidPrinciples.DependencyInjection
{
	public interface Account
	{
		void Deposit(decimal amount);
		void Withdraw(decimal amount);
	}
	
    public class AccountBase : Account
    {
        private decimal _overdraft;
        private decimal _balance;

        public AccountBase(decimal overdraft)
        {
            _overdraft = overdraft;
        }

        public void Deposit(decimal amount)
        {
            _balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            _balance += amount;
        }
    }

	public class LoggingAccount : Account
    {
        private decimal _overdraft;
        private decimal _balance;

        public LoggingAccount(decimal overdraft)
        {
            _overdraft = overdraft;
        }

        public void Deposit(decimal amount)
        {
            _balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            _balance += amount;
        }
    }

	public class ATM
	{
		private Account _account;
		
		public ATM (Account account)
		{
			_account = account;
		}

		public void SetAccount(Account account)
		{
			_account = account;
		}
		
		public void WithdrawOperation(decimal amount)
		{
			_account.Withdraw(amount);
		}
	}
}
