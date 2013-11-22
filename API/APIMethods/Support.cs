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

namespace APIMethods.Support
{

		public static class Alert
		{
			/// <summary>
			/// Returns API documentation on a specific method in Support/Alert
			/// </summary>
			public static JObject MethodInfo (string method)
			{
				 return Documentation.docs["Support/Alert"]["__methods"][method];
			}
			
			/// <summary>
			/// Returns the details of the active support alert.
			/// </summary>
			public static string GetActive (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Support/Alert/getActive";
				return APIHandler.Post (method, options, encoding);
			}
		}

		public static class Ticket
		{
			/// <summary>
			/// Returns API documentation on a specific method in Support/Ticket
			/// </summary>
			public static JObject MethodInfo (string method)
			{
				 return Documentation.docs["Support/Ticket"]["__methods"][method];
			}
			
			/// <summary>
			/// Adds or replaces customer feedback for a closed ticket.
			/// </summary>
			public static string AddFeedback (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Support/Ticket/addFeedback";
				return APIHandler.Post (method, options, encoding);
			}

			/// <summary>
			/// Adds customer feedback for a specific ticket transaction.  The transaction is
			/// specified by the time key, which is the time of the transaction to which
			/// feedback is being added.  Rating is typically "good" or "poor".
			/// </summary>
			public static string AddTransactionFeedback (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Support/Ticket/addTransactionFeedback";
				return APIHandler.Post (method, options, encoding);
			}

			/// <summary>
			/// Links a ticket to a given account, setting appropriate attributes and adding
			/// a transaction authentication message to the ticket.
			/// </summary>
			public static string Authenticate (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Support/Ticket/authenticate";
				return APIHandler.Post (method, options, encoding);
			}

			/// <summary>
			/// Closes a ticket
			/// </summary>
			public static string Close (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Support/Ticket/close";
				return APIHandler.Post (method, options, encoding);
			}

			/// <summary>
			/// Makes a new ticket in the given account.
			/// </summary>
			public static string Create (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Support/Ticket/create";
				return APIHandler.Post (method, options, encoding);
			}

			/// <summary>
			/// Returns details for a specific ticket id.
			/// </summary>
			public static string Details (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Support/Ticket/details";
				return APIHandler.Post (method, options, encoding);
			}

			/// <summary>
			/// Returns a list of the tickets in a given account, for a given ticket status.  If
			/// no 'status' is passed in, only 'open' tickets are returned.
			///
			/// Default pagination is 10 per page, this can be specified to a maximum of 100 per
			/// page.
			///
			/// Valid Status options are:
			///
			/// open - tickets that are still unresolved
			/// recent - tickets that were recently created, whether they are resolved or not
			/// closed - tickets that are resolved, regardless of age
			/// archived - really old tickets that have been archived, for reference only (cannot be reopened)
			/// </summary>
			public static string List (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Support/Ticket/list";
				return APIHandler.Post (method, options, encoding);
			}

			/// <summary>
			/// Reopens a closed ticket.
			/// </summary>
			public static string Reopen (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Support/Ticket/reopen";
				return APIHandler.Post (method, options, encoding);
			}

			/// <summary>
			/// Adds a customer transaction to the ticket.
			///
			/// If not given, C<subject> defaults to the ticket subject.
			/// </summary>
			public static string Reply (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Support/Ticket/reply";
				return APIHandler.Post (method, options, encoding);
			}

			/// <summary>
			/// Returns the list of valid ticket types.
			/// </summary>
			public static string Types (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Support/Ticket/types";
				return APIHandler.Post (method, options, encoding);
			}
		}

}

