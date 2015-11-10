using System;
using System.Linq;

namespace UnitTestingDesign
{
	public class Program
	{
		private readonly IDatabaseRepository repo;

		public Program(IDatabaseRepository repo)
		{
			this.repo = repo;
		}

		public static void Main(string[] args)
		{
		}
	}
}
