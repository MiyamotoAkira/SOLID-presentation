namespace SolidPrinciples.AllDependencies
{
    public class AccountBase
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

	public class LoggingAccount
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
		private AccountBase _account;
		
		public ATM ()
		{
			_account = new AccountBase(100);
		}

		public void WithdrawOperation(decimal amount)
		{
			_account.Withdraw(amount);
		}
	}
}
