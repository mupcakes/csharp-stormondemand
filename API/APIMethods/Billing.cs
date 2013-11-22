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

namespace APIMethods.Billing
{
	/// <summary>
	/// Billing/invoice API Methods
	/// </summary>
	public static class Invoice
	{
		/// <summary>
		/// Returns API documentation on a specific method in Billing/Invoice/
		/// </summary>
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Billing/Invoice"]["__methods"][method];
		}

		/// <summary>
		/// Returns data specific to one invoice.  In addition to what is returned in the
		/// list method, additional details about the specific lineitems are included
		/// in this method.
		/// </summary>
		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Billing/Invoice/details";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Returns a list of all the invoices for the logged in account.  Invoices are created
		/// at your regular billing date, but are also created for one-off items like creating
		/// or cloning a server.
		/// </summary>
		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Billing/Invoice/list";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Returns a projection of what the given account's next bill will look like
		/// at their next bill date.
		/// </summary>
		public static string Next (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Billing/Invoice/next";
			return APIHandler.Post (method, options, encoding);
		}
	}

	/// <summary>
	/// Billing/Payment API Methods
	/// </summary>
	public static class Payment
	{
		/// <summary>
		/// Returns API documentation on a specific method in Billing/Payment/
		/// </summary>
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Billing/Payment"]["__methods"][method];
		}

		/// <summary>
		/// Charges the credit card on file for the given account the given amount, and
		/// applies those new funds to the account.  Currently this method is only useful
		/// for credit card accounts.  A forbidden exception will be thrown if used with
		/// a check account.
		/// </summary>
		public static string Make (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Billing/Payment/make";
			return APIHandler.Post (method, options, encoding);
		}
	}
}

