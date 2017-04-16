using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace NetworkConnectivity
{
	public class Network
	{
		List<List<int>> net;
		int cityNum;
		int lineNum;

		public int CityNum { get => cityNum; }
		public int LineNum { get => lineNum; }
		public List<List<int>> Net { get => net; }


		/// <summary>
		/// 按照参数，随机生成网络
		/// </summary>
		public void RandomGenerate()
		{
			List<int> inside = new List<int>();
			List<int> outside = new List<int>(Enumerable.Range(0, CityNum));
			Random rand = new Random();
			int lineLeft = LineNum;//存放剩余线路数

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
				Net[inside[atIn]][outside[atOut]]++;
				Net[outside[atOut]][inside[atIn]]++;
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
				} while (pos1 == pos2 || Net[inside[pos1]][inside[pos2]] == 1);
				//连接两点  
				Net[inside[pos1]][inside[pos2]]++;
				Net[inside[pos2]][inside[pos1]]++;
				lineLeft--;
			}
		}

		/// <summary>
		///	去除冗余网络
		/// </summary>
		public void RemoveRedundantLines()
		{
			foreach (var pair in this.GetLineList())
			{
				//删掉一条边
				this.Net[pair.Key][pair.Value] = 0;
				this.Net[pair.Value][pair.Key] = 0;

				//判断是否联通
				if (this.IsConnected() == false)
				{
					//如果不联通 ,//恢复边
					this.Net[pair.Key][pair.Value] = 1;
					this.Net[pair.Value][pair.Key] = 1;
				}
			}
		}
		/// <summary>
		/// 连通性判断
		/// </summary>
		/// <returns>联通返回true否则返回false</returns>
		public bool IsConnected()
		{
			List<bool> visited = new List<bool>(Enumerable.Repeat(false, CityNum));

			//深度优先搜索  
			DFS(visited, 0);

			if (visited.Contains(false))
			{
				return false;
			}
			else
			{
				return true;
			}
		}
		private void DFS(List<bool> visited, int i)
		{
			visited[i] = true;
			for (int j = 0; j < CityNum; j++)
			{
				if (Net[i][j] != 0 && visited[j] == false)
					DFS(visited, j);
			}
		}
		/// <summary>
		/// 获得装有那些被去掉就会使图不再连通的边的LIst
		/// </summary>
		public List<KeyValuePair<int, int>> GetIndependentLineList()
		{
			List<KeyValuePair<int, int>> inDependentList = new List<KeyValuePair<int, int>>();

			var list = this.GetLineList();
			foreach (var pair in list)
			{
				//删掉一条边
				this.Net[pair.Key][pair.Value] = 0;
				this.Net[pair.Value][pair.Key] = 0;

				//判断是否联通
				if (this.IsConnected() == false)
				{
					//如果不联通，记录
					inDependentList.Add(pair);
				}
				//恢复边
				this.Net[pair.Key][pair.Value] = 1;
				this.Net[pair.Value][pair.Key] = 1;
			}
			return inDependentList;
		}


		/// <summary>
		/// 按照大小构造net,并随机生成
		/// </summary>
		/// <param name="n">城市数</param>
		/// <param name="m">通讯线路条数</param>
		public Network(int n, int m)
		{
			InitNetwork(n, m);
			RandomGenerate();
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
				throw new InvalidParamException(n, (n - 1), n * (n - 1) / 2);
			}
			cityNum = n;
			lineNum = m;
			net = new List<List<int>>(n);
			for (int i = 0; i < n; i++)
			{
				Net.Add(new List<int>(Enumerable.Repeat(0, n)));
			}
		}
		/// <summary>
		/// 拷贝构造网络
		/// </summary>
		/// <param name="other">另一个Network对象</param>
		public Network(Network other)
		{
			InitNetwork(other.cityNum, other.lineNum);
			for (int i = 0; i < other.net.Count; i++)
			{
				for (int j = 0; j < other.net[i].Count; j++)
				{
					net[i][j] = other.net[i][j];
				}
			}
		}



		/// <summary>
		/// 获得线路的端点
		/// </summary>
		/// <returns>端点对的列表</returns>
		public List<KeyValuePair<int, int>> GetLineList()
		{
			var list = new List<KeyValuePair<int, int>>(LineNum);
			for (int i = 0; i < CityNum; i++)
			{
				for (int j = 0; j < i; j++)
				{
					if (Net[i][j] != 0)
					{
						list.Add(new KeyValuePair<int, int>(i, j));
					}
				}
			}

			return list;
		}

		/// <summary>
		/// 生成邻接矩阵的字符串形式
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			string matrix = "";
			for (int i = 0; i < CityNum; i++)
			{
				for (int j = 0; j < CityNum; j++)
				{
					matrix += Net[i][j];
					matrix += " ";
				}
				matrix += "\r\n";
			}
			return matrix;
		}
		public void Save(string path)
		{

			FileStream fs = new FileStream(path, FileMode.Create);
			StreamWriter sw = new StreamWriter(fs);
			sw.Write(this.ToString());

			sw.Flush();
			sw.Close();
			fs.Close();
		}


	}
}
