using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace NetworkConnectivity
{
	/// <summary>
	/// 捆绑了Graphics和Network
	/// </summary>
	class DrawNet
	{
		Graphics g;
		Network net;
		Point center = new Point(200, 200);
		List<Point> surround;
		int radius = 180;
		int ptSize = 9;
		const double pi = Math.PI;
		Pen linePen = new Pen(Brushes.DeepSkyBlue) { Width = 2, LineJoin = LineJoin.Bevel };
		Pen highlightPen = new Pen(Brushes.Red) { Width = 2, LineJoin = LineJoin.Bevel };
		Brush pointBrush = Brushes.LightGreen;
		Brush highLightPointBrush = Brushes.Yellow;

		public Point Center { get => center; }
		public List<Point> Surround { get => surround; }
		public int Radius { get => radius; }
		public int PtSize { get => ptSize; }
		public Network Net { get => net; }

		/// <summary>
		/// 初始化图
		/// </summary>
		/// <param name="g"></param>
		/// <param name="net">要绘制的图</param>
		public DrawNet(Graphics g,Network net)
		{
			this.g = g;
			this.net = net;
			Init(g, net);
		}
		public DrawNet(DrawNet other)
		{
			g = other.g;
			net = new Network(other.net);
			Init(g, net);
		}
		public void Init(Graphics g, Network net)
		{
			int n = net.CityNum;
			surround = new List<Point>(n);
			for (int i = 0; i < n; i++)
			{
				int x = center.X + (int)(radius * Math.Cos(i * 2 * pi / n));
				int y = center.Y + (int)(radius * Math.Sin(i * 2 * pi / n));
				surround.Add(new Point(x, y));
			}
		}



		/// <summary>
		/// 绘制线
		/// </summary>
		/// <param name="lineList">存储线的两端点的列表</param>
		/// <param name="linePen">用于画线</param>
		public void PrintLine(List<KeyValuePair<int,int>> lineList,Pen linePen)
		{
			foreach (var pt in lineList)
			{
				g.DrawLine(linePen, surround[pt.Key], surround[pt.Value]);
			}
		}
		/// <summary>
		/// 绘制点
		/// </summary>
		/// <param name="pointList">存放点的表</param>
		/// <param name="brush">点的颜色</param>
		/// <param name="ptSize">点的大小</param>
		public void PrintPoint(List<Point> pointList, Brush brush, int ptSize)
		{
			foreach (Point pt in pointList)
			{
				g.FillEllipse(brush, pt.X - ptSize / 2, pt.Y - ptSize / 2, ptSize, ptSize);
			}
		}



		/// <summary>
		/// 绘制当前网络的普通图像
		/// </summary>
		public void DrawNormalGraphic()
		{
			g.Clear(Color.White);

			//绘制线路与点
			PrintLine(net.GetLineList(), linePen);
			PrintPoint(surround, pointBrush, ptSize);
		}
		/// <summary>
		/// 绘制突出显示特定线的图
		/// </summary>
		/// <param name="HighlightLineList"></param>
		public void DrawHighlightLineGraphic(List<KeyValuePair<int, int>> HighlightLineList)
		{
			g.Clear(Color.White);

			//绘制线路与点
			PrintLine(net.GetLineList(), linePen);
			PrintLine(HighlightLineList, highlightPen);
			PrintPoint(surround, pointBrush, ptSize);
		}
		/// <summary>
		/// 绘制突出显示特定点的图
		/// </summary>
		/// <param name="HighlightLineList"></param>
		public void DrawHighlightPointGraphic(List<Point> HighlightPointList)
		{
			g.Clear(Color.White);

			//绘制线路与点
			PrintLine(net.GetLineList(), linePen);
			PrintPoint(surround, pointBrush, ptSize);
			PrintPoint(HighlightPointList, pointBrush, ptSize);
		}

	}
}
