using System;

namespace TightlyCoupledExample
{
	public class Account
	{
		public Account(decimal initialBalance)
		{
			Balance = initialBalance;
		}

		public void Credit(decimal creditAmount)
		{
			if (creditAmount < 0)
				throw new ArgumentOutOfRangeException();
			 
			Balance += creditAmount;
			LastTransactionDate = TimeProvider.Current.UtcNow;
		}

		public decimal Balance { get; private set; }
		public DateTime LastTransactionDate { get; private set; }
		public override string ToString()
		{
			return string.Format("Balance: {0}, LastTransactionDate: {1}", Balance,LastTransactionDate);
		}
	}
}