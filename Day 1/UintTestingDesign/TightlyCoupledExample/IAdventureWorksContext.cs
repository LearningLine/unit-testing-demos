using System.Linq;

namespace UnitTestingDesign
{
	public interface IAdventureWorksContext
	{
		IQueryable<Person> People { get; }
	}
}