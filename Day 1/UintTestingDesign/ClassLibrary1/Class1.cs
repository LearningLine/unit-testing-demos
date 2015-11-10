using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingDesign;

namespace ClassLibrary1
{
    public class ClassToTest
    {
		private readonly IDatabaseRepository repo;

		public ClassToTest(IDatabaseRepository repo)
		{
			this.repo = repo;
		}

	    public void Run()
	    {
			var people = repo.GetAllPeople();

			foreach (var person in people)
			{
				Console.WriteLine("{0} {1}", person.FirstName, person.LastName);
			}
		}
	}
}
