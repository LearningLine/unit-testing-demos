using System.Collections.Generic;

namespace UnitTestingDesign
{
	public class RealDatabaseRepoService : IDatabaseRepository
	{
		public IEnumerable<Person> GetAllPeople()
		{
			return DatabaseRepository.GetAllPeople();
		}

		public IEnumerable<Person> GetAllPeopleWithLastName(string lastName)
		{
			return DatabaseRepository.GetAllPeopleWithLastName(lastName);
		}
	}
}