using System;
using StormOnDemandAPI;
using NUnit.Framework;

namespace Tests
{
	/// <summary>
	/// Sends Storm API Ping request
	/// </summary>
	[TestFixture]
	public class APIPing
	{
		// Test variables.
		string response;
		string desiredResponse = "{\"ping\":\"success\"}";
		string badAuth = "ProtocolError Error";

		/// <summary>
		/// Initializes variable data.
		/// </summary>
		[SetUp]
		public void Init ()
		{
			//REAL API INFO REQUIRED FOR THIS TO PASS
			Auth.username = "USER";
			Auth.password = "PASS";
		}

		/// <summary>
		/// Generates Ping request to the API. Tests to make sure ping was successful
		/// </summary>
		[Test]
		public void PingRequest()
		{
			response = APIMethods.Utilities.Info.Ping ();
			StringAssert.AreNotEqualIgnoringCase (badAuth, response, "Did you forget to set your API auth information?");
			StringAssert.AreEqualIgnoringCase (desiredResponse, response);
		}
	}
}

