using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSwarmOptimizationCalculator.Models
{
    public class Parameters
    {
        public double From { get; set; }

        public double To { get; set; }

        public int ParticleNumber { get; set; }

        public int Iterations { get; set; }

        public double Proximity { get; set; }

        public double C1 { get; set; }

        public double C2 { get; set; }

        public double C3 { get; set; }

        public Parameters(int particleNumber, int iterations, double proximity, double c1, double c2, double c3, double from, double to)
        {
            ParticleNumber = particleNumber;
            Iterations = iterations;
            Proximity = proximity;
            C1 = c1;
            C2 = c2;
            C3 = c3;
            From = from;
            To = to;
        }
    }
}
