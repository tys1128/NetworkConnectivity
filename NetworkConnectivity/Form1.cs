using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NetworkConnectivity
{
	public partial class Form1 : Form
    {
		string defaultCityNum = "19";
		string defaultLineNum = "171";

		DrawNet drawNet1;
        DrawNet drawNet2;
        Graphics graph;

        public Form1()
        {
            InitializeComponent();
            graph = splitContainer1.Panel2.CreateGraphics();
        }
		private void Form1_Load(object sender, EventArgs e)
		{
			InitFormItem();
			InitText();
			textBoxCityNum.Text = defaultCityNum;
			textBoxLineNum.Text = defaultLineNum;
		}
		/// <summary>
		/// 初始化按钮/图像/文本
		/// </summary>
		void InitFormItem()
		{
			startGenerateButton.Enabled = true;
			generateNetwork2Button.Enabled = false;
			tellDependablility1Button.Enabled = false;
			equipSwitchButton1.Enabled = false;
			equipSwitchButton2.Enabled = false;
			saveNetworkButton.Enabled = false;
			warningLabel.Visible = false;

			graph.Clear(Color.White);
		}
		void InitText()
		{
			labelTellReliability.Visible = false;
		}



		private void startGenerateButton_Click(object sender, EventArgs e)
		{
			InitFormItem();
			InitText();

			try
			{
				drawNet1 = new DrawNet(graph, new Network(int.Parse(textBoxCityNum.Text), int.Parse(textBoxLineNum.Text)));
			}
			catch (InvalidParamException excp)
			{
				InitFormItem();

				textBoxCityNum.Text = excp.n.ToString();
				warningLabel.Text = string.Format("城市数为{0}时，m的范围应为[{1},{2}]", excp.n, excp.mLower, excp.mUpper);
				warningLabel.Visible = true;
				return;
			}
			catch (FormatException)
			{
				InitFormItem();
				warningLabel.Text = "请输入数据（使用阿拉伯数字）";
				warningLabel.Visible = true;
				return;
			}

			drawNet1.DrawNormalGraphic();

			generateNetwork2Button.Enabled = true;
			tellDependablility1Button.Enabled = true;
			equipSwitchButton1.Enabled = true;
			equipSwitchButton2.Enabled = false;
		}


		private void generateNetwork2Button_Click(object sender, EventArgs e)
		{
			InitText();

			drawNet2 = new DrawNet(drawNet1);
			drawNet2.Net.RemoveRedundantLines();
			drawNet2.DrawNormalGraphic();

			equipSwitchButton2.Enabled = true;
			saveNetworkButton.Enabled = true;
		}

		private void tellDependablility1Button_Click(object sender, EventArgs e)
		{
			InitText();

			DrawNet tDrawNet = new DrawNet(drawNet1);
			var inDependentList = tDrawNet.Net.GetIndependentLineList();

			tDrawNet.DrawHighlightLineGraphic(inDependentList);

			labelTellReliability.Visible = true;
			if (inDependentList.Count == 0)
			{
				labelTellReliability.Text = "该网络是可靠网络";
			}
			else
			{
				labelTellReliability.Text = "该网络不是可靠网络";
			}
		}

		private void equipSwitchButton1_Click(object sender, EventArgs e)
		{
			InitText();

		}

		private void equipSwitchButton2_Click(object sender, EventArgs e)
		{
			InitText();

		}

		private void saveNetworkButton_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfDialog = new SaveFileDialog {
				Filter = "文本文件(*.txt)|*.txt",
				RestoreDirectory = true,
				Title="保存网络①",
				FileName="Net1.txt",
			};

			if (sfDialog.ShowDialog() == DialogResult.OK)
			{
				FileStream fs = new FileStream(sfDialog.FileName, FileMode.Create);
				StreamWriter sw = new StreamWriter(fs);
				sw.Write(drawNet1.Net.ToString());

				sw.Flush();
				sw.Close();
				fs.Close();
			}
			sfDialog.Title = "保存网络②";
			sfDialog.FileName = "Net2.txt";
			if (sfDialog.ShowDialog() == DialogResult.OK)
			{
				FileStream fs = new FileStream(sfDialog.FileName, FileMode.Create);
				StreamWriter sw = new StreamWriter(fs);
				sw.Write(drawNet2.Net.ToString());

				sw.Flush();
				sw.Close();
				fs.Close();
			}
		}



		private void textBoxLineNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                startGenerateButton_Click(sender, e);
            }
        }

        private void textBoxLineNum_TextChanged(object sender, EventArgs e)
        {
            InitFormItem();
			InitText();
        }

		private void textBoxCityNum_TextChanged(object sender, EventArgs e)
		{
			InitFormItem();
			InitText();
		}

	}
}
