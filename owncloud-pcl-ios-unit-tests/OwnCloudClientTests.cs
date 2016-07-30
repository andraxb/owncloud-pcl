
using System;
using NUnit.Framework;
using owncloudpcl;

namespace owncloudpcliosunittests
{
	// TODO

	/// <summary>
	/// Own cloud client tests.
	/// </summary>
	[TestFixture]
	public class OwnCloudClientTests
	{
		private OwnCloudClient _client;

		[SetUp]
		public void Setup() {
			_client = new OwnCloudClient ("");
		}

		[TearDown]
		public void Dispose() { 
			// TODO: disconnect from the client to make sure the session has ended on the Server.
		}

		[Test]
		public void TestLogin() {

		}

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
