using System;
using NUnit.Framework;
using System.Net.NetworkInformation;
using System.Text;
using StormOnDemandAPI;

namespace Tests
{
	/// <summary>
	/// Generic ping to the storm api.
	/// </summary>
	[TestFixture]
	public class GenericPing
	{
		// Test variables.
		string _hostname;
		Ping _pinger;
		PingOptions _pingerOptions;
		string _data;
		Byte[] _buffer;
		int _timeout;
		PingReply _reply;

		/// <summary>
		/// Initializes variable data.
		/// </summary>
		[SetUp]
		public void Init()
		{
			_hostname = "api.stormondemand.com";
			_pinger = new Ping();
			_pingerOptions = new PingOptions();
			_pingerOptions.DontFragment = true;
			_pingerOptions.Ttl = 128;
			_data = "Junk data";
			_buffer = Encoding.ASCII.GetBytes(_data);
			_timeout = 120;
		}

		/// <summary>
		/// Pings api.stormondemand.com to check route to API
		/// </summary>
		[Test]
		public void TestConnection()
		{
			_reply = _pinger.Send (_hostname, _timeout, _buffer, _pingerOptions);

			Assert.AreNotEqual (_reply.Status, IPStatus.TimedOut);
			Assert.AreNotEqual ( _reply.Status, IPStatus.TtlExpired);
			Assert.AreNotEqual (_reply.Status, IPStatus.DestinationUnreachable);
			Assert.AreEqual (_reply.Status, IPStatus.Success);
		}
	}
}
