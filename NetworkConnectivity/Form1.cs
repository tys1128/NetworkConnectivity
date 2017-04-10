using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkConnectivity
{
	//delegate void InitializeButtonDel();
	//InitializeButtonDel firstInit+=()=>startGenerateButton.Enabled = true;

	public partial class Form1 : Form
	{
		Network net1;
		Network net2;
		Graphics graph;

		public Form1()
		{
			InitializeComponent();
			graph = splitContainer1.Panel2.CreateGraphics();
		}



		/// <summary>
		/// 初始化按钮/图像
		/// </summary>
		void InitButtonAndGraphics()
		{
			startGenerateButton.Enabled = true;
			generateNetwork2Button.Enabled = false;
			tellDependablility1Button.Enabled = false;
			equipSwitchButton1.Enabled = false;
			equipSwitchButton2.Enabled = false;
			warningLabel.Visible = false;
		}
		/// <summary>
		/// 绘制网络
		/// </summary>
		/// <param name="g"></param>
		/// <param name="net"></param>
		void DrawNet(Graphics g, Network net)
		{
			Pen pointPen = new Pen(Brushes.Yellow) { Width = 6, LineJoin = LineJoin.Round };
			Pen linePen = new Pen(Brushes.DeepSkyBlue) { Width = 2, LineJoin = LineJoin.Bevel };
			const int r = 180;//radius
			const double pi = Math.PI;

			Point center = new Point(200, 200);
			List<Point> surround = new List<Point>();
			for (int i = 0; i < 12; i++)
			{
				int x = center.X + (int)(r * Math.Cos(i * pi / 6));
				int y = center.Y + (int)(r * Math.Sin(i * pi / 6));
				surround.Add(new Point(x, y));
			}

			for (int i = 0; i < surround.Count; i++)
			{
				////Point temp = new Point(x, y);
				////surround[i].Offset(temp);
				//surround[i].X += x;
				//surround[i].Y += y;
				g.FillEllipse(Brushes.Black, surround[i].X, surround[i].Y, 8, 8);
			}

			//g.DrawLine(skyBluePen, stPoint, endPoint);

			pointPen.Dispose();
			linePen.Dispose();
		}



		private void Form1_Load(object sender, EventArgs e)
		{
			InitButtonAndGraphics();
			textBoxCityNum.Text = "7";
			textBoxLineNum.Text = "15";

		}

		private void startGenerateButton_Click(object sender, EventArgs e)
		{
			InitButtonAndGraphics();

			try
			{
				net1 = new Network(int.Parse(textBoxCityNum.Text), int.Parse(textBoxLineNum.Text));
			}
			catch (InvalidParamException excp)
			{
				InitButtonAndGraphics();
				textBoxCityNum.Text = excp.n.ToString();
				warningLabel.Text = string.Format("城市数为{0}时，m的范围应为[{1},{2}]", excp.n, excp.mLower, excp.mUpper);
				warningLabel.Visible = true;
				return;
			}
			catch (FormatException)
			{
				InitButtonAndGraphics();
				warningLabel.Text = "未输入数据";
				warningLabel.Visible = true;
				return;
			}

			DrawNet(graph, net1);

			generateNetwork2Button.Enabled = true;
			tellDependablility1Button.Enabled = true;
			equipSwitchButton1.Enabled = true;
			equipSwitchButton2.Enabled = false;
		}

		private void generateNetwork2Button_Click(object sender, EventArgs e)
		{


			equipSwitchButton2.Enabled = true;
		}

		private void tellDependablility1Button_Click(object sender, EventArgs e)
		{

		}

		private void equipSwitchButton1_Click(object sender, EventArgs e)
		{

		}

		private void equipSwitchButton2_Click(object sender, EventArgs e)
		{

		}



		private void textBoxLineNum_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				startGenerateButton_Click(sender, e);
			}
		}
	}
}
