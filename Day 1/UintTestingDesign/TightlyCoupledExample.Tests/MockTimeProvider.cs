using System;

namespace UnitTestingDesign.Tests
{
	public class MockTimeProvider : TimeProvider
	{
		public override DateTime UtcNow { get { return new DateTime(2015,1,1);} }
	}
}