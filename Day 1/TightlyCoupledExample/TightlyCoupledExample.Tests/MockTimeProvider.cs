using System;

namespace TightlyCoupledExample.Tests
{
	public class MockTimeProvider : TimeProvider
	{
		public override DateTime UtcNow { get { return new DateTime(2015,1,1);} }
	}
}