using ParticleSwarmOptimizationCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParticleSwarmOptimizationCalculator
{
    public class Algorithm
    {
        private readonly Parameters _parameters;
        private readonly Random _randomizer;
        private List<Particle> _particles;
        private readonly int NeighboursCounter;
        private Result _result;

        private static MainForm form;

        public Algorithm(Parameters parameters)
        {
            _parameters = parameters;
            NeighboursCounter = int.Parse(Math.Floor(_parameters.Proximity / 100 * _parameters.ParticleNumber).ToString());
            _randomizer = new Random();
            _result = new Result();
        }

        public Result Start(MainForm refObj)
        {
            form = refObj;
            _particles = new List<Particle>(_parameters.ParticleNumber);
            InitParticles(_particles);
            Process();
            return _result;
        }

        private void Process()
        {
            int counter = 0;
            do
            {
                form.UpdateIterationLabel(counter+1);
                if (counter == 0)
                {
                    form.RefreshParticlesChart(_particles);
                }
                foreach (var particle in _particles)
                {
                    particle.FX = Calculations.GetFunctionResult(particle.X);
                    if (particle.FX > Calculations.GetFunctionResult(particle.B))
                        particle.B = particle.X;
                    particle.BG = _particles.OrderBy(_ => Math.Abs(particle.X - _.X))
                        .Take(NeighboursCounter)
                        .OrderByDescending(_ => Calculations.GetFunctionResult(_.B)).First().X;
                    if (particle.FX > Calculations.GetFunctionResult(particle.BG))
                        particle.BG = particle.X;
                }
                foreach (var particle in _particles)
                {
                    particle.V = _parameters.C1 * GetRandomNumber(0, 1, _randomizer) * particle.V +
                        _parameters.C2 * GetRandomNumber(0, 1, _randomizer) * (particle.B - particle.X) +
                        _parameters.C3 * GetRandomNumber(0, 1, _randomizer) * (particle.BG - particle.X);
                    particle.X = particle.X + particle.V;
                }
                _result.Mins.Add(_particles.Min(_ => _.FX));
                _result.Avgs.Add(_particles.Average(_ => _.FX));
                _result.Maxs.Add(_particles.Max(_ => _.FX));
                counter++;
                form.RefreshParticlesChart(_particles);
            }
            while (counter < _parameters.Iterations);
        }

        private void InitParticles(List<Particle> input)
        {
            for (int i = 1; i <= _parameters.ParticleNumber; i++)
            {
                var particle = new Particle();
                particle.X = GetRandomNumber(_parameters.From, _parameters.To, _randomizer);
                input.Add(particle);
            }
        }

        private double GetRandomNumber(double from, double to, Random random)
        {
            double number;
            number = random.NextDouble() * (to - from) + from;
            return number;
        }
    }
}
