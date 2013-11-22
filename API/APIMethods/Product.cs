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
	public static class Product
	{
		/// <summary>
		/// Returns API documentation on a specific method in Products/
		/// </summary>
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Product"]["__methods"][method];
		}

		/// <summary>
		/// Returns information about a product's pricing and options.
		/// The product code for a specific server or service on an account can be found with the
		/// Server/Details method, under the 'type' field, and a list of valid product codes can
		/// be obtained via the Product/List method.
		/// </summary>
		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Product/details";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Converts path elements to a product code and alias.
		/// </summary>
		public static string GetProductCodeFromPath (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Product/getProductCodeFromPath";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Returns production information for all products, or products in a series or
		/// category depending on the arguments passed. Only returns products available to the account.
		/// </summary>
		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Product/list";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Get a total price for a product, including other useful information that
		/// will affect the order.
		/// </summary>
		/// <returns>
		/// The 'balance' is the amount of money on the account that will be used prior to
		/// attempting to charge your credit card for the server creation.
		/// The 'initial' amount is the amount you need to prepay for the server for now
		/// until your next billing date.
		/// The 'cc_chage' amount is the amount that will be charged to your credit card,
		/// if your account is set to the credit card payment method.
		/// 'approved' is a boolean.  If true then this purchase would be allowed by the
		/// system.
		/// </returns>
		public static string Price (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Product/price";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Returns the minimal price for a product, picking the cheapest feature for
		/// each slot.
		/// </summary>
		public static string StartingPrice (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Product/startingPrice";
			return APIHandler.Post (method, options, encoding);
		}
	}
}

