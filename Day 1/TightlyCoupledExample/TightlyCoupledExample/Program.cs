using System;
using System.Linq;

namespace TightlyCoupledExample
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var employees = GetAllEmployees();

			foreach (var employee in employees)
			{
				Console.WriteLine(employee.UserName);
			}
		}

		public static int Add(int x, int y)
		{
			return x - y;
		}

		private static IQueryable<Employee> GetAllEmployees()
		{
			var context = new AdventureWorksContext();
			return context.GetAllEmployees();
		}

		public static int Subtract(int x, int y)
		{
			return x - y;
		}

		public int Divide(int x, int y)
		{
			throw new NotImplementedException();
		}
	}
}
