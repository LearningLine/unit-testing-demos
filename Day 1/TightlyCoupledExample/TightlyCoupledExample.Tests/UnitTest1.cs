using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace TightlyCoupledExample.Tests
{
	[TestClass]
	public class UnitTest1
	{

		//public void Test()
		//{
		//	IEnumerable<string> list = new List<string> {"Foo", "Bar", "Baz"};

		//	if (list.Any())
		//	{
				
		//	}

		//}
		

		[TestMethod]
		public void ProgramStartup_Calls_GetAllEmployees()
		{
			//Arrange

			//Act
			Program.Main(null);

			//Assert

			//GetAllEmployees was called
		}

		[TestMethod]
		public void Add_Returns_TheSum()
		{
			//Arrange
			int expected = 4;

			//Act
			var actual = Program.Add(2, 2);

			//Assert
			Assert.AreEqual(expected,actual);
		}

		[TestMethod]
		public void Subtract_Returns_TheResult()
		{
			int expected = 0;

			var p = new Program();

			int actual = p.Divide(2,2);

			Assert.AreEqual(expected,actual);
		}














	}
}
