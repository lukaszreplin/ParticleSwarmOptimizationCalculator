namespace ParticleSwarmOptimizationCalculator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.numberParticlesTb = new System.Windows.Forms.TextBox();
            this.iterationsTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.proximityTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.c1Tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.c2Tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.c3Tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fxResultTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.xResultTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.chartTab = new System.Windows.Forms.TabPage();
            this.resChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.animationTab = new System.Windows.Forms.TabPage();
            this.startButton = new System.Windows.Forms.Button();
            this.fromTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.toTb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.particlesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label11 = new System.Windows.Forms.Label();
            this.iterationL = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.chartTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resChart)).BeginInit();
            this.animationTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.particlesChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of particles";
            // 
            // numberParticlesTb
            // 
            this.numberParticlesTb.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberParticlesTb.Location = new System.Drawing.Point(169, 10);
            this.numberParticlesTb.Margin = new System.Windows.Forms.Padding(4);
            this.numberParticlesTb.Name = "numberParticlesTb";
            this.numberParticlesTb.Size = new System.Drawing.Size(104, 27);
            this.numberParticlesTb.TabIndex = 1;
            // 
            // iterationsTb
            // 
            this.iterationsTb.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iterationsTb.Location = new System.Drawing.Point(387, 9);
            this.iterationsTb.Margin = new System.Windows.Forms.Padding(4);
            this.iterationsTb.Name = "iterationsTb";
            this.iterationsTb.Size = new System.Drawing.Size(97, 27);
            this.iterationsTb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(281, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Iterations [T]";
            // 
            // proximityTb
            // 
            this.proximityTb.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.proximityTb.Location = new System.Drawing.Point(596, 9);
            this.proximityTb.Margin = new System.Windows.Forms.Padding(4);
            this.proximityTb.Name = "proximityTb";
            this.proximityTb.Size = new System.Drawing.Size(88, 27);
            this.proximityTb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(492, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Proximity [%]";
            // 
            // c1Tb
            // 
            this.c1Tb.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.c1Tb.Location = new System.Drawing.Point(755, 10);
            this.c1Tb.Margin = new System.Windows.Forms.Padding(4);
            this.c1Tb.Name = "c1Tb";
            this.c1Tb.Size = new System.Drawing.Size(100, 27);
            this.c1Tb.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(727, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "c₁";
            // 
            // c2Tb
            // 
            this.c2Tb.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.c2Tb.Location = new System.Drawing.Point(891, 10);
            this.c2Tb.Margin = new System.Windows.Forms.Padding(4);
            this.c2Tb.Name = "c2Tb";
            this.c2Tb.Size = new System.Drawing.Size(100, 27);
            this.c2Tb.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(863, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "c₂";
            // 
            // c3Tb
            // 
            this.c3Tb.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.c3Tb.Location = new System.Drawing.Point(1027, 10);
            this.c3Tb.Margin = new System.Windows.Forms.Padding(4);
            this.c3Tb.Name = "c3Tb";
            this.c3Tb.Size = new System.Drawing.Size(100, 27);
            this.c3Tb.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(999, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "c₃";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fxResultTb);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.xResultTb);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(24, 85);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(525, 107);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // fxResultTb
            // 
            this.fxResultTb.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fxResultTb.Location = new System.Drawing.Point(303, 38);
            this.fxResultTb.Margin = new System.Windows.Forms.Padding(4);
            this.fxResultTb.Name = "fxResultTb";
            this.fxResultTb.ReadOnly = true;
            this.fxResultTb.Size = new System.Drawing.Size(175, 27);
            this.fxResultTb.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(244, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "f(x)";
            // 
            // xResultTb
            // 
            this.xResultTb.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.xResultTb.Location = new System.Drawing.Point(69, 38);
            this.xResultTb.Margin = new System.Windows.Forms.Padding(4);
            this.xResultTb.Name = "xResultTb";
            this.xResultTb.ReadOnly = true;
            this.xResultTb.Size = new System.Drawing.Size(164, 27);
            this.xResultTb.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(30, 42);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "x";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.chartTab);
            this.tabControl1.Controls.Add(this.animationTab);
            this.tabControl1.Location = new System.Drawing.Point(24, 209);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1351, 560);
            this.tabControl1.TabIndex = 13;
            // 
            // chartTab
            // 
            this.chartTab.Controls.Add(this.resChart);
            this.chartTab.Location = new System.Drawing.Point(4, 28);
            this.chartTab.Margin = new System.Windows.Forms.Padding(4);
            this.chartTab.Name = "chartTab";
            this.chartTab.Padding = new System.Windows.Forms.Padding(4);
            this.chartTab.Size = new System.Drawing.Size(1343, 528);
            this.chartTab.TabIndex = 0;
            this.chartTab.Text = "Result chart";
            this.chartTab.UseVisualStyleBackColor = true;
            // 
            // resChart
            // 
            chartArea1.Name = "ChartArea1";
            this.resChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.resChart.Legends.Add(legend1);
            this.resChart.Location = new System.Drawing.Point(3, 3);
            this.resChart.Name = "resChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.resChart.Series.Add(series1);
            this.resChart.Size = new System.Drawing.Size(1337, 522);
            this.resChart.TabIndex = 0;
            this.resChart.Text = "chart1";
            // 
            // animationTab
            // 
            this.animationTab.Controls.Add(this.particlesChart);
            this.animationTab.Location = new System.Drawing.Point(4, 28);
            this.animationTab.Margin = new System.Windows.Forms.Padding(4);
            this.animationTab.Name = "animationTab";
            this.animationTab.Padding = new System.Windows.Forms.Padding(4);
            this.animationTab.Size = new System.Drawing.Size(1343, 528);
            this.animationTab.TabIndex = 1;
            this.animationTab.Text = "Animation";
            this.animationTab.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(1259, 10);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(116, 27);
            this.startButton.TabIndex = 14;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // fromTb
            // 
            this.fromTb.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fromTb.Location = new System.Drawing.Point(71, 50);
            this.fromTb.Margin = new System.Windows.Forms.Padding(4);
            this.fromTb.Name = "fromTb";
            this.fromTb.Size = new System.Drawing.Size(104, 27);
            this.fromTb.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(18, 53);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "From";
            // 
            // toTb
            // 
            this.toTb.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toTb.Location = new System.Drawing.Point(216, 50);
            this.toTb.Margin = new System.Windows.Forms.Padding(4);
            this.toTb.Name = "toTb";
            this.toTb.Size = new System.Drawing.Size(104, 27);
            this.toTb.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(183, 53);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 19);
            this.label10.TabIndex = 17;
            this.label10.Text = "To";
            // 
            // particlesChart
            // 
            chartArea2.Name = "ChartArea1";
            this.particlesChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.particlesChart.Legends.Add(legend2);
            this.particlesChart.Location = new System.Drawing.Point(3, 3);
            this.particlesChart.Name = "particlesChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.particlesChart.Series.Add(series2);
            this.particlesChart.Size = new System.Drawing.Size(1337, 522);
            this.particlesChart.TabIndex = 0;
            this.particlesChart.Text = "chart1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1237, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 19);
            this.label11.TabIndex = 19;
            this.label11.Text = "Iteration";
            // 
            // iterationL
            // 
            this.iterationL.AutoSize = true;
            this.iterationL.Location = new System.Drawing.Point(1311, 50);
            this.iterationL.Name = "iterationL";
            this.iterationL.Size = new System.Drawing.Size(18, 19);
            this.iterationL.TabIndex = 20;
            this.iterationL.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 799);
            this.Controls.Add(this.iterationL);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.toTb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.fromTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.c3Tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.c2Tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.c1Tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.proximityTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iterationsTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberParticlesTb);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Particle Swarm Application";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.chartTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resChart)).EndInit();
            this.animationTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.particlesChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberParticlesTb;
        private System.Windows.Forms.TextBox iterationsTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox proximityTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox c1Tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox c2Tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox c3Tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox fxResultTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox xResultTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage chartTab;
        private System.Windows.Forms.TabPage animationTab;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox fromTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox toTb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart resChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart particlesChart;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label iterationL;
    }
}

