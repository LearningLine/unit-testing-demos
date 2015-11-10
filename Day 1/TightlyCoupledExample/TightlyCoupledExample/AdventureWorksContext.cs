using System.Data.Entity;
using System.Linq;

namespace TightlyCoupledExample
{
	public class AdventureWorksContext : DbContext
	{
		public DbSet<Employee> Employees { get; set; }

		public AdventureWorksContext()
			: base("name=adventureWorksConnection")
		{
			
		}

		public IQueryable<Employee> GetAllEmployees()
		{
			return Employees.AsQueryable();
		}

		public Employee GetEmployee(int id)
		{
			return Employees.FirstOrDefault(e => e.Id == id);
		}
	}
}