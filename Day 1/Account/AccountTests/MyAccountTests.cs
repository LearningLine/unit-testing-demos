using System;
using Account;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AccountTests
{
	[TestClass]
	public class MyAccountTests
	{
		[TestMethod]
		public void OpeningNewAccount_ShouldStartWith_100Balance()
		{
			var acc = new MyAccount(new MockAccountRepo());

			Assert.AreEqual(100,acc.Balance);
		}

		[TestMethod]
		public void Desposit_ShouldIncreaseBalance()
		{
			//Arrange
			var acc = new MyAccount(new MockAccountRepo());

			//Act
			var startingBalance = acc.Balance;
			var newBalance = acc.Deposit(100);
			//Assert

			Assert.AreEqual(startingBalance + 100, newBalance);
		}
	}

	public class MockAccountRepo : IAccountRepo
	{
		public decimal Deposit(int depositAmount)
		{
			throw new NotImplementedException();
		}

		public decimal Withdraw(int withdrawAmount)
		{
			throw new NotImplementedException();
		}

		public int Balance { get; set; }
	}
}
