using System.Collections.Generic;

namespace SolidPrinciples.DependencyInjectionA
{
	public static class ServiceLocator
	{
		private static Dictionary<string, object> _services;
		
		static ServiceLocator()
		{
			_services = new Dictionary<string, object>();
		}

		public static void AddService(string key, object service)
		{
			_services.Add(key, service);
		}

		public static object Retrieve(string key)
		{
			return _services[key];
		}
	}
	
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
		
		public ATM ()
		{
			_account = ServiceLocator.Retrieve("account") as Account;
		}

		public void WithdrawOperation(decimal amount)
		{
			_account.Withdraw(amount);
		}
	}
}
