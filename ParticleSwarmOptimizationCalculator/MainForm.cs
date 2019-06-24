using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParticleSwarmOptimizationCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            numberParticlesTb.Text = "100";
            iterationsTb.Text = "100";
            proximityTb.Text = "60";
            c1Tb.Text = "0,8";
            c2Tb.Text = "1,2";
            c3Tb.Text = "1,2";
        }
    }
}
