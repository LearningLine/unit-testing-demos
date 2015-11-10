using System;
using NUnit.Framework;
using TightlyCoupledExample;

namespace AccountnUnitTests
{
	[TestFixture]
    public class Class1
    {
		[Test]
		[TestCase(100)]
		[TestCase(0)]
		public void Credit_WhenCalled_IncreasesAccountBalancenUnit(decimal creditAmount)
		{
			//Arrange
			decimal initialBalance = 50m;
			var account = new Account(initialBalance);

			//Act
			account.Credit(creditAmount);

			//Assert
			var expected = initialBalance + creditAmount;

			Assert.AreEqual(expected, account.Balance);
		}


		[Test]
		//[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void Credit_WhenCalledWithNegativeNumber_ShouldThrowAOORE()
		{
			//Arrange
			decimal creditAmount = -10m;
			var acc = new Account(0);

			//Act
			//Assert
			//Assert.That(() => acc.Credit(creditAmount),
			//	Throws.InstanceOf<ArgumentOutOfRangeException>());

			Assert.Throws<ArgumentOutOfRangeException>(
				() => acc.Credit(creditAmount));
		}



	}
}
