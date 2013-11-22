using System;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using StormOnDemandAPI;

namespace Tests
{
	/// <summary>
	/// Test ability to Deserialize JSON into different object types.
	/// </summary>
	[TestFixture]
	public class Deserialize
	{
		// Test variables
		Hashtable hash;
		string testData;
		Dictionary<string, dynamic> de;
		IPDetailsResponse ipde;

		/// <summary>
		/// Initializes variable data.
		/// </summary>
		[SetUp]
		public void Init ()
		{
			//Sample api return of IPDetails method to test against
			testData = "{\"broadcast\":\"12.34.56.255\"," +
				"\"gateway\":\"12.34.254.1\"," +
				"\"ip\":\"12.34.56.78\"," +
				"\"netmask\":\"255.255.254.0\"," +
				"\"id\":\"987654\"}";
		}

		/// <summary>
		/// Deserializes a JSON string into a classes properties->values.
		/// </summary>
		[Test]
		public void DeserializeClass ()
		{
			ipde = new IPDetailsResponse ();

			// Deserializes JSON string data to properties,value in ResponseIPDetails object
			ipde = Newtonsoft.Json.JsonConvert.DeserializeObject<IPDetailsResponse> (testData);

			//Check if properties/values are stored properly
			StringAssert.AreEqualIgnoringCase (ipde.broadcast, "12.34.56.255");
			StringAssert.AreEqualIgnoringCase (ipde.gateway, "12.34.254.1");
			StringAssert.AreEqualIgnoringCase (ipde.ip, "12.34.56.78");
			StringAssert.AreEqualIgnoringCase (ipde.netmask, "255.255.254.0");
			StringAssert.AreEqualIgnoringCase (ipde.id, "987654");

		}
	
		/// <summary>
		/// Deserializes a JSON string into a Dictionary<key,value> set.
		/// </summary>
		[Test]
		public void DeserializeDictionary ()
		{
			de = new Dictionary<string, dynamic> ();
			// Deserialize test JSON string into a Dictionary<T,T> object
			de = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, dynamic>> (testData);

			//Check if Dictionary keys,values are stored properly
			foreach (KeyValuePair<string,dynamic> en in de) {
				if (en.Key == "broadcast")
					StringAssert.AreEqualIgnoringCase (en.Value, "12.34.56.255");
				else if (en.Key == "gateway")
					StringAssert.AreEqualIgnoringCase (en.Value, "12.34.254.1");
				else if (en.Key == "ip")
					StringAssert.AreEqualIgnoringCase (en.Value, "12.34.56.78");
				else if (en.Key == "netmask")
					StringAssert.AreEqualIgnoringCase (en.Value, "255.255.254.0");
				else if (en.Key == "id")
					StringAssert.AreEqualIgnoringCase (en.Value, "987654");
			}
		}

		/// <summary>
		/// Deserializes a JSON string into a Hashtable<key,value> object.
		/// </summary>
		[Test]
		public void DeserializeHash ()
		{
			hash = new Hashtable ();

			// Deserialize test JSON string into Hashtable object
			hash = Newtonsoft.Json.JsonConvert.DeserializeObject<Hashtable> (testData);

			// Check if hashtable keys,values are stored properly
			foreach (DictionaryEntry en in hash) {
				if (en.Key == "broadcast")
					StringAssert.AreEqualIgnoringCase (en.Value.ToString (), "12.34.56.255");
				else if (en.Key == "gateway")
					StringAssert.AreEqualIgnoringCase (en.Value.ToString (), "12.34.254.1");
				else if (en.Key == "ip")
					StringAssert.AreEqualIgnoringCase (en.Value.ToString (), "12.34.56.78");
				else if (en.Key == "netmask")
					StringAssert.AreEqualIgnoringCase (en.Value.ToString (), "255.255.254.0");
				else if (en.Key == "id")
					StringAssert.AreEqualIgnoringCase (en.Value.ToString (), "987654");
			}
		}
	}
}