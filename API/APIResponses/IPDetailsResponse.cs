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

namespace StormOnDemandAPI
{
	/// <summary>
	/// Example response to catch and store the returned JSON from APIDetails method.
	/// Stores each JSON key value pair into object properties
	/// </summary>
	public class IPDetailsResponse
	{
		/// <summary>
		/// Gets or sets the broadcast IP Address
		/// </summary>
		public string broadcast { get; set; }

		/// <summary>
		/// Gets or sets the gateway IP Address
		/// </summary>
		public string gateway{ get; set; }

		/// <summary>
		/// Gets or sets the IP Address
		/// </summary>
		public string ip { get; set; }

		/// <summary>
		/// Gets or sets the netmask IP Address
		/// </summary>
		public string netmask { get; set; }

		/// <summary>
		/// Gets or sets the id
		/// </summary>
		public string id { get; set; }
	}
}

