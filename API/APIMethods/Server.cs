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
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace APIMethods
{
	public static class Server
	{
		/// <summary>
		/// Returns API documentation on a specific method in Server/
		/// </summary>
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Server"]["__methods"][method];
		}

		/// <summary>
		/// Checks if a given domain is free. Will return an adjusted domain name.
		/// Host.* will become host2.* if its unavailable.
		/// If the domain is reserved exception type LW::Exception::Resource::Unavaiable will be returned
		/// </summary>
		public static string Available (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/available";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Clone a server. 
		/// </summary>
		/// <returns>
		/// Returns the information about the newly created clone.
		/// </returns>
		public static string Clone (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/clone";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Provision a new server.  This fires off the build process, which does the
		/// actual provisioning of a new server on its parent.
		/// </summary>
		public static string Create (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/create";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Kills a server.  It will refund for any remaining time that has been prepaid,
		/// charge any outstanding bandwidth charges, and then start the workflow to tear
		/// down the server.
		/// </summary>
		public static string Destroy (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/destroy";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Gets data relevant to a provisioned server.
		/// </summary>
		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/details";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Get a list of notifications for a specific server.  Information about the data
		/// returned can here be found in storm/alerts/details
		/// </summary>
		public static string History (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/history";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Get a list of servers, services, and devices on your account.
		/// A more detailed description of what is returned can be found
		/// in the documentation for the server/details method.
		///
		/// Valid options for category include:
		/// Dedicated	-- Servers, both physical and virtual.
  		/// Provisioned	-- Products which are subject to automated provisioning, such as Storm
  		/// LoadBalancer-- A hardware or software load balancer.
  		/// HPBS		-- Products backed by our High Performance Block Storage technology
		/// </summary>
		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/list";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Reboot a server. The 'force' flag will do a hard shutdown/boot of the server from
		/// the parent server.
		/// If the server in question does not support automatic rebooting, a reboot
		/// request will be created in helpdesk.
		/// </summary>
		public static string Reboot (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/reboot";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Resize a server to a new configuration.  Available config_ids can be found in
		/// storm/config/list
		/// </summary>
		public static string Resize (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/resize";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Stop a server.  The 'force' flag will do a hard stop of the server from the
		/// parent server. Otherwise, it will issue a halt command to the server and
		/// shutdown normally.
		/// </summary>
		public static string Shutdown (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/shutdown";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Boot a server.  If the server is already running, this will do nothing.
		/// </summary>
		public static string Start (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/start";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Update details about your server, including the backup and bandwidth plans, any
		/// advanced authentication options, and the hostname ('domain') we have on file.
		/// Updating the 'domain' field will not change the actual hostname on the server.
		/// It merely updates what our records show.
		/// </summary>
		public static string Update (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/update";
			return APIHandler.Post (method, options, encoding);
		}

		public static class Virtual
		{
			public static class Domain
			{
				/// <summary>
				/// Returns API documentation on a specific method in Server/VirtualDomain/
				/// </summary>
				public static JObject MethodInfo (string method)
				{
					 return Documentation.docs["Server/VirtualDomain"]["__methods"][method];
				}

				/// <summary>
				/// Create a new add-on domain for a shared subaccnt.
				/// </summary>
				public static string Create (object options, EncodeType encoding = EncodeType.JSON)
				{
					string method = "/Server/VirtualDomain/create";
					return APIHandler.Post (method, options, encoding);
				}

				/// <summary>
				/// Returns the number of free VIRs a given type of shared account receives.
				/// </summary>
				public static string FreeCount (object options, EncodeType encoding = EncodeType.JSON)
				{
					string method = "/Server/VirtualDomain/freecount";
					return APIHandler.Post (method, options, encoding);
				}

				/// <summary>
				/// Lists the domains for a given server.
				/// </summary>
				public static string List (object options, EncodeType encoding = EncodeType.JSON)
				{
					string method = "/Server/VirtualDomain/list";
					return APIHandler.Post (method, options, encoding);
				}

				/// <summary>
				/// Lists the domains for an account that are not linked to a server.
				/// </summary>
				public static string ListOrphans (object options, EncodeType encoding = EncodeType.JSON)
				{
					string method = "/Server/VirtualDomain/listOrphans";
					return APIHandler.Post (method, options, encoding);
				}

				/// <summary>
				/// Links an existing orphaned add-on domain to a shared subaccnt.
				/// </summary>
				public static string ReLink (object options, EncodeType encoding = EncodeType.JSON)
				{
					string method = "/Server/VirtualDomain/relink";
					return APIHandler.Post (method, options, encoding);
				}
			}
		}
	}
}


