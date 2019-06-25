using ParticleSwarmOptimizationCalculator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ParticleSwarmOptimizationCalculator
{
    public partial class MainForm : Form
    {
        private List<Particle> _particles;
        public MainForm()
        {
            InitializeComponent();
            InitData();
            particlesChart.Series[0].Name = "Particles";
            particlesChart.Series[0].ChartType = SeriesChartType.Point;
            particlesChart.ChartAreas[0].AxisX.Minimum = -4;
            particlesChart.ChartAreas[0].AxisX.Maximum = 12;
            resChart.Series[0].Name = "Minimum";
            resChart.Series[0].ChartType = SeriesChartType.Line;
            var maxs = new Series();
            var avgs = new Series();
            maxs.Name = "Maximum";
            avgs.Name = "Average";
            maxs.ChartType = SeriesChartType.Line;
            avgs.ChartType = SeriesChartType.Line;
            resChart.Series.Add(avgs);
            resChart.Series.Add(maxs);
            
        }

        private void InitData()
        {
            numberParticlesTb.Text = "100";
            iterationsTb.Text = "100";
            proximityTb.Text = "60";
            c1Tb.Text = "0,8";
            c2Tb.Text = "1,2";
            c3Tb.Text = "1,2";
            fromTb.Text = "-4";
            toTb.Text = "12";
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            foreach (var sss in resChart.Series)
            {
                sss.Points.Clear();
            }
            var parameters = TryGenerateParameters();
            var algorithm = new Algorithm(parameters);
            Result results = new Result();
            await Task.Run(() =>
            {
                results = algorithm.Start(this);
            });
            for (int i = 1; i <= results.Avgs.Count; i++)
            {
                resChart.Series["Minimum"].Points.AddXY(i, results.Mins[i - 1]);
                resChart.Series["Average"].Points.AddXY(i, results.Avgs[i - 1]);
                resChart.Series["Maximum"].Points.AddXY(i, results.Maxs[i - 1]);
            }
            xResultTb.Text = results.X.ToString();
            fxResultTb.Text = results.FX.ToString();
            startButton.Enabled = true;
        }

        private Parameters TryGenerateParameters()
        {
            try
            {
                return new Parameters(int.Parse(numberParticlesTb.Text), int.Parse(iterationsTb.Text), double.Parse(proximityTb.Text),
                    double.Parse(c1Tb.Text), double.Parse(c2Tb.Text), double.Parse(c3Tb.Text), double.Parse(fromTb.Text), double.Parse(toTb.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Nieprawidłowe wartości parametrów!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public void RefreshParticlesChart(List<Particle> input)
        {
            _particles = input;
            Invoke(new Action(() =>
            {
                foreach (var sss in particlesChart.Series)
                {
                    sss.Points.Clear();
                }
                foreach (var particle in _particles)
                {
                    particlesChart.Series["Particles"].Points.AddXY(particle.X, 0);
                }
            }));
        }

        public void UpdateIterationLabel(int number)
        {
            Invoke(new Action(() =>
            {
                iterationL.Text = number.ToString();
            }));
        } 
    }
}
