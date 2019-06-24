using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSwarmOptimizationCalculator.Models
{
    public class Result
    {
        public List<double> Mins { get; set; } = new List<double>();

        public List<double> Avgs { get; set; } = new List<double>();

        public List<double> Maxs { get; set; } = new List<double>();
    }
}
