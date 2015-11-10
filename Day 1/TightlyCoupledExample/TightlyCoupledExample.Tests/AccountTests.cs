using ApprovalTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TightlyCoupledExample.Tests
{
	[TestClass]
	public class AccountTests
	{
		[TestMethod]
		//[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void Credit_WhenCalled_IncreasesAccountBalance()
		{
			//Arrange
			decimal creditAmount = 100m;
			decimal initialBalance = 50m;
			var account = new Account(initialBalance);

			//Act
			account.Credit(creditAmount);

			//Assert
			var expected = initialBalance + creditAmount;

			Assert.AreEqual(expected,account.Balance);
		}

		[TestMethod]
		public void Credit_WhenCalled_IncreaseBalanceAndSetsTransactionDate()
		{
			//Arrange
			decimal creditAmount = 100m;
			decimal initialBalance = 50m;
			var account = new Account(initialBalance);

			TimeProvider.Current = new MockTimeProvider();
			
			//Act
			account.Credit(creditAmount);

			//Assert
			Approvals.Verify(account);
		}
	}
}
