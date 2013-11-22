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

namespace APIMethods.Storage
{
	public static class Block
	{
		public static class Cluster
		{
			/// <summary>
			/// Returns API documentation on a specific method in Storage/Block/Cluster
			/// </summary>
			public static JObject MethodInfo (string method)
			{
				return Documentation.docs ["Storage/Block/Cluster"] ["__methods"] [method];
			}

			/// <summary>
			/// Get a paginated list of block storage clusters, including the zone that the
			/// cluster is in.
			/// </summary>
			public static string List (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Storage/Block/Cluster/list";
				return APIHandler.Post (method, options, encoding);
			}
		}

		public static class Volume
		{
			/// <summary>
			/// Returns API documentation on a specific method in Storage/Block/Volume
			/// </summary>
			public static JObject MethodInfo (string method)
			{
				return Documentation.docs ["Storage/Block/Volume"] ["__methods"] [method];
			}

			/// <summary>
			/// Attach a volume to a particular instance.
			/// </summary>
			public static string Attach (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Storage/Block/Volume/attach";
				return APIHandler.Post (method, options, encoding);
			}

			/// <summary>
			/// Create a new volume(150G minimum)
			/// </summary>
			public static string Create (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Storage/Block/Volume/create";
				return APIHandler.Post (method, options, encoding);
			}

			/// <summary>
			/// Detach a volume from an instance.  This method is roughly equivalent to
			/// unplugging an external drive, and it is important to ensure the volume is
			/// unmounted before using this method.
			/// </summary>
			public static string Detach (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Storage/Block/Volume/detach";
				return APIHandler.Post (method, options, encoding);
			}

			/// <summary>
			/// Delete a volume, including any and all data stored on it.  The volume must not
			/// be attached to any instances to call this method.
			/// </summary>
			public static string Delete (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Storage/Block/Volume/delete";
				return APIHandler.Post (method, options, encoding);
			}

			/// <summary>
			/// Retrieve information about a specific volume.
			/// accnt: your account number
			/// id: the id of the volume
			/// domain: the name you gave the volume on creation
			/// size: the size of the volume, in GB
			/// status: status of the volume (unprovisioned, active, or attached)
			/// uniq_id: the unique identifier, made of 6 letters and numbers, of the volume.
			/// attached_to: the unique identifier of the server this volume is attached to (or 'null').
			/// device: if the volume is attached to a server, this is the device that it is attached as
			/// </summary>
			public static string Details (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Storage/Block/Volume/details";
				return APIHandler.Post (method, options, encoding);
			}

			/// <summary>
			/// Get a paginated list of block storage volumes for your account. More
			/// information about the returned data structure can be found in the documentation
			/// for storage/block/volume/details
			/// </summary>
			public static string List (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Storage/Block/Volume/list";
				return APIHandler.Post (method, options, encoding);
			}

			/// <summary>
			/// Resize a volume.  Volumes can currently only be resized larger.
			/// </summary>
			public static string Resize (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Storage/Block/Volume/resize";
				return APIHandler.Post (method, options, encoding);
			}

			/// <summary>
			/// Update an existing volume.  Currently, only renaming the volume is supported.
			/// More information about the returned data structure can be found in the
			/// documentation for storage/block/volume/details/
			/// </summary>
			public static string Update (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Storage/Block/Volume/update";
				return APIHandler.Post (method, options, encoding);
			}
		}
	}
}


