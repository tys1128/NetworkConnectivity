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
    public partial class Form1 : Form
    {
		string defaultCityNum = "3";
		string defaultLineNum = "3";

		DrawNet drawNet1;
        DrawNet drawNet2;
        Graphics graph;

        public Form1()
        {
            InitializeComponent();
            graph = splitContainer1.Panel2.CreateGraphics();
        }


        /// <summary>
        /// 初始化按钮/图像/文本
        /// </summary>
        void InitFormItem()
        {
            startGenerateButton.Enabled = true;
			displayNet1Button.Enabled = false;
            generateNetwork2Button.Enabled = false;
            tellDependablility1Button.Enabled = false;
            equipSwitchButton1.Enabled = false;
            equipSwitchButton2.Enabled = false;
            warningLabel.Visible = false;

			graph.Clear(Color.White);
        }
		void InitText()
		{
			labelTellReliability.Visible = false;
		}



		private void Form1_Load(object sender, EventArgs e)
        {
            InitFormItem();
			InitText();
			textBoxCityNum.Text = defaultCityNum;
            textBoxLineNum.Text = defaultLineNum;
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

			displayNet1Button.Enabled = true;
            generateNetwork2Button.Enabled = true;
            tellDependablility1Button.Enabled = true;
            equipSwitchButton1.Enabled = true;
            equipSwitchButton2.Enabled = false;
        }

		private void displayNet1Button_Click(object sender, EventArgs e)
		{
			drawNet1.DrawNormalGraphic();
		}

		private void generateNetwork2Button_Click(object sender, EventArgs e)
        {
			InitText();

            drawNet2 = new DrawNet(drawNet1);
            foreach (var pair in drawNet2.Net.GetLineList())
            {
                //删掉一条边
                drawNet2.Net.Net[pair.Key][pair.Value] = 0;
                drawNet2.Net.Net[pair.Value][pair.Key] = 0;

                //判断是否联通
                if (drawNet2.Net.IsConnected() == false)
                {
                    //如果不联通 ,//恢复边
                    drawNet2.Net.Net[pair.Key][pair.Value] = 1;
                    drawNet2.Net.Net[pair.Value][pair.Key] = 1;
                }
            }
            drawNet2.DrawNormalGraphic();

            equipSwitchButton2.Enabled = true;
        }

        private void tellDependablility1Button_Click(object sender, EventArgs e)
        {
			InitText();

			List<KeyValuePair<int, int>> inDependentList = new List<KeyValuePair<int, int>>();
			DrawNet tDrawNet = new DrawNet(drawNet1);
			Network tNet = drawNet1.Net;

            var list = tNet.GetLineList();
            foreach (var pair in list)
            {
                //删掉一条边
                tNet.Net[pair.Key][pair.Value] = 0;
                tNet.Net[pair.Value][pair.Key] = 0;

                //判断是否联通
                if (tNet.IsConnected() == false)
                {
                    //如果不联通，记录
                    inDependentList.Add(pair);
                }
                //恢复边
                tNet.Net[pair.Key][pair.Value] = 1;
                tNet.Net[pair.Value][pair.Key] = 1;
            }

			tDrawNet.DrawHighLightLineGraphic(inDependentList);
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
        }

	}
}
