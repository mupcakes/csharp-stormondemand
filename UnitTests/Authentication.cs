using System;
using NUnit.Framework;
using System.Net;
using StormOnDemandAPI;

namespace Tests
{
	/// <summary>
	/// Tests that you able to set Auth info, doesn't touch the API
	/// </summary>
	[TestFixture]
	public class Authentication
	{
		// Test variables
		string _testUser;
		string _testPassword;

		[SetUp]
		public void Init ()
		{
			/// <summary>
			/// Initializes variable data
			/// </summary>
			_testUser = "NUnitUser";
			_testPassword = "NUnitPassword";
			Auth.username = _testUser;
			Auth.password = _testPassword;
		}

		/// <summary>
		/// Determines whether this instance can set auth info.
		/// </summary>
		[Test]
		public void CanSetAuthInfo()
		{
			StringAssert.AreEqualIgnoringCase (_testUser, Auth.username);
			StringAssert.AreEqualIgnoringCase (_testPassword, Auth.password);
		}

		/// <summary>
		/// Checks the type of the credentials.
		/// </summary>
		[Test]
		public void CheckCredentialsType()
		{
			Assert.IsInstanceOf<ICredentials>(Auth.Credentials);
		}
	}
}

