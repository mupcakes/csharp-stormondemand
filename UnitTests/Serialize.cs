using System;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using StormOnDemandAPI;
using Newtonsoft.Json;

namespace Tests
{
	/// <summary>
	/// Test ability to Serialize different object types into a JSON string.
	/// </summary>
	[TestFixture]
	public class Serialize
	{
		//Variables
		string ret;
		string desiredOutput;
		dynamic genRequest;
		Dictionary<string, dynamic> de;
		IPDetailsRequest ipDetails;

		/// <summary>
		/// Initializes test variables
		/// </summary>
		[SetUp]
		public void Init()
		{
			// JSON string sample of API request for /Server/list to compare serialized objects to
			desiredOutput = "{\"params\":{\"uniq_id\":\"ABCD12\",\"ip\":\"12.34.56.78\"}}";
		}

		/// <summary>
		/// Serializes a dictionary<key,value> set into JSON string.
		/// </summary>
		[Test]
		public void SerializeDictionary ()
		{
			de = new Dictionary<string, dynamic>();
			de.Add ("uniq_id", "ABCD12");
			de.Add ("ip", "12.34.56.78");

			// Converts Dictionary<keys,values> to JSON string
			ret = JsonConvert.SerializeObject (de);

			// Checks if data is Serialized properly
			Assert.IsInstanceOf<Dictionary<string, dynamic>>(de);
			StringAssert.AreEqualIgnoringCase (desiredOutput, ret);
		}

		/// <summary>
		/// Serializes a class into a JSON string based on properties->values.
		/// </summary>
		[Test]
		public void SerializeClass()
		{
			ipDetails = new IPDetailsRequest ();

			ipDetails.uniq_id = "ABCD12";
			ipDetails.ip = "12.34.56.78";

			// Serializes IPDetailsRequest object properties,values into a JSON string
			ret = JsonConvert.SerializeObject (ipDetails);

			// Checks if data is Serialized properly
			Assert.IsInstanceOf<IPDetailsRequest>(ipDetails);
			StringAssert.AreEqualIgnoringCase (desiredOutput, ret);
		}
	}
}

