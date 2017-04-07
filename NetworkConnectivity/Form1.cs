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

		public Form1()
		{
			InitializeComponent();
		}



		/// <summary>
		/// 初始化按钮/文本
		/// </summary>
		private void InitButtonAndText()
		{
			//textBoxCityNum.Text = "7";
			//textBoxLineNum.Text = "15";
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
		private void DrawNet(Graphics g,Network net)
		{
			Pen pointPen = new Pen(Brushes.Yellow) { Width = 6, LineJoin = LineJoin.Round };
			Pen linePen = new Pen(Brushes.DeepSkyBlue) { Width = 2, LineJoin = LineJoin.Bevel };

			Point stPoint = new Point(80, 80);
			Point endPoint = new Point(160, 160);
			g.FillEllipse(Brushes.YellowGreen, 12, 12, 12, 12);
			//g.DrawLine(skyBluePen, stPoint, endPoint);

			linePen.Dispose();

		}



		private void Form1_Load(object sender, EventArgs e)
		{
			InitButtonAndText();
		}

		private void startGenerateButton_Click(object sender, EventArgs e)
		{
			try
			{
				net1 = new Network(int.Parse(textBoxCityNum.Text), int.Parse(textBoxLineNum.Text));
			}
			catch (InvalidParamException excp)
			{
				InitButtonAndText();
				textBoxCityNum.Text = excp.n.ToString();
				warningLabel.Text = string.Format("城市数为{0}时，m的范围应为[{1},{2}]", excp.n, excp.mLower, excp.mUpper);
				warningLabel.Visible = true;
				return;
			}
			catch (FormatException)
			{
				InitButtonAndText();
				warningLabel.Text = "未输入数据";
				warningLabel.Visible = true;
				return;
			}

			DrawNet(splitContainer1.Panel2.CreateGraphics(),net1);

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
