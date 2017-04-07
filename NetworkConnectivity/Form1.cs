using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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



		private void Form1_Load(object sender, EventArgs e)
		{
			InitButtonAndText();
		}

		private void startGenerateButton_Click(object sender, EventArgs e)
		{
			InitButtonAndText();
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
				warningLabel.Text = "未输入数据";
				warningLabel.Visible = true;
				return;
			}

			//warningLabel.Visible = false;
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

		private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{
			//InitButtonAndText();
		}

		private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
		{
			Graphics g;
			// Sets g to a graphics object representing the drawing surface of the
			// control or form g is a member of.
			g = splitContainer1.Panel2.CreateGraphics();

			// Create a new pen.
			Pen skyBluePen = new Pen(Brushes.DeepSkyBlue)
			{

				// Set the pen's width.
				Width = 8.0F,

				// Set the LineJoin property.
				LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel
			};

			// Draw a rectangle.
			e.Graphics.DrawRectangle(skyBluePen, new Rectangle(40, 40, 150, 200));

			//Dispose of the pen.
			skyBluePen.Dispose();

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
