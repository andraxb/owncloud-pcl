
using System;
using NUnit.Framework;

namespace owncloudpcliosunittests
{
	// TODO

	/// <summary>
	/// Own cloud client tests.
	/// </summary>
	[TestFixture]
	public class OwnCloudClientTests
	{
		[Test]
		public void Pass ()
		{
			Assert.True (true);
		}

		[Test]
		public void Fail ()
		{
			Assert.False (true);
		}

		[Test]
		[Ignore ("another time")]
		public void Ignore ()
		{
			Assert.True (false);
		}
	}
}
