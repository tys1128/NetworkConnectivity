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

		private void Form1_Load(object sender, EventArgs e)
		{

			//
			//初始化按钮/文本
			//
			textBoxCityNum.Text = "7";
			textBoxLineNum.Text = "15";
			startGenerateButton.Enabled = true;
			generateNetwork2Button.Enabled = false;
			tellDependablility1Button.Enabled = false;
			equipSwitchButton1.Enabled = false;
			equipSwitchButton2.Enabled = false;
		}

		private void startGenerateButton_Click(object sender, EventArgs e)
		{
			try
			{  
				net1 = new Network(int.Parse(textBoxCityNum.Text), int.Parse(textBoxLineNum.Text));
			}
			catch (InvalidParamException excp)
			{
				Console.WriteLine(excp.ToString());
				
			}

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
	}
}
