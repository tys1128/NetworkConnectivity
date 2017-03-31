namespace NetworkConnectivity
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
			this.startGenerateButton = new System.Windows.Forms.Button();
			this.generateNetwork2Button = new System.Windows.Forms.Button();
			this.tellDependablility1Button = new System.Windows.Forms.Button();
			this.equipSwitchButton1 = new System.Windows.Forms.Button();
			this.equipSwitchButton2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
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
			this.splitContainer1.Panel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.splitContainer1.Size = new System.Drawing.Size(637, 468);
			this.splitContainer1.SplitterDistance = 205;
			this.splitContainer1.TabIndex = 0;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
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
			// 
			// startGenerateButton
			// 
			this.startGenerateButton.Location = new System.Drawing.Point(3, 3);
			this.startGenerateButton.Name = "startGenerateButton";
			this.startGenerateButton.Size = new System.Drawing.Size(180, 126);
			this.startGenerateButton.TabIndex = 0;
			this.startGenerateButton.Text = "输入数据\r\n以生成网络①";
			this.startGenerateButton.UseVisualStyleBackColor = true;
			this.startGenerateButton.Click += new System.EventHandler(this.startGenerateButton_Click);
			// 
			// generateNetwork2Button
			// 
			this.generateNetwork2Button.Location = new System.Drawing.Point(3, 135);
			this.generateNetwork2Button.Name = "generateNetwork2Button";
			this.generateNetwork2Button.Size = new System.Drawing.Size(180, 54);
			this.generateNetwork2Button.TabIndex = 2;
			this.generateNetwork2Button.Text = "去除①中的冗余线路生成②";
			this.generateNetwork2Button.UseVisualStyleBackColor = true;
			this.generateNetwork2Button.Click += new System.EventHandler(this.generateNetwork2Button_Click);
			// 
			// tellDependablility1Button
			// 
			this.tellDependablility1Button.Location = new System.Drawing.Point(3, 195);
			this.tellDependablility1Button.Name = "tellDependablility1Button";
			this.tellDependablility1Button.Size = new System.Drawing.Size(180, 54);
			this.tellDependablility1Button.TabIndex = 1;
			this.tellDependablility1Button.Text = "①为可靠网络？";
			this.tellDependablility1Button.UseVisualStyleBackColor = true;
			this.tellDependablility1Button.Click += new System.EventHandler(this.tellDependablility1Button_Click);
			// 
			// equipSwitchButton1
			// 
			this.equipSwitchButton1.Location = new System.Drawing.Point(3, 255);
			this.equipSwitchButton1.Name = "equipSwitchButton1";
			this.equipSwitchButton1.Size = new System.Drawing.Size(180, 54);
			this.equipSwitchButton1.TabIndex = 3;
			this.equipSwitchButton1.Text = "为①配备交换机";
			this.equipSwitchButton1.UseVisualStyleBackColor = true;
			this.equipSwitchButton1.Click += new System.EventHandler(this.equipSwitchButton1_Click);
			// 
			// equipSwitchButton2
			// 
			this.equipSwitchButton2.Location = new System.Drawing.Point(3, 315);
			this.equipSwitchButton2.Name = "equipSwitchButton2";
			this.equipSwitchButton2.Size = new System.Drawing.Size(180, 54);
			this.equipSwitchButton2.TabIndex = 4;
			this.equipSwitchButton2.Text = "为②配备交换机";
			this.equipSwitchButton2.UseVisualStyleBackColor = true;
			this.equipSwitchButton2.Click += new System.EventHandler(this.equipSwitchButton2_Click);
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
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
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
    }
}

