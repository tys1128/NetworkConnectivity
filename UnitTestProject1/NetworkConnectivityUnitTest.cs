using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetworkConnectivity;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

			Point center = new Point(200, 200);
			List<Point> surround = new List<Point>(Enumerable.Repeat(center, 12));
			Assert.AreNotSame(surround[1], surround[1]);
		}
		struct Point
		{
			int a, b;
			private int v1;
			private int v2;

			public Point(int v1, int v2) : this()
			{
				this.v1 = v1;
				this.v2 = v2;
			}
		}
	}
}
