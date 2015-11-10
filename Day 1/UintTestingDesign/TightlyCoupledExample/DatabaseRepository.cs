using System.Collections.Generic;
using System.Linq;

namespace UnitTestingDesign
{
	public class DatabaseRepository
	{
		private static readonly AdventureWorksContext context 
			= new AdventureWorksContext();

		public static IEnumerable<Person> GetAllPeople()
		{
			return context.People;
		}

		public static IEnumerable<Person> GetAllPeopleWithLastName(string lastName)
		{
			return context.People.Where(p => p.LastName == lastName);
		}
	}
}