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

namespace APIMethods.Storm
{
	public enum BandwidthQuota {
		AsYouGo = 0,
	};

	public enum BackupEnabled {
		No = 0,
		Yes = 1
	};

	public enum SkipFSResize {
		No = 0,
		Yes = 1
	};

	public enum Force {
		No = 0,
		Yes = 1
	}

	public static class Backup
	{
		/// <summary>
		/// Returns API documentation on a specific method in Storm/Backup
		/// </summary>
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Storm/Backup"]["__methods"][method];
		}

		/// <summary>
		/// Get information about a specific backup.
		/// </summary>
		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Backup/details";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Get a paginated list of backups for a particular server. More information about
		/// the data returned can be found under the documentation for storm/backup/details
		/// </summary>
		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Backup/list";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Re-images a server with the backup image requested.  If the 'force' flag is passed
		/// it will rebuild the filesystem on the server before restoring.  This option is not
		/// usually needed, but if regular restores are failing, it can fix some scenarios.
		/// </summary>
		public static string Restore (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Backup/restore";
			return APIHandler.Post (method, options, encoding);
		}
	}

	public static class Config
	{
		/// <summary>
		/// Returns API documentation on a specific method in Storm/Config
		/// </summary>
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Storm/Config"]["__methods"][method];
		}

		/// <summary>
		/// Get information about a specific config.
		/// </summary>
		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Config/details";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Get a list of available server configurations.  Only active configurations will
		/// be returned by this method, whereas the 'details' method will allow you to query
		/// information about an inactive configuration.  For more information about the fields
		/// returned here, refer to the documentation for storm/config/details.
		/// valid options for category are storm, ssd, bare-metal and all.
		/// </summary>
		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Config/list";
			return APIHandler.Post (method, options, encoding);
		}
	}

	public static class Image
	{
		/// <summary>
		/// Returns API documentation on a specific method in Storm/Image
		/// </summary>
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Storm/Image"]["__methods"][method];
		}

		/// <summary>
		/// Fires off a process to image the server right now.  Since the image
		/// won't be created immediately, we can't return the information about it.
		/// </summary>
		public static string Create (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Image/create";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Fires off a process to delete the requested image from the image server that stores it.
		/// </summary>
		public static string Delete (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Image/delete";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Get information about a specific image.
		/// </summary>
		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Image/details";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Get a paginated list of previously-created images for your account. More
		/// information about the returned data structure can be found in the documentation
		/// for server/image/details
		/// </summary>
		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Image/list";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Re-images a server with the image requested.  If the 'force' flag is passed
		/// it will rebuild the filesystem on the server before restoring.  This option is not
		/// usually needed, but if regular restores are failing, it can fix some scenarios.
		/// </summary>
		public static string Restore (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Image/restore";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Update an existing image.  Currently, only renaming the image is supported.
		/// More information about the returned data structure can be found in the
		/// documentation for server/image/details/
		/// </summary>
		public static string Update (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Image/update";
			return APIHandler.Post (method, options, encoding);
		}
	}

	public static class Server
	{
		/// <summary>
		/// Returns API documentation on a specific method in Storm/Server
		/// </summary>
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Storm/Server"]["__methods"][method];
		}

		/// <summary>
		/// Clone a server. Returns the information about the newly created clone.
		/// config_id and ip_count are defaulted to the values on the original server, if
		/// nothing is passed in.
		/// </summary>
		public static string Clone (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/clone";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Provision a new server.  This fires off the build process, which does the
		/// actual provisioning of a new server on its parent.  Each server consists of
		/// several distinct options:
		///
		/// config_id: the id of the server configuration you wish to use.  For a list
		/// of available configs, see the storm/config/list API method
		///
		/// template: templates are the LiquidWeb-provided server OS images.  For a list
		/// of available templates, see the storm/template/list API method
		/// 
		/// image_id: rather that provisioning a LiquidWeb template, you can specify
		/// the id of a user-created image on your account.  Use the API method
		/// storm/image/list to find any existing images you have, or storm/image/create
		/// to create a new image from an existing server
		///
		/// ip_count: the number of IPs you wish the server to have.  This defaults to
		/// 1 IP, which is included in the base price.  Pricing for additional IPs can
		/// be found using the product/details API method.
		///
		/// bandwidth_quota: the bandwidth plan you wish to use.  A quota of 0 indicates
		/// that you want as-you-go, usage-based bandwidth charges, but may not be
		/// permitted with all configs.  The remaining available quota options can be
		/// found with the product/details API method.
		///
		/// backup_enabled: whether or not backups should be enabled.  Defaults to no.
		/// If this is not set to 1, neither of the following two options will be used.
		///
		/// backup_plan: either 'quota' or 'daily', depending on whether you are
		/// choosing a quota-based backup plan or just a specific number of days to be
		/// backed up.
		///
		/// backup_quota: for a 'daily' plan, this indicates the number of days to back
		/// up.  For a quota plan, this is the total number of GB to keep.  Available
		/// options are found with the product/details API method .
		///
		/// public_ssh_key: optional public ssh key you want added to authorized_keys
		/// on your new server.  This should be a valid public ssh key, e.g. the contents
		/// of your id_rsa.pub file.
		/// 
		/// Beyond those options, we need the hostname of the server ('domain') and the
		/// root password you would like set on the server originally ('password').
		/// </summary>
		public static string Create (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/create";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Kills a server.  It will refund for any remaining time that has been prepaid,
		/// charge any outstanding bandwidth charges, and then start the workflow to tear
		/// down the server.
		/// </summary>
		public static string Destroy (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/destroy";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Gets data relevant to a Storm server.
		/// </summary>
		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/details";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Get a list of notifications for a specific server.  Information about the data
		/// returned can here be found in storm/alerts/details
		/// </summary>
		public static string History (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/history";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Retrieve a paginated list of Storm servers on your account.  A more detailed
		/// description of what is returned can be found in the documentation for the
		/// storm/server/details method.
		/// </summary>
		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/list";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Reboot a server. The 'force' flag will do a hard shutdown/boot of the server from
		/// the parent server.
		/// </summary>
		public static string Reboot (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/reboot";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Resize a server to a new configuration.  Available config_ids can be found in
		/// storm/config/list.
		///
		/// You will be billed for the prorated difference of the price of the new
		/// configuration compared to the price of your old configuration.  The difference
		/// will be refunded or charged at your next billing date.
		///
		/// A server resize cannot cross zones.
		/// 
		/// When resizing to a larger configuration, the filesystem resize operation can be
		/// skipped by passing the 'skip_fs_resize' option.  In this case, the storage
		/// associated with the new configuration is allocated, but not available
		/// immediately.  The filesystem resize should be scheduled with the support team.
		///
		/// Skipping the filesystem resize is only possible when moving to a larger
		/// configuration.  This option has no effect if moving to the same or smaller
		/// configuration.
		/// </summary>
		public static string Resize (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/resize";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Stop a server.  The 'force' flag will do a hard stop of the server from the
		/// parent server. Otherwise, it will issue a halt command to the server and
		/// shutdown normally.
		/// </summary>
		public static string Shutdown (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/shutdown";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Boot a server.  If the server is already running, this will do nothing.
		/// </summary>
		public static string Start (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/start";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Gets the current status of a server, in relation to what processes are being run
		///	on its behalf.
		/// 
		/// If nothing is currently running, only the 'status' field will be returned.
		///
		///The list of available statuses at this time is:
		///
		/// Building
		/// Cloning
		/// Resizing
		/// Moving
		/// Booting
		/// Stopping
		/// Restarting
		/// Rebooting
		/// Shutting Down
		/// Restoring Backup
		/// Creating Image
		/// Deleting Image
		/// Restoring Image
		/// Re-Imaging
		/// Updating Firewall
		/// Updating Network
		/// Adding IPs
		/// Removing IP
		///Destroying
		/// </summary>
		public static string Status (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/status";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Update details about your server, including the backup and bandwidth plans, and
		/// the hostname ('domain') we have on file.
		///
		/// Updating the 'domain' field will not change the actual hostname on the server.
		/// It merely updates what our records show.
		/// </summary>
		public static string Update (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/update";
			return APIHandler.Post (method, options, encoding);
		}
	}

	public static class Template
	{
		/// <summary>
		/// Returns API documentation on a specific method in Storm/Template
		/// </summary>
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Storm/Template"]["__methods"][method];
		}

		/// <summary>
		/// Get information about a specific template.  You can query details about inactive
		/// templates because backups, existing servers, and images might be tied to one,
		/// but you cannot provision to or restore an inactive template.  You can, however,
		/// restore from a deprecated template.
		/// </summary>
		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Template/details";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Get a list of useable templates. More information about the fields
		/// returned can be found in the documenation for server/template/details
		///
		/// This method returns templates that are currently active, including
		/// deprecated templates which may not be used for new instances but
		/// may be associated with existing servers or backups.
		/// </summary>
		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Template/list";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Re-images a server with the template requested.  If the 'force' flag is passed
		/// it will rebuild the filesystem on the server before restoring.  This option is not
		/// usually needed, but if regular restores are failing, it can fix some scenarios.
		/// </summary>
		public static string Restore (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Template/restore";
			return APIHandler.Post (method, options, encoding);
		}
	}
}

