using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkConnectivity
{

	public class Network
	{
		List<List<int>> net;
		int cityNum;
		int lineNum;

		public List<List<int>> Net { get => net; set => net = value; }

		/// <summary>
		/// 按照大小初始化net
		/// </summary>
		/// <param name="n"></param>
		/// <param name="m"></param>
		public Network(int n, int m)
		{
			InitNetwork(n, m);
		}

		/// <summary>
		/// 按照大小初始化net
		/// </summary>
		/// <param name="n">城市数</param>
		/// <param name="m">通讯线路条数</param>
		public void InitNetwork(int n, int m)
		{
			if (n <= 0 || m < 0 || m < n - 1 || m > n * (n - 1) / 2)
			{
				throw new InvalidParamException(n,(n-1), n * (n - 1) / 2);
			}
			cityNum = n;
			lineNum = m;
			net = new List<List<int>>(n);
			for (int i = 0; i < n; i++)
			{
				net.Add(new List<int>(Enumerable.Repeat(0, n)));
			}
		}

		/// <summary>
		/// 按照参数，随机生成网络
		/// </summary>
		public void RandomGenerate()
		{
			List<int> inside = new List<int>();
			List<int> outside = new List<int>(Enumerable.Range(0, cityNum));
			Random rand = new Random();
			int lineLeft = lineNum;//存放剩余线路数

			//先随机选取一个外部点加入内部
			int pos = rand.Next(outside.Count);
			inside.Add(outside[pos]);
			outside.RemoveAt(pos);
			//所有点未全部进入内部时
			while (outside.Count > 0)
			{
				//每次随机在内外部点中各选取一个
				int atIn = rand.Next(inside.Count);
				int atOut = rand.Next(outside.Count);
				//连接两点
				net[inside[atIn]][outside[atOut]]++;
				net[outside[atOut]][inside[atIn]]++;
				lineLeft--;
				//将外部点加入内部 
				inside.Add(outside[atOut]);
				outside.RemoveAt(atOut);
			}
			//所有点全部进入内部点时
			while (lineLeft > 0)
			{
				//在内部任选两点
				int pos1, pos2;
				do
				{
					pos1 = rand.Next(inside.Count);
					pos2 = rand.Next(inside.Count);
				} while (pos1 == pos2);
				//连接两点  
				net[inside[pos1]][inside[pos2]]++;
				net[inside[pos2]][inside[pos1]]++;
				lineLeft--;
			}

		}

		/// <summary>
		/// 生成邻接矩阵的字符串形式
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			string matrix = "";
			for (int i = 0; i < cityNum; i++)
			{
				for (int j = 0; j < cityNum; j++)
				{
					matrix += net[i][j];
					matrix += "\t";
				}
				matrix += "\n";
			}
			return matrix;
		}


	}
}
