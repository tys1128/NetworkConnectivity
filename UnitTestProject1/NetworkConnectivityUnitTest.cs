using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetworkConnectivity;

namespace NetworkConnectivityUnitTest
{
	[TestClass]
	public class NetworkConnectivityTest
	{
		[TestMethod]
		public void InitNetworkTest()
		{
			Network net = new Network(9, 18);
			Assert.AreNotSame(net.Net[0], net.Net[1]);
		}
	}
}
