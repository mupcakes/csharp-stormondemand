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

namespace APIMethods.Account
{
	/// <summary>
	/// Account/Auth API Methods
	/// </summary>
	public static class Auth 
	{
		/// <summary>
		/// Returns API documentation on a specific method in Account/Auth/
		/// </summary>
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Account/Auth"]["__methods"][method];
		}

		/// <summary>
		/// This method will expire an existing token immediately instead of waiting for it
		/// to expire on its own.  This is useful if you want to forcibly stop the use of a
		/// token for security reasons.
		/// </summary>
		public static string ExpireToken (object options, EncodeType encoding = EncodeType.JSON)
		{ 
			string method = "/Account/Auth/expireToken";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Authentication tokens are short-term alternative credentials for an account.
		/// Once a user logs in with their password, you should use that password to generate
		/// an authentication token, which can be cached by your application.  The authentication
		/// tokens time out after a specified period of inactivity (defaults to 15 minutes,
		/// maximum time is 1 hour).
		/// 
		/// Tokens can be kept alive by calling this method again before the token expires,
		/// up to a maximum of 12 hours.  After 12 hours, the token will be expired permanently
		/// and a new token will need to be retrieved using the original password for your user.
		/// </summary>
		public static string Token (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Account/Auth/token";
			return APIHandler.Post (method, options, encoding);
		}
	}

}

