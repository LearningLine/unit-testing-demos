using System.Collections.Generic;
using System.Configuration;
using ApprovalTests;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestingDesign.Tests
{
	[TestClass]
	public class PersonTests
	{
		//[TestMethod]
		//public void GetAllPeople_WhenCalled_ReturnsPeople()
		//{
		//	//Arrange
		//	var mockDbContext = new MockDbContext();
		//	var program = new Program(mockDbContext);
		//	//Act
		//	program.FetchData();

		//	//Assert that Get all People was called
		//	Assert.IsTrue(mockDbContext.GetPeopleCalled);
		//}


		[TestMethod]
		public void TestingStatics()
		{
			//Arrange
			//Act

			var test = new ClassToTest(new FakeDatabaseRepoService());
			test.Run();

			//Assert
			//Approvals.VerifyAll(people, "people");
		}
	}

	public class FakeDatabaseRepoService : IDatabaseRepository
	{
		public IEnumerable<Person> GetAllPeople()
		{
			throw new System.NotImplementedException();
		}

		public IEnumerable<Person> GetAllPeopleWithLastName(string lastName)
		{
			throw new System.NotImplementedException();
		}
	}
}
