namespace SolidPrinciples.SegregatedInterface
{
    public interface WithdrawAccount
    {
        void Withdraw(decimal amount);
    }

	public interface DepositAccount
	{
		void Deposit(decimal amount);
	}

    public class AccountBase : WithdrawAccount, DepositAccount
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

	public class ATM
	{
		private WithdrawAccount _account;
		
		public ATM (WithdrawAccount account)
		{
			_account = account;
		}

		public void WithdrawOperation(decimal amount)
		{
			_account.Withdraw(amount);
		}
	}
}
