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

namespace APIMethods
{
	public static class Utilities
	{
		public static class Info
		{
			/// <summary>
			/// Returns API documentation on a specific method in Utilities/Info
			/// </summary>
			public static JObject MethodInfo (string method)
			{
				 return Documentation.docs["Utilities/Info"]["__methods"][method];
			}

			/// <summary>
			/// This method can be used as a basic check to see if communication with the api
			/// is possible.
			/// </summary>
			public static string Ping ( EncodeType encoding = EncodeType.JSON)
			{
				object options = string.Empty;
				string method = "/Utilities/Info/ping";
				return APIHandler.Post (method, options, encoding);
			}

			/// <summary>
			/// Returns the version of the of the api your are using.
			/// </summary>
			public static string Version ( EncodeType encoding = EncodeType.JSON)
			{
				object options = string.Empty;
				string method = "/Utilities/Info/version";
				return APIHandler.Post (method, options, encoding);
			}
		}
	}
}

