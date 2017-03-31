using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworkConnectivity;

namespace ConsoleTest
{
	class ConsoleTest
	{
		static void Main(string[] args)
		{
			TestInitNetwork();

			Console.ReadKey();
		}

		static void TestInitNetwork()
		{

			Network net = new Network(7,7);
			Console.WriteLine(net.ToString());
			net.RandomGenerate();
			Console.WriteLine(net.ToString());

		}
	}
}
