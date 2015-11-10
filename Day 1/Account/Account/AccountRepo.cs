using System;

namespace Account
{
	public class AccountRepo
	{
		private readonly string connectionString;

		public AccountRepo(string connectionString)
		{
			this.connectionString = connectionString;
		}

		public decimal Balance { get; set; }
		public decimal Deposit(decimal depositAmount)
		{
			return Balance += depositAmount;
		}

		public decimal Withdraw(decimal withdrawlAmount)
		{
			if (Balance <= 0)
				throw new ArgumentOutOfRangeException();

			return Balance -= withdrawlAmount;
		}
	}
}