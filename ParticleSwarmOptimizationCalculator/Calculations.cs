using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSwarmOptimizationCalculator
{
    public class Calculations
    {
        public static double GetFunctionResult(double input)
        {
            return (input % 1) * (Math.Cos(20 * Math.PI * input) - Math.Sin(input));
        }
    }
}
