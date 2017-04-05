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
			Network net;
			while (true)
			{
				try
				{
					string strn = Console.ReadLine();
					string strm = Console.ReadLine();

					net = new Network(int.Parse(strn), int.Parse(strm));
					net.RandomGenerate();
					Console.WriteLine(net.ToString());
				}
				catch (InvalidParamException e)
				{
					Console.WriteLine("城市数为{0}时，m的范围为[{1},{2}]", e.n,e.mLower,e.mUpper);
				}
			}
		}


	}
}
