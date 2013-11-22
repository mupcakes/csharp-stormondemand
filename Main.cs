using System;
using System.Collections.Generic;
using System.Collections;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using APIMethods;
using APIMethods.Storm;

namespace StormOnDemandAPI
{
	class MainClass
	{
		public static void Main ()
		{
			// Auto accepts SSL issues when executing through IDE
			ServicePointManager.ServerCertificateValidationCallback = ( se, cert, chain, sslerror ) => {
				return true; };

			// Setup API auth info
			Auth.username = "USER";
			Auth.password = "PASSWORD";

			string _uid = "ABCDEF";
			string _ip = "127.0.0.1";

			//populate documentation
			Documentation.PullAPIDocs ();

			#region using a static class
			IPDetailsRequest ipReq = new IPDetailsRequest();
			IPDetailsResponse ipRes = new IPDetailsResponse();
			string response;

			ipReq.uniq_id = _uid;
			ipReq.ip = _ip;

			// parses ipReq object into JSON format and posts to API
			// returns the JSON string response from the API
			response = APIMethods.Network.IP.Details (ipReq);
			Console.WriteLine (response);

			// Storing response in a class object
			ipRes = JsonConvert.DeserializeObject<IPDetailsResponse>(response);

			#endregion

			Console.WriteLine ("\n");

			#region Using a Dictionary
			Dictionary<dynamic, string> dictionaryIpDetails = new Dictionary<dynamic, string>();
			dictionaryIpDetails.Add ("uniq_id", _uid);
			dictionaryIpDetails.Add ("ip", _ip);

			// APIMethods.* always return the JSON string response from the API
			Console.WriteLine (APIMethods.Network.IP.Details (dictionaryIpDetails));

			#endregion

			Console.WriteLine ("\n");

			#region Using a Dictionary
			Hashtable hashIpDetails = new Hashtable();
			hashIpDetails.Add ("uniq_id", _uid);
			hashIpDetails.Add ("ip", _ip);

			// APIMethods.* always return the JSON string response from the API
			Console.WriteLine (APIMethods.Network.IP.Details (hashIpDetails));

			#endregion

			Console.WriteLine ("\n");

			#region Documentation example
			// Can use docmentation to pull info on methods such as Network/IP/details
			Console.WriteLine (APIMethods.Network.IP.MethodInfo ("details"));
			#endregion
		}
	}
}
