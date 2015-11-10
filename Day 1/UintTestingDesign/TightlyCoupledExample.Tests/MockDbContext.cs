using System.Collections.Generic;
using System.Linq;

namespace UnitTestingDesign.Tests
{
	public class MockDbContext : IAdventureWorksContext
	{
		public bool GetPeopleCalled;
		public IQueryable<Person> People
		{
			get
			{
				GetPeopleCalled = true;
				return new List<Person>
				{
					new Person
					{
						FirstName = "John", LastName = "Smith"
					}
				}.AsQueryable();
			}
		}
	}
}