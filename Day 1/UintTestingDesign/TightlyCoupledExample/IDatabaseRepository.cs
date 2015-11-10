using System.Collections.Generic;

namespace UnitTestingDesign
{
	public interface IDatabaseRepository
	{
		IEnumerable<Person> GetAllPeople();
		IEnumerable<Person> GetAllPeopleWithLastName(string lastName);
	}
}