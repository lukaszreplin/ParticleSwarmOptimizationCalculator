using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSwarmOptimizationCalculator.Models
{
    public class Particle
    {
        public double X { get; set; }

        public double FX { get; set; }

        public double V { get; set; }

        public double B { get; set; }

        public double BG { get; set; }
    }
}
