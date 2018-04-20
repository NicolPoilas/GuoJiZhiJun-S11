namespace GuoJiZhiJun_S11
{
    partial class Main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BusOffOn = new System.Windows.Forms.Button();
            this.comboBoxChannel = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudrate = new System.Windows.Forms.ComboBox();
            this.labelBusLoad = new System.Windows.Forms.Label();
            this.buttonSimulation = new System.Windows.Forms.Button();
            this.buttonMonitor = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BusOffOn);
            this.groupBox1.Controls.Add(this.comboBoxChannel);
            this.groupBox1.Controls.Add(this.comboBoxBaudrate);
            this.groupBox1.Controls.Add(this.labelBusLoad);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 82);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CAN Seeting";
            // 
            // BusOffOn
            // 
            this.BusOffOn.Location = new System.Drawing.Point(279, 17);
            this.BusOffOn.Name = "BusOffOn";
            this.BusOffOn.Size = new System.Drawing.Size(75, 23);
            this.BusOffOn.TabIndex = 0;
            this.BusOffOn.Text = "Bus On";
            this.BusOffOn.UseVisualStyleBackColor = true;
            this.BusOffOn.Click += new System.EventHandler(this.BusOffOn_Click);
            // 
            // comboBoxChannel
            // 
            this.comboBoxChannel.FormattingEnabled = true;
            this.comboBoxChannel.Location = new System.Drawing.Point(10, 20);
            this.comboBoxChannel.Name = "comboBoxChannel";
            this.comboBoxChannel.Size = new System.Drawing.Size(263, 20);
            this.comboBoxChannel.TabIndex = 2;
            // 
            // comboBoxBaudrate
            // 
            this.comboBoxBaudrate.FormattingEnabled = true;
            this.comboBoxBaudrate.Items.AddRange(new object[] {
            "50",
            "100",
            "125",
            "250",
            "500"});
            this.comboBoxBaudrate.Location = new System.Drawing.Point(10, 49);
            this.comboBoxBaudrate.Name = "comboBoxBaudrate";
            this.comboBoxBaudrate.Size = new System.Drawing.Size(80, 20);
            this.comboBoxBaudrate.TabIndex = 3;
            // 
            // labelBusLoad
            // 
            this.labelBusLoad.Location = new System.Drawing.Point(162, 50);
            this.labelBusLoad.Name = "labelBusLoad";
            this.labelBusLoad.Size = new System.Drawing.Size(111, 19);
            this.labelBusLoad.TabIndex = 5;
            this.labelBusLoad.Text = "Bus Load:";
            this.labelBusLoad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSimulation
            // 
            this.buttonSimulation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSimulation.Location = new System.Drawing.Point(12, 100);
            this.buttonSimulation.Name = "buttonSimulation";
            this.buttonSimulation.Size = new System.Drawing.Size(94, 23);
            this.buttonSimulation.TabIndex = 14;
            this.buttonSimulation.Text = "Simulation";
            this.buttonSimulation.UseVisualStyleBackColor = true;
            this.buttonSimulation.Click += new System.EventHandler(this.buttonSimulation_Click);
            // 
            // buttonMonitor
            // 
            this.buttonMonitor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMonitor.Location = new System.Drawing.Point(112, 100);
            this.buttonMonitor.Name = "buttonMonitor";
            this.buttonMonitor.Size = new System.Drawing.Size(94, 23);
            this.buttonMonitor.TabIndex = 15;
            this.buttonMonitor.Text = "Monitor";
            this.buttonMonitor.UseVisualStyleBackColor = true;
            this.buttonMonitor.Click += new System.EventHandler(this.buttonMonitor_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(389, 134);
            this.Controls.Add(this.buttonMonitor);
            this.Controls.Add(this.buttonSimulation);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "GuoJiZhiJun_S11";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BusOffOn;
        private System.Windows.Forms.ComboBox comboBoxChannel;
        private System.Windows.Forms.ComboBox comboBoxBaudrate;
        private System.Windows.Forms.Label labelBusLoad;
        private System.Windows.Forms.Button buttonSimulation;
        private System.Windows.Forms.Button buttonMonitor;
    }
}

