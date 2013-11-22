#region License
// Copyright (c) 2013 mupton@liquidweb.com
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

using System;
using StormOnDemandAPI;
using Newtonsoft.Json.Linq;

namespace APIMethods.Monitoring
{
	/// <summary>
	/// Monitoring/Bandwidth API Methods
	/// </summary>
	public static class Bandwidth
	{
		/// <summary>
		/// Returns API documentation on a specific method in Monitoring/Bandwidth/
		/// </summary>
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Monitoring/Bandwidth"]["__methods"][method];
		}

		/// <summary>
		/// Get a bandwidth usage graph for a server.  The image is returned as a base64
		/// encoded blob.
		/// </summary>
		public static string Graph (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Monitoring/Bandwidth/graph";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Get bandwidth usage stats for a server.
		/// </summary>
		public static string Stats (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Monitoring/Bandwidth/stats";
			return APIHandler.Post (method, options, encoding);
		}
	}

	public static class Load
	{
		/// <summary>
		/// Returns API documentation on a specific method in Monitoring/Load/
		/// </summary>
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Monitoring/Load"]["__methods"][method];
		}

		/// <summary>
		/// Get a load graph for a server as a base64 encoded blob.
		/// </summary>
		public static string Graph (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Monitoring/Load/graph";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Get load stats for a server.  Memory is returned in units of MB, whereas disk usage
		/// is in terms of GB.  Values can be returned as 'N/A' if there was no data collected
		/// or the item in question is not something on the server.
		/// </summary>
		public static string Stats (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Monitoring/Load/stats";
			return APIHandler.Post (method, options, encoding);
		}
	}

	public static class Services
	{
		/// <summary>
		/// Returns API documentation on a specific method in Monitoring/Services/
		/// </summary>
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Monitoring/Services"]["__methods"][method];
		}

		/// <summary>
		/// Get the current monitoring settings for a server.
		/// </summary>
		public static string Get (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Monitoring/Services/get";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Returns a list of IPs that our monitoring system runs from.
		/// </summary>
		public static string MonitoringIPs (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Monitoring/Services/monitoringIps";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Get the current service status for each monitored service on a server.
		/// </summary>
		public static string Status (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Monitoring/Services/status";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Update service monitoring settings for a server, if they already exist.
		/// </summary>
		public static string Update (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Monitoring/Services/update";
			return APIHandler.Post (method, options, encoding);
		}
	}
}

