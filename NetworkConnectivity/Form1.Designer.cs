﻿namespace NetworkConnectivity
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.label2 = new System.Windows.Forms.Label();
			this.lable1 = new System.Windows.Forms.Label();
			this.textBoxLineNum = new System.Windows.Forms.TextBox();
			this.textBoxCityNum = new System.Windows.Forms.TextBox();
			this.startGenerateButton = new System.Windows.Forms.Button();
			this.generateNetwork2Button = new System.Windows.Forms.Button();
			this.tellDependablility1Button = new System.Windows.Forms.Button();
			this.equipSwitchButton1 = new System.Windows.Forms.Button();
			this.equipSwitchButton2 = new System.Windows.Forms.Button();
			this.warningLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
			this.splitContainer1.Panel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.warningLabel);
			this.splitContainer1.Panel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
			this.splitContainer1.Size = new System.Drawing.Size(637, 468);
			this.splitContainer1.SplitterDistance = 210;
			this.splitContainer1.TabIndex = 0;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
			this.flowLayoutPanel1.Controls.Add(this.splitContainer2);
			this.flowLayoutPanel1.Controls.Add(this.startGenerateButton);
			this.flowLayoutPanel1.Controls.Add(this.generateNetwork2Button);
			this.flowLayoutPanel1.Controls.Add(this.tellDependablility1Button);
			this.flowLayoutPanel1.Controls.Add(this.equipSwitchButton1);
			this.flowLayoutPanel1.Controls.Add(this.equipSwitchButton2);
			this.flowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(186, 444);
			this.flowLayoutPanel1.TabIndex = 0;
			this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
			// 
			// splitContainer2
			// 
			this.splitContainer2.Location = new System.Drawing.Point(3, 3);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.label2);
			this.splitContainer2.Panel1.Controls.Add(this.lable1);
			this.splitContainer2.Panel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.textBoxLineNum);
			this.splitContainer2.Panel2.Controls.Add(this.textBoxCityNum);
			this.splitContainer2.Size = new System.Drawing.Size(180, 69);
			this.splitContainer2.SplitterDistance = 27;
			this.splitContainer2.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(97, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "线路数：";
			// 
			// lable1
			// 
			this.lable1.AutoSize = true;
			this.lable1.Location = new System.Drawing.Point(3, 0);
			this.lable1.Name = "lable1";
			this.lable1.Size = new System.Drawing.Size(65, 20);
			this.lable1.TabIndex = 0;
			this.lable1.Text = "城市数：";
			// 
			// textBoxLineNum
			// 
			this.textBoxLineNum.Location = new System.Drawing.Point(101, 3);
			this.textBoxLineNum.Name = "textBoxLineNum";
			this.textBoxLineNum.Size = new System.Drawing.Size(76, 29);
			this.textBoxLineNum.TabIndex = 1;
			this.textBoxLineNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxLineNum_KeyDown);
			// 
			// textBoxCityNum
			// 
			this.textBoxCityNum.Location = new System.Drawing.Point(3, 3);
			this.textBoxCityNum.Name = "textBoxCityNum";
			this.textBoxCityNum.Size = new System.Drawing.Size(76, 29);
			this.textBoxCityNum.TabIndex = 0;
			// 
			// startGenerateButton
			// 
			this.startGenerateButton.Location = new System.Drawing.Point(3, 78);
			this.startGenerateButton.Name = "startGenerateButton";
			this.startGenerateButton.Size = new System.Drawing.Size(180, 78);
			this.startGenerateButton.TabIndex = 0;
			this.startGenerateButton.Text = "生成网络①";
			this.startGenerateButton.UseVisualStyleBackColor = true;
			this.startGenerateButton.Click += new System.EventHandler(this.startGenerateButton_Click);
			// 
			// generateNetwork2Button
			// 
			this.generateNetwork2Button.Location = new System.Drawing.Point(3, 162);
			this.generateNetwork2Button.Name = "generateNetwork2Button";
			this.generateNetwork2Button.Size = new System.Drawing.Size(180, 54);
			this.generateNetwork2Button.TabIndex = 2;
			this.generateNetwork2Button.Text = "去除①中的冗余线路生成②";
			this.generateNetwork2Button.UseVisualStyleBackColor = true;
			this.generateNetwork2Button.Click += new System.EventHandler(this.generateNetwork2Button_Click);
			// 
			// tellDependablility1Button
			// 
			this.tellDependablility1Button.Location = new System.Drawing.Point(3, 222);
			this.tellDependablility1Button.Name = "tellDependablility1Button";
			this.tellDependablility1Button.Size = new System.Drawing.Size(180, 54);
			this.tellDependablility1Button.TabIndex = 1;
			this.tellDependablility1Button.Text = "①为可靠网络？";
			this.tellDependablility1Button.UseVisualStyleBackColor = true;
			this.tellDependablility1Button.Click += new System.EventHandler(this.tellDependablility1Button_Click);
			// 
			// equipSwitchButton1
			// 
			this.equipSwitchButton1.Location = new System.Drawing.Point(3, 282);
			this.equipSwitchButton1.Name = "equipSwitchButton1";
			this.equipSwitchButton1.Size = new System.Drawing.Size(180, 54);
			this.equipSwitchButton1.TabIndex = 3;
			this.equipSwitchButton1.Text = "为①配备交换机";
			this.equipSwitchButton1.UseVisualStyleBackColor = true;
			this.equipSwitchButton1.Click += new System.EventHandler(this.equipSwitchButton1_Click);
			// 
			// equipSwitchButton2
			// 
			this.equipSwitchButton2.Location = new System.Drawing.Point(3, 342);
			this.equipSwitchButton2.Name = "equipSwitchButton2";
			this.equipSwitchButton2.Size = new System.Drawing.Size(180, 54);
			this.equipSwitchButton2.TabIndex = 4;
			this.equipSwitchButton2.Text = "为②配备交换机";
			this.equipSwitchButton2.UseVisualStyleBackColor = true;
			this.equipSwitchButton2.Click += new System.EventHandler(this.equipSwitchButton2_Click);
			// 
			// warningLabel
			// 
			this.warningLabel.AutoSize = true;
			this.warningLabel.Location = new System.Drawing.Point(20, 119);
			this.warningLabel.Name = "warningLabel";
			this.warningLabel.Size = new System.Drawing.Size(25, 21);
			this.warningLabel.TabIndex = 6;
			this.warningLabel.Text = "   ";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(637, 468);
			this.Controls.Add(this.splitContainer1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button equipSwitchButton1;
        private System.Windows.Forms.Button generateNetwork2Button;
        private System.Windows.Forms.Button tellDependablility1Button;
        private System.Windows.Forms.Button startGenerateButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button equipSwitchButton2;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.Label lable1;
		private System.Windows.Forms.TextBox textBoxLineNum;
		private System.Windows.Forms.TextBox textBoxCityNum;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label warningLabel;
	}
}

