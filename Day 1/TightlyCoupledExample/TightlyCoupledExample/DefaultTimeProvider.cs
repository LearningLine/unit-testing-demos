using System;

namespace TightlyCoupledExample
{
	public class DefaultTimeProvider : TimeProvider
	{
		private static TimeProvider instance;

		public static TimeProvider Instance
		{
			get { return instance ?? (instance = new DefaultTimeProvider()); }
		}

		private DefaultTimeProvider()
		{

		}

		public override DateTime UtcNow
		{
			get { return DateTime.UtcNow; }
		}
	}
}